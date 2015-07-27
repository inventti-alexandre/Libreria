





CREATE PROCEDURE [dbo].[usp_SeleccionarTituloConsignadoCB]
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

SELECT     dbo.Titulos.Cod, dbo.Titulos.NombreTitulo AS Titulo, dbo.Autores.Nombre AS Autor, dbo.Proveedores.Cuenta AS nProv, 
                    dbo.RemitosVentaDetalle.PrecioVenta AS PrcVta1, dbo.RemitosVentaDetalle.PrecioCompra AS PrcComp, dbo.Editoriales.Nombre AS rEditorial, 
                      dbo.TitulosPartes.Nombre AS rParte, dbo.Titulos.UbicacionId AS nUbi, dbo.Titulos.ModoStockId AS ModoStock, dbo.Titulos.Id, 
                      dbo.TitulosConsignaciones.CntPr, dbo.TitulosConsignaciones.CntCn, dbo.RemitosVentaDetalle.Descuento, dbo.RemitosVentaDetalle.PrecioBase
FROM         dbo.RemitosVenta RIGHT OUTER JOIN
                      dbo.RemitosVentaDetalle ON dbo.RemitosVenta.Id = dbo.RemitosVentaDetalle.RemitoVentaId RIGHT OUTER JOIN
                      dbo.Titulos INNER JOIN
                      dbo.TitulosConsignaciones ON dbo.Titulos.Id = dbo.TitulosConsignaciones.TituloId ON 
                      dbo.RemitosVentaDetalle.TituloId = dbo.Titulos.Id LEFT OUTER JOIN
                      dbo.Autores ON dbo.Titulos.AutorId = dbo.Autores.Id LEFT OUTER JOIN
                      dbo.Proveedores ON dbo.Titulos.ProveedorId = dbo.Proveedores.Id LEFT OUTER JOIN
                      dbo.Editoriales ON dbo.Titulos.EditorialId = dbo.Editoriales.Id LEFT OUTER JOIN
                      dbo.TitulosPartes ON dbo.Titulos.PartesId = dbo.TitulosPartes.Id LEFT OUTER JOIN
                      dbo.TitulosUbicacion ON dbo.Titulos.UbicacionId = dbo.TitulosUbicacion.Id
WHERE  (Titulos.CodigoBarra = @CodigoBarra OR @CodigoBarra='')
ORDER BY Titulos.NombreTitulo

--SELECT l.Cod, l.Titulo, l.Autor, l.nProv, l.PrcVta1, l.PrcComp, l.rEditorial,  l.rParte, l.nUbi, l.ModoStock 




