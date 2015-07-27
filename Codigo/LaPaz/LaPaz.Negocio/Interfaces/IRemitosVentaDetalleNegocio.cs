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
    public interface IRemitosVentaDetalleNegocio : IDisposable
    {
        List<RemitosVentaDetalleDto> Listado(string sortBy, string sortDirection, string criteria,
                               string remitoVentaId, int pageIndex, int pageSize, out int pageTotal);

        List<RemitosVentaDetalleDto> ListadoByRemitoVentaId(string remitoVentaId);

        RemitosVentaDetalleDto RemitoDetalleById(string remitoDetalleId);
    }
}
