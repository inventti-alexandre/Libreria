using System.ComponentModel.DataAnnotations;

namespace LaPaz.Entidades
{
    [MetadataType(typeof(BancoMetadata))]
    public partial class Banco
    {
    }

    public class BancoMetadata
    {
        [Required(ErrorMessage = "Debe ingresar un nombre")]
        public string Nombre { get; set; }
    }
}
