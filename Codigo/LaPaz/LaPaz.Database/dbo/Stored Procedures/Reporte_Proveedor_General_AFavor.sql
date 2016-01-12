CREATE PROCEDURE [dbo].[Reporte_Proveedor_General_AFavor]
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
	
	INSERT INTO @Conceptos VALUES(37, 'Señas')
	INSERT INTO @Conceptos VALUES(41, 'Notas de Crédito')
	INSERT INTO @Conceptos VALUES(40, 'Egresos')


	DECLARE @Temp TABLE 
	(
		Concepto varchar(50),
		Cantidad int,
		Total money,
		Tipo int
	)	
	

	-----------------------------------------------------------
	------------  SEÑAS ------------------
	-----------------------------------------------------------

	INSERT INTO @Temp
	SELECT 'Señas',
			COUNT(*),
			SUM (PS.Importe - PS.ImporteUsado),
			CM.TipoComprobante
	from CajasMovimientos CM
	INNER JOIN ProveedoresSenias PS
	ON PS.Id= CM.ComprobanteId
	where CM.TipoComprobante = 37 -- SENAS A PROVEEDORES
	AND CM.FechaAlta >= @FechaInicio
	AND CM.FechaAlta < @FechaFin
	AND CM.SucursalAltaId = @SucursalId
	AND (@ProveedorId IS NULL OR @ProveedorId = PS.ProveedorId)
	GROUP BY CM.TipoComprobante

	-----------------------------------------------------------
	------------  NOTA CREDITO ------------------
	-----------------------------------------------------------

	INSERT INTO @Temp
	SELECT 'Notas de Crédito',
			COUNT(*),
			SUM(PMF.Importe - PMF.ImporteOcupado),
			PMF.TipoComprobanteId
	from ProveedoresMontosFavor PMF
	--INNER JOIN Proveedores PS
	--ON PS.Id= CM.ComprobanteId
	where PMF.TipoComprobanteId = 41 -- Nota de credito
	--AND C.ProveedorId='FB8C2F3A-E38A-4D30-A758-DAC31195CFE1' 
	AND PMF.FechaAlta >= @FechaInicio
	AND PMF.FechaAlta < @FechaFin
	AND PMF.SucursalAltaId = @SucursalId
	AND (@ProveedorId IS NULL OR @ProveedorId = PMF.ProveedorId)
	GROUP BY PMF.TipoComprobanteId

		-----------------------------------------------------------
	------------  EGRESO ------------------
	-----------------------------------------------------------

	INSERT INTO @Temp
	SELECT 'Egresos',
			COUNT(*),
			SUM(PMF.Importe - PMF.ImporteOcupado),
			PMF.TipoComprobanteId
	from ProveedoresMontosFavor PMF
	--INNER JOIN Proveedores PS
	--ON PS.Id= CM.ComprobanteId
	where PMF.TipoComprobanteId = 40 -- Egresos
	--AND C.ProveedorId='FB8C2F3A-E38A-4D30-A758-DAC31195CFE1' 
	AND PMF.FechaAlta >= @FechaInicio
	AND PMF.FechaAlta < @FechaFin
	AND PMF.SucursalAltaId = @SucursalId
	AND (@ProveedorId IS NULL OR @ProveedorId = PMF.ProveedorId)
	GROUP BY PMF.TipoComprobanteId

	SELECT C.Nombre,
		   Cantidad = ISNULL(CTE.Cantidad, 0),
		   Total = ISNULL(CTE.Total, 0)
	FROM @Conceptos C
		LEFT JOIN @Temp CTE
			ON C.Id = CTE.tipo
END
	
--RETURN 0
