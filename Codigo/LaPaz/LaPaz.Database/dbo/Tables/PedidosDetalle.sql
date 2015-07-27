CREATE TABLE [dbo].[PedidosDetalle] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [PedidoId]               UNIQUEIDENTIFIER NOT NULL,
    [ProveedorId]            UNIQUEIDENTIFIER NOT NULL,
    [PrvMailPedido]          NVARCHAR (50)    NULL,
    [EstadoEnvio]            BIT              NULL,
    [FechaEnviado]           DATETIME         NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_PedidosDetalle] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_PedidosDetalle_Pedidos] FOREIGN KEY ([PedidoId]) REFERENCES [dbo].[Pedidos] ([Id]) NOT FOR REPLICATION
);


GO
ALTER TABLE [dbo].[PedidosDetalle] NOCHECK CONSTRAINT [FK_PedidosDetalle_Pedidos];

