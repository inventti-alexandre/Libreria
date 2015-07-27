CREATE TABLE [dbo].[ClientesMontosFavorDetalle] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [ClientesMontosFavorId]  UNIQUEIDENTIFIER NOT NULL,
    [TitulosId]              UNIQUEIDENTIFIER NOT NULL,
    [CantidadPropia]         INT              NULL,
    [CantidadConsig]         INT              NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_ClientesMontosFavorDetalle] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ClientesMontosFavorDetalle_ClientesMontosFavor] FOREIGN KEY ([ClientesMontosFavorId]) REFERENCES [dbo].[ClientesMontosFavor] ([Id]),
    CONSTRAINT [FK_ClientesMontosFavorDetalle_Titulos] FOREIGN KEY ([TitulosId]) REFERENCES [dbo].[Titulos] ([Id])
);

