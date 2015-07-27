CREATE TABLE [dbo].[VentasDetalle] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [VentaId]                UNIQUEIDENTIFIER NOT NULL,
    [TituloId]               UNIQUEIDENTIFIER NOT NULL,
    [CantidadPropia]         INT              NULL,
    [CantidadConsig]         INT              NULL,
    [Precio]                 MONEY            NULL,
    [IdNotaDeVenta]          UNIQUEIDENTIFIER NULL,
    [CantidadAuditada]       INT              NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [PrecioBase]             MONEY            NULL,
    [Descuento]              INT              NULL,
    CONSTRAINT [PK_VentasDetalle] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_VentasDetalle_Venta] FOREIGN KEY (VentaId) REFERENCES Ventas(Id), 
    CONSTRAINT [FK_VentasDetalle_Titulo] FOREIGN KEY (TituloId) REFERENCES Titulos(Id), 
    CONSTRAINT [FK_VentasDetalle_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_VentasDetalle_OperadorAlta] FOREIGN KEY (OperadoraltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_VentasDetalle_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_VentasDetalle_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_VentasDetalle_ToTable] FOREIGN KEY (IdNotaDeVenta) REFERENCES ClientesMontosFavor(Id)
);


GO
CREATE NONCLUSTERED INDEX [IX_s00FacVtaDet_1]
    ON [dbo].[VentasDetalle]([TituloId] ASC);

