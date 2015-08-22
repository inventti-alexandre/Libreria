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
    
    public partial class Pedido
    {
        public Pedido()
        {
            this.PedidosDetalles = new HashSet<PedidosDetalle>();
        }
    
        public System.Guid Id { get; set; }
        public int SucursalId { get; set; }
        public System.Guid ClienteId { get; set; }
        public System.Guid TituloId { get; set; }
        public int Cantidad { get; set; }
        public Nullable<int> PrioridadesId { get; set; }
        public Nullable<int> EstadoPedido { get; set; }
        public Nullable<System.DateTime> FechaPedido { get; set; }
        public Nullable<System.DateTime> FechaPedidoProveedor { get; set; }
        public Nullable<System.Guid> OperadorId { get; set; }
        public Nullable<System.DateTime> FechaAviso { get; set; }
        public Nullable<System.DateTime> FechaVenta { get; set; }
        public Nullable<System.Guid> VentaDetalleId { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
    
        public virtual ICollection<PedidosDetalle> PedidosDetalles { get; set; }
    }
}