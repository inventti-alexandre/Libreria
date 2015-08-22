using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Datos.Interfaces;
using LaPaz.Negocio.Interfaces;

namespace LaPaz.Negocio
{
    public class ProveedoresMontoFavorNegocio : NegocioBase ,IProveedoresMontoFavorNegocio

    {
        public ProveedoresMontoFavorNegocio(ILaPazUow uow)
        {
            Uow = uow;
        }


    }
}
