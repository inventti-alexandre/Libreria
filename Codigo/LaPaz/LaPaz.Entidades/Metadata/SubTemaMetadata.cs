using System;
using System.ComponentModel.DataAnnotations;
using Framework.Comun.Mapping;
using Framework.Comun.Validation;

namespace LaPaz.Entidades
{
    [MetadataType(typeof(SubTemaMetadata))]
    public partial class SubTema
    {
    }

    public class SubTemaMetadata
    {
        [Required(ErrorMessage = "Debe ingresar un Nombre")]
        public string Nombre { get; set; }
        
        [NotEqualToValue(0, typeof(int), ErrorMessage = "Debe seleccionar un Tema")]
        [Required(ErrorMessage = "Debe seleccionar un Tema")]
        public int TemaId { get; set; }

    }
}
