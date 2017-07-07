INSERT INTO LCorrientes.dbo.Cajas
           ([Id]
           ,[SucursalId]
           ,[OperadorId]
           ,[Fecha]
           ,[FCierre]
           ,[Inicio]
           ,[Ingresos]
           ,[Egresos]
           ,[Saldo]
           ,[Cheques]
           ,[Bonos]
           ,[PcAlta]
           ,[FechaAlta]
           ,[OperadorAltaId]
           ,[SucursalAltaId]
           ,[FechaModificacion]
           ,[OperadorModificacionId]
           ,[SucursalModificacionId])
SELECT [Id]
      ,[SucursalId]
      ,[OperadorId]
      ,[Fecha]
      ,[FCierre]
      ,[Inicio]
      ,[Ingresos]
      ,[Egresos]
      ,[Saldo]
      ,[Cheques]
      ,[Bonos]
      ,[PcAlta]
      ,[FechaAlta]
      ,[OperadorAltaId]
      ,[SucursalAltaId]
      ,[FechaModificacion]
      ,[OperadorModificacionId]
      ,[SucursalModificacionId]
  FROM LCorrientesFeria.dbo.Cajas
  where FechaAlta > '2017-07-04 00:14'





