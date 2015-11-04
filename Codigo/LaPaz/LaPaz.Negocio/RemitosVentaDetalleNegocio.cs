using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Framework.Comun.Attributes;
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
    [SharedContext]
    public class RemitosVentaDetalleNegocio : NegocioBase, IRemitosVentaDetalleNegocio
    {
        public RemitosVentaDetalleNegocio(ILaPazUow uow)
        {
            Uow = uow;
        }

        public List<RemitosVentaDetalleDto> Listado(string sortBy, string sortDirection, string criteria,
                               string remitoVentaId, int pageIndex, int pageSize, out int pageTotal)
        {

            var criteros = new PagingCriteria();
            Guid _remitoVentaId;
            Guid.TryParse(remitoVentaId, out _remitoVentaId);

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "FechaAlta";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            var denominacionFormateado = criteria.ToStringSearch();

            Expression<Func<RemitosVentaDetalle, bool>> where = x => x.RemitoVentaId == _remitoVentaId;

            var resultados = Uow.RemitosVentasDetalle.Listado(criteros, 
                                                        where,
                                                        x => x.Titulo,
                                                        x => x.SucursalAlta);

            pageTotal = resultados.PagedMetadata.TotalItemCount;

            return resultados.Entities.Project().To<RemitosVentaDetalleDto>().ToList();
        }

        public List<RemitosVentaDetalleDto> ListadoByRemitoVentaId(string remitoVentaId)
        {

            var criteros = new PagingCriteria();
            Guid _remitoVentaId;
            Guid.TryParse(remitoVentaId, out _remitoVentaId);

            criteros.PageNumber = 1;
            criteros.PageSize = 100;
            criteros.SortBy = "FechaAlta";
            criteros.SortDirection =  "DESC";
            
            Expression<Func<RemitosVentaDetalle, bool>> where = x => x.RemitoVentaId == _remitoVentaId;

            var resultados = Uow.RemitosVentasDetalle.Listado(criteros,
                                                        where,
                                                        x => x.Titulo,
                                                        x => x.SucursalAlta);
            
            return resultados.Entities.Project().To<RemitosVentaDetalleDto>().ToList();
        }

        public RemitosVentaDetalleDto RemitoDetalleById(string remitoDetalleId)
        {

            var criteros = new PagingCriteria();
            Guid _remitoDetalleId;
            Guid.TryParse(remitoDetalleId, out _remitoDetalleId);

            criteros.PageNumber = 1;
            criteros.PageSize = 20;
            criteros.SortBy = "FechaAlta";
            criteros.SortDirection = "DESC";

            Expression<Func<RemitosVentaDetalle, bool>> where = x => x.Id == _remitoDetalleId;

            var resultados = Uow.RemitosVentasDetalle.Listado(criteros,
                                                        where,
                                                        x => x.Titulo,
                                                        x => x.SucursalAlta);

            var list = resultados.Entities.Project().To<RemitosVentaDetalleDto>().ToList();
            return list.FirstOrDefault();
        }
    }
}
