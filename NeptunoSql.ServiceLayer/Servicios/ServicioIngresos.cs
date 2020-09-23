using NeptunoSql.DataLayer;
using NeptunoSql.DataLayer.Repositorios.Facades;

namespace NeptunoSql.ServiceLayer.Servicios
{
    public class ServicioIngresos
    {
        private IRepositorioIngresos _repositorioIngresos;
        private IRepositorioDetalleIngresos _repositorioDetalleIngresos;
        private IRepositorioProductos _repositorioProductos;
        private ConexionBd _conexion;

    }
}
