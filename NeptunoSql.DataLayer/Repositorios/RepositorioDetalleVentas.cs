using System;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.DataLayer.Repositorios.Facades;
using System.Data.SqlClient;

namespace NeptunoSql.DataLayer.Repositorios
{
    public class RepositorioDetalleVentas:IRepositorioDetalleVentas
    {
        private readonly SqlConnection cn;
        private readonly SqlTransaction tran;

        public RepositorioDetalleVentas(SqlConnection cn, SqlTransaction tran)
        {
            this.cn = cn;
            this.tran = tran;
        }

        public void Guardar(DetalleVenta detalleVenta)
        {
            try
            {
                string cadenaComando = "INSERT INTO DetalleVentas (VentaId, ProductoId, PrecioUnitario, Cantidad, Descuento, PrecioTotal, KardexId) " +
                                       "VALUES (@vta, @prod, @pUnit, @cant, @desc, @pTot, @kardex)";
                var comando = new SqlCommand(cadenaComando, cn, tran);
                comando.Parameters.AddWithValue("@vta", detalleVenta.Venta.VentaId);
                comando.Parameters.AddWithValue("@prod", detalleVenta.Producto.ProductoId);
                comando.Parameters.AddWithValue("@pUnit", detalleVenta.PrecioUnitario);
                comando.Parameters.AddWithValue("@cant", detalleVenta.Cantidad);
                comando.Parameters.AddWithValue("@desc", detalleVenta.Descuento);
                comando.Parameters.AddWithValue("@pTot", detalleVenta.Total);
                comando.Parameters.AddWithValue("@kardex", detalleVenta.Kardex.KardexId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Error al intentar guardar un detalle de venta");
            }


        }
    }
}
