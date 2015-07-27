using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPaz.Entidades.Enums
{
    public enum TipoMovimientoCajaEnum
    {
        FacturaVentaContado = 1,
        FacturaVentaCtaCte = 2,
        Cobranzas = 3,
        SeñaCliente = 4,
        TransferenciasCajasIngreso = 5,
        VacanteIngreso = 6,
        FacturaVentaConsigCliente = 7,
        Retención = 8,
        PagoProveedores = 9,
        TransferenciasCajasEgreso = 10,
        AnulacionReciboCte = 11,
        NotaCredito = 12,
        AnulaciónOrdenPago = 13,
        VacanteEgreso = 14,
        NovedadesSueldos = 15,
        AnulaciónSeña = 16,
        DepositoEfectivo = 17,
        ExtracciónEfectivo = 18,
        CobroChequesTros = 19,
        SobranteCaja = 20,
        PagoGastos = 21,
        FaltanteCaja = 22,
        CobroVales = 23,
        OtrosIngresos = 24,
        VueltoGastos = 25,
        AnulaciónFacCtaCte = 26,
        AnulaciónFacContado = 27,
        CreditoFavorPorNc = 28,
        FacConsignacionContado = 29,
        FacConsignacionCtaCte = 30,
        DepositoConCajaAnterior = 31,
        SeñaProveedor = 32,//1031,//32,
        SeñaProveedorCajaAnterior = 33,//2034,//33,
        PagoProveedorCajaAnterior = 34,//2035,//34,
        AnulacionSeniaProveedor = 35

    }
}
