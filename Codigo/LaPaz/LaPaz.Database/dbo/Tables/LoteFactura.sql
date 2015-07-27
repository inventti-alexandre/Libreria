CREATE TABLE [dbo].[LoteFactura] (
    [NroLote]                INT              IDENTITY (1, 1) NOT NULL,
    [SucursalLote]           INT              NOT NULL,
    [OperadorLote]           UNIQUEIDENTIFIER NOT NULL,
    [Tipo]                   CHAR (1)         NOT NULL,
    [PtoVenta]               INT              NOT NULL,
    [NroDesde]               INT              NOT NULL,
    [NroHasta]               INT              NOT NULL,
    [NroActual]              INT              NULL,
    [Estado]                 INT              NOT NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_LoteFactura] PRIMARY KEY CLUSTERED ([NroLote] ASC),
    CONSTRAINT [IX_LoteFactura] UNIQUE NONCLUSTERED ([NroLote] ASC, [SucursalLote] ASC, [OperadorLote] ASC)
);

