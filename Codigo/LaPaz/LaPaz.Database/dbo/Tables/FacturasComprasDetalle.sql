CREATE TABLE [dbo].[FacturasComprasDetalle] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [FacturaCompraId]        UNIQUEIDENTIFIER NOT NULL,
    [TituloId]               UNIQUEIDENTIFIER NOT NULL,
    [CntPr]                  INT              NULL,
    [CntCn]                  INT              NULL,
    [PrecioCompra]           MONEY            NULL,
    [PrecioVenta]            MONEY            NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_FacturasComprasDetalle] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_FacturasComprasDetalle_Factura] FOREIGN KEY (FacturaCompraId) REFERENCES FacturasCompra(Id), 
    CONSTRAINT [FK_FacturasComprasDetalle_Titulo] FOREIGN KEY (TituloId) REFERENCES Titulos(Id), 
    CONSTRAINT [FK_FacturasComprasDetalle_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_FacturasComprasDetalle_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_FacturasComprasDetalle_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_FacturasComprasDetalle_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id)
);

