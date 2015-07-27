using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Entidades.Enums;

namespace LaPaz.Win.Model
{
    
    public class VentaPago
    {
        public FormaPago TipoPago { get; set; }

        public string Descripcion { get; set; }
    
        [Required(ErrorMessage = "Debe ingresar un importe")]
        public decimal? Importe { get; set; }
    }

    public class VentaPagoTarjeta : VentaPago
    {
        [Required(ErrorMessage = "Debe ingresar una tarjeta")]
        public int? TarjetaId { get; set; }

        public string CuponNumero { get; set; }
    }

    public class VentaPagoCheque : VentaPago
    {
        [Required(ErrorMessage = "Debe ingresar un banco")]
        public int? BancoId { get; set; }

        [Required(ErrorMessage = "Debe ingresar un número")]
        public string Numero { get; set; }
        
        public DateTime? FechaCobro { get; set; }
    }

    public class VentaPagoDeposito : VentaPago
    {
        [Required(ErrorMessage = "Debe ingresar una cuenta")]
        public int? CuentaId { get; set; }

        [Required(ErrorMessage = "Debe ingresar un número")]
        public string Numero { get; set; }

        public DateTime Fecha { get; set; }
    }

    public class VentaPagoTransferencia : VentaPago
    {
        [Required(ErrorMessage = "Debe ingresar una cuenta")]
        public int? CuentaId { get; set; }

        [Required(ErrorMessage = "Debe ingresar un número")]
        public string Numero { get; set; }

        public DateTime Fecha { get; set; }
    }

    public class FormaPagoComparer : IEqualityComparer<VentaPago>
    {
        public bool Equals(VentaPago x, VentaPago y)
        {
            return x.TipoPago == y.TipoPago && x.Descripcion == y.Descripcion;
        }

        public int GetHashCode(VentaPago obj)
        {
            return obj.TipoPago.GetHashCode();
        }
    }
}
