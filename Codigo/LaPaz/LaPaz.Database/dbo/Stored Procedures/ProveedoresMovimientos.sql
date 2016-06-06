CREATE PROCEDURE [dbo].[ProveedoresMovimientos]
@Proveedor uniqueidentifier = null,
@SucursalId int
AS
DECLARE @Temp TABLE
(
	Fecha datetime,
	Concepto varchar(100),
	Importe money,
	Pagos money,
	Efectivo money,
	Tarjeta money,
	Cheque money,
	Deposito money,
	Transferencia money
)


INSERT INTO @Temp
SELECT c.FechaAlta, c.Concepto, c.ImporteNeto,0, CM.Efectivo, CM.Tarjeta, CM.Cheque, CM.Deposito, CM.Transferencia
FROM Compras C
INNER JOIN CajasMovimientos CM ON CM.ComprobanteId = C.Id
WHERE C.ProveedorId =@Proveedor
AND C.SucursalAltaId = @SucursalId

INSERT INTO @Temp
SELECT PP.FechaAlta, TC.Nombre, 0,PP.Importe, CM.Efectivo, CM.Tarjeta, CM.Cheque, CM.Deposito, CM.Transferencia
FROM ProveedoresPagos PP
INNER JOIN TiposComprobantes TC on tc.Id= pp.TipoComprobanteId
INNER JOIN CajasMovimientos CM ON CM.ComprobanteId = PP.Id
WHERE PP.ProveedorId =@Proveedor
AND PP.SucursalAltaId = @SucursalId


SELECT * FROM @Temp
ORDER BY Fecha


