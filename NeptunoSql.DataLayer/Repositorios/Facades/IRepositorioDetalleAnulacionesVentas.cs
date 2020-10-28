using NeptunoSql.BusinessLayer;
using NeptunoSql.BusinessLayer.Entities;

namespace NeptunoSql.DataLayer.Repositorios.Facades
{
    public interface IRepositorioDetalleAnulacionesVentas
    {
        void Guardar(DetalleAnulacionVenta detalleAnulacionVenta);
    }
}
