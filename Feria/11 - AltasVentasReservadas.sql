INSERT INTO LCorrientes.dbo.VentasReservadas
           ([SucReserva]
           ,[NroLote]
           ,[LCN]
           ,[FechaAlta]
           ,[SucursalAltaId]
           ,[OperadorAltaId]
           ,[FechaModificacion]
           ,[SucursalModificacionId]
           ,[OperadorModificacionId])
    
           (  SELECT [SucReserva]
			,[NroLote]
			,[LCN]
			,[FechaAlta]
			,[SucursalAltaId]
			,[OperadorAltaId]
			,[FechaModificacion]
			,[SucursalModificacionId]
			,[OperadorModificacionId]
  FROM LCorrientesFeria.dbo.VentasReservadas
  WHERE NroReserva > 21458
  )


