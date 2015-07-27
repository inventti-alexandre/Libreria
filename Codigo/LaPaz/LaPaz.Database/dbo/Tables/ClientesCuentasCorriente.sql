CREATE TABLE [dbo].[ClientesCuentasCorriente] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [VentaId]                UNIQUEIDENTIFIER NOT NULL,
    [ClienteId]              UNIQUEIDENTIFIER NULL,
    [Cuota]                  TINYINT          NOT NULL,
    [Fecha]                  DATETIME         NULL,
    [FechaVencimiento]       DATETIME         NULL,
    [FechaUltimoPago]        DATETIME         NULL,
    [Importe]                REAL             NULL,
    [Pagado]                 REAL             NULL,
    [FechaGeneracion]        DATETIME         NULL,
    [Observaciones]          VARCHAR (255)    NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_ClientesCuentasCorriente] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_s00CCCliente_2]
    ON [dbo].[ClientesCuentasCorriente]([Fecha] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_s00CCCliente_3]
    ON [dbo].[ClientesCuentasCorriente]([FechaVencimiento] ASC);

