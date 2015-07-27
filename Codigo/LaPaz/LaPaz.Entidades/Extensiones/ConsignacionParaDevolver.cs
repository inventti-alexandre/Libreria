using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPaz.Entidades
{
    public partial class ConsignacionesParaDevolver
    {
        private int? _cantidadADevolver;
        public int CantidadADevolver
        {
            get { return _cantidadADevolver ?? Convert.ToInt32(CantidadSinRendir); }
            set { _cantidadADevolver = value; }
        }
    }
}
