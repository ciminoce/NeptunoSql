using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.ServiceLayer.Servicios;
using NeptunoSql.ServiceLayer.Servicios.Facades;
using NeptunoSql.Windows.Helpers;

namespace NeptunoSql.Windows
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void BuscarToolStripButton_Click(object sender, EventArgs e)
        {
            FrmBuscarProductoVenta frm=new FrmBuscarProductoVenta(this);
            frm.ShowDialog(this);
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            _servicioProductos=new ServicioProductos();
            ManejarBarraHerramientas(true);
        }

        private void ManejarBarraHerramientas(bool b)
        {
            VentasToolStripButton.Enabled = b;
            CancelarToolStripButton.Enabled = !b;
            FinalizarVentaToolStripButton.Enabled = !b;
            BuscarToolStripButton.Enabled = !b;
            DescuentoToolStripButton.Enabled = !b;
            PagarToolStripButton.Enabled = !b;
            CerrarToolStripButton.Enabled = b;
        }

        private void CerrarToolStripButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VentasToolStripButton_Click(object sender, EventArgs e)
        {
            ManejarBarraHerramientas(false);
            CodigoBarraTextBox.Enabled = true;
        }

        private IServicioProductos _servicioProductos;

        private void CodigoBarraTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (string.IsNullOrEmpty(CodigoBarraTextBox.Text))
                {
                    return;
                }

                Producto producto = _servicioProductos.GetProductoPorCodigoDeBarras(CodigoBarraTextBox.Text);
                if (producto != null)
                {
                    var index = AgregarProductoEnGrilla(producto);
                    CodigoBarraTextBox.Clear();
                    DialogResult dr = MessageBox.Show("¿Ingresa cantidad?", "Mensaje",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
                    if (dr == DialogResult.No)
                    {
                        CalcularMostrarTotales();

                        return;
                    }

                    IngresarCantidad(index);
                }

                CalcularMostrarTotales();
            }
        }

        private void CalcularMostrarTotales()
        {
            decimal total = CalcularTotal();

            MostrarTotales(total);
        }

        private void MostrarTotales(decimal total)
        {
            TotalLabel.Text = total.ToString("C");
            SubtotalTextBox.Text = total.ToString("C");
            TotalTextBox.Text = total.ToString("C");
        }

        private decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow r in VentasDataGridView.Rows)
            {
                total += (decimal) r.Cells[cmnPrecioTotal.Index].Value;
            }

            return total;
        }

        private int AgregarProductoEnGrilla(Producto producto)
        {
            DataGridViewRow r = ConstruirFila();
            SetearFila(r, producto);
            AgregarFila(r);
            return r.Index;
        }

        private void IngresarCantidad(int index)
        {
            var cantidad = Interaction.InputBox("Ingrese la cantidad vendida", "Ingreso de Cantidad",
                "1", 800, 400);
            if (!decimal.TryParse(cantidad, out decimal cantidadVendida))
            {
                return;
            }
            else if (cantidadVendida <= 0 || cantidadVendida > int.MaxValue)
            {
                //TODO:Hacer el control de la cantidad que se vende por el stock
                return;
            }

            DataGridViewCell celdaCantidad = VentasDataGridView.Rows[index]
                .Cells[cmnCantidad.Index];
            celdaCantidad.Value = cantidadVendida;
            DataGridViewCell celdaPrecio = VentasDataGridView.Rows[index]
                .Cells[cmnPrecioUnitario.Index];
            

            DataGridViewCell celdaTotal = VentasDataGridView.Rows[index]
                .Cells[cmnPrecioTotal.Index];
            celdaTotal.Value = cantidadVendida *(decimal) celdaPrecio.Value;


        }


        private void AgregarFila(DataGridViewRow r)
        {
            VentasDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Producto producto)
        {
            r.Cells[cmnProducto.Index].Value = producto.ToString();
            r.Cells[cmnPrecioUnitario.Index].Value = producto.PrecioUnitario;
            r.Cells[cmnCantidad.Index].Value = 1;
            r.Cells[cmnPrecioTotal.Index].Value = producto.PrecioUnitario;

            r.Tag = producto;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r=new DataGridViewRow();
            r.CreateCells(VentasDataGridView);
            return r;
        }

        private void VentasDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==5)
            {
                VentasDataGridView.Rows.RemoveAt(e.RowIndex);
                CalcularMostrarTotales();
            }
        }

        public void AgregarProductoEnVenta(Producto producto, decimal cantidad)
        {
            DataGridViewRow r = Helper.ConstruirFila(ref VentasDataGridView);
            SetearFila(r,producto);
            AgregarFila(r);
            r.Cells[cmnCantidad.Index].Value = cantidad;
            r.Cells[cmnPrecioTotal.Index].Value = cantidad * (decimal) r.Cells[cmnPrecioUnitario.Index].Value;
        }
    }
}
