using System;
using System.Windows.Forms;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.ServiceLayer.Servicios;
using NeptunoSql.ServiceLayer.Servicios.Facades;
using NeptunoSql.Windows.Helpers;
using NeptunoSql.Windows.Helpers.Enum;

namespace NeptunoSql.Windows
{
    public partial class FrmMarcasAE : Form
    {
        public FrmMarcasAE()
        {
            InitializeComponent();
        }
        public FrmMarcasAE(FrmMarcas frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (marca != null)
            {
                TextBoxMarca.Text = marca.NombreMarca;
            }
        }

        private Marca marca;
        public void SetMarca(Marca marca)
        {
            this.marca = marca;
        }

        public Marca GetMarca()
        {
            return marca;
        }



        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(TextBoxMarca.Text.Trim()) &&
                string.IsNullOrWhiteSpace(TextBoxMarca.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(TextBoxMarca, "Debe ingresar una marca");
            }

            return valido;
        }

        private bool _esEdicion = false;
        private IServicioMarcas _servicio=new ServicioMarcas();
        private FrmMarcas frm;
        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if (ValidarDatos())
            {
                if (marca == null)
                {
                    marca = new Marca();
                }

                marca.NombreMarca = TextBoxMarca.Text;
                if (ValidarObjeto())
                {

                    if (!_esEdicion)
                    {
                        try
                        {
                            _servicio.Guardar(marca);
                            if (frm != null)
                            {
                                frm.AgregarFila(marca);

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
            TextBoxMarca.Clear();
            TextBoxMarca.Focus();
            marca = null;
        }

        private bool ValidarObjeto()
        {
            var valido = true;
            errorProvider1.Clear();
            if (_servicio.Existe(marca))
            {
                valido = false;
                errorProvider1.SetError(TextBoxMarca, "Marca repetida");
            }

            return valido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

    }
}
