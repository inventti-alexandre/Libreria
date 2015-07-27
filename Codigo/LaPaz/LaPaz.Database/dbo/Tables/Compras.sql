CREATE TABLE [dbo].[Compras] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [LCN]                    NCHAR (13)       NULL,
    [TipoComprobanteId]      INT              NOT NULL,
    [ProveedorId]            UNIQUEIDENTIFIER NOT NULL,
    [LetraComprobante]       CHAR (1)         NOT NULL,
    [PuntoVenta]             INT              NOT NULL,
    [NumeroComprobante]      NCHAR (13)       NULL,
    [FechaComprobante]       DATETIME         NOT NULL,
    [FechaVencimiento]       DATETIME         NULL,
    [Concepto]               NVARCHAR (50)    NULL,
    [ImporteNeto]            MONEY            NULL,
    [ImporteIVA]             MONEY            NULL,
    [Observaciones]          NVARCHAR (100)   NULL,
    [BultoId]                UNIQUEIDENTIFIER NULL,
    [EstadoCompraId]         INT              NOT NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaAlta]              DATETIME         NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_Compras] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Compras_TipoComprobante] FOREIGN KEY (TipoComprobanteId) REFERENCES TiposComprobantes(Id), 
    CONSTRAINT [FK_Compras_Proveedor] FOREIGN KEY (ProveedorId) REFERENCES Proveedores(Id), 
    CONSTRAINT [FK_Compras_Bulto] FOREIGN KEY (BultoId) REFERENCES ProveedoresBultos(Id), 
    CONSTRAINT [FK_Compras_EstadoCompra] FOREIGN KEY (EstadoCompraId) REFERENCES EstadosCompra(Id), 
    CONSTRAINT [FK_Compras_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Compras_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_Compras_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_Compras_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id)
);


GO
CREATE NONCLUSTERED INDEX [IX_s00FacCmpCab_4]
    ON [dbo].[Compras]([TipoComprobanteId] ASC);

