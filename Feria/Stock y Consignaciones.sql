delete from LCorrientesFeria.dbo.TitulosStock
delete from LCorrientesFeria.dbo.TitulosConsignaciones

INSERT INTO LCorrientesFeria.dbo.TitulosStock
           ([TituloId]
           ,[SucursalId]
           ,[StkPr]
           ,[StkCn]
           ,[FechaAlta]
           ,[SucursalAltaId]
           ,[OperadorAltaId]
           ,[FechaModificacion]
           ,[SucursalModificacionId]
           ,[OperadorModificacionId])

(
SELECT 
      [TituloId]
      ,[SucursalId]
      ,[StkPr]
      ,[StkCn]
      ,[FechaAlta]
      ,[SucursalAltaId]
      ,[OperadorAltaId]
      ,[FechaModificacion]
      ,[SucursalModificacionId]
      ,[OperadorModificacionId]
  FROM LCorrientes.dbo.TitulosStock
)



INSERT INTO LCorrientesFeria.dbo.TitulosConsignaciones
           ([Id]
           ,[TituloId]
           ,[ClienteId]
           ,[ProveedorId]
           ,[TipoConsignacion]
           ,[CntPr]
           ,[CntCn]
           ,[CntVn]
           ,[CntDev]
           ,[FechaAlta]
           ,[SucursalAltaId]
           ,[OperadorAltaId]
           ,[FechaModificacion]
           ,[SucursalModificacionId]
           ,[OperadorModificacionId])
     (

SELECT [Id]
      ,[TituloId]
      ,[ClienteId]
      ,[ProveedorId]
      ,[TipoConsignacion]
      ,[CntPr]
      ,[CntCn]
      ,[CntVn]
      ,[CntDev]
      ,[FechaAlta]
      ,[SucursalAltaId]
      ,[OperadorAltaId]
      ,[FechaModificacion]
      ,[SucursalModificacionId]
      ,[OperadorModificacionId]
  FROM LCorrientes.dbo.TitulosConsignaciones
	 )



