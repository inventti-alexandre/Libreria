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
    public interface ITitulosConsignacionesDevueltasNegocio : IDisposable
    {
        List<TitulosConsignacionesDevueltasDto> Listado(string sortBy, string sortDirection, Guid? proveedorId, string nroComprobante, int sucursal,  DateTime fechaInicio, DateTime fechaFin, int pageIndex, int pageSize, out int pageTotal);
    }
}
