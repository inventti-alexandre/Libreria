using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
    public class ComprasDetalleDto : IMapFrom<ComprasDetalle>
    {
        public System.Guid Id { get; set; }
        public System.Guid CompraId { get; set; }
        public string TituloNombreTitulo { get; set; }
        public Nullable<int> CntPr { get; set; }
        public Nullable<int> CntCn { get; set; }
        public Nullable<decimal> PrecioCompra { get; set; }
        public Nullable<decimal> PrecioVenta { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
     
    }

}