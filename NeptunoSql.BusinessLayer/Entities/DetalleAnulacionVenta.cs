namespace NeptunoSql.BusinessLayer.Entities
{
    public class DetalleAnulacionVenta
    {
        public int DetalleAnulacionId { get; set; }
        public AnulacionVenta AnulacionVenta { get; set; }
        public Producto Producto { get; set; }
        public decimal Cantidad { get; set; }
        public Kardex Kardex { get; set; }

    }
}
