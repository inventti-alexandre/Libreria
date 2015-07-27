





-- =============================================
-- Author:		<Avanic>
-- Description:	<Selección de Titulos desde grilla principal>
-- =============================================
create PROCEDURE [dbo].[usp_SeleccionarTitulos]
	@Todo as nvarchar(1),
	@Proveedor int,
	@NumeroTitulo nvarchar(13),
	@Codigo nvarchar(17),
	@Titulo nvarchar(50),
	@Autor nvarchar(30),
	@Stock int
AS

SET NOCOUNT ON
SET TRANSACTION ISOLATION LEVEL READ COMMITTED

IF @Stock = 1
	BEGIN
		SELECT     dbo.Titulos.Id, dbo.Titulos.Cod, dbo.Titulos.NombreTitulo AS Titulo, dbo.Autores.Nombre AS Autor, dbo.Titulos.PrecioVentaTitulo AS PrcVta1, dbo.Titulos.ISBN, 
							  dbo.Editoriales.Nombre AS cEdi, dbo.Titulos.nControl, dbo.Titulos.Encuad, dbo.Titulos.UbicacionId AS nUbi, dbo.Titulos.FUltVta, dbo.Titulos.Fingreso, 
							  dbo.Proveedores.Cuenta AS nProv, dbo.Proveedores.Denominacion AS cProv, dbo.Titulos.PesoTitulo AS dePeso, 
							  dbo.Titulos.PrecioCompraTitulo AS PrcComp, dbo.TitulosPartes.Nombre AS rParte, dbo.TitulosModoStock.Nombre AS ModoStock, 
							  dbo.Titulos.CodigoBarra AS CodBarra, dbo.Titulos.FechaAlta AS FeGr, dbo.Operadores.Usuario AS OpeGr, 
							  (SELECT SUM(dbo.TitulosStock.stkPr + dbo.TitulosStock.stkCn) FROM dbo.TitulosStock WHERE dbo.TitulosStock.TituloId = dbo.Titulos.Id) AS Stock
		FROM         dbo.Titulos LEFT OUTER JOIN
							  dbo.Operadores ON dbo.Titulos.OperadorModificacionId = dbo.Operadores.Id AND dbo.Titulos.OperadorAltaId = dbo.Operadores.Id LEFT OUTER JOIN
							  dbo.Proveedores ON dbo.Titulos.ProveedorId = dbo.Proveedores.Id LEFT OUTER JOIN
							  dbo.TitulosModoStock ON dbo.Titulos.ModoStockId = dbo.TitulosModoStock.Id LEFT OUTER JOIN
							  dbo.TitulosPartes ON dbo.Titulos.PartesId = dbo.TitulosPartes.Id LEFT OUTER JOIN
							  dbo.Editoriales ON dbo.Titulos.EditorialId = dbo.Editoriales.Id LEFT OUTER JOIN
							  dbo.Autores ON dbo.Titulos.AutorId = dbo.Autores.Id
		WHERE (dbo.Proveedores.Cuenta = @Proveedor OR @Proveedor = -1) 
			AND (dbo.Titulos.Cod LIKE @Todo + '____' + @NumeroTitulo + '%')
			AND (dbo.Titulos.Cod = @Codigo OR @Codigo = '')
			AND (dbo.Titulos.NombreTitulo LIKE @Todo + @Titulo + '%')
			AND (dbo.Autores.Nombre LIKE @Todo + @Autor + '%')
			AND ISNULL((SELECT SUM(dbo.TitulosStock.stkPr + dbo.TitulosStock.stkCn) FROM dbo.TitulosStock WHERE dbo.TitulosStock.TituloId = dbo.Titulos.Id), 0) > 0
		ORDER BY dbo.Titulos.NombreTitulo
	END
