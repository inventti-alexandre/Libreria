using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using LaPaz.Datos.Helpers;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio.Interfaces;

namespace LaPaz.Negocio
{
    public class TitulosConsignacionesDevueltasNegocio : NegocioBase , ITitulosConsignacionesDevueltasNegocio
    {
        public TitulosConsignacionesDevueltasNegocio(ILaPazUow uow)
        {
            Uow = uow;
        }

      
        public List<TitulosConsignacionesDevueltasDto> Listado(string sortBy, string sortDirection, Guid? proveedorId, string nroComprobante, int sucursal, DateTime fechaInicio, DateTime fechaFin, int pageIndex, int pageSize, out int pageTotal)
        {
            var criteros = new PagingCriteria();

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "FechaAlta";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            Expression<Func<TitulosConsignacionesDevuelta, bool>> where = x => (string.IsNullOrEmpty(nroComprobante) || x.LCN.Contains(nroComprobante)) &&
                                                           (!proveedorId.HasValue || x.ProveedorId == proveedorId) &&
                                                           (x.SucursalAltaId == sucursal) &&
                                                           (x.FechaAlta > fechaInicio) && (x.FechaAlta < fechaFin)
                                                           ;

            var resultados = Uow.TitulosConsignacionesDevueltas.Listado(criteros,
                                                where,
                                                x => x.Proveedore);

            pageTotal = resultados.PagedMetadata.TotalItemCount;
            return resultados.Entities.Project().To<TitulosConsignacionesDevueltasDto>().ToList();
        }
    }
}
