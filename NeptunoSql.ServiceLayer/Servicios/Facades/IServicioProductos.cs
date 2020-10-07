using System.Collections.Generic;
using NeptunoSql.BusinessLayer.Entities;

namespace NeptunoSql.ServiceLayer.Servicios.Facades
{
    public interface IServicioProductos
    {
        Producto GetProductoPorId(int id);
        List<Producto> GetLista();
        void Guardar(Producto producto);
        void Borrar(int id);
        bool Existe(Producto producto);
        bool EstaRelacionado(Producto producto);

        Producto GetProductoPorCodigoDeBarras(string codigo);
    }
}
