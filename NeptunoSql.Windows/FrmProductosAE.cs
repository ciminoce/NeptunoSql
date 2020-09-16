using System;
using System.Drawing;
using System.Net.NetworkInformation;
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
        private FrmProductos frm;
        public FrmProductosAE(FrmProductos frm)
        {
            InitializeComponent();
            this.frm = frm;

        }
        public FrmProductosAE()
        {
            InitializeComponent();
        }
        private readonly string _imagenNoDisponible = Application.StartupPath + "\\Imágenes\\" + "SinImagenDisponible.jpg";
        private readonly string _archivoNoEncontrado = Application.StartupPath + "\\Imágenes\\" + "ArchivoNoEncontrado.jpg";
        private readonly string _rutaCarpetaImagenes = Application.StartupPath + "\\Imágenes\\";
        private string _rutaDelArchivo = "";

        private readonly IServicioMarcas _servicioMarcas=new ServicioMarcas();
        private readonly IServicioMedidas _servicioMedidas=new ServicioMedidas();
        private readonly IServicioCategorias _servicioCategorias=new ServicioCategorias();

        private Producto producto;
        private IServicioProductos _servicio=new ServicioProductos();
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Helper.CargarComboMarcas(ref ComboBoxMarcas);
            Helper.CargarComboCategorias(ref ComboBoxCategorias);
            Helper.CargarComboMedidas(ref ComboBoxMedidas);
            if (producto!=null)
            {
                ComboBoxMarcas.SelectedValue = producto.Marca.MarcaId;
                ComboBoxCategorias.SelectedValue = producto.Categoria.CategoriaId;
                ComboBoxMedidas.SelectedValue = producto.Medida.MedidaId;
                TextBoxDescripcion.Text = producto.Descripcion;
                TextBoxCodigoDeBarras.Text = producto.CodigoBarra;
                TextBoxPrecioVenta.Text = producto.PrecioUnitario.ToString();
                CheckBoxSuspendido.Checked = producto.Suspendido;
                if (producto.Imagen!=null)
                {
                    picProducto.Image=Image.FromFile(producto.Imagen);
                }
                else
                {
                    picProducto.Image=Image.FromFile(_imagenNoDisponible);
                }
            }
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

        private bool _esEdicion = false;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (producto == null)
                {
                    producto = new Producto();
                }

                producto.Marca =(Marca) ComboBoxMarcas.SelectedItem;
                producto.Categoria = ComboBoxCategorias.SelectedItem as Categoria;
                producto.Medida = ComboBoxMedidas.SelectedItem as Medida;
                producto.Descripcion = TextBoxDescripcion.Text;
                producto.CodigoBarra = TextBoxCodigoDeBarras.Text;
                producto.PrecioUnitario = decimal.Parse(TextBoxPrecioVenta.Text);
                producto.Suspendido = CheckBoxSuspendido.Checked;
                if (!string.IsNullOrEmpty(_rutaDelArchivo))
                {
                    producto.Imagen = _rutaDelArchivo;
                }
                else
                {
                    producto.Imagen = _imagenNoDisponible;
                }

                if (ValidarObjeto())
                {

                    if (!_esEdicion)
                    {
                        try
                        {
                            _servicio.Guardar(producto);
                            if (frm != null)
                            {
                                frm.AgregarFila(producto);

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

        private bool ValidarDatos()
        {
            var valido = true;
            errorProvider1.Clear();
            if (ComboBoxMarcas.SelectedIndex==0)
            {
                valido = false;
                errorProvider1.SetError(ComboBoxMarcas,"Debe seleccionar una marca");
            }
            if (ComboBoxCategorias.SelectedIndex==0)
            {
                valido = false;
                errorProvider1.SetError(ComboBoxCategorias,"Debe seleccionar una categoría");
            }
            if (ComboBoxMedidas.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(ComboBoxMedidas, "Debe seleccionar una medida");
            }

            if (string.IsNullOrEmpty(TextBoxDescripcion.Text) || 
                string.IsNullOrWhiteSpace(TextBoxDescripcion.Text))
            {
                valido = false;
                errorProvider1.SetError(TextBoxDescripcion,"Debe ingresar una descripción");
            }

            if (!decimal.TryParse(TextBoxPrecioVenta.Text,out var precio))
            {
                valido = false;
                errorProvider1.SetError(TextBoxPrecioVenta,"Precio mal ingresado");
            }else if (precio<=0 || precio>=int.MaxValue)
            {
                valido = false;
                errorProvider1.SetError(TextBoxPrecioVenta,"Precio fuera del rango permitido");
            }
            return valido;
        }

        private void InicializarControles()
        {
            
            producto = null;
        }

        private bool ValidarObjeto()
        {
            var valido = true;
            errorProvider1.Clear();
            //if (_servicio.Existe(producto))
            //{
            //    valido = false;
            //    errorProvider1.SetError(TextBoxMarca, "Marca repetida");
            //}

            return valido;
        }

        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            //Abro un filedialog para buscar un archivo de imagen
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //Seteo que no se pueda elegir más de uno a la vez
            openFileDialog1.Multiselect = false;
            //Seteo el directorio donde busco
            openFileDialog1.InitialDirectory = Application.StartupPath + @"\Imágenes";
            //Pongo los filtros 
            openFileDialog1.Filter = " Imagenes(*.BMP;*.JPG;*.GIF;*.PGN)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            //Por defecto busco bitmaps
            openFileDialog1.FilterIndex = 1;
            //Abro el cuadro de diálogo
            DialogResult dr = openFileDialog1.ShowDialog(this);
            //Si el dialogo termina OK
            if (dr == DialogResult.OK)
            {
                //Tomo el nombre del archivo de imagen con su ruta
                //archivoNombreConRuta = openFileDialog1.FileName;
                picProducto.Image = Image.FromFile(openFileDialog1.FileName);
                _rutaDelArchivo = openFileDialog1.FileName;
            }

        }

        public void SetProducto(Producto producto)
        {
            this.producto = producto;
        }

        public Producto GetProducto()
        {
            return producto;
        }
    }
}
