using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using LaPaz.Datos.Helpers;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades.Dto;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio.Interfaces;
using System.Linq;
using LaPaz.Entidades;
using AutoMapper;

namespace LaPaz.Negocio
{
    public class SubTemaNegocio : NegocioBase, ISubTemaNegocio
    {
        public SubTemaNegocio(ILaPazUow uow)
        {
            Uow = uow;
        }

        public List<SubTemaDto> Listado(string sortBy, string sortDirection, int? temaId, string nombre, int pageIndex, int pageSize, out int pageTotal)
        {
            var criteros = new PagingCriteria();

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "Nombre";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            Expression<Func<SubTema, bool>> where = x =>(!temaId.HasValue || x.TemaId == temaId) && 
                                                        (string.IsNullOrEmpty(nombre) || x.Nombre.Contains(nombre));

            var resultados = Uow.SubTemas.Listado(criteros,
                                                     where);
            

            pageTotal = resultados.PagedMetadata.TotalItemCount;

            return resultados.Entities.Project().To<SubTemaDto>().ToList();   
        }
    }
}
