using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using NeptunoSql.BusinessLayer;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.BusinessLayer.Entities.Enums;
using NeptunoSql.ServiceLayer.Servicios;
using NeptunoSql.ServiceLayer.Servicios.Facades;
using NeptunoSql.Windows.Helpers;
using NeptunoSql.Windows.Helpers.Enum;

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
            _servicioVentas=new ServicioVenta();
            ManejarBotonesBarraHerramientasVentas(true);
            ManejarBotonesBarraHerramientasProducto(false);
            ManejarBotonesBarraHerramientasPagarVenta(false);
            ManejaBotonesBarraHerramientasFinalVentas(false);

        }


        private void ManejaBotonesBarraHerramientasFinalVentas(bool b)
        {
            CancelarToolStripButton.Enabled = b;
            FinalizarVentaToolStripButton.Enabled = b;
        }

        private void ManejarBotonesBarraHerramientasPagarVenta(bool b)
        {
            PagarToolStripButton.Enabled = b;
            AnularVtaToolStripButton.Enabled = b;
        }

        private void ManejarBotonesBarraHerramientasProducto(bool b)
        {
            BuscarToolStripButton.Enabled = b;
            DescuentoToolStripButton.Enabled = b;
        }

        private void ManejarBotonesBarraHerramientasVentas(bool b)
        {
            VentasToolStripButton.Enabled = b;
            ConsultarToolStripButton.Enabled = b;
            CerrarToolStripButton.Enabled = b;
        }

        private void CerrarToolStripButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VentasToolStripButton_Click(object sender, EventArgs e)
        {
            ManejarBotonesBarraHerramientasVentas(false);
            ManejarBotonesBarraHerramientasProducto(true);
            ManejarBotonesBarraHerramientasPagarVenta(false);
            ManejaBotonesBarraHerramientasFinalVentas(true);
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
            r.Cells[cmnDescuento.Index].Value = 0;
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
                DialogResult dr = MessageBox.Show("¿Desea borrar el producto seleccionado?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr==DialogResult.No)
                {
                    return;
                }
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
            CalcularMostrarTotales();
        }

        private void CancelarToolStripButton_Click(object sender, EventArgs e)
        {
            InicializarControlesVenta();
        }

        private void InicializarControlesVenta()
        {
            InicializarGrilla();
            InicializarTotales();
            ManejarBotonesBarraHerramientasVentas(true);
            ManejarBotonesBarraHerramientasProducto(false);
            ManejarBotonesBarraHerramientasPagarVenta(false);
            ManejaBotonesBarraHerramientasFinalVentas(false);

            CodigoBarraTextBox.Enabled = false;

        }

        private void InicializarTotales()
        {
           TotalTextBox.Clear();
           SubtotalTextBox.Clear();
           DescuentosTextBox.Clear();
           TotalLabel.Text = "0.00";
            
        }

        private void InicializarGrilla()
        {
            VentasDataGridView.Rows.Clear();
        }

        private IServicioVentas _servicioVentas;
        private int VentaId = 0;
        private Venta venta;
        private void FinalizarVentaToolStripButton_Click(object sender, EventArgs e)
        {
            if (VentasDataGridView.Rows.Count==0)
            {
                return;
            }

            venta = new Venta();
            venta.Fecha=DateTime.Now;
            venta.Subtotal = CalcularTotal();
            venta.Descuentos = CalcularTotalDescuento();
            venta.Total = venta.Subtotal - venta.Descuentos;
            venta.Estado = EstadoVenta.EnProceso;
            venta.DetalleVentas = CargarDetalleVenta();
            try
            {
                _servicioVentas.Guardar(venta);
                VentaId = venta.VentaId;//Para anular o pagar la venta
                Helper.MensajeBox($"Venta Nro {venta.VentaId} guardada", Tipo.Success);
               
                ManejarBotonesBarraHerramientasProducto(false);
                ManejarBotonesBarraHerramientasVentas(false);
                ManejaBotonesBarraHerramientasFinalVentas(false);
                ManejarBotonesBarraHerramientasPagarVenta(true);
            }
            catch (Exception ex)
            {
                Helper.MensajeBox(ex.Message, Tipo.Error);
            }
        }

        private List<DetalleVenta> CargarDetalleVenta()
        {
            List<DetalleVenta> detalleVentas=new List<DetalleVenta>();
            foreach (DataGridViewRow row in VentasDataGridView.Rows)
            {
                DetalleVenta detalleventa=new DetalleVenta();
                detalleventa.Producto = (Producto) row.Tag;
                detalleventa.PrecioUnitario =(decimal) row.Cells[cmnPrecioUnitario.Index].Value;
                detalleventa.Cantidad = (decimal) row.Cells[cmnCantidad.Index].Value;
                detalleventa.Descuento = Convert.ToDecimal(row.Cells[cmnDescuento.Index].Value);
                detalleventa.Total = (decimal) row.Cells[cmnPrecioTotal.Index].Value;
                
                detalleVentas.Add(detalleventa);
            }

            return detalleVentas;
        }


        private decimal CalcularTotalDescuento()
        {
            decimal total = 0;
            foreach (DataGridViewRow r in VentasDataGridView.Rows)
            {
                total += Convert.ToDecimal(r.Cells[cmnDescuento.Index].Value);
            }

            return total;

        }

        private void PagarToolStripButton_Click(object sender, EventArgs e)
        {
            FrmPago frm=new FrmPago();
            var importeVenta = _servicioVentas.GetTotalVenta(VentaId);
            frm.SetImporteYVenta(importeVenta, VentaId);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                try
                {
                    _servicioVentas.FacturarVenta(VentaId);
                    Helper.MensajeBox($"Venta Nro {VentaId} Facturada", Tipo.Success);
                    VentaId = 0;
                    InicializarControlesVenta();
                }
                catch (Exception exception)
                {
                    Helper.MensajeBox(exception.Message, Tipo.Error);
                }
            }
        }

        private void AnularVtaToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"¿Desea anular la venta {VentaId}?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.No)
            {
                return;
            }
            try
            {
                _servicioVentas.AnularVenta(venta);
                Helper.MensajeBox($"Venta Nro {VentaId} Anulada", Tipo.Success);
                VentaId = 0;
                venta = null;
                InicializarControlesVenta();
            }
            catch (Exception exception)
            {
                Helper.MensajeBox(exception.Message, Tipo.Error);
            }

        }

        private void DescuentoToolStripButton_Click(object sender, EventArgs e)
        {
            if (VentasDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            DataGridViewRow r = VentasDataGridView.SelectedRows[0];
            decimal importeTotal =(decimal) r.Cells[4].Value;
            FrmDescuento frm = new FrmDescuento() {Text = "Establecer descuento"};
            frm.SetImporte(importeTotal);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                decimal descuento = frm.GetDescuento();
                r.Cells[3].Value = descuento;
                r.Cells[4].Value = importeTotal - descuento;

            }
        }
    }
}
