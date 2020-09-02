using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.DataLayer.Repositorios.Facades;

namespace NeptunoSql.DataLayer.Repositorios
{
    public class RepositorioCategorias:IRepositorioCategorias
    {
        private readonly SqlConnection _sqlConnection;

        public RepositorioCategorias(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public Categoria GetCategoriaPorId(int id)
        {
            try
            {
                Categoria categoria = null;
                string cadenaComando = "SELECT CategoriaId, NombreCategoria, Descripcion FROM Categorias WHERE CategoriaId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    categoria = ConstruirCategoria(reader);
                    reader.Close();
                }

                return categoria;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<Categoria> GetLista()
        {
            List<Categoria> lista = new List<Categoria>();
            try
            {
                string cadenaComando = "SELECT CategoriaId, NombreCategoria, Descripcion FROM Categorias";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Categoria categoria = ConstruirCategoria(reader);
                    lista.Add(categoria);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Categoria ConstruirCategoria(SqlDataReader reader)
        {
            //var categoria=new Categoria();
            //categoria.CategoriaId = reader.GetInt32(0);
            //categoria.NombreCategoria = reader.GetString(1);
            //categoria.Descripcion = reader.GetString(2);
            //return categoria;
            return new Categoria
            {
                CategoriaId = reader.GetInt32(0),
                NombreCategoria = reader.GetString(1),
                Descripcion = reader[2] != DBNull.Value ? reader.GetString(2) : null
            };
        }

        public void Guardar(Categoria categoria)
        {
            if (categoria.CategoriaId == 0)
            {
                //Nuevo registro
                try
                {
                    string cadenaComando = "INSERT INTO Categorias VALUES(@nombre, @desc)";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", categoria.NombreCategoria);
                    comando.Parameters.AddWithValue("@desc", categoria.Descripcion);

                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    categoria.CategoriaId = (int)(decimal)comando.ExecuteScalar();

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
            else
            {
                //Edición
                try
                {
                    string cadenaComando = "UPDATE Categorias SET NombreCategoria=@nombre, Descripcion=@desc WHERE CategoriaId=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", categoria.NombreCategoria);
                    comando.Parameters.AddWithValue("@desc", categoria.Descripcion);
                    comando.Parameters.AddWithValue("@id", categoria.CategoriaId);
                    comando.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }

        public void Borrar(int id)
        {
            try
            {
                string cadenaComando = "DELETE FROM Categorias WHERE CategoriaId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Categoria categoria)
        {
            try
            {
                SqlCommand comando;
                if (categoria.CategoriaId == 0)
                {
                    string cadenaComando = "SELECT CategoriaId, NombreCategoria, Descripcion FROM Categorias WHERE NombreCategoria=@nombre";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", categoria.NombreCategoria);

                }
                else
                {
                    string cadenaComando = "SELECT CategoriaId, NombreCategoria, Descripcion FROM Categorias WHERE NombreCategoria=@nombre AND CategoriaId<>@id";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", categoria.NombreCategoria);
                    comando.Parameters.AddWithValue("@id", categoria.CategoriaId);


                }
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Categoria categoria)
        {
            return false;
        }
    }
}
