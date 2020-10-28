using NeptunoSql.BusinessLayer;
using NeptunoSql.BusinessLayer.Entities;

namespace NeptunoSql.DataLayer.Repositorios.Facades
{
    public interface IRepositorioAnulacionesVentas
    {
        void Guardar(AnulacionVenta anulacionVenta);
    }
}
