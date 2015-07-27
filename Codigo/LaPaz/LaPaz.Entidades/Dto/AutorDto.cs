using System;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
    public class AutorDto : IMapFrom<Autor>
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }
        public string Descripcion { get; set; }
        public int? Prioridad { get; set; }

    }
}
