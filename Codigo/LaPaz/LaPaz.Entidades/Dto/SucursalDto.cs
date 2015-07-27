using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
    public class SucursalDto : IMapFrom<Sucursal>
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? ProvinciaId { get; set; }
        public int? LocalidadId { get; set; }
        public string ProvinciaNombre { get; set; }
        public string LocalidadNombre { get; set; }
        public string Direccion { get; set; }
        public string TelPart { get; set; }
        public string TelCel { get; set; }
    }
}
