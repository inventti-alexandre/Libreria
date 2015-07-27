CREATE TABLE [dbo].[CobradoresRecibos] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [CobradorId]             INT              NOT NULL,
    [ReciboId]               UNIQUEIDENTIFIER NOT NULL,
    [VentaId]                UNIQUEIDENTIFIER NOT NULL,
    [Cuota]                  INT              NOT NULL,
    [Fecha]                  DATETIME         NULL,
    [Importe]                MONEY            NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_CobradorRecibos] PRIMARY KEY CLUSTERED ([Id] ASC)
);

