INSERT INTO [TiposMovimientosCajas]
           ([Id],
		   [Nombre]
           ,[Abreviatura]
           ,[FechaAlta]
           )
     SELECT
			36
           ,'PAGO CUENTA A PROVEEDOR CON CAJA ANTERIOR'
           ,'PCTAPROVCJAANT'
            ,GETDATE()
           
		   WHERE NOT EXISTS (SELECT 1 FROM TiposMovimientosCajas WHERE Id = 36)