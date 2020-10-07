using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.DataLayer.Repositorios.Facades;

namespace NeptunoSql.DataLayer.Repositorios
{
    public class RepositorioProductos:IRepositorioProductos
    {
        private readonly SqlConnection _connection;
        private readonly IRepositorioMarcas _repositorioMarcas;
        private readonly IRepositorioCategorias _repositorioCategorias;
        private readonly IRepositorioMedidas _repositorioMedidas;
        private readonly SqlTransaction _tran;

        public RepositorioProductos(SqlConnection connection, IRepositorioMarcas repositorioMarcas, IRepositorioCategorias repositorioCategorias, IRepositorioMedidas repositorioMedidas)
        {
            _connection = connection;
            _repositorioMarcas = repositorioMarcas;
            _repositorioCategorias = repositorioCategorias;
            _repositorioMedidas = repositorioMedidas;
        }

        public RepositorioProductos(SqlConnection connection)
        {
            _connection = connection;
        }

        public RepositorioProductos(SqlConnection cn, SqlTransaction tran)
        {
            _connection = cn;
            _tran = tran;
        }

        public Producto GetProductoPorId(int id)
        {
            Producto p = null;
            try
            {
                string cadenaComando =
                    "SELECT ProductoId, Descripcion, MarcaId, CategoriaId, PrecioUnitario, Stock, CodigoBarra, "+
                    " MedidaId, Imagen, Suspendido FROM Productos WHERE ProductoId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _connection);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if(reader.HasRows)
                {
                    reader.Read();
                    p = ConstruirProductoTotal(reader);
                }
                reader.Close();
                return p;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        private Producto ConstruirProductoTotal(SqlDataReader reader)
        {
            Producto producto = new Producto();
            producto.ProductoId = reader.GetInt32(0);
            producto.Descripcion = reader.GetString(1);
            producto.Marca = _repositorioMarcas.GetMarcaPorId(reader.GetInt32(2));
            producto.Categoria = _repositorioCategorias.GetCategoriaPorId(reader.GetInt32(3));
            producto.PrecioUnitario = reader.GetDecimal(4);
            producto.Stock = reader.GetDecimal(5);
            producto.CodigoBarra =reader[6]!=DBNull.Value?reader.GetString(6):null;
            producto.Medida = _repositorioMedidas.GetMedidaPorId(reader.GetInt32(7));
            producto.Imagen =reader[8]!=DBNull.Value?reader.GetString(8):null;
            producto.Suspendido = reader.GetBoolean(9);
            return producto;

        }

        public List<Producto> GetLista()
        {
            List<Producto> lista=new List<Producto>();
            try
            {
                string cadenaComando =
                    "SELECT ProductoId, Descripcion, MarcaId, CategoriaId, PrecioUnitario, Stock, Suspendido " +
                    " FROM Productos";
                SqlCommand comando=new SqlCommand(cadenaComando, _connection);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Producto producto = ConstruirProducto(reader);
                    lista.Add(producto);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {
               
                throw new Exception(e.Message);
            }
        }

        private Producto ConstruirProducto(SqlDataReader reader)
        {
            Producto producto=new Producto();
            producto.ProductoId = reader.GetInt32(0);
            producto.Descripcion = reader.GetString(1);
            producto.Marca = _repositorioMarcas.GetMarcaPorId(reader.GetInt32(2));
            producto.Categoria = _repositorioCategorias.GetCategoriaPorId(reader.GetInt32(3));
            producto.PrecioUnitario = reader.GetDecimal(4);
            producto.Stock = reader.GetDecimal(5);
            producto.Suspendido = reader.GetBoolean(6);
            return producto;

        }

        public void Guardar(Producto producto)
        {
            try
            {
                string cadenaComando = "INSERT INTO Productos (Descripcion, MarcaId, CategoriaId, PrecioUnitario, " +
                                       "CodigoBarra, MedidaId, Imagen, Suspendido) VALUES (@desc, @marca, @cate, " +
                                       "@precio, @cod, @medida, @imagen, @susp)";
                var comando=new SqlCommand(cadenaComando,_connection);
                comando.Parameters.AddWithValue("@desc", producto.Descripcion);
                comando.Parameters.AddWithValue("@marca", producto.Marca.MarcaId);
                comando.Parameters.AddWithValue("@cate", producto.Categoria.CategoriaId);
                comando.Parameters.AddWithValue("@precio", producto.PrecioUnitario);
                comando.Parameters.AddWithValue("@cod", producto.CodigoBarra);
                comando.Parameters.AddWithValue("@medida", producto.Medida.MedidaId);
                comando.Parameters.AddWithValue("@imagen", producto.Imagen);
                comando.Parameters.AddWithValue("@susp", producto.Suspendido);
                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@IDENTITY";
                comando=new SqlCommand(cadenaComando,_connection);
                int id = (int) (decimal) comando.ExecuteScalar();
                producto.ProductoId = id;




            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Existe(Producto producto)
        {
            throw new System.NotImplementedException();
        }

        public bool EstaRelacionado(Producto producto)
        {
            throw new System.NotImplementedException();
        }

        public void ActualizarStock(Producto producto, decimal cantidad)
        {
            try
            {
                string cadenaComando = "UPDATE Productos SET Stock=Stock+@cant WHERE ProductoId=@id";
                var comando=new SqlCommand(cadenaComando,_connection,_tran);
                comando.Parameters.AddWithValue("@cant", cantidad);
                comando.Parameters.AddWithValue("@id", producto.ProductoId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                
                throw new Exception("Error al actualizar el stock de un producto");
            }
        }

        public Producto GetProductoPorCodigoDeBarras(string codigo)
        {
            Producto p = null;
            try
            {
                string cadenaComando =
                    "SELECT ProductoId, Descripcion, MarcaId, CategoriaId, PrecioUnitario, Stock, CodigoBarra, " +
                    " MedidaId, Imagen, Suspendido FROM Productos WHERE CodigoBarra=@barra";
                SqlCommand comando = new SqlCommand(cadenaComando, _connection);
                comando.Parameters.AddWithValue("@barra", codigo);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    p = ConstruirProductoTotal(reader);
                }
                reader.Close();
                return p;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
