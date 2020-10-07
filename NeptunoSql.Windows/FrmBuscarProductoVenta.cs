using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.ServiceLayer.Servicios;
using NeptunoSql.ServiceLayer.Servicios.Facades;
using NeptunoSql.Windows.Helpers;

namespace NeptunoSql.Windows
{
    public partial class FrmBuscarProductoVenta : Form
    {
        private FrmVentas frm;
        public FrmBuscarProductoVenta(FrmVentas frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void CerrarPictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }
        private readonly IServicioProductos _servicioProductos=new ServicioProductos();
        private void FrmBuscarProductoVenta_Load(object sender, EventArgs e)
        {
            CargarDatosEnGrilla();
        }

        private List<Producto> lista;
        private void CargarDatosEnGrilla()
        {
            lista = _servicioProductos.GetLista();
            foreach (var producto in lista)
            {
                DataGridViewRow r = Helper.ConstruirFila(ref ProductosDataGridView);
                SetearFila(r, producto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            ProductosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Producto producto)
        {
            r.Cells[cmnProducto.Index].Value = producto.ToString();
            r.Cells[cmnCategoria.Index].Value = producto.Categoria.NombreCategoria;
            r.Cells[cmnPrecioUnitario.Index].Value = producto.PrecioUnitario;
            r.Cells[cmnStock.Index].Value = producto.Stock;

            r.Tag = producto;

        }

        private Producto producto;
        private void ProductosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==4)
            {
                DataGridViewRow r = ProductosDataGridView.Rows[e.RowIndex];
                producto = (Producto) r.Tag;

                var cantidad = Interaction.InputBox("Ingrese la cantidad vendida", "Ingreso de Cantidad",
                    "1", 800, 400);
                if (!decimal.TryParse(cantidad, out decimal cantidadVendida))
                {
                    return;
                }
                else if (cantidadVendida <= 0 || cantidadVendida >producto.Stock)
                {
                    //TODO:Se puede sacar un mensaje de error
                    return;
                }
                frm.AgregarProductoEnVenta(producto,cantidadVendida);
            }
        }
    }
}
