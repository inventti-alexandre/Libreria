INSERT INTO LCorrientes.dbo.Ventas
           ([Id]
           ,[LCN]
           ,[ComprobanteId]
           ,[ClienteId]
           ,[LetraComprobante]
           ,[PuntoVenta]
           ,[NumeroComprobante]
           ,[FechaComprobante]
           ,[FechaVencimiento]
           ,[CondicionVentaId]
           ,[Concepto]
           ,[ImporteNeto]
           ,[ImporteIva]
           ,[ImporteSena]
           ,[FechaUltimoPago]
           ,[TotalPagado]
           ,[EstadoVentaId]
           ,[FechaAlta]
           ,[SucursalAltaId]
           ,[OperadorAltaId]
           ,[FechaModificacion]
           ,[SucursalModificacionId]
           ,[OperadorModificacionId]
           ,[OperadorAutoriza]
           ,[ValidacionUsuario])
(
SELECT [Id]
      ,[LCN]
      ,[ComprobanteId]
      ,[ClienteId]
      ,[LetraComprobante]
      ,[PuntoVenta]
      ,[NumeroComprobante]
      ,[FechaComprobante]
      ,[FechaVencimiento]
      ,[CondicionVentaId]
      ,[Concepto]
      ,[ImporteNeto]
      ,[ImporteIva]
      ,[ImporteSena]
      ,[FechaUltimoPago]
      ,[TotalPagado]
      ,[EstadoVentaId]
      ,[FechaAlta]
      ,[SucursalAltaId]
      ,[OperadorAltaId]
      ,[FechaModificacion]
      ,[SucursalModificacionId]
      ,[OperadorModificacionId]
      ,[OperadorAutoriza]
      ,[ValidacionUsuario]
  FROM LCorrientesFeria.dbo.Ventas
    where FechaAlta > '2017-07-20 14:30'
)