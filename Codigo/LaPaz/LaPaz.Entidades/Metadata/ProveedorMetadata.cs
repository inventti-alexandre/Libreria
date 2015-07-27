using System;
using System.ComponentModel.DataAnnotations;
using Framework.Comun.Mapping;
using Framework.Comun.Validation;

namespace LaPaz.Entidades
{
    [MetadataType(typeof(ProveedorMetadata))]
    public partial class Proveedor
    {
    }

    public class ProveedorMetadata
    {
        [RequiredIf("Gto",false,ErrorMessage = "Debe ingresar una cuenta")]
        public int? Cuenta { get; set; }

        [Required(ErrorMessage = "Debe ingresar una denominación")]
        public string Denominacion { get; set; }

        [Required(ErrorMessage = "Debe ingresar una domicilio")]
        public string Domicilio { get; set; }

        public int? TipoDocumento { get; set; }

        public string Cuit { get; set; }

        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "El email no es válido")]
        public string EmailPedido { get; set; }
    }
}
