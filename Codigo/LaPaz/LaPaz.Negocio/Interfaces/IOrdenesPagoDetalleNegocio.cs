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
    public interface IOrdenesPagoDetalleNegocio : IDisposable
    {
       List<OrdenesPagoDetalleDto> Listado(string sortBy, string sortDirection, DateTime fechaDesde, DateTime fechaHasta, bool? conAnulados, int pageIndex, int pageSize, out int pageTotal);
    }
}
