using System;
using System.ComponentModel.DataAnnotations;
using Framework.Comun.Mapping;
using Framework.Comun.Validation;

namespace LaPaz.Entidades
{
    [MetadataType(typeof(AutorMetadata))]
    public partial class Autor
    {
    }

    public class AutorMetadata
    {
        [Required(ErrorMessage = "Debe ingresar un Nombre")]
        public string Nombre { get; set; }
    }
}
