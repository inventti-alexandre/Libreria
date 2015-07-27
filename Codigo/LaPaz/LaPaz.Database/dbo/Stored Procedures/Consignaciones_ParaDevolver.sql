CREATE PROCEDURE Consignaciones_ParaDevolver
	@ProveedorId uniqueidentifier = null,
	@Desde datetime,
	@Hasta datetime
AS
BEGIN
	WITH TituloCTE (Editorial, TituloId, NombreTitulo, Autor, Codigo, CantidadSinRendir)
	AS
	(
		SELECT 
			E.Nombre,
			T.Id,
			T.NombreTitulo,
			A.Nombre,
			T.Cod,
			SUM(ISNULL(TC.CntCn, 0) - ISNULL(TC.CntVn, 0) - ISNULL(TC.CntDev, 0))
		FROM TitulosConsignaciones TC
			LEFT JOIN Titulos T
				ON TC.TituloId = T.Id
			LEFT JOIN Autores A
				ON T.AutorId = A.Id
			LEFT JOIN Editoriales E
				ON T.EditorialId = E.Id	
		WHERE TC.ProveedorId = @ProveedorId
			AND @Desde < TC.FechaAlta
			AND @Hasta > TC.FechaAlta
		GROUP BY T.Id, E.Nombre, T.NombreTitulo, A.Nombre, T.Cod
	)
	
	SELECT *
	FROM TituloCTE
	WHERE CantidadSinRendir > 0
	
END