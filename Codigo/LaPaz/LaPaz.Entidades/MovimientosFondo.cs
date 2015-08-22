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
    
    public partial class MovimientosFondo
    {
        public System.Guid Id { get; set; }
        public Nullable<int> SucursalId { get; set; }
        public Nullable<System.DateTime> FechaMovimiento { get; set; }
        public Nullable<int> TipoMovimientoFondoId { get; set; }
        public Nullable<int> TipoComprobanteId { get; set; }
        public string LetraComprobante { get; set; }
        public string NumeroComprobante { get; set; }
        public Nullable<System.DateTime> FechaComprobante { get; set; }
        public string Concepto { get; set; }
        public Nullable<System.Guid> UsCajaOrigenId { get; set; }
        public Nullable<int> CuentaOrigenId { get; set; }
        public Nullable<System.Guid> UsCajaDestinoId { get; set; }
        public Nullable<int> CuentaDestinoId { get; set; }
        public string DescripcionMovimiento { get; set; }
        public Nullable<decimal> ImporteMovimiento { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
    }
}