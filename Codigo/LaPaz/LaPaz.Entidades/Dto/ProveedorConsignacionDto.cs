using System;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
    public class ProveedorConsignacionDto : IMapFrom<TituloConsignacionRendida>
    {
        public Guid Id { get; set; }
        public string LCN { get; set; }
        public Guid ProveedorId { get; set; }
        public string ProveedorDenominacion { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<decimal> Importe { get; set; }
        public string Observaciones { get; set; }
        public System.DateTime FechaConsignacion { get; set; }
        public Nullable<decimal> Pagado { get; set; }
        public Nullable<System.DateTime> UltimaFechaPago { get; set; }       
    }
}
