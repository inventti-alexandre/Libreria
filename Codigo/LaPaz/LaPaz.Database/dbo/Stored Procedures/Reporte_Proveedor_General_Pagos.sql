CREATE PROCEDURE [dbo].[Reporte_Proveedor_General_Pagos]
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
	INSERT INTO @Conceptos VALUES(2, 'Anticipos Cta Cte')
	INSERT INTO @Conceptos VALUES(39, 'Pagos CtaCte/Consign.')


	DECLARE @Temp TABLE 
	(
		Concepto varchar(50),
		Cantidad int,
		Total money,
		Tipo int
	)	
	-----------------------------------------------------------
	------------  COMPRAS - CONTADO  ------------------
	-----------------------------------------------------------
			
	INSERT INTO @Temp
	SELECT 'Compras Contado',
			COUNT(*),
			--SUM(C.ImporteNeto + cm.Senia),
			SUM(CM.Importe + cm.Senia),
			C.TipoComprobanteId
	from CajasMovimientos CM
	INNER JOIN Compras C
	ON C.Id= CM.ComprobanteId
	where CM.TipoComprobante = 29 -- FAC.CPRA. CONTADO
	--AND C.ProveedorId='FB8C2F3A-E38A-4D30-A758-DAC31195CFE1' 
	AND C.FechaAlta >= @FechaInicio
	AND C.FechaAlta < @FechaFin
	AND C.SucursalAltaId = @SucursalId
	AND (@ProveedorId IS NULL OR @ProveedorId = C.ProveedorId)
	GROUP BY C.TipoComprobanteId

	-----------------------------------------------------------
	------------  COMPRAS - CUENTA CORRIENTE  ------------------
	-----------------------------------------------------------
	INSERT INTO @Temp
	SELECT 'Anticipos Cta Cte',
			COUNT(*),
			SUM(CM.Importe + cm.Senia),
			C.TipoComprobanteId
	from CajasMovimientos CM
	INNER JOIN Compras C
	ON C.Id= CM.ComprobanteId
	where CM.TipoComprobante = 2 -- FAC.CPRA. CTA CTE
	--AND C.ProveedorId='FB8C2F3A-E38A-4D30-A758-DAC31195CFE1' 
	AND C.FechaAlta >= @FechaInicio
	AND C.FechaAlta < @FechaFin
	AND C.SucursalAltaId = @SucursalId
	AND (@ProveedorId IS NULL OR @ProveedorId = C.ProveedorId)
	GROUP BY C.TipoComprobanteId

	-----------------------------------------------------------
	------------  PAGOS - CUENTA CORRIENTE - CONSIGNACIONES ------------------
	-----------------------------------------------------------

	INSERT INTO @Temp
	SELECT 'Pagos CtaCte/Consign.',
			COUNT(*),
			SUM(CM.Importe + cm.Senia),
			CM.TipoComprobante
	from CajasMovimientos CM
	INNER JOIN ProveedoresPagos PP
	ON PP.Id= CM.ComprobanteId
	where CM.TipoComprobante = 39 -- PAGO A PROVEEDORES
	--AND C.ProveedorId='FB8C2F3A-E38A-4D30-A758-DAC31195CFE1' 
	AND CM.FechaAlta >= @FechaInicio
	AND CM.FechaAlta < @FechaFin
	AND CM.SucursalAltaId = @SucursalId
	AND (@ProveedorId IS NULL OR @ProveedorId = PP.ProveedorId)
	GROUP BY CM.TipoComprobante

	
	SELECT C.Nombre,
		   Cantidad = ISNULL(CTE.Cantidad, 0),
		   Total = ISNULL(CTE.Total, 0)
	FROM @Conceptos C
		LEFT JOIN @Temp CTE
			ON C.Id = CTE.tipo
END
	
--RETURN 0
