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
    public partial class FrmMedidas : Form
    {
        public FrmMedidas()
        {
            InitializeComponent();
        }
        private List<Medida> lista;
        private IServicioMedidas _servicio;

        private void MostrarEnGrilla()
        {
            DataGridViewDatos.Rows.Clear();
            foreach (var medida in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, medida);
                AgregarFila(r);
            }
        }

        private void ActualizarGrilla()
        {
            try
            {
                _servicio = new ServicioMedidas();
                lista = _servicio.GetLista();
                MostrarEnGrilla();
            }
            catch (Exception ex)
            {

                Helper.MensajeBox(ex.Message, Tipo.Error);
            }

        }

        private void AgregarFila(DataGridViewRow r)
        {
            DataGridViewDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Medida medida)
        {
            r.Cells[cmnMedida.Index].Value = medida.Denominacion;
            r.Cells[cmnAbreviatura.Index].Value = medida.Abreviatura;

            r.Tag = medida;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(DataGridViewDatos);
            return r;
        }

        private void tsbCerrar_Click(object sender, System.EventArgs e)
        {
            Close();
        }


        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FrmMedidasAE frm = new FrmMedidasAE(this);
            frm.Text = "Nueva Medida";
            frm.ShowDialog(this);
        }

        public void AgregarFila(Medida medida)
        {
            DataGridViewRow r = ConstruirFila();
            SetearFila(r, medida);
            AgregarFila(r);
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (DataGridViewDatos.SelectedRows.Count > 0)
            {
                DataGridViewRow r = DataGridViewDatos.SelectedRows[0];
                Medida medida = (Medida)r.Tag;

                DialogResult dr = MessageBox.Show(this, $"¿Desea dar de baja a la medida {medida.Denominacion}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        _servicio.Borrar(medida.MedidaId);
                        DataGridViewDatos.Rows.Remove(r);
                        Helper.MensajeBox("Registro borrado", Tipo.Success);
                    }
                    catch (Exception exception)
                    {
                        Helper.MensajeBox(exception.Message, Tipo.Error);

                    }
                }
            }
        }


        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (DataGridViewDatos.SelectedRows.Count > 0)
            {
                DataGridViewRow r = DataGridViewDatos.SelectedRows[0];
                Medida medida = (Medida)r.Tag;
                Medida medidaAux =(Medida) medida.Clone();
                FrmMedidasAE frm = new FrmMedidasAE();
                frm.Text = "Editar Medida";
                frm.SetMedida(medida);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        medida = frm.GetMedida();
                        _servicio.Guardar(medida);
                        SetearFila(r, medida);
                        Helper.MensajeBox("Registro Agregado", Tipo.Success);
                    }
                    catch (Exception exception)
                    {
                        SetearFila(r, medidaAux);
                        Helper.MensajeBox(exception.Message, Tipo.Error);

                    }
                }
            }
        }

        private void FrmMedidas_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
    }
}
