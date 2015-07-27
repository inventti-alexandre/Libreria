using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
    public class ClienteDto : IMapFrom<Cliente>
    {
        public Guid Id { get; set; }
        public string Denominacion { get; set; }
        public string TiposDocumentosIdentidadNombre { get; set; }
        public string Cuit { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Mail { get; set; }
        //public string LocalidadeNombre { get; set; }
        //public string ProfesioneNombre { get; set; }
        //public string EspecialidadeNombre { get; set; }
        
    }
}
