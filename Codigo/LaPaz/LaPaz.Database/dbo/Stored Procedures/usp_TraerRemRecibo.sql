CREATE PROCEDURE [dbo].[usp_TraerRemRecibo]
	@ComprasId uniqueidentifier
AS

SET NOCOUNT ON
SET TRANSACTION ISOLATION LEVEL READ COMMITTED

SELECT     dbo.Compras.LCN AS flcn, dbo.Compras.Concepto, dbo.Proveedores.Id, dbo.Compras.FechaComprobante AS Fecha, dbo.Compras.FechaAlta AS FeGr, 
                      0 AS nSena, dbo.Compras.ImporteNeto AS nTotal, 0 AS nTotPag, dbo.Titulos.Cod AS Codigo, dbo.Titulos.NombreTitulo AS DescLibro, 
                      dbo.Autores.Nombre AS Autor, dbo.ComprasDetalle.CntPr, dbo.ComprasDetalle.CntCn, dbo.ComprasDetalle.PrecioCompra AS PrcCmp, '' AS NcId, 
                      dbo.Proveedores.Denominacion, '' AS NcLcn, dbo.Compras.EstadoCompraId, dbo.Compras.FechaModificacion, dbo.Titulos.Id AS TituloId, 
                      dbo.Proveedores.Cuenta AS CuentaId, dbo.Proveedores.SucursalAltaId AS CuentaSuc, dbo.ComprasDetalle.PrecioVenta AS PrcVta, 
                      dbo.Compras.Observaciones AS Coment, dbo.RemitosCompra.LCN AS rLcn
FROM         dbo.RemitosCompra RIGHT OUTER JOIN
                      dbo.Compras INNER JOIN
                      dbo.ComprasDetalle ON dbo.Compras.Id = dbo.ComprasDetalle.CompraId INNER JOIN
                      dbo.Proveedores ON dbo.Compras.ProveedorId = dbo.Proveedores.Id INNER JOIN
                      dbo.Titulos ON dbo.ComprasDetalle.TituloId = dbo.Titulos.Id INNER JOIN
                      dbo.Autores ON dbo.Titulos.AutorId = dbo.Autores.Id ON dbo.RemitosCompra.CompraId = dbo.Compras.Id
WHERE dbo.Compras.Id = @ComprasId
