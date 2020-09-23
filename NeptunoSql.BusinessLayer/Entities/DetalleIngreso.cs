namespace NeptunoSql.BusinessLayer.Entities
{
    public class DetalleIngreso
    {
        public int DetalleIngresoId { get; set; }
        public Ingreso Ingreso { get; set; }
        public Producto Producto { get; set; }
        public double Cantidad { get; set; }
    }
}
