using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPaz.Negocio.Response
{
    public class CrearVentaResponse
    {
        public CrearVentaResponse()
        {
            Comprobantes = new List<ComprobanteVenta>();
            FacturaInfo = new FacturaInfo();
        }

        public IList<ComprobanteVenta> Comprobantes { get; set; }

        public FacturaInfo FacturaInfo { get; set; }

        public Guid VentaId { get; set; }
    }
}
