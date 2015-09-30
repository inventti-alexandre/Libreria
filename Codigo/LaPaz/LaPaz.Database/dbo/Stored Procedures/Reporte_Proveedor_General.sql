CREATE PROCEDURE [dbo].[Reporte_Proveedor_General]
	@SucursalId int,
	@FechaInicio datetime,
	@FechaFin datetime,
	@OperadorId uniqueidentifier = null,
	@ProveedorId uniqueidentifier = null
AS
BEGIN
	
	DECLARE @Conceptos TABLE
	(
		Id int,
		Nombre varchar(50)
	)
	
	INSERT INTO @Conceptos VALUES(29, 'Compras Contado')
	INSERT INTO @Conceptos VALUES(2, 'Compras Cta Cte')
	INSERT INTO @Conceptos VALUES(8, 'Consignacion')
	--INSERT INTO @Conceptos VALUES(26, 'Anulacion Fact. CtaCte')
	--INSERT INTO @Conceptos VALUES(16, 'Anulación de Señas')
	--INSERT INTO @Conceptos VALUES(27, 'Anulación Fact. Contado')
	--INSERT INTO @Conceptos VALUES(31, 'Depósitos con Caja Anterior')
	--INSERT INTO @Conceptos VALUES(32, 'Señas a Proveedores')
	
	DECLARE @Temp TABLE 
	(
		Concepto varchar(50),
		Cantidad int,
		Total money
	)
				
	INSERT INTO @Temp
	SELECT C.Concepto,
			COUNT(*),
			SUM(C.ImporteNeto)
	FROM Compras C
		--LEFT JOIN @Conceptos C
			--ON CM.TipoMovimientoCajaId = C.Id
	WHERE (C.TipoComprobanteId = 29
			OR C.TipoComprobanteId = 2
			OR C.TipoComprobanteId = 8
		--	OR CM.TipoComprobanteId = 26
		--	OR CM.TipoComprobanteId = 16
		--	OR CM.TipoComprobanteId = 27
		--	OR CM.TipoComprobanteId = 31
		--	OR CM.TipoComprobanteId = 32
		)
			AND C.FechaAlta >= @FechaInicio
			AND C.FechaAlta < @FechaFin
			AND C.SucursalAltaId = @SucursalId
			AND C.ProveedorId = @ProveedorId
			--AND (@OperadorId IS NULL OR @OperadorId = CM)
	GROUP BY C.Concepto
		
	SELECT C.Nombre,
		   Cantidad = ISNULL(CTE.Cantidad, 0),
		   Total = ISNULL(CTE.Total, 0)
	FROM @Conceptos C
		LEFT JOIN @Temp CTE
			ON C.Nombre = CTE.Concepto
END
--RETURN 0
