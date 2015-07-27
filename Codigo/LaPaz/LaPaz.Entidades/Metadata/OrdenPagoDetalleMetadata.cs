using System;
using System.ComponentModel.DataAnnotations;
using Framework.Comun.Validation;
using LaPaz.Entidades.Enums;
namespace LaPaz.Entidades
{
    [MetadataType(typeof(OrdenesPagoDetalleMetadata))]
    public partial class OrdenesPagoDetalle
    {
        public void InvertirImportes()
        {
            this.Efectivo = -this.Efectivo;
            this.Deposito = -this.Deposito;
            this.Transferencia = -this.Transferencia;
            this.DepositoEfectivo = -this.DepositoEfectivo;
            this.Cheques = -this.Cheques;
            this.ImportePagado = -this.ImportePagado;
        }

        public FormaPago? TipoPago
        {
            get
            {
                FormaPago? result = null;
                if (this.Efectivo.HasValue && this.Efectivo > 0)
                {
                    result = FormaPago.Efectivo;
                }

                if (this.Cheques.HasValue && this.Cheques > 0)
                {
                    result = FormaPago.Cheque;
                }

                if (this.DepositoEfectivo.HasValue && this.DepositoEfectivo > 0)
                {
                    result = FormaPago.Deposito;
                }

                if (this.Transferencia.HasValue && this.Transferencia > 0)
                {
                    result = FormaPago.Transferencia;
                }

                return result;
            }

        }

    }

    public class OrdenesPagoDetalleMetadata
    {

       
    }
}
