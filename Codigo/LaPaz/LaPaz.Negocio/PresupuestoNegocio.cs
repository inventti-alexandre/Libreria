using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Framework.Comun.Extentensions;
using LaPaz.Datos.Helpers;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades.Dto;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio.Interfaces;
using System.Linq;
using LaPaz.Entidades;

namespace LaPaz.Negocio
{
    public class PresupuestoNegocio : NegocioBase, IPresupuestoNegocio
    {
        public PresupuestoNegocio(ILaPazUow uow)
        {
            Uow = uow;
        }

        public List<PresupuestoDto> Listado(string sortBy, string sortDirection, string criteria, int pageIndex, int pageSize, out int pageTotal)
        {

            var criteros = new PagingCriteria();

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "FechaAlta";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            var cuitFormateado = criteria.PadLeft(11, '0');
            var denominacionFormateado = criteria.ToStringSearch();

            Expression<Func<Presupuestos, bool>> where =
                x => ((string.IsNullOrEmpty(criteria) || SqlFunctions.PatIndex(denominacionFormateado, x.Cliente.Denominacion) > 0) || x.Cliente.Denominacion.Contains(denominacionFormateado) ||
                 x.Concepto.Contains(criteria) || x.Cliente.Cuit.Contains(cuitFormateado));

            var resultados = Uow.Presupuesto.Listado(criteros,
                                                     where,
                                                     x => x.Cliente);

            pageTotal = resultados.PagedMetadata.TotalItemCount;

            return resultados.Entities.Project().To<PresupuestoDto>().ToList();
        }

        public List<PresupuestoDto> Listado(string sortBy, string sortDirection, string criteria, string lcn, int pageIndex, int pageSize, out int pageTotal)
        {

            var criteros = new PagingCriteria();

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "FechaAlta";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            var cuitFormateado = criteria.PadLeft(11, '0');
            var denominacionFormateado = criteria.ToStringSearch();
            var lcnFormateado = lcn.ToStringSearch();

            Expression<Func<Presupuestos, bool>> where =
                x => (
                        (string.IsNullOrEmpty(criteria) || SqlFunctions.PatIndex(denominacionFormateado, x.Cliente.Denominacion) > 0) 
                        || x.Cliente.Denominacion.Contains(denominacionFormateado)
                        || x.Concepto.Contains(criteria) || x.Cliente.Cuit.Contains(cuitFormateado))
                        &&
                        (x.LCN.Contains(lcn) || SqlFunctions.PatIndex(lcnFormateado, x.LCN) > 0)
                        ;

            var resultados = Uow.Presupuesto.Listado(criteros,
                                                     where,
                                                     x => x.Cliente);

            pageTotal = resultados.PagedMetadata.TotalItemCount;

            return resultados.Entities.Project().To<PresupuestoDto>().ToList();
        }
    }
}
