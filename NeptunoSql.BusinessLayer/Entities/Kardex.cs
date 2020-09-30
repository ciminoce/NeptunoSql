using System;

namespace NeptunoSql.BusinessLayer.Entities
{
    public class Kardex
    {
        public int KardexId { get; set; }
        public Producto Producto { get; set; }
        public DateTime Fecha { get; set; }
        public string Movimiento { get; set; }
        public decimal Entrada { get; set; }
        public decimal Salida { get; set; }
        public decimal Saldo { get; set; }
    }
}
