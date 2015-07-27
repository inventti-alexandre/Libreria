
CREATE VIEW [dbo].[vRemitosVentaDetalle]
AS
SELECT     dbo.RemitosVenta.Id, dbo.RemitosVenta.LCN AS rLCN, dbo.Clientes.Id AS ClienteId, dbo.Clientes.Cuenta, dbo.RemitosVenta.Concepto, 
                      dbo.RemitosVenta.FechaEmision, dbo.RemitosVenta.FechaComprobante AS Fecha, dbo.RemitosVenta.FechaVencimiento AS FVtoCons, 
                      dbo.RemitosVenta.TipoComprobante AS CompTipo, dbo.RemitosVenta.ImporteNeto AS TotFac, dbo.RemitosVenta.ImporteIVA AS nIVA, 
                      dbo.RemitosVenta.Observaciones AS Coment, dbo.Titulos.Cod AS codigo, dbo.Titulos.NombreTitulo AS DescLibro, dbo.Autores.Nombre AS Autor, 
                      dbo.RemitosVentaDetalle.CntPr, dbo.RemitosVentaDetalle.CntCn, dbo.RemitosVentaDetalle.PrecioCompra AS PrcCmp, 
                      dbo.RemitosVentaDetalle.PrecioVenta AS PrcVta, dbo.Clientes.Denominacion, dbo.Clientes.Cuit, dbo.Clientes.Domicilio, dbo.Clientes.Telefono, 
                      dbo.Localidades.Nombre AS rLoca, dbo.Provincias.Nombre AS rProv, dbo.RemitosVenta.FechaVencimiento AS FVtoCnCli
FROM         dbo.Localidades RIGHT OUTER JOIN
                      dbo.Provincias RIGHT OUTER JOIN
                      dbo.Autores RIGHT OUTER JOIN
                      dbo.RemitosVenta INNER JOIN
                      dbo.RemitosVentaDetalle ON dbo.RemitosVenta.Id = dbo.RemitosVentaDetalle.RemitoVentaId INNER JOIN
                      dbo.Titulos ON dbo.RemitosVentaDetalle.TituloId = dbo.Titulos.Id LEFT OUTER JOIN
                      dbo.Clientes ON dbo.RemitosVenta.ClienteId = dbo.Clientes.Id ON dbo.Autores.Id = dbo.Titulos.AutorId ON 
                      dbo.Provincias.Id = dbo.Clientes.ProvinciaId ON dbo.Localidades.Id = dbo.Clientes.LocalidadId