ELSE 
	IF @Stock = 0
		BEGIN
			SELECT     dbo.Titulos.Id,dbo.Titulos.Cod, dbo.Titulos.NombreTitulo AS Titulo, dbo.Autores.Nombre AS Autor, dbo.Titulos.PrecioVentaTitulo AS PrcVta1, dbo.Titulos.ISBN, 
								  dbo.Editoriales.Nombre AS cEdi, dbo.Titulos.nControl, dbo.Titulos.Encuad, dbo.Titulos.UbicacionId AS nUbi, dbo.Titulos.FUltVta, dbo.Titulos.Fingreso, 
								  dbo.Proveedores.Cuenta AS nProv, dbo.Proveedores.Denominacion AS cProv, dbo.Titulos.PesoTitulo AS dePeso, 
								  dbo.Titulos.PrecioCompraTitulo AS PrcComp, dbo.TitulosPartes.Nombre AS rParte, dbo.TitulosModoStock.Nombre AS ModoStock, 
								  dbo.Titulos.CodigoBarra AS CodBarra, dbo.Titulos.FechaAlta AS FeGr, dbo.Operadores.Usuario AS OpeGr, 
								  (SELECT SUM(dbo.TitulosStock.stkPr + dbo.TitulosStock.stkCn) FROM dbo.TitulosStock WHERE dbo.TitulosStock.TituloId = dbo.Titulos.Id) AS Stock
			FROM         dbo.Titulos LEFT OUTER JOIN
								  dbo.Operadores ON dbo.Titulos.OperadorModificacionId = dbo.Operadores.Id AND dbo.Titulos.OperadorAltaId = dbo.Operadores.Id LEFT OUTER JOIN
								  dbo.Proveedores ON dbo.Titulos.ProveedorId = dbo.Proveedores.Id LEFT OUTER JOIN
								  dbo.TitulosModoStock ON dbo.Titulos.ModoStockId = dbo.TitulosModoStock.Id LEFT OUTER JOIN
								  dbo.TitulosPartes ON dbo.Titulos.PartesId = dbo.TitulosPartes.Id LEFT OUTER JOIN
								  dbo.Editoriales ON dbo.Titulos.EditorialId = dbo.Editoriales.Id LEFT OUTER JOIN
								  dbo.Autores ON dbo.Titulos.AutorId = dbo.Autores.Id
			WHERE (dbo.Proveedores.Cuenta = @Proveedor OR @Proveedor = -1) 
				AND (dbo.Titulos.Cod LIKE @Todo + '____' + @NumeroTitulo + '%')
				AND (dbo.Titulos.Cod = @Codigo OR @Codigo = '')
				AND (dbo.Titulos.NombreTitulo LIKE @Todo + @Titulo + '%')
				AND (dbo.Autores.Nombre LIKE @Todo + @Autor + '%')
				AND ISNULL((SELECT SUM(dbo.TitulosStock.stkPr + dbo.TitulosStock.stkCn) FROM dbo.TitulosStock WHERE dbo.TitulosStock.TituloId = dbo.Titulos.Id), 0) = 0	
			ORDER BY dbo.Titulos.NombreTitulo
		END
	ELSE
		BEGIN
			SELECT    dbo.Titulos.Id, dbo.Titulos.Cod, dbo.Titulos.NombreTitulo AS Titulo, dbo.Autores.Nombre AS Autor, dbo.Titulos.PrecioVentaTitulo AS PrcVta1, dbo.Titulos.ISBN, 
								  dbo.Editoriales.Nombre AS cEdi, dbo.Titulos.nControl, dbo.Titulos.Encuad, dbo.Titulos.UbicacionId AS nUbi, dbo.Titulos.FUltVta, dbo.Titulos.Fingreso, 
								  dbo.Proveedores.Cuenta AS nProv, dbo.Proveedores.Denominacion AS cProv, dbo.Titulos.PesoTitulo AS dePeso, 
								  dbo.Titulos.PrecioCompraTitulo AS PrcComp, dbo.TitulosPartes.Nombre AS rParte, dbo.TitulosModoStock.Nombre AS ModoStock, 
								  dbo.Titulos.CodigoBarra AS CodBarra, dbo.Titulos.FechaAlta AS FeGr, dbo.Operadores.Usuario AS OpeGr, 
								  (SELECT SUM(dbo.TitulosStock.stkPr + dbo.TitulosStock.stkCn) FROM dbo.TitulosStock WHERE dbo.TitulosStock.TituloId = dbo.Titulos.Id) AS Stock
			FROM         dbo.Titulos LEFT OUTER JOIN
								  dbo.Operadores ON dbo.Titulos.OperadorModificacionId = dbo.Operadores.Id AND dbo.Titulos.OperadorAltaId = dbo.Operadores.Id LEFT OUTER JOIN
								  dbo.Proveedores ON dbo.Titulos.ProveedorId = dbo.Proveedores.Id LEFT OUTER JOIN
								  dbo.TitulosModoStock ON dbo.Titulos.ModoStockId = dbo.TitulosModoStock.Id LEFT OUTER JOIN
								  dbo.TitulosPartes ON dbo.Titulos.PartesId = dbo.TitulosPartes.Id LEFT OUTER JOIN
								  dbo.Editoriales ON dbo.Titulos.EditorialId = dbo.Editoriales.Id LEFT OUTER JOIN
								  dbo.Autores ON dbo.Titulos.AutorId = dbo.Autores.Id
			WHERE (dbo.Proveedores.Cuenta = @Proveedor OR @Proveedor = -1) 
				AND (dbo.Titulos.Cod LIKE @Todo + '____' + @NumeroTitulo + '%')
				AND (dbo.Titulos.Cod = @Codigo OR @Codigo = '')
				AND (dbo.Titulos.NombreTitulo LIKE @Todo + @Titulo + '%')
				AND (dbo.Autores.Nombre LIKE @Todo + @Autor + '%')				
			ORDER BY dbo.Titulos.NombreTitulo
		END
--





