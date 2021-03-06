﻿CREATE TABLE [dbo].[CuentasMovimientos] (
    [Id]                       INT              IDENTITY (1, 1) NOT NULL,
    [CuentaId]                 INT              NOT NULL,
    [TipoMovimientoId]         INT              NOT NULL,
    [FechaMovimiento]          DATETIME         NOT NULL,
    [EstadoMovimientoCuentaId] INT              NULL,
    [MotivoEstado]             VARCHAR (30)     NULL,
    [TipoComprobanteId]        INT              NULL,
    [ComprobanteId]            UNIQUEIDENTIFIER NULL,
    [MonedaId]                 INT              NOT NULL,
    [CondicionVentaId]         INT              NULL,
    [NroMovimiento]            NCHAR (30)       NULL,
    [FechaCobro]               DATETIME         NULL,
    [Descripcion]              NVARCHAR (50)    NULL,
    [Debito]                   MONEY            NULL,
    [Credito]                  MONEY            NULL,
    [ResumenConciliacion]      NVARCHAR (30)    NULL,
    [FechaConciliacion]        DATETIME         NULL,
    [TipoCarga]                INT              NULL,
    [CajaId]                   UNIQUEIDENTIFIER NULL,
    [FechaAlta]                DATETIME         NULL,
    [OperadorAltaId]           UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]           INT              NULL,
    [FechaModificacion]        DATETIME         NULL,
    [OperadorModificacionId]   UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId]   INT              NULL,
    CONSTRAINT [PK_CuentasMovimientos_1] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CuentasMovimientos_Cuentas] FOREIGN KEY ([CuentaId]) REFERENCES [dbo].[Cuentas] ([Id])
);

