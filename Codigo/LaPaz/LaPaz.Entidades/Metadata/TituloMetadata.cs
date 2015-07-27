using System;
using System.ComponentModel.DataAnnotations;
using Framework.Comun.Validation;

namespace LaPaz.Entidades
{
    [MetadataType(typeof(TituloMetadata))]
    public partial class Titulo
    {
    }

    public class TituloMetadata
    {
        [Required(ErrorMessage = "Debe ingresar un título")]
        public string NombreTitulo { get; set; }

        [Required(ErrorMessage = "Debe ingresar un código")]
        public string Cod { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar un preveedor")]
        public Guid ProveedorId { get; set; }

        [NumericGreaterThan("PrecioCompraTitulo", AllowEquality = true, ErrorMessage = "El precio de venta no puede ser menor al precio de compra")]
        public decimal? PrecioVentaTitulo { get; set; }
    }
}
