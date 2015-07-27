CREATE TABLE [dbo].[Pedidos] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [SucursalId]             INT              NOT NULL,
    [ClienteId]              UNIQUEIDENTIFIER NOT NULL,
    [TituloId]               UNIQUEIDENTIFIER NOT NULL,
    [Cantidad]               INT              NOT NULL,
    [PrioridadesId]          INT              NULL,
    [EstadoPedido]           INT              NULL,
    [FechaPedido]            DATETIME         NULL,
    [FechaPedidoProveedor]   DATETIME         NULL,
    [OperadorId]             UNIQUEIDENTIFIER NULL,
    [FechaAviso]             DATETIME         NULL,
    [FechaVenta]             DATETIME         NULL,
    [VentaDetalleId]         UNIQUEIDENTIFIER NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_Pedidos] PRIMARY KEY CLUSTERED ([Id] ASC)
);

