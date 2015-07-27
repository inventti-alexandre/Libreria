using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPaz.Entidades
{
    [MetadataType(typeof(TicketConsultaMetadata))]
    public partial class TicketConsulta
    {
        public int MotivoId { get; set; }
        public string Mensaje { get; set; }
    }

    public class TicketConsultaMetadata
    {
        [Required(ErrorMessage = "Debe ingresar un mensaje")]
        public string Mensaje { get; set; }
    }
}
