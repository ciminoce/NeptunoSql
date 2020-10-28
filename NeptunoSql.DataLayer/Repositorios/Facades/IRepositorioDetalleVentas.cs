using System.Collections.Generic;
using NeptunoSql.BusinessLayer.Entities;

namespace NeptunoSql.DataLayer.Repositorios.Facades
{
    public interface IRepositorioDetalleVentas
    {
        void Guardar(DetalleVenta detalleVenta);
        List<DetalleVenta> GetDetallesPorVenta(int ventaId);
    }
}
