using System;
using Framework.Comun.Mapping;

namespace LaPaz.Entidades.Dto
{
    public class CuentaDto : IMapFrom<Cuenta>
    {
        public int Id { get; set; }
        public int TipoCuentaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> BancoPropioId { get; set; }
        public Nullable<System.Guid> OperadorId { get; set; }
        public string Titular { get; set; }
        public System.DateTime FechaApertura { get; set; }
        public Nullable<System.DateTime> FechaCierre { get; set; }
        public Nullable<decimal> Debitos { get; set; }
        public Nullable<decimal> Creditos { get; set; }
        public Nullable<decimal> DebitosConciliado { get; set; }
        public Nullable<decimal> CreditosConciliado { get; set; }
        public bool Activo { get; set; }

        public string OperadorUsuario { get; set; }
        public string TiposCuentaNombre { get; set; }
        public string BancosPropioNombre { get; set; }

    }
}
