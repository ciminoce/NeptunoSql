using NeptunoSql.BusinessLayer.Entities;

namespace NeptunoSql.ServiceLayer.Servicios.Facades
{
    public interface IServicioIngresos
    {
        void Guardar(Ingreso ingreso);
    }
}
