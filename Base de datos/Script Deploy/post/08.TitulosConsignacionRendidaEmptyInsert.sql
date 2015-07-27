INSERT INTO TitulosConsignacionesRendidas
           (Id
           ,LCN
           ,ProveedorId
           ,FechaAlta
           ,Importe
           
           ,OperadorAltaId
           
           ,SucursalAltaId
           
           ,FechaConsignacion
           ,TipoConsignacionId
           )
     VALUES
           ('00000000-0000-0000-0000-000000000000'
           ,'XXXXXXXXXXXXX'
           ,'00000000-0000-0000-0000-000000000000'
           ,GETDATE()
           ,0
           ,'00000000-0000-0000-0000-000000000000'
           
           ,1
           
           ,GETDATE()
           ,2)
           
GO


