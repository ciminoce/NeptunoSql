using System.Data.SqlClient;
using NeptunoSql.DataLayer.Repositorios.Facades;

namespace NeptunoSql.DataLayer.Repositorios
{
    public class RepositorioDetalleIngresos:IRepositorioDetalleIngresos
    {
        private readonly SqlConnection _sqlConnection;

        public RepositorioDetalleIngresos(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
    }
}
