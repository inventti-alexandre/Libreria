using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Entidades.Enums;

namespace LaPaz.Negocio.Data
{
    public class CrearVentaData : VentaDataBase
    {
        public IList<VentaTitulo> Titulos { get; set; }
    }
}
