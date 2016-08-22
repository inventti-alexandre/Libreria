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
    public class PresupuestoDetalleNegocio : NegocioBase, IPresupuestoDetalleNegocio
    {
        public PresupuestoDetalleNegocio(ILaPazUow uow)
        {
            Uow = uow;
        }

        public List<PresupuestoDetalleDto> Listado(string sortBy, string sortDirection, string criteria,
                               string presupuestoId, int pageIndex, int pageSize, out int pageTotal)
        {

            var criteros = new PagingCriteria();
            Guid _presupuestoId;
            Guid.TryParse(presupuestoId, out _presupuestoId);

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "FechaAlta";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            var denominacionFormateado = criteria.ToStringSearch();

            Expression<Func<PresupuestosDetalle, bool>> where = x => x.PresupuestoId == _presupuestoId;

            var resultados = Uow.PresupuestoDetalle.Listado(criteros, 
                                                        where
                                                        //, x => x.Titulo
                                                        //, x => x.SucursalAlta
                                                        );

            pageTotal = resultados.PagedMetadata.TotalItemCount;

            return resultados.Entities.Project().To<PresupuestoDetalleDto>().ToList();
        }

        public List<PresupuestoDetalleDto> ListadoByPresupuestoId(string presupuestoId)
        {

            var criteros = new PagingCriteria();
            Guid _presupuestoId;
            Guid.TryParse(presupuestoId, out _presupuestoId);

            criteros.PageNumber = 1;
            criteros.PageSize = 100;
            criteros.SortBy = "FechaAlta";
            criteros.SortDirection =  "DESC";
            
            Expression<Func<PresupuestosDetalle, bool>> where = x => x.PresupuestoId == _presupuestoId;

            var resultados = Uow.PresupuestoDetalle.Listado(criteros,
                                                        where
                                                        , x => x.Titulos
                                                        ,x => x.Sucursales
                                                        );
            
            return resultados.Entities.Project().To<PresupuestoDetalleDto>().ToList();
        }

        public PresupuestoDetalleDto PresupuestoDetalleById(string presupuestoDetalleId)
        {

            var criteros = new PagingCriteria();
            Guid _presupuestoDetalleId;
            Guid.TryParse(presupuestoDetalleId, out _presupuestoDetalleId);

            criteros.PageNumber = 1;
            criteros.PageSize = 20;
            criteros.SortBy = "FechaAlta";
            criteros.SortDirection = "DESC";

            Expression<Func<PresupuestosDetalle, bool>> where = x => x.Id == _presupuestoDetalleId;

            var resultados = Uow.PresupuestoDetalle.Listado(criteros,
                                                        where
                                                        , x => x.Titulos
                                                        , x => x.Sucursales
                                                        );

            var list = resultados.Entities.Project().To<PresupuestoDetalleDto>().ToList();
            return list.FirstOrDefault();
        }
    }
}
