using System.Collections.Generic;
using NeptunoSql.BusinessLayer.Entities;

namespace NeptunoSql.ServiceLayer.Servicios.Facades
{
    public interface IServicioCategorias
    {
        Categoria GetCategoriaPorId(int id);
        List<Categoria> GetLista();
        void Guardar(Categoria medida);
        void Borrar(int id);
        bool Existe(Categoria medida);
        bool EstaRelacionado(Categoria medida);

    }
}
