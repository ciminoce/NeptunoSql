using NeptunoSql.BusinessLayer.Entities;

namespace NeptunoSql.DataLayer.Repositorios.Facades
{
    public interface IRepositorioDetalleVentas
    {
        void Guardar(DetalleVenta detalleVenta);
    }
}
