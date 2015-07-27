CREATE TABLE [dbo].[OperadoresRoles]
(
	[OpetadorId] UNIQUEIDENTIFIER NOT NULL , 
    [RoleId] INT NOT NULL, 
    PRIMARY KEY ([OpetadorId], [RoleId]), 
    CONSTRAINT [FK_OperadoresRoles_Operadores] FOREIGN KEY ([OpetadorId]) REFERENCES [Operadores]([Id]), 
    CONSTRAINT [FK_OperadoresRoles_Roles] FOREIGN KEY ([RoleId]) REFERENCES [Roles]([Id])
)
