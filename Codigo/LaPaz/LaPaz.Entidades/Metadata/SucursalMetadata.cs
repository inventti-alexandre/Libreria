using System;
using System.ComponentModel.DataAnnotations;
using Framework.Comun.Mapping;
using Framework.Comun.Validation;

namespace LaPaz.Entidades
{
    [MetadataType(typeof(SucursalMetadata))]
    public partial class Sucursal
    {
    }

    public class SucursalMetadata
    {
        [Required(ErrorMessage = "Debe ingresar un importe")]
        public decimal MaximoImporteVenta { get; set; }

        [Required(ErrorMessage = "Debe ingresar un porcentaje de descuento")]
        [Range(0, 100, ErrorMessage = "El porcentaje no puede superar el 100%")]
        public decimal MaximoPorcentajeDescuento { get; set; }

        [Required(ErrorMessage = "Debe ingresar un número máximo de líneas por venta")]
        [Range(1, 1000, ErrorMessage = "El número debe ser mayor a 0")]
        public int MaximoNroLineasPorVenta { get; set; }
    }
}
