using System;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
    public class VentaDto : IMapFrom<Venta>
    {
        public Guid Id { get; set; }
        public string LCN { get; set; }
        public string EstadosVentaAbreviatura { get; set; }
        public string TiposComprobanteAbreviatura { get; set; }
        public string ClienteDenominacion { get; set; }
        public string LetraComprobante { get; set; }
        public int NumeroComprobante { get; set; }
        public string CondicionesVentaDescripcion { get; set; }
        public string Concepto { get; set; }
        public decimal ImporteNeto { get; set; }
        public decimal ImporteIva { get; set; }
        public decimal? ImporteSena { get; set; }
        public decimal? TotalPagado { get; set; }
        public DateTime? FechaUltimoPago { get; set; }
        public DateTime? FechaAlta { get; set; }
    }
}
