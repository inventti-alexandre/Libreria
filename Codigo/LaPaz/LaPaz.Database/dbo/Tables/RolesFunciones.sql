CREATE TABLE [dbo].[RolesFunciones]
(
	[RoleId] INT NOT NULL , 
    [FuncionId] INT NOT NULL, 
    PRIMARY KEY ([FuncionId], [RoleId]), 
    CONSTRAINT [FK_RolesFunciones_Roles] FOREIGN KEY ([RoleId]) REFERENCES [Roles]([Id]), 
    CONSTRAINT [FK_RolesFunciones_Funciones] FOREIGN KEY ([FuncionId]) REFERENCES [Funciones]([Id])
)
