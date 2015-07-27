using System;
using Framework.Ioc;
using LaPaz.Datos.Helpers;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;

namespace LaPaz.Datos
{
    public class LaPazUow : ILaPazUow
    {
        public LaPazUow(IRepositoryProvider repositoryProvider)
        {
            CreateDbContext();

            repositoryProvider.DbContext = DbContext;
            RepositoryProvider = repositoryProvider;
        }

        // Repositorios
        public IRepository<Cliente> Clientes { get { return GetStandardRepo<Cliente>(); } }
        public IRepository<Proveedor> Proveedores { get { return GetStandardRepo<Proveedor>(); } }
        public IRepository<ProveedoresPago> ProveedoresPagos { get { return GetStandardRepo<ProveedoresPago>(); } }
        public IRepository<ProveedoresPagosDetalle> ProveedoresPagosDetalles { get { return GetStandardRepo<ProveedoresPagosDetalle>(); } }
        public IRepository<Provincia> Provincias { get { return GetStandardRepo<Provincia>(); } }
        public IRepository<Localidad> Localidades { get { return GetStandardRepo<Localidad>(); } }
        public IRepository<Profesion> Profesiones { get { return GetStandardRepo<Profesion>(); } }
        public IRepository<Especialidad> Especialidades { get { return GetStandardRepo<Especialidad>(); } }
        public IRepository<CondicionesVenta> CondicionesVenta { get { return GetStandardRepo<CondicionesVenta>(); } }
        public IRepository<CondicionCompra> CondicionesCompra { get { return GetStandardRepo<CondicionCompra>(); } }
        public IRepository<EstadosCliente> EstadosClientes { get { return GetStandardRepo<EstadosCliente>(); } }
        public IRepository<TiposDocumentosIdentidad> TiposDocumentosIdentidad { get { return GetStandardRepo<TiposDocumentosIdentidad>(); } }
        public IRepository<Editorial> Editoriales { get { return GetStandardRepo<Editorial>(); } }
        public IRepository<Autor> Autores { get { return GetStandardRepo<Autor>(); } }
        public IRepository<Tema> Temas { get { return GetStandardRepo<Tema>(); } }
        public IRepository<SubTema> SubTemas { get { return GetStandardRepo<SubTema>(); } }
        public ITituloRepository Titulos { get { return GetRepo<ITituloRepository>(); } }
        public IRepository<Tarjeta> Tarjetas { get { return GetStandardRepo<Tarjeta>(); } }
        public IRepository<Banco> Bancos { get { return GetStandardRepo<Banco>(); } }
        public IRepository<LoteFactura> LotesFacturas { get { return GetStandardRepo<LoteFactura>(); } }
        public IRepository<Venta> Ventas { get { return GetStandardRepo<Venta>(); } }
        public IRepository<Caja> Cajas { get { return GetStandardRepo<Caja>(); } }
        public IRepository<ClienteMontoFavor> ClientesMontosFavor { get { return GetStandardRepo<ClienteMontoFavor>(); } }
        public IRepository<ClienteCuentaCorriente> ClientesCuentasCorrientes { get { return GetStandardRepo<ClienteCuentaCorriente>(); } }
        public IRepository<TituloStock> TitulosStock { get { return GetStandardRepo<TituloStock>(); } }
        public IRepository<VentaDetalle> VentasDetalle { get { return GetStandardRepo<VentaDetalle>(); } }
        public IRepository<CajaMovimiento> CajaMovimientos { get { return GetStandardRepo<CajaMovimiento>(); } }
        public IRepository<TarjetasMovimiento> TarjetasMovimientos { get { return GetStandardRepo<TarjetasMovimiento>(); } }
        public IRepository<ChequesTercero> ChequesTerceros { get { return GetStandardRepo<ChequesTercero>(); } }
        public IRepository<ClientesMovimiento> ClientesMovimientos { get { return GetStandardRepo<ClientesMovimiento>(); } }
        public IRepository<ProveedorBanco> ProveedoresBancos { get { return GetStandardRepo<ProveedorBanco>(); } }
        public IRepository<OrdenesPago> OrdenesPagos { get { return GetStandardRepo<OrdenesPago>(); } }
        public IRepository<OrdenesPagoDetalle> OrdenesPagosDetalle { get { return GetStandardRepo<OrdenesPagoDetalle>(); } }
        public IRepository<OrdenPagoCheque> OrdenPagoCheque { get { return GetStandardRepo<OrdenPagoCheque>(); } }
        public IRepository<Sucursal> Sucursales { get { return GetStandardRepo<Sucursal>(); } }
        public IRepository<CentrosCosto> CentrosCostos { get { return GetStandardRepo<CentrosCosto>(); } }
        public IRepository<TiposGasto> TiposGastos { get { return GetStandardRepo<TiposGasto>(); } }
        public IRepository<ProveedoresCuentasCorriente> ProveedoresCuentasCorriente { get { return GetStandardRepo<ProveedoresCuentasCorriente>(); } }
        public IRepository<Compra> Compras { get { return GetStandardRepo<Compra>(); } }
        public IRepository<ComprasDetalle> ComprasDetalles { get { return GetStandardRepo<ComprasDetalle>(); } }
        public IRepository<TipoComprobante> TiposComprobantes { get { return GetStandardRepo<TipoComprobante>(); } }
        public IRepository<VentaReservada> VentasReservadas { get { return GetStandardRepo<VentaReservada>(); } }
        public IRepository<Operador> Operadores { get { return GetStandardRepo<Operador>(); } }
        public IRepository<OperadorSucursal> OperadorSucursales { get { return GetStandardRepo<OperadorSucursal>(); } }
        public IRepository<FacturasCompra> FacturasCompras { get { return GetStandardRepo<FacturasCompra>(); } }
        public IRepository<FacturasComprasDetalle> FacturasComprasDetalles { get { return GetStandardRepo<FacturasComprasDetalle>(); } }
        public IRepository<TitulosConsignacion> TitulosConsignaciones { get { return GetStandardRepo<TitulosConsignacion>(); } }
        public IConsignacionVendidaRepository TitulosConsignacionesVendidas { get { return GetRepo<IConsignacionVendidaRepository>(); } }
        public IRepository<ProveedoresCuentasCorriente> ProveedoresCuentasCorrientes { get { return GetStandardRepo<ProveedoresCuentasCorriente>(); } }
        public IRepository<Role> Roles { get { return GetStandardRepo<Role>(); } }
        public IRepository<Funcion> Funciones { get { return GetStandardRepo<Funcion>(); } }
        public IRepository<ClientesMontosFavorDetalle> ClientesMontosFavorDetalles { get { return GetStandardRepo<ClientesMontosFavorDetalle>(); } }
        public IRepository<ProveedorSenia> ProveedoresSenias { get { return GetStandardRepo<ProveedorSenia>(); } }
        public IRepository<Personal> Personales { get { return GetStandardRepo<Personal>(); } }
        public IRepository<ChequesTercero> ChequesTercero{get { return GetStandardRepo<ChequesTercero>(); }}
        public IRepository<Cuenta> Cuentas { get { return GetStandardRepo<Cuenta>(); } }
        public IRepository<CuentasMovimiento> CuentasMovimientos { get { return GetStandardRepo<CuentasMovimiento>(); } }
        public IRepository<EstadosLoteFactura> EstadosLotesFactura { get { return GetStandardRepo<EstadosLoteFactura>(); } }
        public IRepository<BancoPropio> BancosPropios { get { return GetStandardRepo<BancoPropio>(); } }
        public IRepository<TiposCuenta> TiposCuentas { get { return GetStandardRepo<TiposCuenta>(); } }
        public IRepository<Presupuestos> Presupuesto { get { return GetStandardRepo<Presupuestos>(); } }
        public IRepository<PresupuestosDetalle> PresupuestoDetalle { get { return GetStandardRepo<PresupuestosDetalle>(); } }
        public IRepository<RemitosCompra> RemitosCompra { get { return GetStandardRepo<RemitosCompra>(); } }
        public IRepository<RemitosCompraDetalle> RemitosCompraDetalle { get { return GetStandardRepo<RemitosCompraDetalle>(); } }
        public IRepository<TituloConsignacionRendida> TitulosConsignacionesRendidas { get { return GetStandardRepo<TituloConsignacionRendida>(); } }
        public IRepository<TituloConsignacionRendidasDetalle> TitulosConsignacionesRendidasDetalle { get { return GetStandardRepo<TituloConsignacionRendidasDetalle>(); } }
        public IRepository<RemitosVenta> RemitosVentas { get { return GetStandardRepo<RemitosVenta>(); } }
        public IRepository<RemitosVentaDetalle> RemitosVentasDetalle { get { return GetStandardRepo<RemitosVentaDetalle>(); } }
        public IReporteRepository Reportes { get { return GetRepo<IReporteRepository>(); } }
        public IConsignacionDevueltaRepository TitulosConsignacionesDevueltas { get { return GetRepo<IConsignacionDevueltaRepository>(); } }
        public IRepository<TitulosConsignacionesDevueltasDetalle> TitulosConsignacionesDevueltasDetalles { get { return GetStandardRepo<TitulosConsignacionesDevueltasDetalle>(); } }

