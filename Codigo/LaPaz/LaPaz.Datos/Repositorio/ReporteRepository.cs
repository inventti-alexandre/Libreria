using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;

namespace LaPaz.Datos.Repositorio
{
    public class ReporteRepository : EFBaseRepository, IReporteRepository
    {
        public ReporteRepository()
        {
        }

        public ReporteRepository(DbContext dbContext)
            : base(dbContext)
        {
        }

        public IQueryable<SP_GenerarFacturaByVentaId_Result> FacturaByVentaId(Guid ventaId)
        {
            return LaPazEntities.SP_GenerarFacturaByVentaId(ventaId).AsQueryable();
        }

        public IQueryable<SP_PresupuestoById1_Result> PresupuestoById(Guid presupuestoId)
        {
            return LaPazEntities.SP_PresupuestoById1(presupuestoId).AsQueryable();
        }

        public IQueryable<SP_ClienteMontoFavorByLCN_Result> ClienteMontoFavorByLcn(string lcn)
        {
            return LaPazEntities.SP_ClienteMontoFavorByLCN(lcn).AsQueryable();
        }

        public List<RptInformeCajaRow> InformeCaja(DateTime fechaInicio, DateTime fechaFin, int sucursalId, Guid? operadorId)
        {
            return LaPazEntities.ReporteInformeCaja(sucursalId, fechaInicio, fechaFin, operadorId).ToList();
        }


        public List<ReporteCajaResumidaVentasRow> CajaResumidaVentas(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId)
        {
            return LaPazEntities.ReporteCajaResumidaVentas(sucursalId, inicio, fin, operadorId).ToList();
        }

        public List<ReporteCajaResumidaIngresosEgreso> CajaResumidaIngresos(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId)
        {
            return LaPazEntities.ReporteCajaResumidaIngresos(sucursalId, inicio, fin, operadorId).ToList();
        }

        public List<ReporteCajaResumidaIngresosEgreso> CajaResumidaEgresos(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId)
        {
            return LaPazEntities.ReporteCajaResumidaEgresos(sucursalId, inicio, fin, operadorId).ToList();
        }

        public List<ReporteCajaResumidaComposicion> CajaResumidaComposicionIngresos(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId)
        {
            return LaPazEntities.ReporteCajaResumidaComposicionIngresos(sucursalId, inicio, fin, operadorId).ToList();
        }

        public List<ReporteCajaResumidaComposicion> CajaResumidaComposicionEgresos(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId)
        {
            return LaPazEntities.ReporteCajaResumidaComposicionEgresos(sucursalId, inicio, fin, operadorId).ToList();
        }

        public List<ReporteCajaResumidaComposicion> CajaResumidaComposicionVentas(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId)
        {
            return LaPazEntities.ReporteCajaResumidaComposicionVentas(sucursalId, inicio, fin, operadorId).ToList();
        }


        public List<RptTarjetasChequesYDepositosRow> TarjetasChequesYDespositos(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId)
        {
            return LaPazEntities.ReporteTarjetasChequesYDepositos(sucursalId, inicio, fin, operadorId).ToList();
        }


        public List<ReporteConsignacionesVendidasRow> ConsignacionesVendidas(DateTime inicio, DateTime fin, int sucursalId, Guid? proveedorId, Guid? operadorId, int? proveedorCod)
        {
            return LaPazEntities.ReporteConsignacionesVendidas(sucursalId, inicio, fin, proveedorId, operadorId, proveedorCod).ToList();
        }


        public List<RptInformeCajaRow> MovimientosCajaAnterior(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId)
        {
            return LaPazEntities.ReporteMovimientosCajaAnterior(sucursalId, inicio, fin, operadorId).ToList();
        }

        public List<ReporteVentasRow> ReporteVentas(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId, int? temaId, int? editorialId, Guid? proveedorId, bool? conStockConsignado, bool? conStockPropio)
        {
            return LaPazEntities.ReporteVentas(sucursalId, inicio, fin, operadorId, temaId, editorialId, proveedorId, conStockConsignado,conStockPropio).ToList();
        }

        public List<ReporteAutorTitulosListado> ReporteAutorTitulosListado(int? codigoProveedor, string codigoLibroCompleto, string isbn, string codigoBarra, string tituloNombre, Guid? proveedorid, int? temaid, string autorNombre, int? editorialId, bool? conStock, int? sucursalId, bool? ochoDeMarzo)
        {
            return LaPazEntities.ReporteAutorTitulosListado(codigoProveedor, codigoLibroCompleto, isbn, codigoBarra,
                                                            tituloNombre, proveedorid, temaid, autorNombre, editorialId,
                                                            conStock, sucursalId, ochoDeMarzo).ToList();
        }

        public List<ReporteClientesPorTitulo> ReporteClientesPorTitulo(Guid tituloId, DateTime fechaDesde, DateTime fechaHasta, int sucursalId)
        {
            return LaPazEntities.ReporteClientesPorTitulos(tituloId, fechaDesde, fechaHasta, sucursalId).ToList();
        }

        public List<ReporteMultiRanking> ReporteMultiRanking(string tipoRanking, DateTime fechaDesde, DateTime fechaHasta, int sucursalId, bool? muestraCantidad, int cantidadFilas)
        {
            return
                LaPazEntities.ReporteMultiRanking(tipoRanking, sucursalId, fechaDesde, fechaHasta, cantidadFilas,
                                                  muestraCantidad).ToList();
        }

        public List<ReciboConsignacion> ReciboConsignacion(Guid consginacionId)
        {
            return LaPazEntities.ReciboConsignacion(consginacionId).ToList();
        }
    }
}