--Alumnos
DELETE FROM Alumnos

--Cajas
--ELIMINAR CAJAS DE OTRAS SUCURSALES
DELETE FROM TarjetasMovimientos
DELETE FROM TarjetasLiquidacion
DELETE FROM OrdenesPagoDetalle
DELETE FROM OrdenesPago
DELETE FROM CajasMovimientos
DELETE FROM Cajas

--Cheques
DELETE FROM ChequesTerceros

--Cuentas Corrientes de Clientes
DELETE FROM ClientesCuentasCorriente

--Clientes Montos a Favor
DELETE FROM ClientesMontosFavorDetalle
DELETE FROM ClientesMontosFavor

--Clientes Movimientos
DELETE FROM ClientesMovimiento

--Comentarios
DELETE FROM ComentariosClientes
DELETE FROM Comentarios

--Eliminar las compras
DELETE FROM ComprasDetalle 
DELETE FROM FacturasComprasDetalle 
DELETE FROM FacturasCompra 
DELETE FROM RemitosCompraDetalle
DELETE FROM RemitosCompra
DELETE FROM Compras WHERE ID <>  '00000000-0000-0000-0000-000000000000'

--Cuenta Movimiento
DELETE FROM CuentasMovimientos 

--Duplicados
DELETE FROM DUPLICADOS 
DELETE FROM DuplicadosTitulosStock
DELETE FROM DuplicadosTitulosStockAuditado

--Email
DELETE FROM Email

--ELIMINAR VENTAS 
DELETE FROM NotasDeVentaDetalle  
DELETE FROM NotasDeVenta 
DELETE FROM VentasDetalle 
DELETE FROM Ventas 

--Liquidaciones
DELETE FROM Liquidaciones
DELETE FROM LiquidacionPersonal

--ELIMINAR LOTES DE FACTURA MENORES A LA FECHA
DELETE FROM LoteFactura 

--MOVIMIENTOS FONDOS
DELETE FROM MovimientosFondoDetalle
DELETE FROM MovimientosFondo

--Numeradores
DELETE FROM Numeradores

--ORDENES PAGO 
DELETE FROM OrdenesPagoTransferencia
DELETE FROM OrdenesPagoTransferencia
DELETE FROM OrdenPagoCheques

--PEDIDOS
DELETE FROM PedidosDetalle
DELETE FROM Pedidos

--PRECIOS ACT
DELETE FROM PRECIOSACT
DELETE FROM PRECIOSACT2
DELETE FROM PRECIOSACTlpc3

--PRESUPUESTOS
DELETE FROM PresupuestosDetalle
DELETE FROM Presupuestos

--PREVENTAS
DELETE FROM PreVentas

--PROVEEDORES
DELETE FROM ProveedoresBanco
DELETE FROM ProveedoresBultos
DELETE FROM ProveedoresCuentasCorriente
DELETE FROM ProveedoresMontosFavorDetalle
DELETE FROM ProveedoresMontosFavor
DELETE FROM ProveedoresPagosDetalle
DELETE FROM ProveedoresPagos
DELETE FROM ProveedoresSenias

--RECIBOS
DELETE FROM RecibosDetalle
DELETE FROM Recibos

--REGISTROS
DELETE FROM RegistrosExportaciones
DELETE FROM RegistrosImportaciones

--REMITOS
DELETE FROM RemitosCompraDetalle
DELETE FROM RemitosCompra
DELETE FROM RemitosVentaDetalle
DELETE FROM RemitosVenta

--TITULOS
DELETE FROM TitulosConsignaciones
DELETE FROM TitulosConsignacionesDevueltasDetalles
DELETE FROM TitulosConsignacionesDevueltasDetalles
DELETE FROM TitulosConsignacionesRendidasDetalle
DELETE FROM TitulosConsignacionesRendidasDetalle
DELETE FROM TitulosConsignacionesVendidas
DELETE FROM TITULOSFALTA3
DELETE FROM TITULOSFALTALPC3
DELETE FROM TitulosMovimiento
DELETE FROM TitulosStock
DELETE FROM TitulosStockAuditado

--TRANSFERENCIAS
DELETE FROM TransferenciasDetalle
DELETE FROM Transferencias

--VALES
DELETE FROM Vales

--VENTAS
DELETE FROM VentasDetalle
DELETE FROM VentasPendientesEntrega
DELETE FROM VentasReservadas
DELETE FROM Ventas


--////*********
