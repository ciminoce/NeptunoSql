using System.Collections.Generic;
using NeptunoSql.BusinessLayer.Entities;

namespace NeptunoSql.ServiceLayer.Servicios.Facades
{
    public interface IServicioKardex
    {
        List<Kardex> ConsultaKardex(Producto producto);
    }
}
