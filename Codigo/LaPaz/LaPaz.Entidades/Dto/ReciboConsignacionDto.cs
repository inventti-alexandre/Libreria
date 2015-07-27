using System;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
    public class ReciboConsignacionDto : IMapFrom<ReciboConsignacion>
    {
        public string Codigo { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Descuento { get; set; }
        public decimal Importe { get; set; }
        
    }
}
