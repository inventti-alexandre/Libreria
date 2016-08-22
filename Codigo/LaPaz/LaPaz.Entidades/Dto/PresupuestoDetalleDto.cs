using System;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
    public class PresupuestoDetalleDto : IMapFrom<PresupuestosDetalle>
    {
        private decimal? _subTotal;

        public Guid Id { get; set; }
        public Guid PresupuestoId { get; set; }
        public Guid TituloId { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public DateTime? FechaAlta { get; set; }

        public string TituloNombreTitulo { get; set; }
        public decimal? TituloPrecioVentaTitulo { get; set; }
        public string TituloCod { get; set; }

        public decimal? SubTotal 
        {
            get { return this.Cantidad * this.Precio;}

            set { this._subTotal = value; }
        }
        
    }
}
