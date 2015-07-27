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
    
    public partial class ChequesTercero
    {
        public ChequesTercero()
        {
            this.OrdenPagoCheques = new HashSet<OrdenPagoCheque>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid CajaMovimientoId { get; set; }
        public int BancoId { get; set; }
        public string NroCheque { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.DateTime> FechaCobro { get; set; }
        public Nullable<float> Importe { get; set; }
        public Nullable<int> sTipo { get; set; }
        public Nullable<int> sSuc { get; set; }
        public Nullable<System.Guid> sId { get; set; }
        public Nullable<System.DateTime> sFecha { get; set; }
        public string sComprob { get; set; }
        public Nullable<int> snSec { get; set; }
        public Nullable<int> EstadoChequeId { get; set; }
        public Nullable<System.Guid> OrdenPagoDetalleId { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
    
        public virtual Banco Banco { get; set; }
        public virtual ICollection<OrdenPagoCheque> OrdenPagoCheques { get; set; }
    }
}
