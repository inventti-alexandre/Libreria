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
    
    public partial class TempLibroIva
    {
        public decimal Iva_Id { get; set; }
        public Nullable<byte> TipoLibro { get; set; }
        public Nullable<byte> CompSuc { get; set; }
        public string CompId { get; set; }
        public string LCN { get; set; }
        public Nullable<byte> nComp { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.DateTime> FConta { get; set; }
        public string Cpto { get; set; }
        public string Cuit { get; set; }
        public Nullable<float> INetoGrab { get; set; }
        public Nullable<float> IExento { get; set; }
        public Nullable<float> IvaTasa1 { get; set; }
        public Nullable<float> IvaTasa2 { get; set; }
        public Nullable<float> IvaTasa3 { get; set; }
        public Nullable<float> ITotal { get; set; }
        public Nullable<byte> lCerrado { get; set; }
    }
}
