using System;
using NeptunoSql.BusinessLayer.Entities;
using System.Collections.Generic;
using System.Windows.Forms;
using NeptunoSql.ServiceLayer.Servicios;
using NeptunoSql.ServiceLayer.Servicios.Facades;
using NeptunoSql.Windows.Helpers;
using NeptunoSql.Windows.Helpers.Enum;

namespace NeptunoSql.Windows
{
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }
        private List<Categoria> _lista;
        private IServicioCategorias _servicio;
        private void MostrarEnGrilla()
        {
            DataGridViewDatos.Rows.Clear();
            foreach (var categoria in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, categoria);
                AgregarFila(r);
            }
        }
        public void AgregarFila(Categoria categoria)
        {
            DataGridViewRow r = ConstruirFila();
            SetearFila(r, categoria);
            AgregarFila(r);
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DataGridViewDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Categoria Categoria)
        {
            r.Cells[cmnCategoria.Index].Value = Categoria.NombreCategoria;

            r.Tag = Categoria;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(DataGridViewDatos);
            return r;
        }
        private void FrmCategorias_Load(object sender, System.EventArgs e)
        {
            try
            {
                _servicio = new ServicioCategorias();
                _lista = _servicio.GetLista();
                MostrarEnGrilla();
            }
            catch (Exception ex)
            {

                Helper.MensajeBox(ex.Message, Tipo.Error);
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FrmCategoriasAE frm = new FrmCategoriasAE();
            frm.Text = "Nueva Categoria";
            DialogResult dr = frm.ShowDialog(this);

        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (DataGridViewDatos.SelectedRows.Count > 0)
            {
                DataGridViewRow r = DataGridViewDatos.SelectedRows[0];
                Categoria categoria = (Categoria)r.Tag;

                DialogResult dr = MessageBox.Show(this, $"¿Desea dar de baja a la categoria {categoria.NombreCategoria}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        _servicio.Borrar(categoria.CategoriaId);
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
                Categoria categoria = (Categoria)r.Tag;
                FrmCategoriasAE frm = new FrmCategoriasAE();
                frm.Text = "Editar Categoria";
                frm.SetCategoria(categoria);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        categoria = frm.GetCategoria();
                        if (!_servicio.Existe(categoria))
                        {
                            _servicio.Guardar(categoria);
                            SetearFila(r, categoria);
                            Helper.MensajeBox("Registro Agregado", Tipo.Success);
                        }
                        else
                        {
                            Helper.MensajeBox("Categoria Repetida", Tipo.Error);
                        }
                    }
                    catch (Exception exception)
                    {
                        Helper.MensajeBox(exception.Message, Tipo.Error);
                    }
                }
            }
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
