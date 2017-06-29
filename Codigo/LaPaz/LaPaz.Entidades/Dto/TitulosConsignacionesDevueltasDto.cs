using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
  public class TitulosConsignacionesDevueltasDto : IMapFrom<TitulosConsignacionesDevuelta>
    {
        public System.Guid Id { get; set; }
        public System.Guid ProveedorId { get; set; }
        public string LCN { get; set; }
        public string Observaciones { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public System.Guid OperadorAltaId { get; set; }
        public int SucursalAltaId { get; set; }

        public string ProveedorDenominacion { get; set; }
        public string ProveedoreDenominacion { get; set; }
 
      
    }

}