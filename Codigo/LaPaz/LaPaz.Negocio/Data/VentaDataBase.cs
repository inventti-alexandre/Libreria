using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Entidades.Enums;

namespace LaPaz.Negocio.Data
{
    public class VentaDataBase
    {
        public bool EsVentaReservada { get; set; }

        public bool EsRendicionConsignacion { get; set; }

        public Guid OperadorId { get; set; }

        public int SucursalId { get; set; }
        
        public int? NumeroComprobante { get; set; }

        public TipoComprobanteEnum TipoComprobanteSeleccionado { get; set; }

        public Guid ClienteId { get; set; }

        public CondicionVentaEnum CondicionVentaSeleccionada { get; set; }

        public decimal? TotalPagar { get; set; }

        public decimal? Senas { get; set; }

        public decimal? CreditosDevolucion { get; set; }

        public Guid CajaActualId { get; set; }

        public TipoMovimientoCajaEnum TipoCajaMovimientoSeleccionado { get; set; }

        public decimal? Anticipo { get; set; }

        public decimal? SubTotal { get; set; }

        public IList<VentaPago> Pagos { get; set; }

        public int? Cuotas { get; set; }

        public float? Montocuota { get; set; }

        public DateTime VencimientoCuota { get; set; }
        
        public string PcAlta { get; set; }
    }
}
