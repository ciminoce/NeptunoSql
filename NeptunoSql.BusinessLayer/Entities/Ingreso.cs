using System;
using System.Collections.Generic;

namespace NeptunoSql.BusinessLayer.Entities
{
    public class Ingreso
    {
        public int IngresoId { get; set; }
        public string Referencia { get; set; }
        public string Empleado { get; set; }
        public DateTime Fecha { get; set; }

        public List<DetalleIngreso> DetalleIngresos { get; set; }
    }
}
