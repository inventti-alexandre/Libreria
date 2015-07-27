using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Entidades;
using LaPaz.Entidades.Enums;
using LaPaz.Win.Extensiones;

namespace LaPaz.Win.Model
{

    public class DetalleFormaPago
    {
        public DetalleFormaPago()
        {
            //Siempre se puede eliminar un pago recien agregado.
            this.PuedeEliminar = true;
        }

        public System.Guid Id { get; set; }

        public FormaPago TipoPago { get; set; }

        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Debe ingresar un importe")]
        public decimal? Importe { get; set; }

        [Required(ErrorMessage = "Debe ingresar una Fecha")]
        public DateTime? Fecha { get; set; }

        public bool IsDeleted { get; set; }

        public bool PuedeEliminar { get; set; }

        public bool EsFijo { get; set; }
    }

    public class PagoEfectivo : DetalleFormaPago
    {
        public bool CajaAnterior { get; set; }
    }

    public class PagoCheque : DetalleFormaPago
    {
        [Required(ErrorMessage = "Debe ingresar un banco")]
        public int? BancoId { get; set; }

        [Required(ErrorMessage = "Debe ingresar un número")]
        public string Numero { get; set; }
    }

    public class PagoDeposito : DetalleFormaPago
    {
        [Required(ErrorMessage = "Debe ingresar una cuenta")]
        public int? DepositoCuentaId { get; set; }

        [Required(ErrorMessage = "Debe ingresar un número")]
        public string Numero { get; set; }
    }

    public class PagoTransferencia : DetalleFormaPago
    {
        [Required(ErrorMessage = "Debe ingresar una Cuenta")]
        public int? CuentaId { get; set; }

        [Required(ErrorMessage = "Debe ingresar un número")]
        public string Numero { get; set; }
    }

    public class FormaPagoDetalleComparer : IEqualityComparer<DetalleFormaPago>
    {
        public bool Equals(DetalleFormaPago x, DetalleFormaPago y)
        {
            return x.TipoPago == y.TipoPago && x.Descripcion == y.Descripcion;
        }

        public int GetHashCode(DetalleFormaPago obj)
        {
            return obj.TipoPago.GetHashCode();
        }
    }
}
