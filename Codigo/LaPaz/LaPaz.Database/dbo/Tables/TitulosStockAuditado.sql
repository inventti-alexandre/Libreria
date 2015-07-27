CREATE TABLE [dbo].[TitulosStockAuditado] (
    [Id]                     INT              IDENTITY (1, 1) NOT NULL,
    [TituloId]               UNIQUEIDENTIFIER NOT NULL,
    [SucursalId]             INT              NOT NULL,
    [Stock]                  INT              NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_TitutlosStockAuditado] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_s00LibStkAud]
    ON [dbo].[TitulosStockAuditado]([TituloId] ASC, [SucursalId] ASC);

