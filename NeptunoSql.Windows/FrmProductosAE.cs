using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.ServiceLayer.Servicios;
using NeptunoSql.ServiceLayer.Servicios.Facades;
using NeptunoSql.Windows.Helpers;
using NeptunoSql.Windows.Helpers.Enum;

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
            if (dr==DialogResult.OK)
            {
                try
                {
                    Marca marca = frm.GetMarca();
                    if (!_servicioMarcas.Existe(marca))
                    {
                        _servicioMarcas.Guardar(marca);
                        Helper.MensajeBox("Marca agregada", Tipo.Success);
                        Helper.CargarComboMarcas(ref ComboBoxMarcas);

                    }
                    else
                    {
                        Helper.MensajeBox("Marca repetida", Tipo.Error);
                    }
                    
                }
                catch (Exception exception)
                {
                        Helper.MensajeBox(exception.Message, Tipo.Error);

                }
            }
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoriasAE frm = new FrmCategoriasAE() { Text = "Agregar una Categoría" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    Categoria categoria = frm.GetCategoria();
                    if (!_servicioCategorias.Existe(categoria))
                    {
                        _servicioCategorias.Guardar(categoria);
                        Helper.MensajeBox("Categoría agregada", Tipo.Success);
                        Helper.CargarComboCategorias(ref ComboBoxCategorias);

                    }
                    else
                    {
                        Helper.MensajeBox("Categoría repetida", Tipo.Error);
                    }

                }
                catch (Exception exception)
                {
                    Helper.MensajeBox(exception.Message, Tipo.Error);

                }
            }

        }

        private void btnAgregarMedida_Click(object sender, EventArgs e)
        {
            FrmMedidasAE frm = new FrmMedidasAE(){Text = "Agregar Medida"};
            DialogResult dr = frm.ShowDialog(this);
            Helper.CargarComboMedidas(ref ComboBoxMedidas);

        }
    }
}
