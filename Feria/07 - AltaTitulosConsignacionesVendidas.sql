INSERT INTO LCorrientes.dbo.TitulosConsignacionesVendidas
           ([Id]
           ,[nTipo]
           ,[ClienteId]
           ,[ProveedorId]
           ,[TituloId]
           ,[ComprobanteId]
           ,[Fecha]
           ,[CntCn]
           ,[CntPag]
           ,[FechaAlta]
           ,[SucursalAltaId]
           ,[OperadorAltaId]
           ,[FechaModificacion]
           ,[SucursalModificacionId]
           ,[OperadorModificacionId])
 (
SELECT [Id]
      ,[nTipo]
      ,[ClienteId]
      ,[ProveedorId]
      ,[TituloId]
      ,[ComprobanteId]
      ,[Fecha]
      ,[CntCn]
      ,[CntPag]
      ,[FechaAlta]
      ,[SucursalAltaId]
      ,[OperadorAltaId]
      ,[FechaModificacion]
      ,[SucursalModificacionId]
      ,[OperadorModificacionId]
  FROM LCorrientesFeria.dbo.TitulosConsignacionesVendidas
 where FechaAlta > '2017-07-06 00:14'
 )


