using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Entidades;

namespace LaPaz.Entidades
{
    public partial class ProveedoresCuentasCorriente
    {
        public string ProveedorDenominacion
        {
            get { return this.Proveedor.Denominacion; }
            set { this.ProveedorDenominacion = value; }
        }
    }
}
