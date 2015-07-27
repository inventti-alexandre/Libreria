
CREATE VIEW [dbo].[vControlVtasCtaCteClientes]
AS
SELECT     dbo.Ventas.Id, dbo.Ventas.LCN, dbo.Ventas.ComprobanteId, dbo.Ventas.ClienteId, dbo.Clientes.Denominacion, dbo.Ventas.ImporteNeto, 
                      dbo.Ventas.ImporteIva, dbo.Ventas.ImporteSena, dbo.Ventas.TotalPagado, dbo.Ventas.EstadoVentaId, dbo.Ventas.FechaComprobante, 
                      dbo.Operadores.Usuario, dbo.Ventas.SucursalAltaId
FROM         dbo.Ventas LEFT OUTER JOIN
                      dbo.Operadores ON dbo.Ventas.OperadorAltaId = dbo.Operadores.Id LEFT OUTER JOIN
                      dbo.Clientes ON dbo.Ventas.ClienteId = dbo.Clientes.Id

