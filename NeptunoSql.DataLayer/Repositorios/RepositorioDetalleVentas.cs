using System;
using System.Collections.Generic;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.DataLayer.Repositorios.Facades;
using System.Data.SqlClient;

namespace NeptunoSql.DataLayer.Repositorios
{
    public class RepositorioDetalleVentas:IRepositorioDetalleVentas
    {
        private readonly SqlConnection cn;
        private readonly SqlTransaction tran;

        private readonly IRepositorioProductos _repositorioProductos;
        public RepositorioDetalleVentas(SqlConnection cn, SqlTransaction tran)
        {
            this.cn = cn;
            this.tran = tran;
        }
        public RepositorioDetalleVentas(SqlConnection cn, SqlTransaction tran,
            IRepositorioProductos repositorioProductos)
        {
            this.cn = cn;
            this.tran = tran;
            this._repositorioProductos = repositorioProductos;
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

        public List<DetalleVenta> GetDetallesPorVenta(int ventaId)
        {
            var lista=new List<DetalleVenta>();
            try
            {
                string cadenaComando =
                    "SELECT ProductoId, PrecioUnitario, Cantidad, Descuento, PrecioTotal" +
                    " FROM DetalleVentas WHERE VentaId=@id ";
                    
                SqlCommand comando = new SqlCommand(cadenaComando, cn,tran);

                comando.Parameters.AddWithValue("@id", ventaId);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    DetalleVenta detalleVenta = ConstruirDetalleVenta(reader);
                    lista.Add(detalleVenta);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private DetalleVenta ConstruirDetalleVenta(SqlDataReader reader)
        {
            return new DetalleVenta
            {
                Producto = _repositorioProductos.GetProductoPorId(reader.GetInt32(0)),
                PrecioUnitario = reader.GetDecimal(1),
                Cantidad = reader.GetDecimal(2),
                Descuento = reader.GetDecimal(3),
                Total = reader.GetDecimal(4)
            };
        }
    }
}
