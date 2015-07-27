CREATE TABLE [dbo].[ClientesArchivos] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [ClienteId]   UNIQUEIDENTIFIER NOT NULL,
    [Descripcion] NVARCHAR (50)    NULL,
    [Path]        NVARCHAR (250)   NULL,
    [Archivo]     NVARCHAR (250)   NULL,
    [OperadorId]  UNIQUEIDENTIFIER NULL,
    [Fecha]       DATETIME         NULL,
    CONSTRAINT [PK_ClientesArchivos] PRIMARY KEY CLUSTERED ([Id] ASC)
);

