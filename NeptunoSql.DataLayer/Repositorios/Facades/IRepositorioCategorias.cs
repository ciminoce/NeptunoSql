using System.Collections.Generic;
using NeptunoSql.BusinessLayer.Entities;

namespace NeptunoSql.DataLayer.Repositorios.Facades
{
    public interface IRepositorioCategorias
    {
        Categoria GetCategoriaPorId(int id);
        List<Categoria> GetLista();
        void Guardar(Categoria categoria);
        void Borrar(int id);
        bool Existe(Categoria categoria);
        bool EstaRelacionado(Categoria categoria);

    }
}
