using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Entidades;

namespace LaPaz.Win.Model
{
    public class CompraTitulo
    {
        public Guid TituloId { get; set; }

        public string TituloNombre { get; set; }

        public string Cod { get; set; }

        [Required(ErrorMessage = "Debe ingresar un valor")]
        public int? CantidadCompra { get; set; }

        public decimal? PrecioBase { get; set; }

        public decimal? PrecioVenta { get; set; }

        public string CodigoBarra { get; set; }


        [Required(ErrorMessage = "Debe ingresar un importe")]
        public decimal? SubTotal { get; set; }

        internal Titulo MapToTitulo()
        {
            var titulo = new Titulo();

            titulo.Id = this.TituloId;
            titulo.NombreTitulo = this.TituloNombre;
            titulo.PrecioVentaTitulo = this.PrecioVenta;
            titulo.CodigoBarra = this.CodigoBarra;

            return titulo;
        }
    }
}
