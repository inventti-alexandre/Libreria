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
    public interface IEditorialNegocio
    {
        List<EditorialDto> Listado(string sortBy, string sortDirection, string nombre, int pageIndex, int pageSize, out int pageTotal);
        
    }
}
