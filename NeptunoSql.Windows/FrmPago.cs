using System;
using System.Windows.Forms;

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
            return true;
        }
    }
}
