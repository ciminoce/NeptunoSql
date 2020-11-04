using System;
using System.Collections.Generic;
using NeptunoSql.BusinessLayer.Entities;

namespace NeptunoSql.DataLayer.Repositorios.Facades
{
    public interface IRepositorioIngresos
    {
        void Guardar(Ingreso ingreso);
        List<Ingreso> GetIngresos(DateTime fechaInicial, DateTime fechaFinal);
    }
}
