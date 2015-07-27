using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Framework.Comun.Extentensions;
using LaPaz.Datos.Helpers;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Negocio.Interfaces;
using Framework.Comun.Utility;

namespace LaPaz.Negocio
{
    public class EditorialNegocio : NegocioBase, IEditorialNegocio
    {
        public EditorialNegocio(ILaPazUow uow)
        {
            Uow = uow;
            
        }

        public List<EditorialDto> Listado(string sortBy, string sortDirection, string nombre, int pageIndex, int pageSize, out int pageTotal)
        {
            var criteros = new PagingCriteria();

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "Nombre";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";
            
            var nombreFormateado = nombre.ToStringSearch();

            Expression<Func<Editorial, bool>> where =
                x => (x.Activo == true) &&
                (string.IsNullOrEmpty(nombreFormateado) || SqlFunctions.PatIndex(nombreFormateado, x.Nombre) > 0);

            var resultados = Uow.Editoriales.Listado(criteros,
                                                    where);

            pageTotal = resultados.PagedMetadata.TotalItemCount;

            return resultados.Entities.Project().To<EditorialDto>().ToList();   
        }

       
    }
}
