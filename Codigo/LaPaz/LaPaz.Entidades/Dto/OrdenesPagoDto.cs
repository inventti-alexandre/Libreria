using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
    public class OrdenesPagoDto: IMapFrom<OrdenesPago>
    {
        public System.Guid Id { get; set; }
        public string SucursalNombre { get; set; }
        public System.DateTime Fecha { get; set; }
        public string LCN { get; set; }
        public string LetraComprobante { get; set; }
        public string NumeroComprobante { get; set; }
        public string TipoGastoNombre { get; set; }
        public string ProveedorDenominacion { get; set; }
        public string Concepto { get; set; }
        public string SucursalGastoNombre { get; set; }
        public string CentroCostoNombre { get; set; }
        public LaPaz.Entidades.Enums.TipoComprobanteEnum TipoComprobanteId { get; set; }
        public decimal SubTotal { get; set; }
        public Nullable<decimal> Recargo { get; set; }
        public decimal Importe { get; set; }
        public Nullable<decimal> ImportePagado { get; set; }
        public Nullable<decimal> ImporteDebe
        {
            get { return (Importe - (ImportePagado ?? 0)); }
        }
        public ICollection<OrdenesPagoDetalle> OrdenesPagoDetalles { get; set; }
    }
}
