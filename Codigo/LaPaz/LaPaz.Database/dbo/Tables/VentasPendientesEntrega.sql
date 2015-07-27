CREATE TABLE [dbo].[VentasPendientesEntrega] (
    [Id]                     INT              IDENTITY (1, 1) NOT NULL,
    [FacturaId]              UNIQUEIDENTIFIER NULL,
    [TituloId]               UNIQUEIDENTIFIER NULL,
    [CantidadPropia]         INT              NULL,
    [CantidadConsig]         INT              NULL,
    [Precio]                 MONEY            NULL,
    [CantidadAuditada]       INT              NULL,
    [FechaEntrega]           DATETIME         NULL,
    [OeradorEntrega]         UNIQUEIDENTIFIER NULL,
    [PcEntrega]              NVARCHAR (20)    NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_VentasPendientesEntrega] PRIMARY KEY CLUSTERED ([Id] ASC)
);

