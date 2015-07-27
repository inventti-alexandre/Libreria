CREATE VIEW [dbo].[vPresupuestos]
AS
SELECT     dbo.Presupuestos.Id, dbo.Presupuestos.Fecha, dbo.Presupuestos.Concepto, dbo.Presupuestos.LCN, dbo.Presupuestos.Descuento, 
                      dbo.Presupuestos.Total, dbo.Titulos.NombreTitulo, dbo.Autores.Nombre, dbo.PresupuestosDetalle.Cantidad, dbo.PresupuestosDetalle.Precio, 
                      dbo.Clientes.Denominacion, dbo.Clientes.Domicilio, dbo.Clientes.Telefono, dbo.Clientes.Celular, dbo.Clientes.Cuit, dbo.Titulos.Cod, 
                      dbo.Presupuestos.Descuento * dbo.Presupuestos.Total * 0.01 AS DescPesos, dbo.Presupuestos.Id AS CompId, 
                      dbo.Presupuestos.SucursalAltaId AS CompSuc
FROM         dbo.Presupuestos INNER JOIN
                      dbo.Clientes ON dbo.Presupuestos.ClienteId = dbo.Clientes.Id INNER JOIN
                      dbo.PresupuestosDetalle ON dbo.Presupuestos.Id = dbo.PresupuestosDetalle.PresupuestoId INNER JOIN
                      dbo.Titulos ON dbo.PresupuestosDetalle.TituloId = dbo.Titulos.Id INNER JOIN
                      dbo.Autores ON dbo.Titulos.AutorId = dbo.Autores.Id

