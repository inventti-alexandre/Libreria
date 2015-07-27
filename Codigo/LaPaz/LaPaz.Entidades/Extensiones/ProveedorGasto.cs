using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPaz.Entidades
{
    public partial class ProveedorGasto
    {
        public System.Guid Id { get; set; }
        public string Denominacion { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Contacto { get; set; }
        public string Cuit { get; set; }
        public Nullable<int> TipoDocumento { get; set; }
        public Nullable<int> ProvinciaId { get; set; }
        public Nullable<int> LocalidadId { get; set; }
        public Nullable<bool> Gto { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
    }
}
