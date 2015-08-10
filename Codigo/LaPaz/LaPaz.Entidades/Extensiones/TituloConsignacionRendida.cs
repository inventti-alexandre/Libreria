using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPaz.Entidades
{
    public partial class TituloConsignacionRendida
    {
        public bool Saldada
        {
            get { return this.Pagado >= this.Importe; }
        }
    }
}
