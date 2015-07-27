using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPaz.Negocio.Helpers
{
    public class IvaHelper
    {
        public static decimal CalcularIva(decimal importe)
        {
            return importe * 0.21m;
        }
    }
}
