using System.Collections.Generic;
using System.Drawing.Text;
using System.Windows.Forms;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.ServiceLayer.Servicios;
using NeptunoSql.ServiceLayer.Servicios.Facades;
using NeptunoSql.Windows.Helpers.Enum;

namespace NeptunoSql.Windows.Helpers
{
    public class Helper
    {
        public static void MensajeBox(string mensaje, Tipo tipo)
        {
            switch (tipo)
            {
                case Tipo.Success:
                    MessageBox.Show(mensaje, "Operación Exitosa", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    break;
                case Tipo.Error:
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    break;
                //case Tipo.Warning:
                //    break;
                //case Tipo.Question:
                //    break;
                //default:
                //    break;
            }
        }
        public static DialogResult MensajeBox(string mensaje)
        {
            return MessageBox.Show(mensaje, "Confirmar operación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }

        public static void CargarComboMarcas(ref ComboBox cbo)
        {
            IServicioMarcas servicioMarcas=new ServicioMarcas();
            cbo.DataSource = null;
            List<Marca> listaMarcas = servicioMarcas.GetLista();
            var defaultMarca = new Marca() { MarcaId = 0, NombreMarca = "[Seleccione Marca]" };
            listaMarcas.Insert(0, defaultMarca);
            cbo.DataSource = listaMarcas;
            cbo.DisplayMember = "NombreMarca";
            cbo.ValueMember = "MarcaId";
            cbo.SelectedIndex = 0;
        }

        public static void CargarComboMedidas(ref ComboBox cbo)
        {
            IServicioMedidas servicioMedidas=new ServicioMedidas();
            cbo.DataSource = null;
            List<Medida> lista = servicioMedidas.GetLista();
            var defaultMedida = new Medida {MedidaId = 0, Abreviatura = "[Seleccione]"};
            lista.Insert(0,defaultMedida);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Abreviatura";
            cbo.ValueMember = "MedidaId";
            cbo.SelectedIndex = 0;
        }

        public static void CargarComboCategorias(ref ComboBox cbo)
        {
            IServicioCategorias servicioCategorias=new ServicioCategorias();
            cbo.DataSource = null;
            List<Categoria> lista = servicioCategorias.GetLista();
            var defaultCategoria = new Categoria { CategoriaId = 0, NombreCategoria = "[Seleccione Categoría]" };
            lista.Insert(0, defaultCategoria);
            cbo.DataSource = lista;
            cbo.DisplayMember = "NombreCategoria";
            cbo.ValueMember = "CategoriaId";
            cbo.SelectedIndex = 0;

        }

        public static DataGridViewRow ConstruirFila(ref DataGridView dgv)
        {
            var r=new DataGridViewRow();
            r.CreateCells(dgv);
            return r;
        }
    }
}
