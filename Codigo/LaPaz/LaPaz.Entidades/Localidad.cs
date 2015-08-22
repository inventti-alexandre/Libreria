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
    
    public partial class Localidad
    {
        public Localidad()
        {
            this.Clientes = new HashSet<Cliente>();
            this.Proveedores = new HashSet<Proveedor>();
            this.Personals = new HashSet<Personal>();
            this.Bancos = new HashSet<Banco>();
            this.Sucursales = new HashSet<Sucursal>();
            this.BancosPropios = new HashSet<BancoPropio>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CP { get; set; }
        public int ProvinciaId { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
    
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Proveedor> Proveedores { get; set; }
        public virtual ICollection<Personal> Personals { get; set; }
        public virtual ICollection<Banco> Bancos { get; set; }
        public virtual ICollection<Sucursal> Sucursales { get; set; }
        public virtual ICollection<BancoPropio> BancosPropios { get; set; }
    }
}