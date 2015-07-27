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
    
    public partial class Transporte
    {
        public Transporte()
        {
            this.ProveedoresBultos = new HashSet<ProveedoresBulto>();
        }
    
        public System.Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }
        public Nullable<decimal> ProvinciaId { get; set; }
        public Nullable<decimal> LocalidadId { get; set; }
        public string Direccion { get; set; }
        public string TelPart { get; set; }
        public string TelCel { get; set; }
        public string Fax { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public Nullable<int> codant { get; set; }
    
        public virtual ICollection<ProveedoresBulto> ProveedoresBultos { get; set; }
    }
}
