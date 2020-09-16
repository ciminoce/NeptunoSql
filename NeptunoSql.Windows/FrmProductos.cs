using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.ServiceLayer.Servicios;
using NeptunoSql.ServiceLayer.Servicios.Facades;
using NeptunoSql.Windows.Helpers;
using NeptunoSql.Windows.Helpers.Enum;

namespace NeptunoSql.Windows
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            
            InitializeComponent();
        }
        private IServicioProductos _servicio;
        private List<Producto> _lista;

        private void MostrarEnGrilla()
        {
            DataGridViewDatos.Rows.Clear();
            foreach (var producto in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, producto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DataGridViewDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Producto producto)
        {
            r.Cells[cmnDescripcion.Index].Value = producto.Descripcion;
            r.Cells[cmnMarca.Index].Value = producto.Marca.NombreMarca;
            r.Cells[cmnCategoria.Index].Value = producto.Categoria.NombreCategoria;
            r.Cells[cmnPrecio.Index].Value = producto.PrecioUnitario;
            r.Cells[cmnStock.Index].Value = producto.Stock;
            r.Cells[cmnSuspendido.Index].Value = producto.Suspendido;
            r.Tag = producto;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(DataGridViewDatos);
            return r;
        }

        public void AgregarFila(Producto producto)
        {
            DataGridViewRow r = ConstruirFila();
            SetearFila(r,producto);
            AgregarFila(r);
        }
        private void FrmProductos_Load(object sender, System.EventArgs e)
        {
            try
            {
                _servicio=new ServicioProductos();
                _lista = _servicio.GetLista();
                MostrarEnGrilla();
            }
            catch (Exception exception)
            {
                Helper.MensajeBox(exception.Message, Tipo.Error);
            }
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FrmProductosAE frm = new FrmProductosAE(this) {Text = "Agregar Producto"};
            DialogResult dr = frm.ShowDialog(this);
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (DataGridViewDatos.SelectedRows.Count==0)
            {
                return;
            }

            DataGridViewRow r = DataGridViewDatos.SelectedRows[0];
            Producto p = (Producto) r.Tag;
            p = _servicio.GetProductoPorId(p.ProductoId);
            FrmProductosAE frm=new FrmProductosAE();
            frm.Text = "Editar un Producto";
            frm.SetProducto(p);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                try
                {
                    p = frm.GetProducto();
                    _servicio.Guardar(p);
                    SetearFila(r,p);
                    Helper.MensajeBox("Registro modificado", Tipo.Success);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }
        }
    }
}
