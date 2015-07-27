using System;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
    public class TemaDto : IMapFrom<Tema>
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }
        public string Descripcion { get; set; }
        public int? Prioridad { get; set; }
        public string SubTemasNombre { get; set; }
    }
}
