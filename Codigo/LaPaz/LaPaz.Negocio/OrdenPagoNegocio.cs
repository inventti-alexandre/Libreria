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
    public class OrdenPagoNegocio : NegocioBase, IOrdenesPagoNegocio
    {
        public OrdenPagoNegocio(ILaPazUow uow)
        {
            Uow = uow;
        }

        public List<OrdenesPagoDto> Listado(string sortBy, string sortDirection, string concepto, string nrocomprobante, 
                        string proveedorId, int? sucursalGastoId, int? centroCostoId, int? tipogastoId, 
                        TipoComprobanteEnum? tipoComprobanteId, bool pendiente, int pageIndex, int pageSize, out int pageTotal)
        {
            var criteros = new PagingCriteria();
            Guid _proveedorId;
            Guid.TryParse(proveedorId, out _proveedorId);

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "Fecha";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            Expression<Func<OrdenesPago, bool>> where = x => (string.IsNullOrEmpty(concepto) || x.Concepto.Contains(concepto)) &&
                                                             (string.IsNullOrEmpty(nrocomprobante) || x.Concepto.Contains(nrocomprobante)) &&
                                                             (sucursalGastoId == 0 || x.SucursalGastoId==sucursalGastoId) &&
                                                             (centroCostoId == 0 || x.CentroCostoId==centroCostoId) &&
                                                             (tipogastoId == 0 || tipogastoId == 0 || x.TipoGastoId == tipogastoId) &&
                                                             (tipoComprobanteId == 0 || tipoComprobanteId == null || x.TipoComprobanteId == tipoComprobanteId) &&
                                                             (_proveedorId == Guid.Empty || x.ProveedorId==_proveedorId) &&
                                                             (!x.FechaAnulacion.HasValue) &&
                                                             (!pendiente || x.Importe > x.ImportePagado);
           
            var resultados = Uow.OrdenesPagos.Listado(criteros,
                                                     where,
                                                     x => x.Proveedor,
                                                     x => x.Sucursal,
                                                     x => x.TiposGasto,
                                                     x => x.SucursalGasto,
                                                     x => x.CentrosCosto,
                                                     x => x.OrdenesPagoDetalles);
            

            pageTotal = resultados.PagedMetadata.TotalItemCount;

            return resultados.Entities.Project().To<OrdenesPagoDto>().ToList();   
        }
    }
}
