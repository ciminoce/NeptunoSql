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

namespace NeptunoSql.Windows
{
    public partial class FrmCategoriasAE : Form
    {
        public FrmCategoriasAE()
        {
            InitializeComponent();
        }

        private Categoria categoria;
        public Categoria GetCategoria()
        {
            return categoria;
        }

        public void SetCategoria(Categoria categoria)
        {
            this.categoria = categoria;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (categoria!=null)
            {
                TextBoxCategoria.Text = categoria.NombreCategoria;
                TextBoxDescripcion.Text = categoria.Descripcion;

            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(TextBoxCategoria.Text.Trim()) &&
                string.IsNullOrWhiteSpace(TextBoxCategoria.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(TextBoxCategoria, "Debe ingresar una categoria");
            }

            return valido;
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if (ValidarDatos())
            {
                if (categoria == null)
                {
                    categoria = new Categoria();
                }

                categoria.NombreCategoria = TextBoxCategoria.Text;
                categoria.Descripcion = TextBoxDescripcion.Text;
                DialogResult = DialogResult.OK;
            }

        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

    }
}
