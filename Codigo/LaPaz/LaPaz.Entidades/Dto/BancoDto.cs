using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
    public class BancoDto : IMapFrom<Banco>
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }
        public int SucursalId { get; set; }
        public int? ProvinciaId { get; set; }
        public int? LocalidadId { get; set; }
        public string ProvinciaNombre { get; set; }
        public string LocalidadNombre { get; set; }
        public string Domicilio { get; set; }
        public string Contacto { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
    }
}
