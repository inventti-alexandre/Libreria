using System;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
    public class TituloDto : IMapFrom<Titulo>
    {
        public Guid Id { get; set; }
        public string Cod { get; set; }
        public string ISBN { get; set; }
        public string NombreTitulo { get; set; }
        public string ProveedorDenominacion { get; set; }
        public Guid? ProveedorId { get; set; }
        public string TemaNombre { get; set; }
        public string AutorNombre { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public decimal? PrecioVentaTitulo { get; set; }
        public decimal? PrecioCompraTitulo { get; set; }
        public int? TituloStockStkPr { get; set; }
        public int? TituloStockStkCn { get; set; }

        public string OperadorModificacionUsuario { get; set; }
    }
}
