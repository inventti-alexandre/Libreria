using System;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
    public class ProveedorBancoDto : IMapFrom<ProveedorBanco>
    {
        public Guid Id { get; set; }
        public string BancoNombre { get; set; }
        public string CtaCte { get; set; }
        public string CajaAhorro { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Titular { get; set; }
        public string CBU { get; set; }
    }
}
