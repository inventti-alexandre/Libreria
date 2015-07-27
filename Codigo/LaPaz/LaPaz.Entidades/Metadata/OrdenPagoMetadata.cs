using System;
using System.ComponentModel.DataAnnotations;
using Framework.Comun.Validation;

namespace LaPaz.Entidades
{
    [MetadataType(typeof(OrdenesPagoMetadata))]
    public partial class OrdenesPago
    {
    }

    public class OrdenesPagoMetadata
    {
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar una sucursal")]
        public int SucursalId { get; set; }

        [NotEqualToValue("0", typeof(String), ErrorMessage = "Debe ingresar una Letra de Comprobante")]
        public string LetraComprobante { get; set; }

        [Required(ErrorMessage = "Debe ingresar un nro. de Comprobante")]
        public string NumeroComprobante { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un Tipo de Gasto")]
        public int? TipoGastoId { get; set; }

        [NotEqualToValue("00000000-0000-0000-0000-000000000000", typeof(Guid), ErrorMessage = "Debe seleccionar un Proveedor")]
        public System.Guid ProveedorId { get; set; }

        [Required(ErrorMessage = "Debe ingresar un Concepto")]
        public string Concepto { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una Sucursal de Gasto")]
        public int? SucursalGastoId { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un Centro de Costo")]
        public int? CentroCostoId { get; set; }

        [NotEqualToValue(0, typeof(int), ErrorMessage = "Debe seleccionar un Tipo de Comprobante")]
        public LaPaz.Entidades.Enums.TipoComprobanteEnum TipoComprobanteId { get; set; }

        [NotEqualToValue(0, typeof(Decimal), ErrorMessage = "Debe ingresar un Sub total")]
        public decimal SubTotal { get; set; }

        [NotEqualToValue(0, typeof(Decimal), ErrorMessage = "Debe ingresar un Importe")]
        public decimal Importe { get; set; }

        [Required(ErrorMessage = "Debe ingresar un Importe Pagado")]
        public decimal? ImportePagado { get; set; }
    }
}
