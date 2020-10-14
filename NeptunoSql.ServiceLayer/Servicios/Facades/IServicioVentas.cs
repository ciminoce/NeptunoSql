using NeptunoSql.BusinessLayer.Entities;

namespace NeptunoSql.ServiceLayer.Servicios.Facades
{
    public interface IServicioVentas
    {
        void Guardar(Venta venta);
    }
}
