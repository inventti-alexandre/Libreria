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

:r .\Roles.Data.sql
:r .\ProveedoresCtaCteEmptyInsert.sql
:R .\TitulosConsignacionRendidaEmptyInsert.sql
:R .\TipoComprobante-MontoFavorProveedor.sql
:R .\TipoMovimientoCaja-PagoCtaProveedorCajaAnterior.sql
:R .\TipoComprobante-NotaCreditoProveedor.sql
