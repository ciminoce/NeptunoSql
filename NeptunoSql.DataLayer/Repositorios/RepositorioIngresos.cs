using System.Data.SqlClient;
using NeptunoSql.DataLayer.Repositorios.Facades;

namespace NeptunoSql.DataLayer.Repositorios
{
    public class RepositorioIngresos:IRepositorioIngresos
    {
        private readonly SqlConnection _sqlConnection;

        public RepositorioIngresos(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

    }
}
