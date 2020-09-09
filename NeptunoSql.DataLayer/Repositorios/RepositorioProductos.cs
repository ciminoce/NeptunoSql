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

        public RepositorioProductos(SqlConnection connection, IRepositorioMarcas repositorioMarcas, IRepositorioCategorias repositorioCategorias, IRepositorioMedidas repositorioMedidas)
        {
            _connection = connection;
            _repositorioMarcas = repositorioMarcas;
            _repositorioCategorias = repositorioCategorias;
            _repositorioMedidas = repositorioMedidas;
        }

        public Producto GetProductoPorId(int id)
        {
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
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
    }
}
