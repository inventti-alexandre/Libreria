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
    
    public partial class RemitosCompraDetalle
    {
        public System.Guid Id { get; set; }
        public System.Guid RemitoCompraId { get; set; }
        public System.Guid TituloId { get; set; }
        public Nullable<int> CntPr { get; set; }
        public Nullable<int> CntCn { get; set; }
        public Nullable<decimal> PrecioCompra { get; set; }
        public Nullable<decimal> PrecioVenta { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
    
        public virtual RemitosCompra RemitosCompra { get; set; }
        public virtual Titulo Titulo { get; set; }
        public virtual Operador Operadore { get; set; }
        public virtual Operador Operadore1 { get; set; }
        public virtual Sucursal Sucursale { get; set; }
        public virtual Sucursal Sucursale1 { get; set; }
    }
}