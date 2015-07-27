using System;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
    public class EditorialDto : IMapFrom<Editorial>
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Email { get; set; }
        public string Contacto { get; set; }
        public string TE1 { get; set; }
        public string TE2 { get; set; }

    }
}
