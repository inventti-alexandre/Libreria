using System;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
    public class RemitosVentaDetalleDto : IMapFrom<RemitosVentaDetalle>
    {
        private decimal? _subTotal;

        public Guid Id { get; set; }
        public Guid RemitoVentaId { get; set; }
        public Guid TituloId { get; set; }
        public int? CntPr { get; set; }
        public int? CntCn { get; set; }
        public decimal? PrecioCompra { get; set; }
        public decimal? PrecioVenta { get; set; }
        public decimal? PrecioBase { get; set; }
        public DateTime? FechaAlta { get; set; }
        public int? Descuento { get; set; }
        public int? CntVendida { get; set; }
        public int? CntDevuelta { get; set; }
        public int? CntARendir { get; set; }
        public int? Recargo { get; set; }

        public string TituloNombreTitulo { get; set; }
        public decimal? TituloPrecioVentaTitulo { get; set; }
        public string TituloCod { get; set; }

        public int? Cantidad
        {
            //get { return (CntPr ?? 0 + CntCn ?? 0); }
            get { return (CntPr + CntCn); }
        }

        //public decimal? SubTotal { 
        //    get { return this.CntVendida*this.PrecioVenta; }

        //    set { this._subTotal = value; }
        //}

        public decimal? SubTotal { get; set; }
    //{
    //        get { return this.CntVendida * this.PrecioVenta;}

    //        set { this._subTotal = value; }
    //    }}
        
    }
}
