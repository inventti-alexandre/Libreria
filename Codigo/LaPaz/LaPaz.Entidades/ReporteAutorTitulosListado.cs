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
    
    public partial class ReporteAutorTitulosListado
    {
        public Nullable<System.Guid> Id { get; set; }
        public string Cod { get; set; }
        public string ISBN { get; set; }
        public string CodigoBarra { get; set; }
        public string NombreTitulo { get; set; }
        public Nullable<System.Guid> ProveedorId { get; set; }
        public string Denominacion { get; set; }
        public string Nombre { get; set; }
        public string AutorNombre { get; set; }
        public string EditorialNombre { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<decimal> PrecioVentaTitulo { get; set; }
        public Nullable<decimal> PrecioCompraTitulo { get; set; }
        public Nullable<int> STKPropio { get; set; }
        public Nullable<int> STKConsignado { get; set; }
        public Nullable<int> STKVJOPropio { get; set; }
        public Nullable<int> STKVJOConsignado { get; set; }
        public string OUsuario { get; set; }
        public string OUPUsuario { get; set; }
    }
}
