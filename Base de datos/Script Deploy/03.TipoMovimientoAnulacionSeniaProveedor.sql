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
           ,'Anulaci�n de Se�a de Proveedor'
           ,'Anul Se�a Prov'
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


