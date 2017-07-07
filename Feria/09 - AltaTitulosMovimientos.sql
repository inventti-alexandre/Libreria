INSERT INTO LCorrientes.dbo.TitulosMovimiento
           ([TituloId]
           ,[TipoComprobanteId]
           ,[ComprobanteId]
           ,[SucursalComprobante]
           ,[Fecha]
           ,[CntAntPr]
           ,[CntAntCn]
           ,[CntAddPr]
           ,[CntAddCn]
           ,[CntMinPr]
           ,[CntMinCn]
           ,[PC]
           ,[FechaAlta]
           ,[SucursalAltaId]
           ,[OperadorAltaId]
           ,[FechaModificacion]
           ,[SucursalModificacionId]
           ,[OperadorModificacionId])
     (
			SELECT 
			[TituloId]
			,[TipoComprobanteId]
			,[ComprobanteId]
			,[SucursalComprobante]
			,[Fecha]
			,[CntAntPr]
			,[CntAntCn]
			,[CntAddPr]
			,[CntAddCn]
			,[CntMinPr]
			,[CntMinCn]
			,[PC]
			,[FechaAlta]
			,[SucursalAltaId]
			,[OperadorAltaId]
			,[FechaModificacion]
			,[SucursalModificacionId]
			,[OperadorModificacionId]
		  FROM LCorrientesFeria.dbo.TitulosMovimiento
	 )

	 

