CREATE TABLE [dbo].[NotasDeVentaDetalle] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [NotaDeVentaId]          UNIQUEIDENTIFIER NOT NULL,
    [VentaDetalleId]         UNIQUEIDENTIFIER NULL,
    [TituloId]               UNIQUEIDENTIFIER NULL,
    [CantidadPropia]         INT              NULL,
    [CantidadConsig]         INT              NULL,
    [Precio]                 MONEY            NULL,
    [CantidadAuditada]       INT              NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_NotasDeVentaDetalle] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_NotasDeVentaDetalle_Titulos] FOREIGN KEY ([TituloId]) REFERENCES [dbo].[Titulos] ([Id])
);

