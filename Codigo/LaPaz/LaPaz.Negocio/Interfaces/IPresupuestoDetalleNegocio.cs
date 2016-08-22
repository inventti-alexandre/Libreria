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
    public interface IPresupuestoDetalleNegocio : IDisposable
    {
        List<PresupuestoDetalleDto> Listado(string sortBy, string sortDirection, string criteria,
                               string remitoVentaId, int pageIndex, int pageSize, out int pageTotal);

        List<PresupuestoDetalleDto> ListadoByPresupuestoId(string presupuestoId);

        PresupuestoDetalleDto PresupuestoDetalleById(string presupuestoDetalleId);
    }
}
