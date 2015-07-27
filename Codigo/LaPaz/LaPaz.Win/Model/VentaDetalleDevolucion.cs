using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Entidades.Enums;

namespace LaPaz.Win.Model
{
    public class VentaDetalleDevolucion
    {
        public Guid Id { get; set; }

        public Guid TituloId{ get; set; }

        public string NombreTitulo { get; set; }

        public int? CantidadPropia { get; set; }

        public int? CantidadConsignada { get; set; }

        public int? CantidadTotal { get; set; }
        
        public decimal? PrecioUnitario { get; set; }
       
        public decimal? Importe { get; set; }
    }
}
