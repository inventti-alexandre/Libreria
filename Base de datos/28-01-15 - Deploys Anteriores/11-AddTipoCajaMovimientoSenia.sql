USE [lapaz]
GO

INSERT INTO [dbo].[TiposMovimientosCajas]
           ([Nombre]
           ,[Abreviatura]
           ,[TipoMovimiento]
           ,[CodTipoAnt]
           ,[FechaAlta]
           ,[FechaModificacion]
           )
     VALUES
           ('SENIA A PROVEEDOR'
           ,'SENIAPROVEEDOR'
           ,2
           ,0
           ,GETDATE()
           ,GETDATE()
           )
GO
