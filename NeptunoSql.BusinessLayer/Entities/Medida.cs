using System;

namespace NeptunoSql.BusinessLayer.Entities
{
    public class Medida:ICloneable
    {
        public int MedidaId { get; set; }
        public string Denominacion { get; set; }
        public string Abreviatura { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
