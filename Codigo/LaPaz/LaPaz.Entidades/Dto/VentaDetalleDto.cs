using System;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
    public class VentaDetalleDto : IMapFrom<VentaDetalle>
    {
        public System.Guid Id { get; set; }
        public System.Guid VentaId { get; set; }
        public System.Guid TituloId { get; set; }
        public int? CantidadPropia { get; set; }
        public int? CantidadConsig { get; set; }
        public decimal? Precio { get; set; }
        public int? CantidadAuditada { get; set; }
        public DateTime? FechaAlta { get; set; }
        public int? SucursalAltaId { get; set; }
        public decimal? PrecioBase { get; set; }
        public int? Descuento { get; set; }

        public string TituloNombreTitulo { get; set; }
     }
}
