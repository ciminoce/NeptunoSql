using System;
using System.Data.SqlClient;
using NeptunoSql.BusinessLayer;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.DataLayer.Repositorios.Facades;

namespace NeptunoSql.DataLayer.Repositorios
{
    public class RepositorioAnulacionesVentas:IRepositorioAnulacionesVentas
    {

        private readonly SqlConnection _sqlConnection;
        private readonly SqlTransaction _tran;

        public RepositorioAnulacionesVentas(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public RepositorioAnulacionesVentas(SqlConnection cn, SqlTransaction tran)
        {
            _sqlConnection = cn;
            _tran = tran;
        }

        public void Guardar(AnulacionVenta anulacionVenta)
        {
            try
            {
                string cadenaComando = "INSERT INTO AnulacionVentas (Referencia, Fecha, VentaId ) " +
                                       "VALUES (@ref, @fecha, @vtaId)";
                var comando = new SqlCommand(cadenaComando, _sqlConnection, _tran);
                comando.Parameters.AddWithValue("@ref", anulacionVenta.Referencia);
                comando.Parameters.AddWithValue("@fecha", anulacionVenta.Fecha);
                comando.Parameters.AddWithValue("@vtaId", anulacionVenta.Venta.VentaId);
                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@IDENTITY";
                comando = new SqlCommand(cadenaComando, _sqlConnection, _tran);
                int id = (int)(decimal)comando.ExecuteScalar();
                anulacionVenta.AnulacionId = id;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

    }
}
