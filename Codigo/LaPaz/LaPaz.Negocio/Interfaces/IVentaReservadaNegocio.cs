using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Datos.Helpers;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;

namespace LaPaz.Negocio.Interfaces
{
    public interface IVentaReservadaNegocio
    {
        List<VentaReservadaDto> Listado(string sortBy, string sortDirection, Guid operador, int sucursal, int pageIndex, int pageSize, out int pageTotal);
    }
}
