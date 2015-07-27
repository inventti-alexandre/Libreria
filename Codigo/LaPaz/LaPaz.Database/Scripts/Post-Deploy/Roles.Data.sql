SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT INTO [dbo].[Roles] ([Id], [Description])
SELECT  1, N'SuperAdmin' WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Roles] WHERE Id = 1)

INSERT INTO [dbo].[Roles] ([Id], [Description])
SELECT  2, N'Admin' WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Roles] WHERE Id = 2)

INSERT INTO [dbo].[Roles] ([Id], [Description])
SELECT  3, N'Administrativo' WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Roles] WHERE Id = 3)

INSERT INTO [dbo].[Roles] ([Id], [Description])
SELECT  4, N'Vendedor' WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Roles] WHERE Id = 4)

INSERT INTO [dbo].[Roles] ([Id], [Description])
SELECT  5, N'Cajero' WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Roles] WHERE Id = 5)

SET IDENTITY_INSERT [dbo].[Roles] OFF