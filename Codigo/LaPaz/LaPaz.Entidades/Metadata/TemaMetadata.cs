using System;
using System.ComponentModel.DataAnnotations;
using Framework.Comun.Mapping;
using Framework.Comun.Validation;

namespace LaPaz.Entidades
{
    [MetadataType(typeof(TemaMetadata))]
    public partial class Tema
    {
    }

    public class TemaMetadata
    {
        [Required(ErrorMessage = "Debe ingresar un Nombre")]
        public string Nombre { get; set; }
    }
}
