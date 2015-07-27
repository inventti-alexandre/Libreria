using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPaz.Negocio.Helpers
{
    public class LcnHelper
    {
        public const string LetraConsumidorFinal = "C";

        public static string ObtenerLcn(int nroComprobante, int nroSucursal = 1, string letraCompraobante = "C")
        {
            return ObtenerLcn(nroComprobante.ToString(),nroSucursal,letraCompraobante);
        }

        public static string ObtenerLcn(string nroComprobante, int nroSucursal = 1, string letraCompraobante = "C")
        {
            var lcnNro = nroComprobante.ToString().PadLeft(8, '0');
            var lcnSuc = nroSucursal.ToString().PadLeft(4, '0');
            var lcn = letraCompraobante + lcnSuc + lcnNro;

            return lcn;
        }
    }
}
