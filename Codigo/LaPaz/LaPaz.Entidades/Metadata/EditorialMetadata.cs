using System.ComponentModel.DataAnnotations;

namespace LaPaz.Entidades
{
    [MetadataType(typeof(EditorialMetadata))]
    public partial class Editorial
    {
    }

    public class EditorialMetadata
    {
        [Required(ErrorMessage = "Debe ingresar un nombre")]
        public string Nombre { get; set; }

        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "El email no es válido")]
        public string Email { get; set; }
        
    }
}
