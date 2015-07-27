using System.ComponentModel.DataAnnotations;
using Framework.Comun.Validation;

namespace LaPaz.Entidades
{
    [MetadataType(typeof(LoteFacturaMetadata))]
    public partial class LoteFactura
    {
    }

    public class LoteFacturaMetadata
    {
        [Required(ErrorMessage = "Debe ingresar un valor")]
        public string NroDesde { get; set; }

        [NumericGreaterThanAttribute("NroDesde", AllowEquality = true, ErrorMessage = "No puede ser menor a {0}")]
        [Required(ErrorMessage = "Debe ingresar un valor")]
        public string NroHasta { get; set; }

        [NumericGreaterThan("NroDesde", AllowEquality = true, ErrorMessage = "No puede ser menor a {0:c2}")]
        [NumericLessThan("NroHasta", AllowEquality = true, ErrorMessage = "No puede ser mayor a {0:c2}")]
        [Required(ErrorMessage = "Debe ingresar un valor")]
        public string NroActual { get; set; }

        [Required(ErrorMessage = "Debe ingresar una letra")]
        public string Tipo { get; set; }

     }
}
