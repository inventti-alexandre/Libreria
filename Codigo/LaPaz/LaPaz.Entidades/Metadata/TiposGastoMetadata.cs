using System;
using System.ComponentModel.DataAnnotations;
using Framework.Comun.Validation;

namespace LaPaz.Entidades
{
    [MetadataType(typeof(TiposGastoMetadata))]
    public partial class TiposGasto
    {
    }

    public class TiposGastoMetadata
    {
        [Required(ErrorMessage = "Debe ingresar un Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe ingresar una Abreviatura")]
        public string Abreviatura { get; set; }

        [Required(ErrorMessage = "Debe ingresar una Descripcion")]
        public string Descripcion { get; set; }
        
    }
}
