CREATE PROCEDURE [dbo].[ProveedoresMovimientos]
@Proveedor uniqueidentifier = null,
@SucursalId int
AS
DECLARE @Temp TABLE
(
	Fecha datetime,
	Concepto varchar(100),
	Importe money,
	Pagos money
)


INSERT INTO @Temp
SELECT c.FechaAlta, c.Concepto, c.ImporteNeto,0
FROM Compras C
WHERE C.ProveedorId =@Proveedor
AND C.SucursalAltaId = @SucursalId

INSERT INTO @Temp
SELECT PP.FechaAlta, TC.Nombre, 0,PP.Importe
FROM ProveedoresPagos PP
INNER JOIN TiposComprobantes TC on tc.Id= pp.TipoComprobanteId
WHERE PP.ProveedorId =@Proveedor
AND PP.SucursalAltaId = @SucursalId


SELECT * FROM @Temp
ORDER BY Fecha


