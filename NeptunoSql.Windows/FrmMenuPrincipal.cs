﻿using System;
using System.Windows.Forms;

namespace NeptunoSql.Windows
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarcas frm=new FrmMarcas();
            frm.ShowDialog(this);

        }

        private void medidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedidas frm=new FrmMedidas();
            frm.ShowDialog(this);
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorias frm=new FrmCategorias();
            frm.ShowDialog(this);
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos frm=new FrmProductos();
            frm.ShowDialog(this);
        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresos frm=new FrmIngresos();
            frm.ShowDialog(this);
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentas frm=new FrmVentas();
            frm.ShowDialog(this);
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-ES");
        }
    }
}
