using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPaz.Entidades.Enums
{
    public enum TipoComprobanteEnum
    {
        FacXVtaCnProv = 1,
        FacCpraCtaCte,
        Recibo,
        NotaCrédito,
        RemitoTransferencia,
        FacVtaCtado,
        FacVtaCtaCte,
        RemitosConsignacProveedor,
        Remitos,
        OrdenPago,
        RemitosConsignacCliente,
        RemitoDevolucConsigCliente,
        FacCpraConsigCliente,
        Pedidos,
        RemitosBajaStockPropio,
        RemitosAnulacConsigVend,
        RemTransfPropioConsig,
        FactVtaCnClienteCtdo,
        IngresosProducción,
        RemitoTransfConsigPropio,
        SeñaCliente,
        FactVtaCnClienteCc,
        LibroIva,
        RecibosNovSueldos = 25,
        ModificarStock,
        Caja,
        RemitosAuditoria,
        FacCpraContado,
        Tickets,
        RemMovFondos = 32,
        Presupuesto = 34,
        AdmRemitosTrnAceptar = 35,
        AdmRemitosTrnRechazar = 36,
        SeñaProveedor,
        FacturaAnulada,
        PagoProveedores
    }
}
