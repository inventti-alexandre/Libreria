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
    
    public partial class RegistrosExportacione
    {
        public System.Guid Id { get; set; }
        public Nullable<int> SucursalExportacion_Id { get; set; }
        public Nullable<System.DateTime> FechaDesde { get; set; }
        public Nullable<System.DateTime> FechaHasta { get; set; }
        public Nullable<System.DateTime> FechaGeneracion { get; set; }
        public Nullable<int> Sucursal_Id { get; set; }
        public Nullable<System.Guid> Operador_id { get; set; }
        public string PC { get; set; }
    }
}
