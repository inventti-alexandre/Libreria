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
   public interface ISubTemaNegocio: IDisposable
    {
       List<SubTemaDto> Listado(string sortBy, string sortDirection, int? temaId, string nombre, int pageIndex, int pageSize, out int pageTotal);
    }
}
