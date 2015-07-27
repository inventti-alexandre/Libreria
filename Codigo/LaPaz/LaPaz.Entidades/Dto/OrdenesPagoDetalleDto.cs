using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
    public class OrdenesPagoDetalleDto : IMapFrom<OrdenesPagoDetalle>
    {
        public System.Guid Id { get; set; }
        public System.Guid OrdenPagoId { get; set; }
        public string OrdenesPagoConcepto { get; set; }
        public int? NumeroLinea { get; set; }
        public DateTime? FechaPago { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? ImportePagado { get; set; }
        public decimal? Efectivo { get; set; }
        public decimal? Cheques { get; set; }
        public decimal? Deposito { get; set; }
        public decimal? DepositoEfectivo { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public decimal? Transferencia { get; set; }
        public Guid? CajaId { get; set; }
        public DateTime? FechaAlta { get; set; }
        public Guid? OperadorAltaId { get; set; }

    }
}
