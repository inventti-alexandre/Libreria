CREATE VIEW [dbo].[vPresupuestoDetalle]
AS
SELECT     dbo.Presupuestos.LCN, dbo.Presupuestos.Concepto AS Cpto, dbo.Clientes.SucursalId AS CliSuc, dbo.Clientes.Cuenta AS CliCuenta, 
                      dbo.Clientes.Denominacion, dbo.Titulos.NombreTitulo AS DescLibro, dbo.Autores.Nombre AS autor, dbo.PresupuestosDetalle.Cantidad AS cnt, 
                      dbo.PresupuestosDetalle.Precio AS prc, dbo.PresupuestosDetalle.TituloId, dbo.Presupuestos.Id AS PtoId, dbo.Presupuestos.Fecha, 
                      dbo.Presupuestos.Total AS nTotal, dbo.Titulos.Cod AS Codigo
FROM         dbo.PresupuestosDetalle INNER JOIN
                      dbo.Presupuestos ON dbo.PresupuestosDetalle.PresupuestoId = dbo.Presupuestos.Id INNER JOIN
                      dbo.Titulos ON dbo.PresupuestosDetalle.TituloId = dbo.Titulos.Id INNER JOIN
                      dbo.Autores ON dbo.Titulos.AutorId = dbo.Autores.Id LEFT OUTER JOIN
                      dbo.Clientes ON dbo.Presupuestos.ClienteId = dbo.Clientes.Id

