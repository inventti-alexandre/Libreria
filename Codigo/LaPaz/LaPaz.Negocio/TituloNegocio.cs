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
using System.Linq;
using LaPaz.Win.Model;

namespace LaPaz.Negocio
{
    public class TituloNegocio : NegocioBase, ITituloNegocio
    {
        public TituloNegocio(ILaPazUow uow)
        {
            Uow = uow;
        }

        public List<TituloDto> Listado(string sortBy, string sortDirection, int? codigoProveedor, string codigoLibroCompleto,
                                       string isbn, string codigoBarra, string titulonombre, Guid? proveedorid, int? temaid,
                                       string autorNombre, int? editorialId, bool? conStock, int? sucursalId, bool? ochoDeMarzo, bool activos,
                                       int pageIndex, int pageSize, out int pageTotal)
        {
            return Uow.Titulos.Listado(sortBy, sortDirection, codigoProveedor, codigoLibroCompleto, isbn, codigoBarra,
                                       titulonombre, proveedorid, temaid, autorNombre, editorialId, conStock, sucursalId, ochoDeMarzo,
                                       activos, pageIndex, pageSize, out pageTotal).ToList();
        }

        public List<TituloDto> Listado(string sortBy, string sortDirection, int? codigoProveedor, string codigoLibroCompleto,
                                       int pageIndex, int pageSize, out int pageTotal)
        {
            return Listado(sortBy, sortDirection, codigoProveedor, codigoLibroCompleto,
                           null, null, null, null, null, null, null, null, null, null, true, pageIndex,
                           pageSize, out pageTotal);
        }

        public List<TituloDto> Listado(string sortBy, string sortDirection, int pageIndex, int pageSize, out int pageTotal)
        {
            return Listado(sortBy, sortDirection, null, null, null, null, null, null, null, null, null, null, null, null, true,
                           pageIndex, pageSize, out pageTotal);
        }

        public List<Cliente> ClientesConsignacion(Guid tituloId, int sucursalId)
        {
            return Uow.Clientes.Listado(c => c.RemitosVentas.Select(rv => rv.RemitosVentaDetalles))
                .Where(
                    c =>
                        c.RemitosVentas.Any(
                            rv =>
                                rv.RemitosVentaDetalles.Any(
                                    rvd => rvd.TituloId == tituloId && rvd.SucursalAltaId == sucursalId))).ToList();
        }

        public List<RemitosVentaDetalle> RemitosConsignacion(Guid tituloId, int sucursalId)
        {
            return
                Uow.RemitosVentasDetalle.Listado(rvd => rvd.RemitosVenta, rvd=>rvd.RemitosVenta.ClienteConsignado)
                .Where(rvd => rvd.TituloId == tituloId && rvd.SucursalAltaId == sucursalId).ToList();
        }

      }
}
