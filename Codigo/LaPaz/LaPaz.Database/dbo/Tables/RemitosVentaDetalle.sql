﻿CREATE TABLE [dbo].[RemitosVentaDetalle] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [RemitoVentaId]          UNIQUEIDENTIFIER NOT NULL,
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
    [Descuento]              INT              NULL,
    [PrecioBase]             MONEY            NULL,
    [CntVendida] INT NULL, 
    [CntDevuelta] INT NULL, 
    CONSTRAINT [PK_RemitosVentaDetalle] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_RemitosVentaDetalle_RemitosVenta] FOREIGN KEY ([RemitoVentaId]) REFERENCES [dbo].[RemitosVenta] ([Id]),
    CONSTRAINT [FK_RemitosVentaDetalle_Titulos] FOREIGN KEY ([TituloId]) REFERENCES [dbo].[Titulos] ([Id]),
	CONSTRAINT [FK_RemitosVentaDetalle_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_RemitosVentaDetalle_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
	CONSTRAINT [FK_RemitosVentaDetalle_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_RemitosVentaDetalle_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id)
);

