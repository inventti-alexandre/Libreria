
CREATE PROCEDURE [dbo].[Reporte_CajaResumida_ComposicionEgresos] 
	@SucursalId int,
	@FechaInicio datetime,
	@FechaFin datetime,
	@OperadorId uniqueidentifier = null
AS
BEGIN
	
	SELECT Efectivo = ISNULL(SUM(CM.Efectivo), 0),
		   Tarjeta = ISNULL(SUM(CM.Tarjeta), 0),
		   Cheque = ISNULL(SUM(CM.Cheque), 0),
		   Depositos = ISNULL(SUM(CM.Deposito), 0),
		   Vales = 0
	FROM CajasMovimientos CM
	WHERE (CM.TipoMovimientoCajaId = 9
			OR CM.TipoMovimientoCajaId = 21
			OR CM.TipoMovimientoCajaId = 12
			OR CM.TipoMovimientoCajaId = 26
			OR CM.TipoMovimientoCajaId = 16
			OR CM.TipoMovimientoCajaId = 27
			OR CM.TipoMovimientoCajaId = 32)
			AND CM.FechaAlta >= @FechaInicio
			AND CM.FechaAlta < @FechaFin
			AND CM.SucursalAltaId = @SucursalId
			AND (@OperadorId IS NULL OR @OperadorId = CM.OperadorAltaId)
END