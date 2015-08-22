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
    
    public partial class VentaDetalle
    {
        public System.Guid Id { get; set; }
        public System.Guid VentaId { get; set; }
        public System.Guid TituloId { get; set; }
        public Nullable<int> CantidadPropia { get; set; }
        public Nullable<int> CantidadConsig { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<System.Guid> IdNotaDeVenta { get; set; }
        public Nullable<int> CantidadAuditada { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<decimal> PrecioBase { get; set; }
        public Nullable<int> Descuento { get; set; }
    
        public virtual Operador OperadorAlta { get; set; }
        public virtual Operador OperadorModificacion { get; set; }
        public virtual Sucursal SucursalAlta { get; set; }
        public virtual Sucursal SucursalModificacion { get; set; }
        public virtual Titulo Titulo { get; set; }
        public virtual Venta Venta { get; set; }
        public virtual ClienteMontoFavor ClientesMontosFavor { get; set; }
    }
}