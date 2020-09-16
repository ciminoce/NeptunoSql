using System;
using System.Windows.Forms;
using NeptunoSql.ServiceLayer.Servicios;
using NeptunoSql.ServiceLayer.Servicios.Facades;
using NeptunoSql.Windows.Helpers;

namespace NeptunoSql.Windows
{
    public partial class FrmProductosAE : Form
    {
        public FrmProductosAE()
        {
            InitializeComponent();
        }
        private readonly IServicioMarcas _servicioMarcas=new ServicioMarcas();
        private readonly IServicioMedidas _servicioMedidas=new ServicioMedidas();
        private readonly IServicioCategorias _servicioCategorias=new ServicioCategorias();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Helper.CargarComboMarcas(ref ComboBoxMarcas);
            Helper.CargarComboCategorias(ref ComboBoxCategorias);
            Helper.CargarComboMedidas(ref ComboBoxMedidas);
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            FrmMarcasAE frm = new FrmMarcasAE() {Text = "Agregar una Marca"};
            DialogResult dr = frm.ShowDialog(this);
            Helper.CargarComboMarcas(ref ComboBoxMarcas);
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoriasAE frm = new FrmCategoriasAE() { Text = "Agregar una Categoría" };
            DialogResult dr = frm.ShowDialog(this);
            Helper.CargarComboCategorias(ref ComboBoxCategorias);
        }

        private void btnAgregarMedida_Click(object sender, EventArgs e)
        {
            FrmMedidasAE frm = new FrmMedidasAE(){Text = "Agregar Medida"};
            DialogResult dr = frm.ShowDialog(this);
            Helper.CargarComboMedidas(ref ComboBoxMedidas);

        }
    }
}
