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
    
    public partial class LiquidacionPersonal
    {
        public System.Guid Id { get; set; }
        public string LiquidacionMesAnio { get; set; }
        public Nullable<byte> TipoLiquidacion { get; set; }
        public float Importe { get; set; }
        public System.DateTime Fecha { get; set; }
        public Nullable<float> ImportePagado { get; set; }
        public Nullable<System.Guid> LiquidacionId { get; set; }
        public System.Guid PersonalId { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public System.Guid OperadorAltaId { get; set; }
        public string FechaModificacion { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
    
        public virtual Liquidacione Liquidacione { get; set; }
        public virtual Personal Personal { get; set; }
    }
}
