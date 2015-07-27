using System;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
    public class ProveedorDto : IMapFrom<Proveedor>
    {
        public Guid Id { get; set; }
        public int? Cuenta { get; set; }
        public string Denominacion { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Contacto { get; set; }
        public string Cuit { get; set; }
        public string ProvinciaNombre { get; set; }
        public string LocalidadNombre { get; set; }
        public string CondicionCompraNombre { get; set; }
        public decimal? PorcentajeDescuento { get; set; }
        public string BancoNombre { get; set; }
        public string CBU { get; set; }
        public string EmailPedido { get; set; }
    }
}
