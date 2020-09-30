using NeptunoSql.BusinessLayer.Entities;

namespace NeptunoSql.DataLayer.Repositorios.Facades
{
    public interface IRepositorioKardex
    {
        void Guardar(Kardex kardex);
        Kardex GetUltimoKardex(Producto producto);
    }
}
