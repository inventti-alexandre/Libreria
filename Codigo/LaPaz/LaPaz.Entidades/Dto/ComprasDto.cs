using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
  public class ComprasDto : IMapFrom<Compra>
    {
        public System.Guid Id { get; set; }
        public string LCN { get; set; }
        public System.Guid ProveedorId { get; set; }
        public string LetraComprobante { get; set; }
        public string NumeroComprobante { get; set; }
        public System.DateTime FechaComprobante { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public string Concepto { get; set; }
        public Nullable<decimal> ImporteNeto { get; set; }
        public Nullable<decimal> ImporteIVA { get; set; }
        public string Observaciones { get; set; }
        public int EstadoCompraId { get; set; }
        public LaPaz.Entidades.Enums.TipoComprobanteEnum TipoComprobanteId { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public string ProveedorDenominacion { get; set; }
      
    }

}