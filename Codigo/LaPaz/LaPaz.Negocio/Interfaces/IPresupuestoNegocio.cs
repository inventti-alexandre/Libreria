using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Entidades.Dto;
using LaPaz.Entidades.Enums;

namespace LaPaz.Negocio.Interfaces
{
    public interface IPresupuestoNegocio
    {
        List<PresupuestoDto> Listado(string sortBy, string sortDirection, string criteria, int pageIndex, int pageSize,
                                     out int pageTotal);

        List<PresupuestoDto> Listado(string sortBy, string sortDirection, string criteria, string lcn, int pageIndex, int pageSize,
                                     out int pageTotal);
    }
}
