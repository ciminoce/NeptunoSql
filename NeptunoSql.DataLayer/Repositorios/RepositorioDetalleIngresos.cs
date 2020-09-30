using System;
using System.Data.SqlClient;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.DataLayer.Repositorios.Facades;

namespace NeptunoSql.DataLayer.Repositorios
{
    public class RepositorioDetalleIngresos:IRepositorioDetalleIngresos
    {
        private readonly SqlConnection _sqlConnection;
        private readonly SqlTransaction _sqlTransactiontran;

        public RepositorioDetalleIngresos(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public RepositorioDetalleIngresos(SqlConnection cn, SqlTransaction tran)
        {
            _sqlConnection = cn;
            _sqlTransactiontran = tran;
        }

        public void Guardar(DetalleIngreso detalleIngreso)
        {
            try
            {
                string cadenaComando = "INSERT INTO DetalleIngresos (IngresoId, ProductoId, Cantidad, KardexId) " +
                                       "VALUES (@ingreso, @prod, @cant, @kardex)";
                var comando = new SqlCommand(cadenaComando, _sqlConnection, _sqlTransactiontran);
                comando.Parameters.AddWithValue("@ingreso", detalleIngreso.Ingreso.IngresoId);
                comando.Parameters.AddWithValue("@prod", detalleIngreso.Producto.ProductoId);
                comando.Parameters.AddWithValue("@cant", detalleIngreso.Cantidad);
                comando.Parameters.AddWithValue("@kardex", detalleIngreso.Kardex.KardexId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Error al intentar guardar un detalle de ingreso");
            }

        }
    }
}
