CREATE PROCEDURE [dbo].[Reporte_CajaResumida_Ventas] 
	@SucursalId int,
	@FechaInicio datetime,
	@FechaFin datetime,
	@OperadorId uniqueidentifier = null
AS
BEGIN
	
	DECLARE @Conceptos TABLE
	(
		Id int,
		Nombre varchar(50)
	)
	
	INSERT INTO @Conceptos VALUES(1, 'Ventas al Contado')
	INSERT INTO @Conceptos VALUES(2, 'Ventas Cuenta Corriente')
	INSERT INTO @Conceptos VALUES(7, 'Ventas por Consignación')
	INSERT INTO @Conceptos VALUES(12, 'Notas de Crédito (-)')
	INSERT INTO @Conceptos VALUES(27, 'Anulacion Venta Contado (-)')
	INSERT INTO @Conceptos VALUES(26, 'Anulacion Venta CtaCte (-)')
	
	DECLARE @Temp TABLE 
	(
		Concepto varchar(50),
		Cantidad int,
		Total money
	)
	
	-----------------------------------------------------------
	-------  FACTURAS VENTAS - CUENTA CORRIENTE ---------------
	-----------------------------------------------------------
			
	INSERT INTO @Temp
	SELECT C.Nombre,
			COUNT(*),
			CASE C.Nombre
				WHEN 'Notas de Crédito (-)' THEN -SUM(CM.ImpFac)
				WHEN 'Anulacion Venta Contado (-)' THEN -SUM(CM.ImpFac)
				WHEN 'Anulacion Venta CtaCte (-)' THEN -SUM(CM.ImpFac)
				ELSE SUM(CM.ImpFac)
			END
	FROM CajasMovimientos CM
		LEFT JOIN @Conceptos C
			ON CM.TipoMovimientoCajaId = C.Id
	WHERE (CM.TipoMovimientoCajaId = 1
			OR CM.TipoMovimientoCajaId = 2
			OR CM.TipoMovimientoCajaId = 7
			OR CM.TipoMovimientoCajaId = 12
			OR CM.TipoMovimientoCajaId = 27
			OR CM.TipoMovimientoCajaId = 26)
			AND CM.FechaAlta >= @FechaInicio
			AND CM.FechaAlta < @FechaFin
			AND CM.SucursalAltaId = @SucursalId
			AND (@OperadorId IS NULL OR @OperadorId = CM.OperadorAltaId)
	GROUP BY C.Nombre
	
	SELECT C.Nombre,
		   Cantidad = ISNULL(CTE.Cantidad, 0),
		   Total = ISNULL(CTE.Total, 0)
	FROM @Conceptos C
		LEFT JOIN @Temp CTE
			ON C.Nombre = CTE.Concepto
END