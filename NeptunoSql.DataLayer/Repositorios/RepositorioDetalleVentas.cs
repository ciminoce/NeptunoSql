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
            throw new System.NotImplementedException();
        }
    }
}
