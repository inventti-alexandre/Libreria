INSERT INTO LCorrientes.dbo.CajasMovimientos
           ([Id]
           ,[CajaId]
           ,[TipoMovimientoCajaId]
           ,[TipoComprobante]
           ,[ComprobanteId]
           ,[Senia]
           ,[Recargo]
           ,[Importe]
           ,[ImpFac]
           ,[Efectivo]
           ,[Tarjeta]
           ,[Cheque]
           ,[Bono]
           ,[fpcBono]
           ,[Deposito]
           ,[CajaIdAnt]
           ,[CompIdAnt]
           ,[CompLcnAnt]
           ,[FacturaReservadas]
           ,[PcAlta]
           ,[FechaAlta]
           ,[OperadorAltaId]
           ,[SucursalAltaId]
           ,[FechaModificacion]
           ,[OperadorModificacionId]
           ,[SucursalModificacionId]
           ,[Transferencia])
		   (
SELECT [Id]
      ,[CajaId]
      ,[TipoMovimientoCajaId]
      ,[TipoComprobante]
      ,[ComprobanteId]
      ,[Senia]
      ,[Recargo]
      ,[Importe]
      ,[ImpFac]
      ,[Efectivo]
      ,[Tarjeta]
      ,[Cheque]
      ,[Bono]
      ,[fpcBono]
      ,[Deposito]
      ,[CajaIdAnt]
      ,[CompIdAnt]
      ,[CompLcnAnt]
      ,[FacturaReservadas]
      ,[PcAlta]
      ,[FechaAlta]
      ,[OperadorAltaId]
      ,[SucursalAltaId]
      ,[FechaModificacion]
      ,[OperadorModificacionId]
      ,[SucursalModificacionId]
      ,[Transferencia]
  FROM LCorrientesFeria.dbo.CajasMovimientos
where FechaAlta > '2017-07-20 14:30'
)


