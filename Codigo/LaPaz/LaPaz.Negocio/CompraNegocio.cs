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
    public class CompraNegocio : NegocioBase , ICompraNegocio
    {
        public CompraNegocio (ILaPazUow uow)
        {
            Uow = uow;
        }

        public Compra CrearCompra (Compra compra)
        {
            return compra;
        }

        public List<ComprasDto> Listado(string sortBy, string sortDirection, Guid? proveedorId, string nroComprobante, TipoComprobanteEnum? tipoId, int sucursal, DateTime fechaInicio, DateTime fechaFin, int pageIndex, int pageSize, out int pageTotal)
        {
            var criteros = new PagingCriteria();

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "FechaAlta";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            Expression<Func<Compra, bool>> where = x => (string.IsNullOrEmpty(nroComprobante) || x.NumeroComprobante.Contains(nroComprobante)) &&
                                                           (!tipoId.HasValue || x.TipoComprobanteId == tipoId) &&
                                                           (!proveedorId.HasValue || x.ProveedorId == proveedorId) &&
                                                           (x.SucursalAltaId == sucursal) &&
                                                           (x.FechaAlta > fechaInicio) && (x.FechaAlta < fechaFin)
                                                           ;

            var resultados = Uow.Compras.Listado(criteros,
                                                where,
                                                x => x.Proveedor,
                                                x => x.TiposComprobante);

            pageTotal = resultados.PagedMetadata.TotalItemCount;
            return resultados.Entities.Project().To<ComprasDto>().ToList();
        }

        public decimal? CompraTotal(Guid? proveedorId, int? sucursalId, DateTime fechaInicio, DateTime fechaFin)
        {
            var compraTotal = Uow.Compras.Listado().Where(x=> (!proveedorId.HasValue || x.ProveedorId == proveedorId) &&
                                                                       (!sucursalId.HasValue || x.SucursalAltaId == sucursalId) &&
                                                           (x.FechaAlta > fechaInicio) && (x.FechaAlta < fechaFin));

            return (decimal?)compraTotal.Select(c => c.ImporteNeto).DefaultIfEmpty(0).Sum() ?? 0;
        }

        public int? CantidadCompra(Guid? proveedorId, int? sucursalId, DateTime fechaInicio, DateTime fechaFin)
        {
            var compraTotal = Uow.Compras.Listado().Where(x => (!proveedorId.HasValue || x.ProveedorId == proveedorId) &&
                                                                       (!sucursalId.HasValue || x.SucursalAltaId == sucursalId) &&
                                                           (x.FechaAlta > fechaInicio) && (x.FechaAlta < fechaFin));

            return (int?)compraTotal.Count() ?? 0;
        }
    }
}
