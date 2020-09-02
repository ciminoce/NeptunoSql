using System;
using System.Windows.Forms;
using NeptunoSql.BusinessLayer.Entities;

namespace NeptunoSql.Windows
{
    public partial class FrmMedidasAE : Form
    {
        public FrmMedidasAE()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (medida!=null)
            {
                TextBoxAbreviatura.Text = medida.Denominacion;
                TextBoxMedida.Text = medida.Abreviatura;
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
                medida.Abreviatura = TextBoxAbreviatura.Text;
                DialogResult = DialogResult.OK;
            }

        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

    }
}
