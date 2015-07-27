CREATE PROCEDURE Consignaciones_VentasSinRendir
	@ProveedorId uniqueidentifier = null,
	@Desde datetime,
	@Hasta datetime
AS
BEGIN
	WITH TituloCTE (Editorial, TituloId, NombreTitulo, Autor, Codigo, 
					PrecioVentaTitulo, PrecioCompraTitulo, CantidadSinRendir)
	AS
	(
		SELECT 
			E.Nombre,
			T.Id,
			T.NombreTitulo,
			A.Nombre,
			T.Cod,
			T.PrecioVentaTitulo,
			T.PrecioCompraTitulo,
			SUM(ISNULL(TCV.CntCn, 0) - ISNULL(TCV.CntPag, 0))
		FROM TitulosConsignacionesVendidas TCV
			LEFT JOIN Titulos T
				ON TCV.TituloId = T.Id
			LEFT JOIN Autores A
				ON T.AutorId = A.Id
			LEFT JOIN Editoriales E
				ON T.EditorialId = E.Id	
		WHERE TCV.ProveedorId = @ProveedorId
			AND @Desde < TCV.FechaAlta
			AND @Hasta > TCV.FechaAlta
		GROUP BY T.Id, E.Nombre, T.NombreTitulo, A.Nombre, T.Cod, 
				T.PrecioVentaTitulo, T.PrecioCompraTitulo
	)
	
	SELECT *
	FROM TituloCTE
	WHERE CantidadSinRendir > 0
	
END