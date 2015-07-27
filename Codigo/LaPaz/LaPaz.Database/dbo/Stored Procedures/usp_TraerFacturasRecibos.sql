-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_TraerFacturasRecibos] 
	@VentasId uniqueidentifier

AS

SET NOCOUNT ON
SELECT     dbo.Ventas.LCN, dbo.Ventas.Concepto, dbo.Clientes.Id, dbo.Ventas.FechaComprobante AS Fecha, dbo.Ventas.FechaAlta AS FeGr, 
                      dbo.Ventas.ImporteSena AS nSena, dbo.Ventas.TotalPagado AS nTotPag, dbo.Ventas.ImporteNeto AS nTotal, dbo.Titulos.Cod AS codigo, 
                      dbo.Titulos.NombreTitulo AS DescLibro, dbo.Autores.Nombre AS Autor, dbo.VentasDetalle.CantidadPropia AS CntPr, 
                      dbo.VentasDetalle.CantidadConsig AS CntCn, dbo.VentasDetalle.Precio, dbo.NotasDeVenta.Id AS NcId, dbo.Clientes.Denominacion AS ClienteNombre, 
                      dbo.NotasDeVenta.LCN AS NcLcn, dbo.Ventas.EstadoVentaId, dbo.Ventas.FechaModificacion, dbo.VentasDetalle.TituloId, dbo.Clientes.Domicilio, 
                      dbo.Clientes.Cuit, dbo.Localidades.Nombre AS Localidad, dbo.Provincias.Nombre AS Provincia, dbo.CondicionesIVA.Nombre AS CondIva, 
                      dbo.Clientes.Cuenta, dbo.Ventas.FechaVencimiento, dbo.Ventas.NumeroComprobante, dbo.CajasMovimientos.Id AS CajaId, 
                      dbo.Ventas.SucursalAltaId, dbo.VentasDetalle.PrecioBase, dbo.VentasDetalle.Descuento
FROM         dbo.VentasDetalle INNER JOIN
                      dbo.Ventas ON dbo.VentasDetalle.VentaId = dbo.Ventas.Id INNER JOIN
                      dbo.Clientes ON dbo.Ventas.ClienteId = dbo.Clientes.Id INNER JOIN
                      dbo.Titulos ON dbo.VentasDetalle.TituloId = dbo.Titulos.Id INNER JOIN
                      dbo.Autores ON dbo.Titulos.AutorId = dbo.Autores.Id INNER JOIN
                      dbo.Provincias ON dbo.Clientes.ProvinciaId = dbo.Provincias.Id INNER JOIN
                      dbo.Localidades ON dbo.Clientes.LocalidadId = dbo.Localidades.Id INNER JOIN
                      dbo.CondicionesIVA ON dbo.Clientes.CondicionIvaId = dbo.CondicionesIVA.Id LEFT OUTER JOIN
                      dbo.CajasMovimientos ON dbo.Ventas.Id = dbo.CajasMovimientos.ComprobanteId LEFT OUTER JOIN
                      dbo.NotasDeVenta ON dbo.Ventas.Id = dbo.NotasDeVenta.ComprobanteId
WHERE  Ventas.Id=@VentasId