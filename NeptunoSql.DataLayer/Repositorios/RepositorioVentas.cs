using System;
using System.Data.SqlClient;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.DataLayer.Repositorios.Facades;

namespace NeptunoSql.DataLayer.Repositorios
{
    public class RepositorioVentas:IRepositorioVentas
    {
        private readonly SqlConnection cn;
        private readonly SqlTransaction tran;
        public RepositorioVentas(SqlConnection cn, SqlTransaction tran)
        {
            this.cn = cn;
            this.tran = tran;

        }

        public void Guardar(Venta venta)
        {
            try
            {
                string cadenaComando = "INSERT INTO Ingresos (Fecha, Subtotal, Descuentos, Total) " +
                                       "VALUES (@fecha, @sub, @desc, @total)";
                var comando = new SqlCommand(cadenaComando, cn, tran);
                comando.Parameters.AddWithValue("@fecha", venta.Fecha);
                comando.Parameters.AddWithValue("@sub", venta.Subtotal);
                comando.Parameters.AddWithValue("@des", venta.Descuentos);
                comando.Parameters.AddWithValue("@total", venta.Total);

                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@IDENTITY";
                comando = new SqlCommand(cadenaComando, cn, tran);
                int id = (int)(decimal)comando.ExecuteScalar();
                venta.VentaId = id;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
    }
}
