using System.ComponentModel.DataAnnotations;
using Framework.Comun.Validation;

namespace LaPaz.Entidades
{
    [MetadataType(typeof(OperadorMetadata))]
    public partial class Operador
    {
    }

    public class OperadorMetadata
    {
        [Required(ErrorMessage = "Debe ingresar un nombre de usuario")]
        public string Usuario { get; set; }

        [ValidateObject]
        public virtual Personal Personal { get; set; }
    }
}
