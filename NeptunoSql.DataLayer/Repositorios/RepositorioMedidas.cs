using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.DataLayer.Repositorios.Facades;

namespace NeptunoSql.DataLayer.Repositorios
{
    public class RepositorioMedidas:IRepositorioMedidas
    {
        private readonly SqlConnection _sqlConnection;

        public RepositorioMedidas(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public Medida GetMedidaPorId(int id)
        {
            try
            {
                Medida medida = null;
                string cadenaComando = "SELECT MedidaId, Denominacion, Abreviatura FROM Medidas WHERE MedidaId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    medida = ConstruirMedida(reader);
                    reader.Close();
                }

                return medida;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<Medida> GetLista()
        {
            List<Medida> lista = new List<Medida>();
            try
            {
                string cadenaComando = "SELECT MedidaId, Denominacion, Abreviatura FROM Medidas";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Medida medida = ConstruirMedida(reader);
                    lista.Add(medida);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Medida ConstruirMedida(SqlDataReader reader)
        {
            return new Medida
            {
                MedidaId = reader.GetInt32(0),
                Denominacion = reader.GetString(1),
                Abreviatura = reader.GetString(2)
            };
        }

        public void Guardar(Medida medida)
        {
            if (medida.MedidaId == 0)
            {
                //Nuevo registro
                try
                {
                    string cadenaComando = "INSERT INTO Medidas VALUES(@deno, @abr)";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@deno", medida.Denominacion);
                    comando.Parameters.AddWithValue("@abr", medida.Abreviatura);

                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    medida.MedidaId = (int)(decimal)comando.ExecuteScalar();

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
                    string cadenaComando = "UPDATE Medidas SET Denominacion=@deno, Abreviatura=@abr WHERE MedidaId=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@deno", medida.Denominacion);
                    comando.Parameters.AddWithValue("@abr", medida.Abreviatura);
                    comando.Parameters.AddWithValue("@id", medida.MedidaId);
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
                string cadenaComando = "DELETE FROM Medidas WHERE MedidaId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Medida medida)
        {
            try
            {
                SqlCommand comando;
                if (medida.MedidaId == 0)
                {
                    string cadenaComando = "SELECT MedidaId, Denominacion, Abreviatura FROM Medidas WHERE Denominacion=@deno";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@deno", medida.Denominacion);

                }
                else
                {
                    string cadenaComando = "SELECT MedidaId, Denominacion, Abreviatura FROM Medidas WHERE Denominacion=@nombre AND MedidaId<>@id";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", medida.Denominacion);
                    comando.Parameters.AddWithValue("@id", medida.MedidaId);


                }
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool ExisteAbreviatura(Medida medida)
        {
            try
            {
                SqlCommand comando;
                if (medida.MedidaId == 0)
                {
                    string cadenaComando = "SELECT MedidaId, Denominacion, Abreviatura FROM Medidas WHERE Abreviatura=@ab";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@ab", medida.Abreviatura);

                }
                else
                {
                    string cadenaComando = "SELECT MedidaId, Denominacion, Abreviatura FROM Medidas WHERE Abreviatura=@ab AND MedidaId<>@id";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@ab", medida.Abreviatura);
                    comando.Parameters.AddWithValue("@id", medida.MedidaId);


                }
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Medida medida)
        {
            return false;
        }
    }
}