        public bool IsDisposed { get; private set; }

        /// <summary>
        /// Save pending changes to the database
        /// </summary>
        public void Commit()
        {
            DbContext.SaveChanges();
        }

        protected void CreateDbContext()
        {
            DbContext = new LaPazEntities();

            // Do NOT enable proxied entities, else serialization fails
            DbContext.Configuration.ProxyCreationEnabled = false;

            // Load navigation properties explicitly (avoid serialization trouble)
            DbContext.Configuration.LazyLoadingEnabled = false;

            // Because Web API will perform validation, we don't need/want EF to do so
            DbContext.Configuration.ValidateOnSaveEnabled = false;

            //DbContext.Configuration.AutoDetectChangesEnabled = false;
            // We won't use this performance tweak because we don't need 
            // the extra performance and, when autodetect is false,
            // we'd have to be careful. We're not being that careful.
        }

        protected IRepositoryProvider RepositoryProvider { get; set; }

        private IRepository<T> GetStandardRepo<T>() where T : class
        {
            return RepositoryProvider.GetRepositoryForEntityType<T>();
        }

        private T GetRepo<T>() where T : class
        {
            return RepositoryProvider.GetRepository<T>();
        }

        private LaPazEntities DbContext { get; set; }

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (DbContext != null)
                {
                    DbContext.Dispose();
                    DbContext = null;
                }

                if (RepositoryProvider != null)
                {
                    Ioc.Container.Release(RepositoryProvider);
                    RepositoryProvider = null;
                }
            }

            Ioc.Container.Release(this);

            IsDisposed = true;
        }

        #endregion


        
    }
}
