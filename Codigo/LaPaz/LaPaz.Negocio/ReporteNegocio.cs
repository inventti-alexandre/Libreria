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
    public class ReporteNegocio : NegocioBase, IReporteNegocio
    {
        private IClock _clock;

        public ReporteNegocio(ILaPazUow uow, IClock clock)
        {
            Uow = uow;
            _clock = clock;
        }

        public List<RptInformeCajaRow> InformeCaja(DateTime fechaInicio, DateTime fechaFin, int sucursalId, Guid? operadorId)
        {
            return Uow.Reportes.InformeCaja(fechaInicio, fechaFin, sucursalId, operadorId);
        }


        public List<ReporteCajaResumidaVentasRow> CajaResumidaVentas(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId)
        {
            return Uow.Reportes.CajaResumidaVentas(inicio, fin, sucursalId, operadorId);
        }

        public List<ReporteCajaResumidaIngresosEgreso> CajaResumidaIngresos(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId)
        {
            return Uow.Reportes.CajaResumidaIngresos(inicio, fin, sucursalId, operadorId);
        }

        public List<ReporteCajaResumidaIngresosEgreso> CajaResumidaEgresos(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId)
        {
            return Uow.Reportes.CajaResumidaEgresos(inicio, fin, sucursalId, operadorId);
        }

        public List<ReporteCajaResumidaComposicion> CajaResumidaComposicionIngresos(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId)
        {
            return Uow.Reportes.CajaResumidaComposicionIngresos(inicio, fin, sucursalId, operadorId);
        }

        public List<ReporteCajaResumidaComposicion> CajaResumidaComposicionEgresos(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId)
        {
            return Uow.Reportes.CajaResumidaComposicionEgresos(inicio, fin, sucursalId, operadorId);
        }

        public List<ReporteCajaResumidaComposicion> CajaResumidaComposicionVentas(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId)
        {
            return Uow.Reportes.CajaResumidaComposicionVentas(inicio, fin, sucursalId, operadorId);
        }


        public List<RptTarjetasChequesYDepositosRow> TarjetasChequesYDespositos(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId)
        {
            return Uow.Reportes.TarjetasChequesYDespositos(inicio, fin, sucursalId, operadorId);
        }


        public List<ReporteConsignacionesVendidasRow> ConsignacionesVendidas(DateTime inicio, DateTime fin, int sucursalId, 
                                                                            Guid? proveedorId, Guid? operadorId, int? proveedorCod)
        {
            return Uow.Reportes.ConsignacionesVendidas(inicio, fin, sucursalId, proveedorId, operadorId, proveedorCod);
        }


        public List<RptInformeCajaRow> MovimientosCajaAnterior(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId)
        {
            return Uow.Reportes.MovimientosCajaAnterior(inicio, fin, sucursalId, operadorId);
        }


        public List<ReporteVentasRow> ReporteVentas(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId, int? temaId, int? editorialId, Guid? proveedorId, bool? conStockConsignado, bool? conStockPropio)
        {
            return Uow.Reportes.ReporteVentas(inicio, fin, sucursalId, operadorId, temaId, editorialId, proveedorId, conStockConsignado, conStockPropio);
        }

        public List<ReporteAutorTitulosListado> ReporteAutorTitulosListado(int? codigoProveedor, string codigoLibroCompleto, string isbn, string codigoBarra, string tituloNombre, string proveedorid, int? temaid, string autorNombre, int? editorialId, bool? conStock, int? sucursalId, bool? ochoDeMarzo)
        {
            List<ReporteAutorTitulosListado> list;
            Guid _proveedorId;
            Guid.TryParse(proveedorid, out _proveedorId);

            if (_proveedorId == Guid.Empty)
            {
                list = Uow.Reportes.ReporteAutorTitulosListado(codigoProveedor, codigoLibroCompleto, isbn, codigoBarra,
                                                            tituloNombre, null, temaid, autorNombre, editorialId,
                                                            conStock, sucursalId, ochoDeMarzo);
            }
            else
            {
                list = Uow.Reportes.ReporteAutorTitulosListado(codigoProveedor, codigoLibroCompleto, isbn, codigoBarra,
                                                            tituloNombre, _proveedorId, temaid, autorNombre, editorialId,
                                                            conStock, sucursalId, ochoDeMarzo);   
            }
            return list;
        }

        public List<ReporteClientesPorTitulo> ReporteClientesPorTitulo(Guid tituloId, DateTime fechaDesde, DateTime fechaHasta, int sucursalId)
        {
            return Uow.Reportes.ReporteClientesPorTitulo(tituloId,fechaDesde,fechaHasta,sucursalId);
        }

        public List<ReporteMultiRanking> ReporteMultiRanking(string tipoRanking, DateTime fechaDesde, DateTime fechaHasta, int sucursalId, bool muestraCantidad, int cantidadFilas)
        {
            return Uow.Reportes.ReporteMultiRanking(tipoRanking, fechaDesde, fechaHasta, sucursalId, muestraCantidad, cantidadFilas).ToList();
        }

        public List<ReciboConsignacion> ReciboConsignacion(Guid consignacionId)
        {
            return Uow.Reportes.ReciboConsignacion(consignacionId).ToList();
        }
    }
}
