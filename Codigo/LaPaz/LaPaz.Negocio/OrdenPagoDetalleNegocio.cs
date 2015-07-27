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
    public class OrdenPagoDetalleNegocio : NegocioBase, IOrdenesPagoDetalleNegocio
    {
        public OrdenPagoDetalleNegocio(ILaPazUow uow)
        {
            Uow = uow;
        }

        public List<OrdenesPagoDetalleDto> Listado(string sortBy, string sortDirection, DateTime fechaDesde, DateTime fechaHasta, 
                bool? conAnulados, int pageIndex, int pageSize, out int pageTotal)
        {
            var criteros = new PagingCriteria();

            fechaDesde = fechaDesde.AddMilliseconds(-1);
            fechaHasta = fechaHasta.AddDays(1);
            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "FechaPago";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "ASC";

            Expression<Func<OrdenesPagoDetalle, bool>> where = x => (x.ImportePagado.Value == 0) &&
                                                                    (!conAnulados.HasValue || x.FechaAnulacion.HasValue == conAnulados) &&
                                                                    (x.FechaPago.Value > fechaDesde && x.FechaPago.Value < fechaHasta);
           
            var resultados = Uow.OrdenesPagosDetalle.Listado(criteros,
                                                     where,
                                                     x => x.OrdenesPago,
                                                     x => x.SucursalAlta);
            

            pageTotal = resultados.PagedMetadata.TotalItemCount;

            return resultados.Entities.Project().To<OrdenesPagoDetalleDto>().ToList();   
        }
    }
}
