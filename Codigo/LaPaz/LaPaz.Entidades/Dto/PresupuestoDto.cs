using System;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
    public class PresupuestoDto : IMapFrom<Presupuestos>
    {
        public Guid Id { get; set; }
        public DateTime? Fecha { get; set; }
        public string ClienteDenominacion { get; set; }
        public string Concepto { get; set; }
        public string LCN { get; set; }
        public Guid? ClienteId { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? Total { get; set; }
        public DateTime? FechaAlta { get; set; }
    }
}
