

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_TraerNotaDeVenta] 
	@NotaDeVentaId uniqueidentifier

AS

SET NOCOUNT ON

SELECT     dbo.NotasDeVenta.LCN, dbo.NotasDeVenta.Concepto, dbo.Clientes.Id, dbo.NotasDeVenta.FechaNotaVenta AS Fecha, 
                      dbo.NotasDeVenta.FechaAlta AS FeGr, 0 AS nSena, 0 AS nTotPag, dbo.NotasDeVenta.ImporteNeto AS nTotal, dbo.Titulos.Cod AS codigo, 
                      dbo.Titulos.NombreTitulo AS DescLibro, dbo.Autores.Nombre AS Autor, dbo.NotasDeVentaDetalle.CantidadPropia AS CntPr, 
                      dbo.NotasDeVentaDetalle.CantidadConsig AS CntCn, dbo.NotasDeVentaDetalle.Precio, dbo.NotasDeVentaDetalle.Id AS NcId, 
                      dbo.Clientes.Denominacion AS ClienteNombre, dbo.NotasDeVenta.LCN AS NcLcn, dbo.NotasDeVenta.EstadoVentaId, 
                      dbo.NotasDeVenta.FechaModificacion, dbo.NotasDeVentaDetalle.TituloId, dbo.Clientes.Domicilio, dbo.Clientes.Cuit, 
                      dbo.Localidades.Nombre AS Localidad, dbo.Provincias.Nombre AS Provincia, dbo.CondicionesIVA.Nombre AS CondIva, dbo.Clientes.Cuenta, 
                      dbo.NotasDeVenta.FechaNotaVenta AS FechaVencimeinto, dbo.NotasDeVenta.NumeroComprobante, dbo.CajasMovimientos.Id AS CajaId, 
                      dbo.NotasDeVenta.SucursalAltaId, dbo.NotasDeVentaDetalle.Precio AS PrecioBase, 0 AS descuento, 
                      dbo.NotasDeVenta.ComprobanteId AS VentaId
FROM         dbo.NotasDeVentaDetalle INNER JOIN
                      dbo.NotasDeVenta ON dbo.NotasDeVentaDetalle.NotaDeVentaId = dbo.NotasDeVenta.Id INNER JOIN
                      dbo.Clientes ON dbo.NotasDeVenta.ClienteId = dbo.Clientes.Id INNER JOIN
                      dbo.Titulos ON dbo.NotasDeVentaDetalle.TituloId = dbo.Titulos.Id INNER JOIN
                      dbo.Autores ON dbo.Titulos.AutorId = dbo.Autores.Id INNER JOIN
                      dbo.Provincias ON dbo.Clientes.ProvinciaId = dbo.Provincias.Id INNER JOIN
                      dbo.Localidades ON dbo.Clientes.LocalidadId = dbo.Localidades.Id INNER JOIN
                      dbo.CondicionesIVA ON dbo.Clientes.CondicionIvaId = dbo.CondicionesIVA.Id LEFT OUTER JOIN
                      dbo.CajasMovimientos ON dbo.NotasDeVenta.Id = dbo.CajasMovimientos.ComprobanteId
WHERE  dbo.NotasDeVenta.Id=@NotaDeVentaId


--LEFT OUTER JOIN
--ClientesCuentasCorriente ON Ventas.Id = ClientesCuentasCorriente.VentaId
---Presupuestos
