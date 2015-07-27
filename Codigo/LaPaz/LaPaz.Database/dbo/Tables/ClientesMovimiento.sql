CREATE TABLE [dbo].[ClientesMovimiento] (
    [Id]                     INT              IDENTITY (1, 1) NOT NULL,
    [IdCliente]              UNIQUEIDENTIFIER NOT NULL,
    [IdTipoComprobante]      INT              NULL,
    [IdComprobante]          UNIQUEIDENTIFIER NULL,
    [Concepto]               NVARCHAR (50)    NULL,
    [Debe]                   MONEY            NULL,
    [Haber]                  MONEY            NULL,
    [Observaciones]          NVARCHAR (100)   NULL,
    [FechaGeneracion]        DATETIME         NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_ClientesMovimiento_1] PRIMARY KEY CLUSTERED ([Id] ASC)
);

