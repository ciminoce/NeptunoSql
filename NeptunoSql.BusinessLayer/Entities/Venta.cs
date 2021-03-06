﻿using System;
using System.Collections.Generic;
using NeptunoSql.BusinessLayer.Entities.Enums;

namespace NeptunoSql.BusinessLayer.Entities
{
    public class Venta
    {
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuentos { get; set; }
        public decimal Total { get; set; }
        public EstadoVenta Estado { get; set; }
        public List<DetalleVenta> DetalleVentas { get; set; }=new List<DetalleVenta>();
    }
}
