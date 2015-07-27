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
INSERT INTO ProveedoresCuentasCorriente
(id,CompraId,ProveedorId,Cuota) 

SELECT N'00000000-0000-0000-0000-000000000000',N'00000000-0000-0000-0000-000000000000'
,N'00000000-0000-0000-0000-000000000000',0 WHERE NOT EXISTS 
(SELECT 1 FROM ProveedoresCuentasCorriente WHERE Id = '00000000-0000-0000-0000-000000000000')

