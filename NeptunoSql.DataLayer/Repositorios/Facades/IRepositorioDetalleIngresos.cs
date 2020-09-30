using NeptunoSql.BusinessLayer.Entities;

namespace NeptunoSql.DataLayer.Repositorios.Facades
{
    public interface IRepositorioDetalleIngresos
    {
        void Guardar(DetalleIngreso detalleIngreso);
    }
}
