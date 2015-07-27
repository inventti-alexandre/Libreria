using System;
using System.ComponentModel.DataAnnotations;

namespace LaPaz.Entidades
{
    [MetadataType(typeof(ProveedorGastoMetadata))]
    public partial class ProveedorGasto
    {
    }

    public class ProveedorGastoMetadata
    {
        [Required(ErrorMessage = "Debe ingresar una denominación")]
        public string Denominacion { get; set; }

        [Required(ErrorMessage = "Debe ingresar una domicilio")]
        public string Domicilio { get; set; }

        [Required(ErrorMessage = "Debe ingresar un CUIT")]
        [RegularExpression(@"^(20|23|27|30|33)[0-9]{8}[0-9]$", ErrorMessage = "El número de cuit no es válido")]
        public string Cuit { get; set; }
    }
}
