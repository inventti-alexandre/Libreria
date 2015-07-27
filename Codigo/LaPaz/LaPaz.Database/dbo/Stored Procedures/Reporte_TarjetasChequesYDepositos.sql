
CREATE PROCEDURE Reporte_TarjetasChequesYDepositos
	@SucursalId int,
	@FechaInicio datetime,
	@FechaFin datetime,
	@OperadorId uniqueidentifier = null
AS
BEGIN
	DECLARE @Temp TABLE
	(
		Grupo varchar(50),
		Nombre varchar(100),
		NroComprobante varchar(50),
		Fecha datetime,
		FechaCobro datetime,
		Importe money
	)

	INSERT INTO @Temp
	SELECT 'Tarjetas',
		   T.Nombre,
		   TM.LoteCupon,
		   TM.Fecha,
		   FechaCobro = NULL,
		   TM.Importe
	FROM TarjetasMovimientos TM
		INNER JOIN Tarjetas T ON TM.TarjetaId = T.Id
	WHERE TM.SucursalAltaId = @SucursalId
		AND TM.Fecha >= @FechaInicio
		AND TM.Fecha < @FechaFin
		AND (@OperadorId IS NULL OR @OperadorId = TM.OperadorAltaId)
	ORDER BY T.Nombre
		
	
	INSERT INTO @Temp
	SELECT 'Cheques',
		   B.Nombre,
		   C.NroCheque,
		   C.Fecha,
		   C.FechaCobro,
		   C.Importe
	FROM ChequesTerceros C
		INNER JOIN Bancos B ON C.BancoId = B.Id
	WHERE C.SucursalAltaId = @SucursalId
		AND C.Fecha >= @FechaInicio
		AND C.Fecha < @FechaFin
		AND (@OperadorId IS NULL OR @OperadorId = C.OperadorAltaId)
	ORDER BY B.Nombre
		   
		   
    INSERT INTO @Temp
	SELECT 'Depósitos Bancarios',
		   C.Nombre,
		   CM.NroMovimiento,
		   CM.FechaMovimiento,
		   CM.FechaCobro,
		   CM.Credito
	FROM CuentasMovimientos CM
		INNER JOIN Cuentas C ON CM.CuentaId = C.Id
	WHERE CM.SucursalAltaId = @SucursalId
		AND CM.FechaMovimiento >= @FechaInicio
		AND CM.FechaMovimiento < @FechaFin
		AND (@OperadorId IS NULL OR @OperadorId = CM.OperadorAltaId)
	ORDER BY C.Nombre
	
	SELECT *
	FROM @Temp
END
