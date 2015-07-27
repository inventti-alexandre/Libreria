

CREATE PROCEDURE [dbo].[usp_SeleccionarTituloFormulario5]
	@Todo as nvarchar(1),
	@NumeroTitulo nvarchar(13),
	@Codigo nvarchar(17),
	@Titulo nvarchar(50),
	@Autor nvarchar(30),
	@CodigoBarra nvarchar(13),
	@ClienteId uniqueidentifier
AS

SET NOCOUNT OFF
--SET TRANSACTION ISOLATION LEVEL READ COMMITTED

/*Creo la consulta para seleccionar registros a la tabla temporal*/
SELECT Titulos.Cod AS Cod, Titulos.NombreTitulo AS Titulo, Autores.Nombre AS Autor, Proveedores.Cuenta AS nProv, 
		Titulos.PrecioVentaTitulo as PrcVta1, Titulos.PrecioCompraTitulo AS PrcComp, Editoriales.Nombre AS rEditorial,  
		TitulosPartes.Nombre AS rParte, Titulos.UbicacionId AS nUbi, Titulos.ModoStockId as ModoStock, Titulos.Id,
		TitulosConsignaciones.CntPr, TitulosConsignaciones.CntCn
FROM  TitulosConsignaciones
	LEFT OUTER JOIN Titulos ON TitulosConsignaciones.TituloId = Titulos.Id
	LEFT OUTER JOIN Autores ON Titulos.AutorId = Autores.Id 
	LEFT OUTER JOIN Proveedores ON Titulos.ProveedorId = Proveedores.Id 
	LEFT OUTER JOIN Editoriales ON Titulos.EditorialId = Editoriales.Id 
	LEFT OUTER JOIN TitulosPartes ON Titulos.PartesId = TitulosPartes.Id 
	LEFT OUTER JOIN TitulosUbicacion ON Titulos.UbicacionId = TitulosUbicacion.Id 
WHERE (Titulos.Cod LIKE @Todo + '____' + @NumeroTitulo + '%')
	AND (Titulos.Cod = @Codigo OR @Codigo = '')
	AND (Titulos.NombreTitulo LIKE @Todo + @Titulo + '%')
	AND (Autores.Nombre LIKE @Todo + @Autor + '%')
	AND (Titulos.CodigoBarra=@CodigoBarra OR @CodigoBarra='')
	AND (TitulosConsignaciones.ClienteId=@ClienteId)
ORDER BY Titulos.NombreTitulo

--  lcSql = "SELECT  c.CntPr, c.CntCn, l.Cod, l.Titulo, l.Autor, l.PrcComp  " & _
--                " FROM ( s00Consig c LEFT JOIN s00Libros l  ON (c.Cod=l.Cod )) " & _
--                fcWhere & " ORDER BY l.Titulo"