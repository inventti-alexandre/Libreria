CREATE PROCEDURE [dbo].[SP_PresupuestoById]
	@presupuestoId uniqueidentifier
	
	AS
	SELECT T.Cod as Codigo, pd.Cantidad as Cantidad, 
t.NombreTitulo + ' - ' + ISNULL(a.Nombre, '')   as Descripcion,
p.Descuento as Descuento,
t.PrecioVentaTitulo as PrecioUnitario, pd.Precio as Importe
FROM
Presupuestos p
INNER JOIN PresupuestosDetalle pd
ON pd.PresupuestoId= p.Id
INNER JOIN Titulos t
ON t.Id= pd.TituloId
LEFT JOIN Autores a
ON a.Id=t.AutorId
where p.Id= @presupuestoId
order by t.NombreTitulo asc


