using System;
using System.Collections.Generic;

namespace NeptunoSql.BusinessLayer.Entities
{
    public class AnulacionVenta
    {
        public int AnulacionId { get; set; }
        public string Referencia { get; set; }
        public DateTime Fecha { get; set; }
        public Venta Venta { get; set; }
        public List<DetalleAnulacionVenta> DetalleAnulacion { get; set; }

    }
}
