

CREATE PROCEDURE [dbo].[usp_SeleccionarTituloFormularioCB]
	@CodigoBarra nvarchar(13)
AS

SET NOCOUNT OFF
--SET TRANSACTION ISOLATION LEVEL READ COMMITTED

/*Creo la consulta para seleccionar registros a la tabla temporal*/
SELECT Titulos.Cod AS Cod, Titulos.NombreTitulo AS Titulo, Autores.Nombre AS Autor, Proveedores.Cuenta AS nProv, 
		Titulos.PrecioVentaTitulo as PrcVta1, Titulos.PrecioCompraTitulo AS PrcComp, Editoriales.Nombre AS rEditorial,  
		TitulosPartes.Nombre AS rParte, Titulos.UbicacionId AS nUbi, Titulos.ModoStockId as ModoStock, Titulos.Id
FROM  Titulos
	LEFT OUTER JOIN Autores ON Titulos.AutorId = Autores.Id 
	LEFT OUTER JOIN Proveedores ON Titulos.ProveedorId = Proveedores.Id 
	LEFT OUTER JOIN Editoriales ON Titulos.EditorialId = Editoriales.Id 
	LEFT OUTER JOIN TitulosPartes ON Titulos.PartesId = TitulosPartes.Id 
	LEFT OUTER JOIN TitulosUbicacion ON Titulos.UbicacionId = TitulosUbicacion.Id 
WHERE  (Titulos.CodigoBarra = @CodigoBarra OR @CodigoBarra='')
ORDER BY Titulos.NombreTitulo

--SELECT l.Cod, l.Titulo, l.Autor, l.nProv, l.PrcVta1, l.PrcComp, l.rEditorial,  l.rParte, l.nUbi, l.ModoStock 
