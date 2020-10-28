using System;
using System.Data.SqlClient;
using NeptunoSql.BusinessLayer;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.DataLayer.Repositorios.Facades;

namespace NeptunoSql.DataLayer.Repositorios
{
    public class RepositorioDetalleAnulacionesVentas:IRepositorioDetalleAnulacionesVentas
    {
        private readonly SqlConnection _sqlConnection;
        private readonly SqlTransaction _sqlTransactiontran;

        public RepositorioDetalleAnulacionesVentas(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public RepositorioDetalleAnulacionesVentas(SqlConnection cn, SqlTransaction tran)
        {
            _sqlConnection = cn;
            _sqlTransactiontran = tran;
        }

        public void Guardar(DetalleAnulacionVenta detalleAnulacion)
        {
            try
            {
                string cadenaComando = "INSERT INTO DetalleAnulacionesVentas (AnulacionId, ProductoId, Cantidad, KardexId) " +
                                       "VALUES (@anul, @prod, @cant, @kardex)";
                var comando = new SqlCommand(cadenaComando, _sqlConnection, _sqlTransactiontran);
                comando.Parameters.AddWithValue("@anul", detalleAnulacion.AnulacionVenta.AnulacionId);
                comando.Parameters.AddWithValue("@prod", detalleAnulacion.Producto.ProductoId);
                comando.Parameters.AddWithValue("@cant", detalleAnulacion.Cantidad);
                comando.Parameters.AddWithValue("@kardex", detalleAnulacion.Kardex.KardexId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Error al intentar guardar un detalle de anulación");
            }

        }

    }
}
