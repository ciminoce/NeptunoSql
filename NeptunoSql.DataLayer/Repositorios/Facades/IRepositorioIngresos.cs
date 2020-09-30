using NeptunoSql.BusinessLayer.Entities;

namespace NeptunoSql.DataLayer.Repositorios.Facades
{
    public interface IRepositorioIngresos
    {
        void Guardar(Ingreso ingreso);
    }
}
