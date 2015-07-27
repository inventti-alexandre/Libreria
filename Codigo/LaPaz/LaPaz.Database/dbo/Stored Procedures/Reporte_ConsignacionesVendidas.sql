
CREATE PROCEDURE [dbo].[Reporte_ConsignacionesVendidas]
	@SucursalId int,
	@FechaInicio datetime,
	@FechaFin datetime,
	@ProveedorId uniqueidentifier = null,
	@OperadorId uniqueidentifier = null,
	@CodProveedor int = NULL
AS
BEGIN
	WITH ConsignacionCTE (Cantidad, Codigo, NombreTitulo, PrecioCompraUnitario, PrecioCompraSubtotal, Proveedor)
	AS
	(
		SELECT SUM(TCV.CntCn) Cantidad,
			T.Cod Codigo,
			T.NombreTitulo,
			--TCV.Fecha,
			T.PrecioCompraTitulo PrecioCompraUnitario,
			PrecioCompraSubtotal = T.PrecioCompraTitulo * SUM(TCV.CntCn),
			P.Denominacion Proveedor
		FROM TitulosConsignacionesVendidas TCV
			INNER JOIN Titulos T ON TCV.TituloId = T.Id
			INNER JOIN Ventas V ON TCV.ComprobanteId = V.Id
			INNER JOIN Proveedores P ON TCV.ProveedorId = P.Id
		WHERE V.EstadoVentaId <> 2
			AND TCV.Fecha >= @FechaInicio
			AND TCV.Fecha < @FechaFin
			AND TCV.SucursalAltaId = @SucursalId
			AND (@ProveedorId IS NULL OR @ProveedorId = TCV.ProveedorId)
			AND (@OperadorId IS NULL OR @OperadorId = TCV.OperadorAltaId)
			AND (@CodProveedor IS NULL OR @CodProveedor = P.Cuenta)
		GROUP BY TCV.ProveedorId, TCV.TituloId, T.Cod, T.NombreTitulo, 
				T.PrecioCompraTitulo, TCV.CntCn, P.Denominacion
	)

	SELECT *
	FROM ConsignacionCTE
	WHERE Cantidad > 0
	ORDER BY Proveedor, NombreTitulo
	
END

