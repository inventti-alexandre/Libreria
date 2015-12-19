﻿CREATE PROCEDURE [dbo].[Reporte_MultiRanking]
	@TipoRanking VARCHAR(50),
	@SucursalId int,	
	@FechaInicio datetime,
	@FechaFin datetime,
	@CantidadFilas INT = NULL,
	@MuestraCantidad BIT,
	@TituloISBN VARCHAR(50) =null, 
	@ProveedorId uniqueidentifier = null, 
	@TemaId int =  null
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @Temp TABLE 
	(	
		Puesto INT NULL,		
		Nombre VARCHAR(100),		
		Total MONEY,
		Cantidad INT
	)

	IF (@TipoRanking = 'CLIENTES')
		BEGIN
			INSERT INTO @Temp
			SELECT ROW_NUMBER() OVER (ORDER BY 									
							CASE WHEN @MuestraCantidad = 1 THEN Cantidad END DESC,
							CASE WHEN @MuestraCantidad = 0 THEN Total END DESC) AS Puesto,AUX.Denominacion, AUX.Total,AUX.Cantidad
			FROM (SELECT C.Id, C.Denominacion, SUM(VD.Precio) AS Total,SUM(VD.CantidadPropia + VD.CantidadConsig) AS Cantidad
				FROM dbo.Clientes C INNER JOIN dbo.Ventas V 
				ON C.Id = V.ClienteId INNER JOIN dbo.VentasDetalle VD
				ON V.Id = VD.VentaId
				--si recibe titulo, proveedor, tema
				INNER JOIN dbo.Titulos T ON T.Id = VD.TituloId
				WHERE V.SucursalAltaId=@SucursalId AND
					V.FechaAlta < @FechaFin AND
					V.FechaAlta > @FechaInicio
					--si recibe titulo, proveedor, tema
					AND (@TituloISBN IS NULL OR @TituloISBN = T.ISBN)
					AND (@ProveedorId IS NULL OR @ProveedorId = T.ProveedorId)
					AND (@TemaId IS NULL OR @TemaId = T.TemaId)
				GROUP BY C.Id, C.Denominacion) AUX			
		END
	ELSE
		IF (@TipoRanking = 'TITULOS')
		BEGIN
			INSERT INTO @Temp
			SELECT ROW_NUMBER() OVER (ORDER BY 									
							CASE WHEN @MuestraCantidad = 1 THEN Cantidad END DESC,
							CASE WHEN @MuestraCantidad = 0 THEN Total END DESC) AS Puest,AUX.NombreTitulo, AUX.Total,AUX.Cantidad
			FROM (SELECT T.Id, T.NombreTitulo, SUM(VD.Precio) AS Total,SUM(VD.CantidadPropia + VD.CantidadConsig) AS Cantidad
				FROM dbo.Titulos T INNER JOIN dbo.VentasDetalle VD
				ON T.Id = VD.TituloId INNER JOIN dbo.Ventas V
				ON VD.VentaId = V.Id
					--si recibe titulo, proveedor, tema
				--INNER JOIN dbo.Titulos T ON T.Id = VD.TituloId
				WHERE V.SucursalAltaId=@SucursalId AND
					V.FechaAlta < @FechaFin AND
					V.FechaAlta > @FechaInicio
					--si recibe titulo, proveedor, tema
					AND (@TituloISBN IS NULL OR @TituloISBN = T.ISBN)
					AND (@ProveedorId IS NULL OR @ProveedorId = T.ProveedorId)
					AND (@TemaId IS NULL OR @TemaId = T.TemaId)
				GROUP BY T.Id, T.NombreTitulo) AUX			
		END	
		ELSE		
			IF (@TipoRanking = 'EDITORIALES')
			BEGIN
				INSERT INTO @Temp
				SELECT ROW_NUMBER() OVER (ORDER BY 									
							CASE WHEN @MuestraCantidad = 1 THEN Cantidad END DESC,
							CASE WHEN @MuestraCantidad = 0 THEN Total END DESC) AS Puest,AUX.Nombre, AUX.Total,AUX.Cantidad
				FROM (SELECT E.Id, E.Nombre, SUM(VD.Precio) AS Total,SUM(VD.CantidadPropia + VD.CantidadConsig) AS Cantidad
					FROM dbo.Titulos T INNER JOIN dbo.VentasDetalle VD
					ON T.Id = VD.TituloId INNER JOIN dbo.Ventas V
					ON VD.VentaId = V.Id INNER JOIN dbo.Editoriales E
					ON T.EditorialId = E.Id
						--si recibe titulo, proveedor, tema
						--INNER JOIN dbo.Titulos T ON T.Id = VD.TituloId
					WHERE V.SucursalAltaId=@SucursalId AND
						V.FechaAlta < @FechaFin AND
						V.FechaAlta > @FechaInicio
						--si recibe titulo, proveedor, tema
					AND (@TituloISBN IS NULL OR @TituloISBN = T.ISBN)
					AND (@ProveedorId IS NULL OR @ProveedorId = T.ProveedorId)
					AND (@TemaId IS NULL OR @TemaId = T.TemaId)
					GROUP BY E.Id, E.Nombre) AUX			
			END
			ELSE		
				IF (@TipoRanking = 'PROVEEDORES')
				BEGIN
					INSERT INTO @Temp
					SELECT ROW_NUMBER() OVER (ORDER BY 									
							CASE WHEN @MuestraCantidad = 1 THEN Cantidad END DESC,
							CASE WHEN @MuestraCantidad = 0 THEN Total END DESC) AS Puest,AUX.Denominacion, AUX.Total,AUX.Cantidad
					FROM (SELECT P.Id, P.Denominacion, SUM(VD.Precio) AS Total,SUM(VD.CantidadPropia + VD.CantidadConsig) AS Cantidad
						FROM dbo.Titulos T INNER JOIN dbo.VentasDetalle VD
						ON T.Id = VD.TituloId INNER JOIN dbo.Ventas V
						ON VD.VentaId = V.Id INNER JOIN dbo.Proveedores P
						ON T.ProveedorId = P.Id
							--si recibe titulo, proveedor, tema
							--INNER JOIN dbo.Titulos T ON T.Id = VD.TituloId
						WHERE V.SucursalAltaId=@SucursalId AND
							V.FechaAlta < @FechaFin AND
							V.FechaAlta > @FechaInicio
							--si recibe titulo, proveedor, tema
					AND (@TituloISBN IS NULL OR @TituloISBN = T.ISBN)
					AND (@ProveedorId IS NULL OR @ProveedorId = T.ProveedorId)
					AND (@TemaId IS NULL OR @TemaId = T.TemaId)
						GROUP BY P.Id, P.Denominacion) AUX			
				END
				ELSE		
					IF (@TipoRanking = 'TEMAS')
					BEGIN
						INSERT INTO @Temp
						SELECT ROW_NUMBER() OVER (ORDER BY 									
							CASE WHEN @MuestraCantidad = 1 THEN Cantidad END DESC,
							CASE WHEN @MuestraCantidad = 0 THEN Total END DESC) AS Puest,AUX.Nombre, AUX.Total,AUX.Cantidad
						FROM (SELECT TE.Id, TE.Nombre, SUM(VD.Precio) AS Total,SUM(VD.CantidadPropia + VD.CantidadConsig) AS Cantidad
							FROM dbo.Titulos T INNER JOIN dbo.VentasDetalle VD
							ON T.Id = VD.TituloId INNER JOIN dbo.Ventas V
							ON VD.VentaId = V.Id INNER JOIN dbo.Temas TE
							ON T.TemaId = TE.Id
								--si recibe titulo, proveedor, tema
								--INNER JOIN dbo.Titulos T ON T.Id = VD.TituloId
							WHERE V.SucursalAltaId=@SucursalId AND
								V.FechaAlta < @FechaFin AND
								V.FechaAlta > @FechaInicio
								--si recibe titulo, proveedor, tema
					AND (@TituloISBN IS NULL OR @TituloISBN = T.ISBN)
					AND (@ProveedorId IS NULL OR @ProveedorId = T.ProveedorId)
					AND (@TemaId IS NULL OR @TemaId = T.TemaId)
							GROUP BY TE.Id, TE.Nombre) AUX			
					END




SELECT 
				T.Puesto,
				T.Nombre,
				T.Cantidad,
				Precio = T.Total
FROM	@Temp T
WHERE	T.Puesto <= @CantidadFilas

END