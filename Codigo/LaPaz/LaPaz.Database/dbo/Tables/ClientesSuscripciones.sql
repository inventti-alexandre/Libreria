CREATE TABLE [dbo].[ClientesSuscripciones] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [ClienteId]              UNIQUEIDENTIFIER NOT NULL,
    [RevistaId]              INT              NOT NULL,
    [Desde]                  DATETIME         NULL,
    [Hasta]                  DATETIME         NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_ClientesSuscripciones] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ClientesSuscripciones_Clientes] FOREIGN KEY ([ClienteId]) REFERENCES [dbo].[Clientes] ([Id])
);

