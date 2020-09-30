using System.Security.AccessControl;

namespace NeptunoSql.BusinessLayer.Entities
{
    public class DetalleIngreso
    {
        public int DetalleIngresoId { get; set; }
        public Ingreso Ingreso { get; set; }
        public Producto Producto { get; set; }
        public decimal Cantidad { get; set; }
        public Kardex Kardex { get; set; }

    }
}
