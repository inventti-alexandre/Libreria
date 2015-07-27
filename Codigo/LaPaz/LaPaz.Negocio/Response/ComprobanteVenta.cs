using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPaz.Negocio.Response
{
    public class ComprobanteVenta
    {
        public string Concepto { get; set; }
        public string LCN { get; set; }
        public decimal? Importe { get; set; }
        public decimal? ImpOcupado { get; set; }
    }
}
