﻿CREATE TABLE [dbo].[RemitosCompra] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [CompraId]               UNIQUEIDENTIFIER NULL,
    [TipoComprobante]        INT              NULL,
    [ProveedorId]            UNIQUEIDENTIFIER NULL,
    [LCN]                    NCHAR (13)       NULL,
    [BultoId]                UNIQUEIDENTIFIER NULL,
    [PuntoVenta]             INT              NOT NULL,
    [NumeroComprobante]      CHAR (13)        NULL,
    [Concepto]               NVARCHAR (50)    NULL,
    [FechaComprobante]       DATETIME         NOT NULL,
    [FechaVencimiento]       DATETIME         NULL,
    [ImporteNeto]            MONEY            NULL,
    [ImporteIVA]             MONEY            NULL,
    [Observaciones]          NVARCHAR (100)   NULL,
    [EstadoId]               INT              NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_Remitos] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_RemitosCompra_Compra] FOREIGN KEY (CompraId) REFERENCES Compras(Id), 
    CONSTRAINT [FK_RemitosCompra_Proveedor] FOREIGN KEY (ProveedorId) REFERENCES Proveedores(Id), 
    CONSTRAINT [FK_RemitosCompra_Estado] FOREIGN KEY (EstadoId) REFERENCES EstadosCompra(Id), 
    CONSTRAINT [FK_RemitosCompra_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_RemitosCompra_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_RemitosCompra_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id),
    CONSTRAINT [FK_RemitosCompra_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id)
);
