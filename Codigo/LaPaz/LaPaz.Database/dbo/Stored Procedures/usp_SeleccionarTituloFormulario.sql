

CREATE PROCEDURE [dbo].[usp_SeleccionarTituloFormulario]
	@Todo as nvarchar(1),
	@Proveedor int,
	@NumeroTitulo nvarchar(13),
	@Codigo nvarchar(17),
	@Titulo nvarchar(50),
	@Autor nvarchar(30),
	@CodigoBarra nvarchar(13),
	@Tema as int,
	@Subtema as int,
	@Editorial as int,
	@ISBN as nvarchar(15),
	@ControlStock as int
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
WHERE (Proveedores.Cuenta = @Proveedor OR @Proveedor = 0) 
	AND (Titulos.Cod LIKE @Todo + '____' + @NumeroTitulo + '%')
	AND (Titulos.Cod = @Codigo OR @Codigo = '')
	AND (Titulos.NombreTitulo LIKE @Todo + @Titulo + '%')
	AND (Autores.Nombre LIKE @Todo + @Autor + '%')
	AND (Titulos.CodigoBarra=@CodigoBarra OR @CodigoBarra='')
	AND (Titulos.TemaId = @Tema OR @Tema = 0) 
	AND (Titulos.SubtemaId = @Subtema OR @Subtema = 0) 
	AND (Titulos.ISBN = @ISBN OR @ISBN = '')
	AND (Titulos.nControl = @ControlStock OR @ControlStock = 0) 
ORDER BY Titulos.NombreTitulo

--SELECT l.Cod, l.Titulo, l.Autor, l.nProv, l.PrcVta1, l.PrcComp, l.rEditorial,  l.rParte, l.nUbi, l.ModoStock 
