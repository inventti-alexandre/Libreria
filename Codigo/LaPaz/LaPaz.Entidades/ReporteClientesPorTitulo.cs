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
    
    public partial class ReporteClientesPorTitulo
    {
        public System.Guid Id { get; set; }
        public string NombreTitulo { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public string NombreCliente { get; set; }
        public string CUIT { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public string Telefono { get; set; }
        public int NumeroComprobante { get; set; }
    }
}
