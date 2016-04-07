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
    public class RemitosVentaNegocio : NegocioBase, IRemitosVentaNegocio
    {
        public RemitosVentaNegocio(ILaPazUow uow)
        {
            Uow = uow;
        }

        public List<RemitosVentaDto> Listado(string sortBy, string sortDirection, string criteria,
                                      Guid clienteId, int? numeroComprobante, 
                                      int pageIndex, int pageSize, out int pageTotal)
        {

            var criteros = new PagingCriteria();

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "FechaAlta";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            var denominacionFormateado = criteria.ToStringSearch();
            
            Expression<Func<RemitosVenta, bool>> where = x => 
                                                         ((string.IsNullOrEmpty(criteria) || SqlFunctions.PatIndex(denominacionFormateado, x.ClienteConsignado.Denominacion) > 0) || x.ClienteConsignado.Denominacion.Contains(denominacionFormateado)) &&
                                                       (!numeroComprobante.HasValue || x.NumeroComprobante.ToString().Contains(numeroComprobante.ToString()));

            var resultados = Uow.RemitosVentas.Listado(criteros, 
                                                        where,
                                                        x => x.ClienteConsignado,
                                                        x => x.SucursalAlta);

            pageTotal = resultados.PagedMetadata.TotalItemCount;

            return resultados.Entities.Project().To<RemitosVentaDto>().ToList();
        }

        public List<RemitosVentaDto> GetByClienteId(Guid clienteId, int sucursalId)
        {

            var criteros = new PagingCriteria();

            criteros.PageNumber = 1;
            criteros.PageSize = 500;
            criteros.SortBy = "FechaAlta";
            criteros.SortDirection = "DESC";

            Expression<Func<RemitosVenta, bool>> where = x => x.ClienteId == clienteId &&
                                                                x.SucursalAltaId==sucursalId &&
                                                              x.TipoComprobante ==
                                                              (int) TipoComprobanteEnum.RemitosConsignacCliente
                                                          &&
                                                            ((x.RemitosVentaDetalles.Sum(r => r.CntPr) + x.RemitosVentaDetalles.Sum(r => r.CntCn))
                                                                >
                                                                (x.RemitosVentaDetalles.Where(r => r.CntCn.HasValue).Sum(r => r.CntDevuelta ?? 0) + x.RemitosVentaDetalles.Where(r => r.CntCn.HasValue).Sum(r => r.CntVendida ?? 0)));
                                                           

            var resultados = Uow.RemitosVentas.Listado(criteros,
                                                            where,
                                                            x => x.RemitosVentaDetalles,
                                                            x => x.SucursalAlta);
            
            return resultados.Entities.Project().To<RemitosVentaDto>().ToList();
        }

        public int SiguienteNroConsignacion(int sucursalId)
        {
            var ultConsignacion = Uow.RemitosVentas.Listado().Where(r => r.TipoComprobante == (int)TipoComprobanteEnum.RemitosConsignacCliente && r.SucursalAltaId== sucursalId).OrderByDescending(r => r.FechaAlta).FirstOrDefault() ;
             
            int nroConsignacion = 1;

            if (ultConsignacion != null)
            {
                if (int.TryParse(ultConsignacion.NumeroComprobante, out nroConsignacion))
                {
                    nroConsignacion += 1;
                }
                else
                {
                    nroConsignacion = 1;
                }
                
            }

            return nroConsignacion;
        }
    }
}
