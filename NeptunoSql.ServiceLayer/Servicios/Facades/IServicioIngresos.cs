using System;
using System.Collections.Generic;
using NeptunoSql.BusinessLayer.Entities;

namespace NeptunoSql.ServiceLayer.Servicios.Facades
{
    public interface IServicioIngresos
    {
        void Guardar(Ingreso ingreso);
        List<Ingreso> GetIngresos(DateTime fechaInicial, DateTime fechaFinal);
    }
}
