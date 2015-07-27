





-- =============================================
-- Author:		<Avanic>
-- Description:	<Selección de Titulos desde grilla principal>
-- =============================================
CREATE PROCEDURE [dbo].[usp_SeleccionarTitulosCB]
	@CodigoBarra nvarchar(13),
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
		WHERE (Titulos.CodigoBarra = @CodigoBarra OR @CodigoBarra='')
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
			WHERE (Titulos.CodigoBarra = @CodigoBarra OR @CodigoBarra='')
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
			WHERE (Titulos.CodigoBarra = @CodigoBarra OR @CodigoBarra='')			
			ORDER BY dbo.Titulos.NombreTitulo
		END
--





