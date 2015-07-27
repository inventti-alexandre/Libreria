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
    
    public partial class ProveedoresCuentasCorriente
    {
        public ProveedoresCuentasCorriente()
        {
            this.OrdenesPagoComprobantes = new HashSet<OrdenesPagoComprobante>();
            this.ProveedoresPagosDetalles = new HashSet<ProveedoresPagosDetalle>();
            this.ProveedoresPagosDetalles1 = new HashSet<ProveedoresPagosDetalle>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid CompraId { get; set; }
        public System.Guid ProveedorId { get; set; }
        public int Cuota { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public Nullable<decimal> Importe { get; set; }
        public Nullable<decimal> Pagado { get; set; }
        public string Observaciones { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
    
        public virtual ICollection<OrdenesPagoComprobante> OrdenesPagoComprobantes { get; set; }
        public virtual Compra Compra { get; set; }
        public virtual Operador OperadorAlta { get; set; }
        public virtual Operador OperadorModificacion { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        public virtual Sucursal SucursalAlta { get; set; }
        public virtual Sucursal SucursalModificacion { get; set; }
        public virtual ICollection<ProveedoresPagosDetalle> ProveedoresPagosDetalles { get; set; }
        public virtual ICollection<ProveedoresPagosDetalle> ProveedoresPagosDetalles1 { get; set; }
    }
}
