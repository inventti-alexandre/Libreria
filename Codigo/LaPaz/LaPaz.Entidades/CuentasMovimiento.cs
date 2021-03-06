//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LaPaz.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class CuentasMovimiento
    {
        public int Id { get; set; }
        public int CuentaId { get; set; }
        public int TipoMovimientoId { get; set; }
        public System.DateTime FechaMovimiento { get; set; }
        public Nullable<int> EstadoMovimientoCuentaId { get; set; }
        public string MotivoEstado { get; set; }
        public Nullable<LaPaz.Entidades.Enums.TipoComprobanteEnum> TipoComprobanteId { get; set; }
        public Nullable<System.Guid> ComprobanteId { get; set; }
        public int MonedaId { get; set; }
        public Nullable<LaPaz.Entidades.Enums.CondicionVentaEnum> CondicionVentaId { get; set; }
        public string NroMovimiento { get; set; }
        public Nullable<System.DateTime> FechaCobro { get; set; }
        public string Descripcion { get; set; }
        public Nullable<decimal> Debito { get; set; }
        public Nullable<decimal> Credito { get; set; }
        public string ResumenConciliacion { get; set; }
        public Nullable<System.DateTime> FechaConciliacion { get; set; }
        public Nullable<int> TipoCarga { get; set; }
        public Nullable<System.Guid> CajaId { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
    
        public virtual Cuenta Cuenta { get; set; }
    }
}
