using System;
using System.Windows.Forms;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.ServiceLayer.Servicios;
using NeptunoSql.ServiceLayer.Servicios.Facades;
using NeptunoSql.Windows.Helpers;
using NeptunoSql.Windows.Helpers.Enum;

namespace NeptunoSql.Windows
{
    public partial class FrmMedidasAE : Form
    {
        public FrmMedidasAE(FrmMedidas frmMedidas)
        {
            InitializeComponent();
            frm = frmMedidas;
        }
        public FrmMedidasAE()
        {
            InitializeComponent();
            
        }

        private bool _esEdicion = false;
        private FrmMedidas frm;
        private IServicioMedidas _servicio;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _servicio=new ServicioMedidas();
            if (medida!=null)
            {
                TextBoxMedida.Text = medida.Denominacion;
                TextBoxAbreviatura.Text = medida.Abreviatura;
                _esEdicion = true;
            }
        }

        private Medida medida;
        public Medida GetMedida()
        {
            return medida;
        }

        public void SetMedida(Medida medida)
        {
            this.medida = medida;
        }
        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(TextBoxMedida.Text.Trim()) &&
                string.IsNullOrWhiteSpace(TextBoxMedida.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(TextBoxMedida, "Debe ingresar una medida");
            }
            if (string.IsNullOrEmpty(TextBoxAbreviatura.Text.Trim()) &&
                string.IsNullOrWhiteSpace(TextBoxAbreviatura.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(TextBoxAbreviatura, "Debe ingresar una abreviatura");
            }

            return valido;
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if (ValidarDatos())
            {
                if (medida == null)
                {
                    medida = new Medida();
                }

                medida.Denominacion = TextBoxMedida.Text;
                medida.Abreviatura = TextBoxAbreviatura.Text.ToUpper();
                if (ValidarObjeto())
                {

                    if (!_esEdicion)
                    {
                        try
                        {
                            _servicio.Guardar(medida);
                            if (frm!=null)
                            {
                                frm.AgregarFila(medida);
                                
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
            TextBoxMedida.Clear();
            TextBoxAbreviatura.Clear();
            TextBoxMedida.Focus();
            medida = null;
        }

        private bool ValidarObjeto()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (_servicio.Existe(medida) )
            {
                valido = false;
                errorProvider1.SetError(TextBoxMedida,"Medida repetida");
            }else if (_servicio.ExisteAbreviatura(medida))
            {
                valido = false;
                errorProvider1.SetError(TextBoxAbreviatura,"Abreviatura repetida");
            }

            return valido;
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

    }
}
