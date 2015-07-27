CREATE TABLE [dbo].[RemitosCompraDetalle] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [RemitoCompraId]         UNIQUEIDENTIFIER NOT NULL,
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
    CONSTRAINT [PK_RemitosDetalle] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_RemitosCompraDetalle_RemitosCompra] FOREIGN KEY ([RemitoCompraId]) REFERENCES [dbo].[RemitosCompra] ([Id]),
    CONSTRAINT [FK_RemitosCompraDetalle_Titulos] FOREIGN KEY ([TituloId]) REFERENCES [dbo].[Titulos] ([Id]), 
    CONSTRAINT [FK_RemitosCompraDetalle_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_RemitosCompraDetalle_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_RemitosCompraDetalle_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id),
    CONSTRAINT [FK_RemitosCompraDetalle_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id)
);

