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
    
    public partial class TiposConsignacione
    {
        public TiposConsignacione()
        {
            this.TitulosConsignaciones = new HashSet<TitulosConsignacion>();
            this.TitulosConsignacionesRendidas = new HashSet<TituloConsignacionRendida>();
            this.TitulosConsignacionesVendidas = new HashSet<TitulosConsignacionesVendida>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> Prioridad { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
    
        public virtual ICollection<TitulosConsignacion> TitulosConsignaciones { get; set; }
        public virtual ICollection<TituloConsignacionRendida> TitulosConsignacionesRendidas { get; set; }
        public virtual ICollection<TitulosConsignacionesVendida> TitulosConsignacionesVendidas { get; set; }
    }
}
