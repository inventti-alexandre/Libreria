using System;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
    public class RemitosVentaDto : IMapFrom<RemitosVenta>
    {
        public Guid Id { get; set; }
        public string LCN { get; set; }
        public string ClienteDenominacion { get; set; }
        public string NumeroComprobante { get; set; }
        public string Concepto { get; set; }
        public DateTime? FechaComprobante { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public DateTime? FechaEmision { get; set; }
        public decimal? ImporteNeto { get; set; }
        public decimal? ImporteIVA { get; set; }
        public string Observaciones { get; set; }
        public DateTime? FechaAlta { get; set; }
    }
}
