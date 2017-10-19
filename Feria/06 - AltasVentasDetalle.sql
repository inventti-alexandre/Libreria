INSERT INTO LCorrientes.dbo.VentasDetalle
           ([Id]
           ,[VentaId]
           ,[TituloId]
           ,[CantidadPropia]
           ,[CantidadConsig]
           ,[Precio]
           ,[IdNotaDeVenta]
           ,[CantidadAuditada]
           ,[FechaAlta]
           ,[SucursalAltaId]
           ,[OperadorAltaId]
           ,[FechaModificacion]
           ,[SucursalModificacionId]
           ,[OperadorModificacionId]
           ,[PrecioBase]
           ,[Descuento])
 (
SELECT [Id]
      ,[VentaId]
      ,[TituloId]
      ,[CantidadPropia]
      ,[CantidadConsig]
      ,[Precio]
      ,[IdNotaDeVenta]
      ,[CantidadAuditada]
      ,[FechaAlta]
      ,[SucursalAltaId]
      ,[OperadorAltaId]
      ,[FechaModificacion]
      ,[SucursalModificacionId]
      ,[OperadorModificacionId]
      ,[PrecioBase]
      ,[Descuento]
  FROM LCorrientesFeria.dbo.VentasDetalle
   where FechaAlta > '2017-07-20 14:30'
 )


