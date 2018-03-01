	
CREATE PROCEDURE [dbo].[Reporte_Ventas]
	@SucursalId int,
	@FechaInicio datetime,
	@FechaFin datetime,
	@OperadorId uniqueidentifier = null,
	@TemaId int = null,
	@EditorialId int = null,
	@ProveedorId uniqueidentifier = null,
	@ConStockConsignado bit = null,
	@ConStockPropio bit = null
AS
BEGIN
		
		WITH VentasCTE AS
		(
			SELECT TituloId = T.Id,
				T.NombreTitulo,
				Tema = TE.Nombre,
				ISBN = T.ISBN,
				Editorial = E.Nombre,
				Proveedor = P.Denominacion,
				Operador = O.Usuario,
				CantidadPropia = SUM(ISNULL(CantidadPropia, 0)),
				CantidadConsig = SUM(ISNULL(CantidadConsig, 0)),	
				Precio = SUM(ISNULL(Precio, 0)),
				STUFF(
					(SELECT TOP 3 ', ' + C.LCN
					FROM Compras C
					INNER JOIN ComprasDetalle CD ON CD.CompraId = C.Id
					WHERE CD.TituloId = T.Id
					--INNER JOIN Titulos T1 ON T1.Id = CD.TituloId
					ORDER BY C.FechaAlta DESC
					FOR XML PATH ('')),
				1,2, '') AS Compras
			FROM VentasDetalle VD
				INNER JOIN Ventas V
					ON VD.VentaId = V.Id
				INNER JOIN Titulos T
					ON VD.TituloId = T.Id
				LEFT JOIN Temas TE
					ON T.TemaId = TE.Id
				LEFT JOIN Editoriales E
					ON T.EditorialId = E.Id
				LEFT JOIN Proveedores P
					ON T.ProveedorId = P.Id
				LEFT JOIN Operadores O
					ON V.OperadorAltaId = O.Id
			WHERE (V.FechaAlta >= @FechaInicio AND V.FechaAlta < @FechaFin)
				AND @SucursalId = V.SucursalAltaId
				AND (@OperadorId IS NULL OR @OperadorId = V.OperadorAltaId)
				AND (@ProveedorId IS NULL OR @ProveedorId = T.ProveedorId)
				AND (@TemaId IS NULL OR @TemaId = T.TemaId)
				AND (@EditorialId IS NULL OR T.EditorialId = @EditorialId)
			
				and V.EstadoVentaId=0
			GROUP BY T.Id, T.NombreTitulo, TE.Nombre, E.Nombre, P.Denominacion, O.Usuario, T.ISBN
			
		)	

		SELECT  TituloId,
				NombreTitulo,
				Tema,
				ISBN,
				Editorial,
				Proveedor,
				Operador,
				CantidadPropia,
				CantidadConsig,	
				Precio,
				Compras
				FROM VentasCTE
				
		WHERE  (@ConStockConsignado IS NULL OR @ConStockConsignado = 0 OR (@ConStockConsignado = 1 AND CantidadConsig > 0))
		   AND (@ConStockPropio IS NULL OR @ConStockPropio = 0 OR (@ConStockPropio = 1 AND CantidadPropia > 0))
		ORDER BY NombreTitulo
		
END



