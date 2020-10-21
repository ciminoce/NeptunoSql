using NeptunoSql.BusinessLayer.Entities;

namespace NeptunoSql.DataLayer.Repositorios.Facades
{
    public interface IRepositorioVentas
    {
        void Guardar(Venta venta);
        decimal GetTotalVenta(int ventaId);
        void FacturarVenta(int ventaId);
    }
}
