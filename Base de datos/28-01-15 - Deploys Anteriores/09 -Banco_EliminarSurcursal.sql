IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Bancos_Sucursal]') AND parent_object_id = OBJECT_ID(N'[dbo].[Bancos]'))
ALTER TABLE [dbo].[Bancos] DROP CONSTRAINT [FK_Bancos_Sucursal]
GO

ALTER TABLE Bancos
DROP COLUMN SucursalId
GO


