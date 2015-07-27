CREATE TABLE [dbo].[Areas] (
    [Id]          INT           NOT NULL,
    [Nombre]      NVARCHAR (50) NOT NULL,
    [Abreviatura] NVARCHAR (10) NULL,
    [Descripcion] NVARCHAR (50) NULL,
    [Prioridad]   INT           NULL,
    CONSTRAINT [PK_Areas] PRIMARY KEY CLUSTERED ([Id] ASC)
);

