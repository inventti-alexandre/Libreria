using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
  public class TitulosMovimientoDto : IMapFrom<TitulosMovimiento>
    {
        public int Id { get; set; }
        public System.Guid TituloId { get; set; }
        public Nullable<LaPaz.Entidades.Enums.TipoComprobanteEnum> TipoComprobanteId { get; set; }
        public Nullable<System.Guid> ComprobanteId { get; set; }
        public Nullable<int> SucursalComprobante { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> CntAntPr { get; set; }
        public Nullable<int> CntAntCn { get; set; }
        public Nullable<int> CntAddPr { get; set; }
        public Nullable<int> CntAddCn { get; set; }
        public int CntMinPr { get; set; }
        public Nullable<int> CntMinCn { get; set; }
        public string PC { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }

        public string TiposComprobantesAbreviatura { get; set; }
        public virtual string TitulosNombreTitulo { get; set; }
        public virtual string VentasLCN { get; set; }
 
      
    }

}