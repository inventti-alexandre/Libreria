CREATE TABLE [dbo].[Vendedores] (
    [Id]              INT              NOT NULL,
    [Nombre]          VARCHAR (50)     NOT NULL,
    [Abreviatura]     NVARCHAR (10)    NULL,
    [FechaGeneracion] DATETIME         NULL,
    [OperadorId]      UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_Vendedores] PRIMARY KEY CLUSTERED ([Id] ASC)
);

