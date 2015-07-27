CREATE PROCEDURE [dbo].[SP_GenerarFacturaByVentaId]
	@ventaId uniqueidentifier
AS
	SELECT t.Cod as Codigo, vd.CantidadConsig + vd.CantidadPropia as Cantidad, 
t.NombreTitulo + ' - ' + ISNULL(a.Nombre, '')  
as Descripcion,vd.Descuento as Descuento,vd.PrecioBase as PrecioUnitario, 
vd.Precio as Importe
FROM Ventas v
INNER JOIN VentasDetalle vd
ON vd.VentaId= v.id
INNER JOIN Titulos t
ON t.Id= vd.TituloId
left JOIN Autores a
ON a.Id=t.AutorId
WHERE v.id= @ventaId
--RETURN 0
