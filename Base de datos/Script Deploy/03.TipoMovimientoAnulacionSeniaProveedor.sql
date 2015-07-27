SET IDENTITY_INSERT dbo.[TiposMovimientosCajas] ON
GO

INSERT INTO [TiposMovimientosCajas]
           ([Id]
           ,[Nombre]
           ,[Abreviatura]
           ,[TipoMovimiento]
           ,[CodTipoAnt]
           ,[FechaAlta]
           ,[OperadorAltaId]
           ,[SucursalAltaId]
           ,[FechaModificacion]
           ,[OperadorModificacionId]
           ,[SucursalModificacionId] )
     VALUES
           (35
           ,'Anulación de Seña de Proveedor'
           ,'Anul Seña Prov'
           ,2
           ,0
           ,GETDATE()
           ,NULL
           ,NULL
           ,GETDATE()
           ,NULL
           ,NULL)

SET IDENTITY_INSERT dbo.[TiposMovimientosCajas] OFF
GO


