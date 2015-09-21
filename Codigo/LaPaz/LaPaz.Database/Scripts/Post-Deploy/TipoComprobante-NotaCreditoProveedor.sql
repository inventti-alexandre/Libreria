/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/



INSERT INTO [TiposComprobantes]
           ([Id],
		   [Nombre]
           ,[Abreviatura]
           ,[Descripcion]
           ,[FechaAlta]
           )
     SELECT
			41
           ,'NOTA DE CREDITO PROVEEDOR'
           ,'NTCREDRPRV'
           ,'NOTA DE CREDITO'
           ,GETDATE()
           
		   WHERE NOT EXISTS (SELECT 1 FROM TiposComprobantes WHERE Id = 41)