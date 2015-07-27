CREATE TABLE [dbo].[MovimientosFondoDetalle] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [MovimientosFondoId]     UNIQUEIDENTIFIER NOT NULL,
    [TipoMovimientoFondoId]  INT              NULL,
    [NumeroComprobante]      VARCHAR (100)    NULL,
    [DescripcionMovimiento]  NVARCHAR (100)   NULL,
    [ImporteDetalle]         MONEY            NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL
);

