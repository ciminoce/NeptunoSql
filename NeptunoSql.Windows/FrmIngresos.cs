using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.ServiceLayer.Servicios;
using NeptunoSql.ServiceLayer.Servicios.Facades;
using NeptunoSql.Windows.Helpers;
using NeptunoSql.Windows.Helpers.Enum;

namespace NeptunoSql.Windows
{
    public partial class FrmIngresos : Form
    {
        public FrmIngresos()
        {
            InitializeComponent();
        }
        private readonly List<Producto> _listaProducto=new List<Producto>();
        private void ProductosLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBuscarProducto frm=new FrmBuscarProducto(this);
            DialogResult dr = frm.ShowDialog(this);
        }

        public void AgregarFila(Producto producto)
        {
            if (_listaProducto.Contains(producto))
            {
                return;
            }
            _listaProducto.Add(producto);
            DataGridViewRow r = Helper.ConstruirFila(ref StockInProductosDataGridView);
            SetearFila(r, producto);
            AgregarFila(r);
        }

        private void SetearFila(DataGridViewRow r, Producto producto)
        {
            r.Cells[cmnMarca.Index].Value = producto.Marca.NombreMarca;
            r.Cells[cmnDescripcion.Index].Value = producto.Descripcion;

            r.Tag = producto;
        }

        private void AgregarFila(DataGridViewRow r)
        {

            StockInProductosDataGridView.Rows.Add(r);
        }

        private void StockInProductosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 2:
                    var cantidad=Interaction.InputBox("Ingrese la cantidad", "Ingreso de Stock",
                        "0", 800, 400);
                    if (!double.TryParse(cantidad, out double stock))
                    {
                        return;
                    }else if (stock<=0 || stock>int.MaxValue)
                    {
                        return;
                    }

                    DataGridViewCell celda= StockInProductosDataGridView.Rows[e.RowIndex]
                        .Cells[e.ColumnIndex];
                    celda.Value = stock;
                    break;
                case 3:
                    StockInProductosDataGridView.Rows.RemoveAt(e.RowIndex);
                    break;
                default:break;
            }
            


        }

        private IServicioIngresos _servicio;
        private void GuardarButton_Click(object sender, System.EventArgs e)
        {
            if (ValidarDatos())
            {
                Ingreso ingreso=new Ingreso();
                ingreso.Referencia = ReferenciaTextBox.Text;
                ingreso.Empleado = EmpleadoTextBox.Text;
                ingreso.Fecha = FechaDateTimePicker.Value;
                ingreso.DetalleIngresos = ConstruirListaDetalleIngresos();
                try
                {
                    _servicio.Guardar(ingreso);
                    Helper.MensajeBox("Registro guardado", Tipo.Success);
                    InicializarControles();

                }
                catch (Exception exception)
                {
                    Helper.MensajeBox(exception.Message, Tipo.Error);
                }

            }
        }

        private void InicializarControles()
        {
            ReferenciaTextBox.Clear();
            FechaDateTimePicker.Value = DateTime.Today;
            EmpleadoTextBox.Clear();
            StockInProductosDataGridView.Rows.Clear();
            ReferenciaTextBox.Focus();
            _listaProducto.Clear();
        }

        private List<DetalleIngreso> ConstruirListaDetalleIngresos()
        {
            List<DetalleIngreso> lista=new List<DetalleIngreso>();
            int contadorFilas = -1;
            foreach (var producto in _listaProducto)
            {
                contadorFilas++;
                DetalleIngreso detalle = new DetalleIngreso
                {
                    Producto = producto,
                    Cantidad = (decimal) (double) StockInProductosDataGridView.Rows[contadorFilas].Cells[2].Value
                };
                lista.Add(detalle);
            }

            return lista;
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(ReferenciaTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(ReferenciaTextBox,"Debe ingresar una referencia");
            }
            if (string.IsNullOrEmpty(EmpleadoTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(EmpleadoTextBox,"Debe ingresar un empleado");
            }

            if (FechaDateTimePicker.Value.Date>DateTime.Today)
            {
                valido = false;
                errorProvider1.SetError(FechaDateTimePicker,"Fecha mal ingresada");
            }

            if (StockInProductosDataGridView.Rows.Count==0)
            {
                valido = false;
                errorProvider1.SetError(ProductosLinkLabel,"Debe seleccionar al menos un producto");
            }
            else
            {
                foreach (DataGridViewRow row in StockInProductosDataGridView.Rows)
                {
                    DataGridViewCell celda = row.Cells[2];
                    if (celda.Value==null)
                    {
                        celda.Style.BackColor = Color.Red;
                    }
                    else
                    {
                        celda.Style.BackColor = Color.White;
                    }
                }
            }
            return valido;
        }

        private void FrmIngresos_Load(object sender, EventArgs e)
        {
            _servicio=new ServicioIngresos();
        }
    }
}
