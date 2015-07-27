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
    public class CompraDetalleNegocio : NegocioBase , ICompraDetalleNegocio
    {
        public CompraDetalleNegocio (ILaPazUow uow)
        {
            Uow = uow;
        }

       
        public List<ComprasDetalleDto> Listado(string sortBy, string sortDirection, Guid? compraId, Guid? tituloId, int sucursal, int pageIndex, int pageSize, out int pageTotal)
        {
            var criteros = new PagingCriteria();

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "FechaAlta";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            Expression<Func<ComprasDetalle, bool>> where = x => (!compraId.HasValue || x.CompraId == compraId) &&
                                                           (!tituloId.HasValue || x.TituloId == tituloId) &&
                                                           (x.SucursalAltaId == sucursal) 
                                                           ;

            var resultados = Uow.ComprasDetalles.Listado(criteros,
                                                where,
                                                x => x.Titulo,
                                                x => x.Compra);

            pageTotal = resultados.PagedMetadata.TotalItemCount;
            return resultados.Entities.Project().To<ComprasDetalleDto>().ToList();
        }

    }
}
