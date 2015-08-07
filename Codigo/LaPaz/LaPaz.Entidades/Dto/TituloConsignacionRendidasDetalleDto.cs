using System;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
    public class TituloConsignacionRendidasDetalleDto : IHaveCustomMappings
    {
        public System.Guid Id { get; set; }
        public System.Guid TituloConsignacionRendidaId { get; set; }
        public string TituloNombre { get; set; }
        public string TituloAutor { get; set; }
        public string TituloCodigo { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal Importe { get; set; }

        public void CreateMappings(AutoMapper.IConfiguration configuration)
        {
            configuration.CreateMap<TituloConsignacionRendidasDetalle, TituloConsignacionRendidasDetalleDto>()
                .ForMember(d => d.TituloNombre, opt => { opt.MapFrom(s => s.Titulo.NombreTitulo); })
                .ForMember(d => d.TituloCodigo, opt => { opt.MapFrom(s => s.Titulo.Cod); })
                .ForMember(d => d.TituloAutor, opt => { opt.MapFrom(s => s.Titulo.Autor.Nombre); });
        }
    }
}
