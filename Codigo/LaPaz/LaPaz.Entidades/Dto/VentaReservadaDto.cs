using System;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
    public class VentaReservadaDto : IMapFrom<VentaReservada>
    {
        public int NroReserva { get; set; }
        public int SucReserva { get; set; }
        public int NroLote { get; set; }
        public string LCN { get; set; }
        public string Comentario { get; set; }
        public DateTime? FechaAlta { get; set; }
        public int? SucursalAltaId { get; set; }
        public Guid? OperadorAltaId { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? SucursalModificacionId { get; set; }
        public Guid? OperadorModificacionId { get; set; }

    }
}
