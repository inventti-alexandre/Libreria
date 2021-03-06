﻿CREATE TABLE [dbo].[CajasMovimientos] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [CajaId]                 UNIQUEIDENTIFIER NOT NULL,
    [TipoMovimientoCajaId]   INT              NULL,
    [TipoComprobante]        INT              NULL,
    [ComprobanteId]          UNIQUEIDENTIFIER NULL,
    [Senia]                  MONEY            NULL,
    [Recargo]                MONEY            NULL,
    [Importe]                MONEY            NULL,
    [ImpFac]                 MONEY            NULL,
    [Efectivo]               MONEY            NULL,
    [Tarjeta]                MONEY            NULL,
    [Cheque]                 MONEY            NULL,
    [Bono]                   MONEY            NULL,
    [fpcBono]                NVARCHAR (20)    NULL,
    [Deposito]               MONEY            NULL,
    [CajaIdAnt]              NCHAR (20)       NULL,
    [CompIdAnt]              NCHAR (20)       NULL,
    [CompLcnAnt]             NCHAR (20)       NULL,
    [FacturaReservadas]      INT              NULL,
    [PcAlta]                 NVARCHAR (20)    NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    [Transferencia] MONEY NULL, 
    CONSTRAINT [PK_CajasMovimientos] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_CajasMovimientos_TipoMovimientoCaja] FOREIGN KEY (TipoMovimientoCajaId) REFERENCES [TiposMovimientosCajas](Id), 
    CONSTRAINT [FK_CajasMovimientos_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES [Operadores](Id), 
    CONSTRAINT [FK_CajasMovimientos_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES [Sucursales](Id), 
    CONSTRAINT [FK_CajasMovimientos_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES [Operadores](Id), 
    CONSTRAINT [FK_CajasMovimientos_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES [Sucursales](Id), 
    CONSTRAINT [FK_CajasMovimientos_TipoComprobante] FOREIGN KEY (TipoComprobante) REFERENCES [TiposComprobantes](Id)
);

