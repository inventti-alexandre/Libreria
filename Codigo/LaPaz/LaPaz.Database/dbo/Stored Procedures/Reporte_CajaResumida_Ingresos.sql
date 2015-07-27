CREATE PROCEDURE [dbo].[Reporte_CajaResumida_Ingresos] 
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
	INSERT INTO @Conceptos VALUES(3, 'Cobranzas')
	INSERT INTO @Conceptos VALUES(4, 'Señas')
	
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
			SUM(CM.Importe)
	FROM CajasMovimientos CM
		LEFT JOIN @Conceptos C
			ON CM.TipoMovimientoCajaId = C.Id
	WHERE (CM.TipoMovimientoCajaId = 1
			OR CM.TipoMovimientoCajaId = 2
			OR CM.TipoMovimientoCajaId = 7
			OR CM.TipoMovimientoCajaId = 3
			OR CM.TipoMovimientoCajaId = 4)
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