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
           ('SENIA A PROVEEDOR CON CAJA ANTERIOR'
           ,'SENIAPROVCJAANT'
           ,2
           ,0
           ,GETDATE()
           ,GETDATE()
           )
GO
