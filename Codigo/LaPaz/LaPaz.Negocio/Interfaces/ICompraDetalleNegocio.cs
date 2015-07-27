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
    public interface ICompraDetalleNegocio : IDisposable
    {
        List<ComprasDetalleDto> Listado(string sortBy, string sortDirection, Guid? compraId, Guid? tituloId, int sucursal, int pageIndex, int pageSize, out int pageTotal);
    }
}
