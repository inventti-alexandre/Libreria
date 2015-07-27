using System;
using System.ComponentModel.DataAnnotations;

namespace LaPaz.Entidades
{
    [MetadataType(typeof(ProveedorBancoMetadata))]
    public partial class ProveedorBanco
    {
    }

    public class ProveedorBancoMetadata
    {
        [Required(ErrorMessage = "Debe ingresar un Titular")]
        public string Titular { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un Banco")]
        public int BancoId { get; set; }

        [Required(ErrorMessage = "Debe ingresar un C.B.U.")]
        public string CBU { get; set; }
    }
}
