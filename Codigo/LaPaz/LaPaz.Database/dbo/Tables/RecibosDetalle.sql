CREATE TABLE [dbo].[RecibosDetalle] (
    [Id]                       UNIQUEIDENTIFIER NOT NULL,
    [ReciboId]                 UNIQUEIDENTIFIER NOT NULL,
    [ClienteCuentaCorrienteId] UNIQUEIDENTIFIER NULL,
    [Importe]                  MONEY            NULL,
    [OperadorAltaId]           UNIQUEIDENTIFIER NULL,
    [FechaAlta]                DATETIME         NULL,
    [SucursalAltaId]           INT              NULL,
    [FechaModificacion]        DATETIME         NULL,
    [SucursalModificacionId]   INT              NULL,
    [OperadorModificacionId]   UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_RecibosDetalle] PRIMARY KEY CLUSTERED ([Id] ASC)
);

