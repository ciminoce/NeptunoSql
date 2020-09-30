using System;
using System.Data.SqlClient;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.DataLayer.Repositorios.Facades;

namespace NeptunoSql.DataLayer.Repositorios
{
    public class RepositorioIngresos:IRepositorioIngresos
    {
        private readonly SqlConnection _sqlConnection;
        private readonly SqlTransaction _tran;

        public RepositorioIngresos(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public RepositorioIngresos(SqlConnection cn, SqlTransaction tran)
        {
            _sqlConnection = cn;
            _tran = tran;
        }

        public void Guardar(Ingreso ingreso)
        {
            try
            {
                string cadenaComando = "INSERT INTO Ingresos (Referencia, Empleado, Fecha) "+
                                       "VALUES (@ref, @emp, @fecha)";
                var comando = new SqlCommand(cadenaComando, _sqlConnection,_tran);
                comando.Parameters.AddWithValue("@ref", ingreso.Referencia);
                comando.Parameters.AddWithValue("@emp", ingreso.Empleado);
                comando.Parameters.AddWithValue("@fecha", ingreso.Fecha);
                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@IDENTITY";
                comando = new SqlCommand(cadenaComando, _sqlConnection,_tran);
                int id = (int)(decimal)comando.ExecuteScalar();
                ingreso.IngresoId= id;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
