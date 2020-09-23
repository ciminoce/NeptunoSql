using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.ServiceLayer.Servicios;
using NeptunoSql.ServiceLayer.Servicios.Facades;
using NeptunoSql.Windows.Helpers;

namespace NeptunoSql.Windows
{
    public partial class FrmBuscarProducto : Form
    {
        private FrmIngresos frm;
        public FrmBuscarProducto(FrmIngresos frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private readonly IServicioProductos _servicio=new ServicioProductos();
        private void FrmBuscarProducto_Load(object sender, EventArgs e)
        {
            CargarProductosEnGrilla();
        }

        private void CargarProductosEnGrilla()
        {
            ProductosDataGridView.Rows.Clear();
            List<Producto> lista = _servicio.GetLista();
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
            r.Tag = producto;
        }

        private void ProductosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex!=1)
            {
                return;
            }

            DataGridViewRow r = ProductosDataGridView.Rows[e.RowIndex];
            Producto p=r.Tag as Producto;
            frm.AgregarFila(p);

        }
    }
}
