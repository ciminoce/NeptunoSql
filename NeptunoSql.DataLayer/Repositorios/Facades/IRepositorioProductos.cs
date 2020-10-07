using System.Collections.Generic;
using NeptunoSql.BusinessLayer.Entities;

namespace NeptunoSql.DataLayer.Repositorios.Facades
{
    public interface IRepositorioProductos
    {
        Producto GetProductoPorId(int id);
        List<Producto> GetLista();
        void Guardar(Producto producto);
        void Borrar(int id);
        bool Existe(Producto producto);
        bool EstaRelacionado(Producto producto);

        void ActualizarStock(Producto producto, decimal cantidad);
        Producto GetProductoPorCodigoDeBarras(string codigo);
    }
}
