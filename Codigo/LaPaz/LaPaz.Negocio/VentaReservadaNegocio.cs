using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using LaPaz.Datos.Helpers;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Negocio.Interfaces;
using Framework.Comun.Utility;

namespace LaPaz.Negocio
{
    public class VentaReservadaNegocio : NegocioBase, IVentaReservadaNegocio
    {
        private IClock _clock;

        public VentaReservadaNegocio(ILaPazUow uow, IClock clock)
        {
            Uow = uow;
            _clock = clock;
        }

        public List<VentaReservadaDto> Listado(string sortBy, string sortDirection, Guid operador, int sucursal, int pageIndex, int pageSize, out int pageTotal)
        {
            var criteros = new PagingCriteria();

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "FechaAlta";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "ASC";

            Expression<Func<VentaReservada, bool>> where = x => (x.OperadorAltaId==operador) &&
                                                         (x.FechaModificacion == null) &&
                                                         (x.SucursalAltaId == sucursal);

            var resultados = Uow.VentasReservadas.Listado(criteros,
                                                    where);

            pageTotal = resultados.PagedMetadata.TotalItemCount;

         return resultados.Entities.Project().To<VentaReservadaDto>().ToList();
        }

    }
}
