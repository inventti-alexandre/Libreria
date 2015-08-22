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
    
    public partial class FacturasCompra
    {
        public FacturasCompra()
        {
            this.FacturasComprasDetalles = new HashSet<FacturasComprasDetalle>();
        }
    
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> CompraId { get; set; }
        public Nullable<LaPaz.Entidades.Enums.TipoComprobanteEnum> TipoComprobante { get; set; }
        public Nullable<System.Guid> ProveedorId { get; set; }
        public string LCN { get; set; }
        public Nullable<System.Guid> BultoId { get; set; }
        public int PuntoVenta { get; set; }
        public string NumeroComprobante { get; set; }
        public string Concepto { get; set; }
        public System.DateTime FechaComprobante { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public Nullable<decimal> ImporteNeto { get; set; }
        public Nullable<decimal> ImporteIVA { get; set; }
        public string Observaciones { get; set; }
        public Nullable<int> EstadoId { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
    
        public virtual Compra Compra { get; set; }
        public virtual Operador OperadorAlta { get; set; }
        public virtual Operador OperadoreModificacion { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        public virtual Sucursal SucursalAlta { get; set; }
        public virtual Sucursal SucursalModificacion { get; set; }
        public virtual TipoComprobante TiposComprobante { get; set; }
        public virtual ICollection<FacturasComprasDetalle> FacturasComprasDetalles { get; set; }
        public virtual ProveedoresBulto ProveedoresBulto { get; set; }
    }
}