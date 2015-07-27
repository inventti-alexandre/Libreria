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
    
    public partial class Banco
    {
        public Banco()
        {
            this.Proveedores = new HashSet<Proveedor>();
            this.ChequesTerceros = new HashSet<ChequesTercero>();
            this.TarjetasMovimientos = new HashSet<TarjetasMovimiento>();
            this.ProveedoresBancoes = new HashSet<ProveedorBanco>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }
        public Nullable<int> ProvinciaId { get; set; }
        public Nullable<int> LocalidadId { get; set; }
        public string Domicilio { get; set; }
        public string Contacto { get; set; }
        public string TE1 { get; set; }
        public string TE2 { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
    
        public virtual ICollection<Proveedor> Proveedores { get; set; }
        public virtual ICollection<ChequesTercero> ChequesTerceros { get; set; }
        public virtual ICollection<TarjetasMovimiento> TarjetasMovimientos { get; set; }
        public virtual ICollection<ProveedorBanco> ProveedoresBancoes { get; set; }
        public virtual Localidad Localidad { get; set; }
        public virtual Operador OperadorAlta { get; set; }
        public virtual Provincia Provincia { get; set; }
        public virtual Sucursal SucursalAlta { get; set; }
        public virtual Sucursal SucursalModificacion { get; set; }
        public virtual Operador OperadorModificacion { get; set; }
    }
}
