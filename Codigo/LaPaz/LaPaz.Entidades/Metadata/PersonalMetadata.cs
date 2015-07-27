using System.ComponentModel.DataAnnotations;

namespace LaPaz.Entidades
{
    [MetadataType(typeof(PersonalMetadata))]
    public partial class Personal
    {
    }

    public class PersonalMetadata
    {
        [Required(ErrorMessage = "Debe ingresar una nombre y apellido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe ingresar una domicilio")]
        public string Domicilio { get; set; }

        [Required(ErrorMessage = "Debe ingresar un CUIT/DNI")]
        [MaxLength(11, ErrorMessage = "El número de cuit/DNI no es válido")]
        [RegularExpression("^[0-9]{8,11}?$", ErrorMessage = "El número de cuit/DNI no es válido")]
        public string Cuit { get; set; }

        [MaxLength(15, ErrorMessage = "Debe tener como máximo 15 elementos")]
        public string Celular { get; set; }
    }
}
