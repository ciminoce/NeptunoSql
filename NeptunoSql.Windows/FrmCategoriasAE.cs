using System;
using System.Windows.Forms;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.ServiceLayer.Servicios;
using NeptunoSql.ServiceLayer.Servicios.Facades;
using NeptunoSql.Windows.Helpers;
using NeptunoSql.Windows.Helpers.Enum;

namespace NeptunoSql.Windows
{
    public partial class FrmCategoriasAE : Form
    {
        public FrmCategoriasAE(FrmCategorias frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        public FrmCategoriasAE()
        {
            InitializeComponent();
        }

        private readonly FrmCategorias frm;
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

        private bool _esEdicion = false;
        private IServicioCategorias _servicio=new ServicioCategorias();
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
                if (ValidarObjeto())
                {

                    if (!_esEdicion)
                    {
                        try
                        {
                            _servicio.Guardar(categoria);
                            if (frm != null)
                            {
                                frm.AgregarFila(categoria);

                            }
                            Helper.MensajeBox("Registro Guardado", Tipo.Success);
                            DialogResult dr = MessageBox.Show("¿Desea dar de alta otro registro?", "Confirmar",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == DialogResult.No)
                            {
                                DialogResult = DialogResult.Cancel;
                            }
                            else
                            {
                                InicializarControles();
                            }
                        }
                        catch (Exception exception)
                        {
                            Helper.MensajeBox(exception.Message, Tipo.Error);
                        }

                    }
                    else
                    {
                        DialogResult = DialogResult.OK;
                    }
                }
            }

        }

        private void InicializarControles()
        {
            TextBoxCategoria.Clear();
            TextBoxDescripcion.Clear();
            TextBoxCategoria.Focus();
            categoria = null;
        }

        private bool ValidarObjeto()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (_servicio.Existe(categoria))
            {
                valido = false;
                errorProvider1.SetError(TextBoxCategoria, "Categoría repetida");
            }

            return valido;
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

    }
}
