CREATE TABLE [dbo].[Moneda] (
    [Id]                     INT              NOT NULL,
    [TipoMonedaId]           INT              NOT NULL,
    [Cotizacion]             MONEY            NOT NULL,
    [FechaCotizacion]        DATETIME         NOT NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_Moneda] PRIMARY KEY CLUSTERED ([Id] ASC)
);

