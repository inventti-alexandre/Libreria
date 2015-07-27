CREATE VIEW [dbo].[vIngresoEgresoTitulos]
AS
SELECT     TOP (100) PERCENT fc.Id, fc.CompraId, fc.TipoComprobante, fc.ProveedorId, fc.LCN AS flcn, fc.BultoId, fc.PuntoVenta, fc.NumeroComprobante, 
                      fc.Concepto, fc.FechaComprobante AS femision, fc.FechaVencimiento, fc.ImporteNeto AS totfac, fc.ImporteIVA, fc.Observaciones AS coment, fc.EstadoId, 
                      fc.FechaAlta, fc.SucursalAltaId, fc.OperadorAltaId, fc.FechaModificacion, fc.SucursalModificacionId, fc.OperadorModificacionId, fd.FacturaCompraId, 
                      fd.TituloId, fd.CntPr, fd.CntCn, fd.PrecioCompra, fd.PrecioVenta, p.Denominacion AS cprov, dbo.Autores.Nombre AS Autor, 
                      dbo.Operadores.Usuario AS opegr, l.Cod AS codigo, l.NombreTitulo AS descLibro, l.PrecioVentaTitulo AS prcvta, dbo.RemitosCompra.LCN AS rlcn
FROM         dbo.Autores INNER JOIN
                      dbo.Titulos AS l ON dbo.Autores.Id = l.AutorId RIGHT OUTER JOIN
                      dbo.FacturasComprasDetalle AS fd RIGHT OUTER JOIN
                      dbo.FacturasCompra AS fc INNER JOIN
                      dbo.Operadores ON fc.OperadorAltaId = dbo.Operadores.Id ON fd.FacturaCompraId = fc.Id ON l.Id = fd.TituloId LEFT OUTER JOIN
                      dbo.Proveedores AS p ON fc.ProveedorId = p.Id FULL OUTER JOIN
                      dbo.RemitosCompra ON fc.Id = dbo.RemitosCompra.CompraId
ORDER BY fc.Id, fd.TituloId