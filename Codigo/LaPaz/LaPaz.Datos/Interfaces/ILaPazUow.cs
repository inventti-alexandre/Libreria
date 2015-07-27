using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Entidades;

namespace LaPaz.Datos.Interfaces
{
    public interface ILaPazUow : IDisposable
    {
        IRepository<Cliente> Clientes { get; }
        IRepository<Proveedor> Proveedores { get; }
        IRepository<ProveedoresPago> ProveedoresPagos { get; }
        IRepository<ProveedoresPagosDetalle> ProveedoresPagosDetalles { get; }
        IRepository<Provincia> Provincias { get; }
        IRepository<Localidad> Localidades { get; }
        IRepository<Profesion> Profesiones { get; }
        IRepository<Especialidad> Especialidades { get; }
        IRepository<EstadosCliente> EstadosClientes { get; }
        IRepository<CondicionesVenta> CondicionesVenta { get; }
        IRepository<CondicionCompra> CondicionesCompra { get; }
        IRepository<TiposDocumentosIdentidad> TiposDocumentosIdentidad { get; }
        IRepository<Editorial> Editoriales { get; }
        IRepository<Autor> Autores { get; }
        IRepository<Tema> Temas { get; }
        IRepository<SubTema> SubTemas { get; }
        ITituloRepository Titulos { get; }
        IRepository<Tarjeta> Tarjetas { get; }
        IRepository<Banco> Bancos { get; }
        IRepository<LoteFactura> LotesFacturas { get; }
        IRepository<Venta> Ventas { get; }
        IRepository<Caja> Cajas { get; }
        IRepository<ClienteMontoFavor> ClientesMontosFavor { get; }
        IRepository<ClienteCuentaCorriente> ClientesCuentasCorrientes { get; }
        IRepository<TituloStock> TitulosStock { get; }
        IRepository<VentaDetalle> VentasDetalle { get; }
        IRepository<CajaMovimiento> CajaMovimientos { get; }
        IRepository<TarjetasMovimiento> TarjetasMovimientos { get; }
        IRepository<ChequesTercero> ChequesTerceros { get; }
        IRepository<ClientesMovimiento> ClientesMovimientos { get; }
        IRepository<ProveedorBanco> ProveedoresBancos { get; }
        IRepository<OrdenesPago> OrdenesPagos { get; }
        IRepository<OrdenesPagoDetalle> OrdenesPagosDetalle { get; }
        IRepository<OrdenPagoCheque> OrdenPagoCheque { get; }
        IRepository<Sucursal> Sucursales { get; }
        IRepository<CentrosCosto> CentrosCostos { get; }
        IRepository<TiposGasto> TiposGastos { get; }
        IRepository<Compra> Compras { get; }
        IRepository<ComprasDetalle> ComprasDetalles { get; }
        IRepository<TipoComprobante> TiposComprobantes { get; }
        IReporteRepository Reportes { get; }
        IRepository<VentaReservada> VentasReservadas { get; }
        IRepository<Operador> Operadores { get; }
        IRepository<OperadorSucursal> OperadorSucursales { get; }
        IRepository<FacturasCompra> FacturasCompras { get; }
        IRepository<FacturasComprasDetalle> FacturasComprasDetalles { get; }
        IRepository<TitulosConsignacion> TitulosConsignaciones { get; }
        IConsignacionVendidaRepository TitulosConsignacionesVendidas { get; }
        IRepository<ProveedoresCuentasCorriente> ProveedoresCuentasCorrientes { get; }
        IRepository<ClientesMontosFavorDetalle> ClientesMontosFavorDetalles { get; }
        IRepository<ProveedorSenia> ProveedoresSenias { get; }
        IRepository<ChequesTercero> ChequesTercero { get; }
        IRepository<Cuenta> Cuentas { get; }
        IRepository<CuentasMovimiento> CuentasMovimientos { get; }
        IRepository<EstadosLoteFactura> EstadosLotesFactura { get; }
        IRepository<BancoPropio> BancosPropios { get; }
        IRepository<TiposCuenta> TiposCuentas { get; }
        IRepository<RemitosCompra> RemitosCompra { get; }
        IRepository<RemitosCompraDetalle> RemitosCompraDetalle { get; }
        IRepository<Presupuestos> Presupuesto { get; }
        IRepository<PresupuestosDetalle> PresupuestoDetalle { get; }
        IRepository<Role> Roles { get; }
        IRepository<Funcion> Funciones { get; }
        IRepository<Personal> Personales { get; }
        IRepository<TituloConsignacionRendida> TitulosConsignacionesRendidas { get; }
        IRepository<TituloConsignacionRendidasDetalle> TitulosConsignacionesRendidasDetalle { get; }
        IRepository<RemitosVenta> RemitosVentas { get; }
        IRepository<RemitosVentaDetalle> RemitosVentasDetalle { get; }
        IConsignacionDevueltaRepository TitulosConsignacionesDevueltas { get; }
        IRepository<TitulosConsignacionesDevueltasDetalle> TitulosConsignacionesDevueltasDetalles { get; }

        bool IsDisposed { get; }

        void Commit();
    }
}
