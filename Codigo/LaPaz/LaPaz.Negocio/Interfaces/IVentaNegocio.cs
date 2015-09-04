using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio.Data;
using LaPaz.Negocio.Response;

namespace LaPaz.Negocio.Interfaces
{
    public interface IVentaNegocio : IDisposable
    {
        List<VentaDto> Listado(string sortBy, string sortDirection, string criteria,
                               string letraComprobante, int? numeroComprobante, TipoComprobanteEnum? tipoComprobante,
                               int pageIndex, int pageSize, out int pageTotal);

        CrearVentaResponse CrearVenta(CrearVentaData venta);
        CrearVentaResponse CrearVentaRendicionConsignacionCliente(RendirConsignacionClienteData ventaData);
        void ReservarFactura(ReservarFacturaData reservarFacturaData);
      //  int SiguienteNumeroFactura(Guid opertadorId);
        int SiguienteNumeroFactura(Guid opertadorId, int sucursalId);
        decimal SenaAFavorCliente(Guid clienteId, int sucursalId);
        decimal CreditosPorDevolucion(Guid clienteId, int sucursalId);
    }
}
