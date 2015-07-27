using System;
using System.ComponentModel.DataAnnotations;
using LaPaz.Entidades;

namespace LaPaz.Negocio.Data
{
    public class VentaTitulo
    {
        public Guid TituloId { get; set; }

        public string TituloNombre { get; set; }

        public string Cod { get; set; }

        public string CodigoBarra { get; set; }

        [Required(ErrorMessage = "Debe ingresar un valor")]
        public int? Cantidad { get; set; }

        public int? CantidadPropia { get; set; }

        public int? CantidadConsignada { get; set; }

        public decimal? PrecioBase { get; set; }

        public Guid? ProveedorId { get; set; }

        public decimal? PrecioVenta { get; set; }

        public int? Descuento { get; set; }

        public int? Recargo { get; set; }

        [Required(ErrorMessage = "Debe ingresar un importe")]
        public decimal? SubTotal { get; set; }

        public Titulo MapToTitulo()
        {
            var titulo = new Titulo();

            titulo.Id = this.TituloId;
            titulo.NombreTitulo = this.TituloNombre;
            titulo.ProveedorId = this.ProveedorId;
            titulo.PrecioVentaTitulo = this.PrecioVenta;

            return titulo;
        }
    }
}
