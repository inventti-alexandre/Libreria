CREATE TABLE [dbo].[CobradoresFacturas] (
    [Id]                     INT              NOT NULL,
    [VentaId]                UNIQUEIDENTIFIER NOT NULL,
    [CobradorId]             INT              NOT NULL,
    [FechaAsignacion]        DATETIME         NOT NULL,
    [OperadorAsignoId]       UNIQUEIDENTIFIER NOT NULL,
    [FechaRetiro]            DATETIME         NULL,
    [OperadorRetiroId]       UNIQUEIDENTIFIER NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_CobradorFacturas_1] PRIMARY KEY CLUSTERED ([Id] ASC)
);

