CREATE TABLE [dbo].[OperadorSucursal] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [OperadorId]             UNIQUEIDENTIFIER NOT NULL,
    [SucursalId]             INT              NOT NULL,
    [Activo]                 BIT              NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_OperadorSucursal] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_OperadorSucursal_Operadores1] FOREIGN KEY ([OperadorId]) REFERENCES [dbo].[Operadores] ([Id]),
    CONSTRAINT [FK_OperadorSucursal_Sucursales1] FOREIGN KEY ([SucursalId]) REFERENCES [dbo].[Sucursales] ([Id])
);

