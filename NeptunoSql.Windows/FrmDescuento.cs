using System;
using System.Windows.Forms;

namespace NeptunoSql.Windows
{
    public partial class FrmDescuento : Form
    {
        public FrmDescuento()
        {
            InitializeComponent();
        }

        private decimal importeTotal;
        private decimal descuento;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ImporteTextBox.Text = importeTotal.ToString();

        }

        public decimal GetDescuento()
        {
            return descuento;
        }
        public void SetImporte(decimal importeTotal)
        {
            this.importeTotal = importeTotal;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                descuento = decimal.Parse(DescuentoTextBox.Text);
                DialogResult = DialogResult.OK;

            }
        }

        private bool ValidarDatos()
        {
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
