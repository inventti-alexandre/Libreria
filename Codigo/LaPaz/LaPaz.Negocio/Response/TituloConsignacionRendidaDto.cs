using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;

namespace LaPaz.Negocio.Response
{
    public class TituloConsignacionRendidaDto
    {
        public TituloConsignacionRendida TituloConsignacionRendida { get; set; }

        public IList<TituloConsignacionRendidasDetalleDto> TituloConsignacionRendidasDetalle { get; set; }    
    }
}
