using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Comun.Validation;
using LaPaz.Entidades;

namespace LaPaz.Win.Model
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

        //[NumericGreaterThanAttribute("PrecioBase",AllowEquality = true,ErrorMessage = "El nuevo precio de venta no puede ser menor al actual {0:c2}")]
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
