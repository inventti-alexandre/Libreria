CREATE PROCEDURE [dbo].[Sp_DevolucionLibros]
	@devolucionId uniqueidentifier = null
AS
		

	SELECT T.Cod as Codigo, (ISNULL(tcdd.Cantidad,0) + ISNULL(TCDD.CantidadPropia,0)) as Cantidad, 
t.NombreTitulo + ' - ' + ISNULL(a.Nombre, '')   as Descripcion,
--p.Descuento as Descuento,
 T.PrecioCompraTitulo as Precio,( (ISNULL(tcdd.Cantidad,0) + ISNULL(TCDD.CantidadPropia,0)) *  T.PrecioCompraTitulo) as Subtotal,
 tcd.LCN, p.Denominacion, tcd.FechaAlta
FROM
TitulosConsignacionesDevueltas tcd
INNER JOIN TitulosConsignacionesDevueltasDetalles tcdd
ON tcdd.tituloconsignaciondevueltaid= tcd.Id
INNER JOIN Proveedores p
ON p.Id=tcd.ProveedorId
INNER JOIN Titulos t
ON t.Id= tcdd.TituloId
LEFT JOIN Autores a
ON a.Id=t.AutorId
where tcd.Id= @devolucionId
order by t.NombreTitulo asc
