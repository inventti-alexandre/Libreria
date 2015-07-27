CREATE TABLE [dbo].[ComprasDetalle] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [CompraId]               UNIQUEIDENTIFIER NOT NULL,
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
    CONSTRAINT [PK_ComprasDetalle] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ComprasDetalle_Compras1] FOREIGN KEY ([CompraId]) REFERENCES [dbo].[Compras] ([Id]), 
    CONSTRAINT [FK_ComprasDetalle_Titulo] FOREIGN KEY (TituloId) REFERENCES Titulos(Id), 
    CONSTRAINT [FK_ComprasDetalle_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_ComprasDetalle_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_ComprasDetalle_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_ComprasDetalle_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id)
);

