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
   public interface ITemaNegocio: IDisposable
    {
       List<TemaDto> Listado(string sortBy, string sortDirection, string nombre, int pageIndex, int pageSize, out int pageTotal);
    }
}
