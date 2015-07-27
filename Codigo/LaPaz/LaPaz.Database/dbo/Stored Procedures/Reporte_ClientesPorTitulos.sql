-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Reporte_ClientesPorTitulos]
	@TituloId uniqueidentifier,
	@FechaDesde Datetime2,
	@FechaHasta DATETIME2,
	@SucursalId INT
AS
BEGIN
	
	SELECT 
		T.Id,
		T.NombreTitulo,
		V.FechaAlta,
		NombreCliente = C.Denominacion,
		C.CUIT,
		Cantidad = SUM(ISNULL(VD.CantidadConsig, 0) + ISNULL(VD.CantidadPropia, 0)),
		Precio = SUM(ISNULL(VD.Precio, 0)),
		C.Telefono,
		v.NumeroComprobante
	FROM TITULOS T INNER JOIN VENTASDETALLE VD 
		ON T.Id = VD.TituloId INNER JOIN VENTAS V
		ON VD.VentaId = V.Id INNER JOIN CLIENTES C
		ON V.ClienteId = C.Id
	WHERE V.SucursalAltaId = @SucursalId AND
		V.EstadoVentaId <> 2 AND
		T.Id = @TituloId AND
		V.FechaAlta > @FechaDesde AND
		V.FechaAlta < @FechaHasta
	GROUP BY T.Id, T.NombreTitulo, V.FechaAlta, C.Denominacion, C.CUIT, C.Telefono, V.NumeroComprobante
	ORDER BY V.FechaAlta DESC
END