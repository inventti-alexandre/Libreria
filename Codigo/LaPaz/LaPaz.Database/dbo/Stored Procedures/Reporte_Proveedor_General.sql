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
	--INSERT INTO @Conceptos VALUES(8, 'Consignacion')

	
	DECLARE @Temp TABLE 
	(
		Concepto varchar(50),
		Cantidad int,
		Total money,
		Tipo int
	)
				
	INSERT INTO @Temp
	SELECT C.Concepto,
			COUNT(*),
			SUM(C.ImporteNeto),
			C.TipoComprobanteId
	FROM Compras C
	WHERE (C.TipoComprobanteId = 29
			OR C.TipoComprobanteId = 2
			OR C.TipoComprobanteId = 8
		)
			AND C.FechaAlta >= @FechaInicio
			AND C.FechaAlta < @FechaFin
			AND C.SucursalAltaId = @SucursalId
			AND C.ProveedorId = @ProveedorId
	GROUP BY C.Concepto, c.TipoComprobanteId
		
	SELECT C.Nombre,
		   Cantidad = ISNULL(CTE.Cantidad, 0),
		   Total = ISNULL(CTE.Total, 0)
	FROM @Conceptos C
		LEFT JOIN @Temp CTE
			ON C.Id = CTE.tipo
END

