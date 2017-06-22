using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Entidades.Enums;

namespace LaPaz.Negocio.Interfaces
{
    public interface IRemitosVentaNegocio : IDisposable
    {
        List<RemitosVentaDto> Listado(string sortBy, string sortDirection, string criteria,
                               Guid clienteId, int? numeroComprobante,
                               int pageIndex, int pageSize, out int pageTotal);

        List<RemitosVentaDto> GetByClienteId(Guid clienteId, int sucursalId);
        List<RemitosVentaDto> GetById(Guid consignacionId, int sucursalId);

        int SiguienteNroConsignacion(int sucursalId);
    }
}
