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
           ('PAGO A PROVEEDOR CON CAJA ANTERIOR'
           ,'PAGOPROVCJAANT'
           ,2
           ,0
           ,GETDATE()
           ,GETDATE()
           )
GO
