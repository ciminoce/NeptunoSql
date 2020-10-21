using System;
using System.Data.SqlClient;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.BusinessLayer.Entities.Enums;
using NeptunoSql.DataLayer.Repositorios.Facades;

namespace NeptunoSql.DataLayer.Repositorios
{
    public class RepositorioVentas:IRepositorioVentas
    {
        private readonly SqlConnection cn;
        private readonly SqlTransaction tran;

        public RepositorioVentas(SqlConnection sqlConnection)
        {
            this.cn = sqlConnection;
        }

        public RepositorioVentas(SqlConnection cn, SqlTransaction tran)
        {
            this.cn = cn;
            this.tran = tran;

        }

        public void Guardar(Venta venta)
        {
            try
            {
                string cadenaComando = "INSERT INTO Ventas (Fecha, Subtotal, Descuentos, Total, Estado) " +
                                       "VALUES (@fecha, @sub, @desc, @total, @estado)";
                var comando = new SqlCommand(cadenaComando, cn, tran);
                comando.Parameters.AddWithValue("@fecha", venta.Fecha);
                comando.Parameters.AddWithValue("@sub", venta.Subtotal);
                comando.Parameters.AddWithValue("@desc", venta.Descuentos);
                comando.Parameters.AddWithValue("@total", venta.Total);
                comando.Parameters.AddWithValue("@estado", venta.Estado);

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

        public decimal GetTotalVenta(int ventaId)
        {
            try
            {
                string cadenaComando = "SELECT Total FROM Ventas WHERE VentaId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", ventaId);

                return (decimal)comando.ExecuteScalar();
                
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public void FacturarVenta(int ventaId)
        {
            try
            {
                string cadenaComando = "UPDATE Ventas SET estado=@estado WHERE VentaId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@estado", EstadoVenta.Facturada);
                comando.Parameters.AddWithValue("@id", ventaId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Error al Facturar una Venta");
            }

        }
    }
}
