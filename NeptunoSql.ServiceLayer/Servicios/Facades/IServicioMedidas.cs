using System.Collections.Generic;
using NeptunoSql.BusinessLayer.Entities;

namespace NeptunoSql.ServiceLayer.Servicios.Facades
{
    public interface IServicioMedidas
    {
        Medida GetMedidaPorId(int id);
        List<Medida> GetLista();
        void Guardar(Medida medida);
        void Borrar(int id);
        bool Existe(Medida medida);
        bool ExisteAbreviatura(Medida medida);
        bool EstaRelacionado(Medida medida);

    }
}
