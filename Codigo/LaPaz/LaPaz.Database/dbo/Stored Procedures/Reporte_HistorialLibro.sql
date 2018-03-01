CREATE PROCEDURE [dbo].[Reporte_HistorialLibro]
	@tituloId uniqueidentifier = null

AS
	DECLARE @Movimientos TABLE
	(
		Fecha datetime,
		Movimiento varchar(50),
		NroComprobante varchar(max),
		Propio int,
		Consignado int,
		DevueltoVendo int,
		Vendido int,
		Cliente varchar(50) ,
		Proveedor varchar(50),
		Operador varchar(50),
		Cod varchar(50),
		ISBN varchar (50),
		NombreTitulo varchar (max),
		stkPr int,
		stkCn int
	)

-----------------------------------------------------
-------------COMPRAS---------------------------------
-----------------------------------------------------
INSERT INTO @Movimientos
SELECT 
C.FechaAlta, C.Concepto, C.LCN, CD.CntPr, CD.CntCn, '', '', '', P.Denominacion,O.Usuario
,T.Cod,T.ISBN,T.NombreTitulo,TS.StkPr,TS.StkCn
FROM ComprasDetalle CD
INNER JOIN Compras C on C.Id=CD.CompraId
INNER JOIN Proveedores P on P.Id = C.ProveedorId
INNER JOIN Operadores O ON O.Id=C.OperadorAltaId
INNER JOIN Titulos T ON T.Id = CD.TituloId
INNER JOIN TitulosStock TS ON TS.TituloId = T .Id
WHERE CD.TituloId = @TituloId

-----------------------------------------------------
-------------VENTAS---------------------------------
-----------------------------------------------------
INSERT INTO @Movimientos
SELECT
V.FechaAlta, V.Concepto, V.LCN, VD.CantidadPropia, VD.CantidadConsig, 
(Abs(VD.CantidadPropia - VD.CantidadConsig)  - VD.CantidadAuditada),''
--VD.CantidadAuditada
, C.Denominacion, '', O.Usuario
,'','','','',''
FROM VentasDetalle VD
INNER JOIN Ventas V on V.Id = VD.VentaId
INNER JOIN Clientes C on C.Id = V.ClienteId
INNER JOIN Operadores O ON O.Id=V.OperadorAltaId
where VD.TituloId = @TituloId

-----------------------------------------------------
-------------CONSIGNA CLIENTE -----------------------
-----------------------------------------------------
INSERT INTO @Movimientos
SELECT --*
RV.FechaAlta, RV.Concepto, RV.LCN, RVD.CntPr, RVD.CntCn, RVD.CntDevuelta, rvd.CntVendida,C.Denominacion, '', O.Usuario
--CntPr as Propio, CntCn as Consignado 
,'','','','',''
FROM RemitosVentaDetalle RVD
INNER JOIN RemitosVenta RV on RV.Id = RVD.RemitoVentaId
INNER JOIN Clientes C on C.Id = RV.ClienteId
INNER JOIN Operadores O ON O.Id=RV.OperadorAltaId
where RVD.TituloId = @TituloId

-----------------------------------------------------
-------------DEVOLUCION CONSIGNA A PROVEEDOR -----------------------
-----------------------------------------------------
INSERT INTO @Movimientos
SELECT --*
TCD.FechaAlta, 'Consigna devuelta a proveedor', TCD.LCN, ISNULL(TCDD.CantidadPropia,0), TCDD.Cantidad, '', '','', P.Denominacion, O.Usuario
--CntPr as Propio, CntCn as Consignado 
,'','','','',''
FROM TitulosConsignacionesDevueltasDetalles TCDD

INNER JOIN TitulosConsignacionesDevueltas TCD on TCD.Id = TCDD.TituloConsignacionDevueltaId
INNER JOIN Proveedores P on P.Id = TCD.ProveedorId
INNER JOIN Operadores O ON O.Id=TCD.OperadorAltaId
where TCDD.TituloId = @TituloId


SELECT * 
FROM @Movimientos
ORDER BY Fecha 