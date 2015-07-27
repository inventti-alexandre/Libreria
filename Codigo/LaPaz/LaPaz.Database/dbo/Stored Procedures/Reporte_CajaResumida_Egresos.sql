CREATE PROCEDURE Reporte_CajaResumida_Egresos
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
	
	INSERT INTO @Conceptos VALUES(9, 'Pago a Proveedores')
	INSERT INTO @Conceptos VALUES(21, 'Pago de Gastos')
	INSERT INTO @Conceptos VALUES(12, 'Notas de Crédito')
	INSERT INTO @Conceptos VALUES(26, 'Anulacion Fact. CtaCte')
	INSERT INTO @Conceptos VALUES(16, 'Anulación de Señas')
	INSERT INTO @Conceptos VALUES(27, 'Anulación Fact. Contado')
	INSERT INTO @Conceptos VALUES(31, 'Depósitos con Caja Anterior')
	INSERT INTO @Conceptos VALUES(32, 'Señas a Proveedores')
	
	DECLARE @Temp TABLE 
	(
		Concepto varchar(50),
		Cantidad int,
		Total money
	)
				
	INSERT INTO @Temp
	SELECT C.Nombre,
			COUNT(*),
			SUM(CM.Importe)
	FROM CajasMovimientos CM
		LEFT JOIN @Conceptos C
			ON CM.TipoMovimientoCajaId = C.Id
	WHERE (CM.TipoMovimientoCajaId = 9
			OR CM.TipoMovimientoCajaId = 21
			OR CM.TipoMovimientoCajaId = 12
			OR CM.TipoMovimientoCajaId = 26
			OR CM.TipoMovimientoCajaId = 16
			OR CM.TipoMovimientoCajaId = 27
			OR CM.TipoMovimientoCajaId = 31
			OR CM.TipoMovimientoCajaId = 32)
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