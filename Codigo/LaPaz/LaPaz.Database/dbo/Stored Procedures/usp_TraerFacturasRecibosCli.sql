CREATE PROCEDURE [dbo].[usp_TraerFacturasRecibosCli] 
	@ClienteId uniqueidentifier

AS

SET NOCOUNT ON

SELECT     dbo.Ventas.LCN, dbo.Ventas.Concepto, dbo.Clientes.Id, dbo.Ventas.FechaComprobante AS Fecha, dbo.Ventas.FechaAlta AS FeGr, 
                      dbo.Ventas.ImporteSena AS nSena, dbo.Ventas.TotalPagado AS nTotPag, dbo.Ventas.ImporteNeto AS nTotal, dbo.NotasDeVenta.Id AS NcId, 
                      dbo.Clientes.Denominacion AS ClienteNombre, dbo.NotasDeVenta.LCN AS NcLcn, dbo.Ventas.EstadoVentaId, dbo.Ventas.FechaModificacion, 
                      dbo.Sucursales.Nombre AS Sucursal, 
					'VentaId' = CASE 
														wHEN  dbo.NotasDeVenta.LCN is null  THEN dbo.ventas.Id 
										WHEN len(dbo.NotasDeVenta.LCN) > 0 THEN dbo.NotasDeVenta.Id
										END  
--dbo.Ventas.Id AS VentaId
FROM         dbo.Ventas INNER JOIN
                      dbo.Clientes ON dbo.Ventas.ClienteId = dbo.Clientes.Id LEFT OUTER JOIN
                      dbo.Sucursales ON dbo.Ventas.SucursalAltaId = dbo.Sucursales.Id LEFT OUTER JOIN
                      dbo.NotasDeVenta ON dbo.Ventas.Id = dbo.NotasDeVenta.ComprobanteId

WHERE  Clientes.Id=@ClienteId and dbo.ventas.comprobanteid=7 and  dbo.Ventas.Concepto <> 'Factura Anulada' 
order by dbo.Ventas.FechaComprobante desc