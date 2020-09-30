using System;
using System.Data.SqlClient;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.DataLayer.Repositorios.Facades;

namespace NeptunoSql.DataLayer.Repositorios
{
    public class RepositorioKardex:IRepositorioKardex
    {
        private readonly SqlConnection _sqlConnection;
        private readonly SqlTransaction _sqlTransaction;

        public RepositorioKardex(SqlConnection sqlConnection, SqlTransaction sqlTransaction)
        {
            _sqlConnection = sqlConnection;
            _sqlTransaction = sqlTransaction;
        }
        public void Guardar(Kardex kardex)
        {
            try
            {
                string cadenaComando = "INSERT INTO Kardex (ProductoId, Fecha, Movimiento, Entrada, Salida, Saldo) " +
                                       "VALUES (@prod, @fecha, @mov, @ent, @sal, @saldo)";
                var comando = new SqlCommand(cadenaComando, _sqlConnection, _sqlTransaction);
                comando.Parameters.AddWithValue("@prod", kardex.Producto.ProductoId);
                comando.Parameters.AddWithValue("@fecha", kardex.Fecha);
                comando.Parameters.AddWithValue("@mov", kardex.Movimiento);
                comando.Parameters.AddWithValue("@ent", kardex.Entrada);
                comando.Parameters.AddWithValue("@sal", kardex.Salida);
                comando.Parameters.AddWithValue("@saldo", kardex.Saldo);


                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@IDENTITY";
                comando = new SqlCommand(cadenaComando, _sqlConnection, _sqlTransaction);
                int id = (int)(decimal)comando.ExecuteScalar();
                kardex.KardexId = id;
            }
            catch (Exception e)
            {

                throw new Exception("Error al intentar agregar un registro en kardex");
            }

        }

        public Kardex GetUltimoKardex(Producto producto)
        {
            Kardex kardex = null;
            try
            {
                string cadenaComando = "SELECT ProductoId, Fecha, Movimiento, Entrada, Salida, Saldo " +
                                       " FROM Kardex WHERE ProductoId=@id AND Fecha=(SELECT MAX(FECHA) "+
                    " FROM Kardex WHERE ProductoId=@id)";
                var comando=new SqlCommand(cadenaComando,_sqlConnection,_sqlTransaction);
                comando.Parameters.AddWithValue("@id", producto.ProductoId);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    kardex=new Kardex();
                    kardex.Producto = producto;
                    kardex.Fecha = reader.GetDateTime(1);
                    kardex.Movimiento = reader.GetString(2);
                    kardex.Entrada = reader.GetDecimal(3);
                    kardex.Salida = reader.GetDecimal(4);
                    kardex.Saldo = reader.GetDecimal(5);
                }
                reader.Close();
                return kardex;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
