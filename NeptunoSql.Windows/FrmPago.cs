using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace NeptunoSql.Windows
{
    public partial class FrmPago : Form
    {
        public FrmPago()
        {
            InitializeComponent();
        }

        private decimal importeVenta;
        private int ventaId;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            VentaNroTextBox.Text = ventaId.ToString();
            ImporteTotalTextBox.Text = importeVenta.ToString();
        }

        public void SetImporteYVenta(decimal importeVenta, int ventaId)
        {
            this.importeVenta = importeVenta;
            this.ventaId = ventaId;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!decimal.TryParse(ImportePagadoTextBox.Text, out decimal importePagado))
            {
                valido = false;
                errorProvider1.SetError(ImportePagadoTextBox,"Importe mal ingresado");
            }else if (importePagado<importeVenta)
            {
                valido = false;
                errorProvider1.SetError(ImportePagadoTextBox, "Importe no válido");
            }
            return valido;
        }

        private void ImportePagadoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (string.IsNullOrEmpty(ImportePagadoTextBox.Text) ||
                    !decimal.TryParse(ImportePagadoTextBox.Text,out decimal importePagado))
                {
                    return;
                }

                VueltoTextBox.Text = (importePagado - importeVenta).ToString();
            }
        }
    }
}
