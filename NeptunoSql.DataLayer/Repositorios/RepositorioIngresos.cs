using System;
using System.Collections.Generic;
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

        public List<Ingreso> GetIngresos(DateTime fechaInicial, DateTime fechaFinal)
        {
            List<Ingreso> lista=new List<Ingreso>();
            var fecha1 = $"{fechaInicial.Year}{fechaInicial.Month.ToString().PadLeft(2,'0')}{fechaInicial.Day.ToString().PadLeft(2, '0')}";
            var fecha2 = $"{fechaFinal.Year}{fechaFinal.Month.ToString().PadLeft(2, '0')}{fechaFinal.Day.ToString().PadLeft(2, '0')}";

            try
            {
                string cadenaComando = "SELECT IngresoId, Referencia, Empleado, Fecha " +
                                       "FROM Ingresos WHERE CAST(Fecha AS Date)>=CAST(@fecha1 AS Date)" +
                                       " AND CAST(Fecha AS Date)<=CAST(@fecha2 AS Date) " +
                                       "ORDER BY Fecha";
                //string cadenaComando = "SELECT IngresoId, Referencia, Empleado, Fecha " +
                //                       "FROM Ingresos WHERE CONVERT(smalldatetime, CONVERT(char(10), Fecha, 103), 103) " +
                //                       " BETWEEN CONVERT(smalldatetime, CONVERT(char(10), @fecha1, 103), 103) " +
                //                       "AND CONVERT(smalldatetime, CONVERT(char(10), @fecha2, 103), 103)" +
                //                       " ORDER BY Fecha";
                //string cadenaComando = "SELECT IngresoId, Referencia, Empleado, Fecha " +
                //                       "FROM Ingresos WHERE Fecha " +
                //                       " BETWEEN CONVERT(char(8), @fecha1, 112) AND CONVERT(char(8), @fecha2, 112)" +
                //                       " ORDER BY Fecha";
                //string cadenaComando = "SELECT IngresoId, Referencia, Empleado, Fecha " +
                //                       "FROM Ingresos WHERE CONVERT(smalldatetime, CONVERT(char(10), fecha, 103), 103)>= @fecha1 "+
                //" AND CONVERT(smalldatetime, CONVERT(char(10), fecha, 103), 103) <= @fecha2";
                //string cadenaComando = "SELECT IngresoId, Referencia, Empleado, Fecha " +
                //                       "FROM Ingresos WHERE CAST(CONVERT(CHAR(8), fecha, 112) AS INT) " +
                //                       "BETWEEN CAST(CONVERT(CHAR(8), @fecha1, 112) AS INT) " +
                //                       "AND CAST(CONVERT(CHAR(8), @fecha2, 112) AS INT)";

                //string cadenaComando = "SELECT IngresoId, Referencia, Empleado, Fecha " +
                //                       "FROM Ingresos WHERE Fecha " +
                //                       "BETWEEN @fecha1 AND @fecha2";

                //string cadenaComando = "SELECT IngresoId, Referencia, Empleado, Fecha " +
                //                       "FROM Ingresos WHERE convert(char(8),Fecha) BETWEEN @fecha1 " +
                //                       "AND @fecha2 ORDER BY Fecha";

                var comando = new SqlCommand(cadenaComando, _sqlConnection, _tran);
                //comando.Parameters.AddWithValue("@fecha1", fecha1);
                //comando.Parameters.AddWithValue("@fecha2", fecha2);
                comando.Parameters.AddWithValue("@fecha1", fechaInicial);
                comando.Parameters.AddWithValue("@fecha2", fechaFinal);
                //comando.Parameters.AddWithValue("@fecha1", fechaInicial.ToString("yyyyMMdd"));
                //comando.Parameters.AddWithValue("@fecha2", fechaFinal.ToString("yyyyMMdd"));
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var ingreso = ConstruirIngreso(reader);
                    lista.Add(ingreso);

                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception("Error al intentar leer los ingresos entre fechas");
            }
        }

        private Ingreso ConstruirIngreso(SqlDataReader reader)
        {
            return new Ingreso
            {
                IngresoId = reader.GetInt32(0),
                Referencia = reader.GetString(1),
                Empleado = reader.GetString(2),
                Fecha = reader.GetDateTime(3)
            };
        }
    }
}
