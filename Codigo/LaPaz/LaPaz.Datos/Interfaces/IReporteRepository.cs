using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Entidades;

namespace LaPaz.Datos.Interfaces
{
    public interface IReporteRepository
    {
        IQueryable<SP_GenerarFacturaByVentaId_Result> FacturaByVentaId(Guid ventaId);

        IQueryable<SP_PresupuestoById1_Result> PresupuestoById(Guid presupuestoId);

        IQueryable<SP_ClienteMontoFavorByLCN_Result> ClienteMontoFavorByLcn(string lcn);

        List<RptInformeCajaRow> InformeCaja(DateTime fechaInicio, DateTime fechaFin, int sucursalId, Guid? operadorId);

        List<ReporteCajaResumidaVentasRow> CajaResumidaVentas(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId);

        List<Reporte_Proveedor_General_Result> ReporteProveedorGeneral(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId, Guid? proveedorId);

        List<Reporte_Proveedor_General_Pagos_Result> ReporteProveedorGeneralPagos(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId, Guid? proveedorId);

        List<Reporte_Proveedor_General_AFavor_Result> ReporteProveedorGeneralAFavor(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId, Guid? proveedorId);

        List<ReporteCajaResumidaIngresosEgreso> CajaResumidaIngresos(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId);

        List<ReporteCajaResumidaIngresosEgreso> CajaResumidaEgresos(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId);

        List<ReporteCajaResumidaComposicion> CajaResumidaComposicionIngresos(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId);

        List<ReporteCajaResumidaComposicion> CajaResumidaComposicionEgresos(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId);

        List<ReporteCajaResumidaComposicion> CajaResumidaComposicionVentas(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId);

        List<RptTarjetasChequesYDepositosRow> TarjetasChequesYDespositos(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId);

        List<ReporteConsignacionesVendidasRow> ConsignacionesVendidas(DateTime inicio, DateTime fin, int sucursalId, Guid? proveedorId, Guid? operadorId, int? proveedorCod);

        List<RptInformeCajaRow> MovimientosCajaAnterior(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId);

        List<ReporteVentasRow> ReporteVentas(DateTime inicio, DateTime fin, int sucursalId, Guid? operadorId, int? temaId, int? editorialId, Guid? proveedorId, bool? conStockConsignado, bool? conStockPropio);

        List<ReporteAutorTitulosListado> ReporteAutorTitulosListado(int? codigoProveedor, string codigoLibroCompleto, string isbn, string codigoBarra, string tituloNombre, Guid? proveedorid, int? temaid, string autorNombre, int? editorialId, bool? conStock, int? sucursalId, bool? ochoDeMarzo);

        List<ReporteClientesPorTitulo> ReporteClientesPorTitulo(Guid tituloId, DateTime fechaDesde, DateTime fechaHasta, int sucursalId);

        List<ReporteMultiRanking> ReporteMultiRanking(string tipoRanking, DateTime fechaDesde, DateTime fechaHasta, int sucursalId, bool? muestraCantidad, int cantidadFilas );

        List<ReciboConsignacion> ReciboConsignacion(Guid consignacionId);
    }

}
