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
           ('Deposito con caja anterior'
           ,'DPCJAANT'
           ,2
           ,0
           ,GETDATE()
           ,GETDATE()
           )
GO


