using System;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
    public class ProveedorCtaCteDto : IMapFrom<ProveedoresCuentasCorriente>
    {
        public Guid Id { get; set; }
        public Guid CompraId { get; set; }
        public Guid ProveedorId { get; set; }
        public int Cuota { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public Nullable<decimal> Importe { get; set; }
        public Nullable<decimal> Pagado { get; set; }
        public string Observaciones { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }

        public string CompraNumeroComprobante { get; set; }

    }
}
