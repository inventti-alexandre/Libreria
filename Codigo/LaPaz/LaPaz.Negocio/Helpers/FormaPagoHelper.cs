using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Entidades;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio.Data;

namespace LaPaz.Negocio.Helpers
{
    public class FormaPagoHelper
    {
        public static string FormaPagoComprobante(IList<VentaPago> pagos)
        {
            string formaDePago = string.Empty;

            foreach (var formaPago in pagos)
            {
                switch (formaPago.TipoPago)
                {
                    case FormaPago.Efectivo:
                        formaDePago += "Efectivo $" + formaPago.Importe + ". ";
                        break;
                    case FormaPago.Tarjeta:
                        formaDePago += "Tarjeta " + formaPago.Descripcion + " $" + formaPago.Importe + ". ";
                        break;
                    case FormaPago.Cheque:
                        formaDePago += "Cheque " + formaPago.Descripcion + " $" + formaPago.Importe + ". ";
                        break;
                    case FormaPago.Deposito:
                        formaDePago += "Deposito " + formaPago.Descripcion + " $" + formaPago.Importe + ". ";
                        break;
                    //case FormaPago.CuentaCorriente:
                    //    formaDePago = "Anticipo $" + ventaData.Anticipo + ". " + reponse.FacturaInfo.Descripcion;
                    //    break;
                }
            }

            return formaDePago;
        }
    }
}
