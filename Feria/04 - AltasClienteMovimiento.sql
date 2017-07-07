INSERT INTO LCorrientes.dbo.ClientesMovimiento
           ([IdCliente]
           ,[IdTipoComprobante]
           ,[IdComprobante]
           ,[Concepto]
           ,[Debe]
           ,[Haber]
           ,[Observaciones]
           ,[FechaGeneracion]
           ,[FechaAlta]
           ,[SucursalAltaId]
           ,[OperadorAltaId]
           ,[FechaModificacion]
           ,[SucursalModificacionId]
           ,[OperadorModificacionId])
(
SELECT [IdCliente]
      ,[IdTipoComprobante]
      ,[IdComprobante]
      ,[Concepto]
      ,[Debe]
      ,[Haber]
      ,[Observaciones]
      ,[FechaGeneracion]
      ,[FechaAlta]
      ,[SucursalAltaId]
      ,[OperadorAltaId]
      ,[FechaModificacion]
      ,[SucursalModificacionId]
      ,[OperadorModificacionId]
  FROM LCorrientesFeria.dbo.ClientesMovimiento
  where FechaAlta > '2017-07-04 00:14'
	)


