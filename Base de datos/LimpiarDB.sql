DECLARE @FechaMinima DATE
SET @FechaMinima = '2014-11-01'

--ELIMINAR VENTAS QUE NO SEAN SUCURSAL CORRIENTES
DELETE FROM NotasDeVentaDetalle WHERE SucursalAltaId <> 2 
DELETE FROM NotasDeVenta WHERE SucursalAltaId <> 2 
DELETE FROM VentasDetalle WHERE SucursalAltaId <> 2
DELETE FROM Ventas WHERE SucursalAltaId <> 2

--ELIMINAR LOTES DE FACTURA MENORES A LA FECHA
DELETE FROM LoteFactura WHERE FechaAlta < @FechaMinima

--PONER A CERO TODO EL STOCK
DELETE TitulosStock WHERE SucursalAltaId <>2
UPDATE TitulosStock SET StkCn = 0, StkPr = 0

--ELIMINAR TODAS LAS SENAS DE PROVEEDORES
DELETE FROM ProveedoresSenias

--ELIMINAR TODAS LAS SENIAS DE LOS CLIENTES
DELETE CMFD FROM ClientesMontosFavorDetalle CMFD INNER JOIN ClientesMontosFavor CMF ON CMFD.ClientesMontosFavorId = CMF.Id  WHERE CMF.TipoComprobanteId = 21
DELETE FROM ClientesMontosFavor  WHERE TipoComprobanteId = 21

--ELIMINAR TODAS LAS NOTAS DE CRÉDITO
DELETE CMFD FROM ClientesMontosFavorDetalle CMFD INNER JOIN ClientesMontosFavor CMF ON CMFD.ClientesMontosFavorId = CMF.Id  WHERE CMF.TipoComprobanteId = 4
DELETE FROM ClientesMontosFavor  WHERE TipoComprobanteId = 4 

--
DECLARE @FechaMinimaComprobantes DATE
SET @FechaMinimaComprobantes = '2015-01-19'
DELETE FROM ClientesMontosFavorDetalle WHERE FechaAlta < @FechaMinimaComprobantes
DELETE FROM ClientesMontosFavor WHERE FechaAlta < @FechaMinimaComprobantes
--TODO: ELIMINAR TODAS LAS DEUDAS DE PROVEEDORES

--ELIMINAR TODAS LAS ORDENES DE PAGO VENCIDAS TODO:PREGUNTAR?
--DELETE FROM OrdenPagoCheques WHERE SucursalAltaId <> 2 OR FechaAlta < @FechaMinima
--DELETE FROM OrdenesPagoDetalle WHERE SucursalAltaId <> 2 OR FechaAlta < @FechaMinima
--DELETE FROM OrdenesPago WHERE SucursalAltaId <> 2 OR FechaAlta < @FechaMinima

--ELIMINAR TODOS LOS MOVIMIENTOS DE TARJETA
DELETE FROM TarjetasMovimientos

--ELIMINAR TODOS LOS MOVIMIENTOS DE CUENTA
DELETE FROM CuentasMovimientos

--ELIMINAR TODOS LOS CHEQUES DE TERCEROS
DELETE FROM OrdenPagoCheques
DELETE FROM ChequesTerceros

--ELIMINAR CAJAS DE OTRAS SUCURSALES
DELETE FROM CajasMovimientos WHERE SucursalAltaId <>2
DELETE FROM Cajas WHERE SucursalAltaId<>2

--SETEO A 0 LOS PROVEEDORES QUE TIENEN DESCUENTO EN NULL
UPDATE Proveedores SET PorcentajeDescuento	=0 WHERE PorcentajeDescuento IS NULL

--ELIMINO PROVEEDORES DE GASTOS DE OTRAS SUCURSALES
DELETE FROM OrdenesPagoDetalle WHERE SucursalAltaId <>2
DELETE OPD FROM OrdenesPagoDetalle OPD 
	LEFT JOIN OrdenesPago OP ON OPD.OrdenPagoId= OP.Id  
	LEFT JOIN Proveedores PRV ON OP.ProveedorId = PRV.Id
	WHERE PRV.SucursalAltaId <> 2 AND PRV.Gto=1

DELETE FROM OrdenesPago WHERE SucursalAltaId <> 2 
DELETE OP FROM OrdenesPago OP
	LEFT JOIN Proveedores PRV ON OP.ProveedorId = PRV.Id  
	WHERE PRV.SucursalAltaId <> 2 AND PRV.Gto = 1


DELETE P FROM Proveedores P WHERE P.SucursalAltaId <> 2 AND P.Gto = 1 
	AND NOT EXISTS (SELECT 1 FROM Titulos T WHERE T.ProveedorId = P.Id)
	AND NOT EXISTS (SELECT 1 FROM Compras C WHERE C.ProveedorId = P.Id);


--eliminar las cuentascorrientes de proveedores
DELETE FROM OrdenesPagoComprobantes 
DELETE FROM ProveedoresCuentasCorriente 

--Eliminar las compras
DECLARE @FechaMinima DATE
SET @FechaMinima = '2014-11-01'
DELETE FROM ComprasDetalle WHERE FechaAlta < @FechaMinima
DELETE FROM FacturasComprasDetalle WHERE FechaAlta < @FechaMinima
DELETE FROM FacturasCompra WHERE FechaAlta < @FechaMinima
DELETE FROM Compras WHERE FechaAlta < @FechaMinima AND ID <>  '00000000-0000-0000-0000-000000000000'



--Eliminar las consignaciones, Presupuestos
DECLARE @FechaMinima DATE
SET @FechaMinima = '2015-01-19'
DELETE FROM PresupuestosDetalle WHERE FechaAlta < @FechaMinima
DELETE FROM Presupuestos WHERE FechaAlta < @FechaMinima

--CONSIGNACIONES
DELETE FROM TitulosConsignaciones where FechaAlta < @FechaMinima
DELETE FROM TitulosConsignacionesVendidas where FechaAlta < @FechaMinima

--CLIENTES
update Clientes set VendedorId = null