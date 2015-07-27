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
    
    public partial class ProveedoresPagosDetalle
    {
        public System.Guid Id { get; set; }
        public System.Guid ProveedorPagoId { get; set; }
        public System.Guid ProveedorCuentaCorrienteId { get; set; }
        public decimal MontoPagado { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public System.Guid OperadorAltaId { get; set; }
        public int SucursalAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public System.Guid ProveedorConsignacionId { get; set; }
    
        public virtual Operador Operadore { get; set; }
        public virtual Operador Operadore1 { get; set; }
        public virtual ProveedoresCuentasCorriente ProveedoresCuentasCorriente { get; set; }
        public virtual ProveedoresPago ProveedoresPago { get; set; }
        public virtual Sucursal Sucursale { get; set; }
        public virtual Sucursal Sucursale1 { get; set; }
        public virtual ProveedoresCuentasCorriente ProveedoresCuentasCorriente1 { get; set; }
        public virtual TituloConsignacionRendida TitulosConsignacionesRendida { get; set; }
        public virtual TituloConsignacionRendida TitulosConsignacionesRendida1 { get; set; }
    }
}
