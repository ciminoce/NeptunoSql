using NeptunoSql.BusinessLayer;
using NeptunoSql.BusinessLayer.Entities;

namespace NeptunoSql.ServiceLayer.Servicios.Facades
{
    public interface IServicioAnulacionVentas
    {
        void Guardar(AnulacionVenta anulacionVenta);
    }
}
