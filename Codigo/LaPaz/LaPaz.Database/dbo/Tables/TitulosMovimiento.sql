CREATE TABLE [dbo].[TitulosMovimiento] (
    [Id]                     INT              IDENTITY (1, 1) NOT NULL,
    [TituloId]               UNIQUEIDENTIFIER NOT NULL,
    [TipoComprobanteId]      INT              NULL,
    [ComprobanteId]          UNIQUEIDENTIFIER NULL,
    [SucursalComprobante]    INT              NULL,
    [Fecha]                  DATETIME         NULL,
    [CntAntPr]               INT              NULL,
    [CntAntCn]               INT              NULL,
    [CntAddPr]               INT              NULL,
    [CntAddCn]               INT              NULL,
    [CntMinPr]               INT              NOT NULL,
    [CntMinCn]               INT              NULL,
    [PC]                     NVARCHAR (30)    NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_TitulosMovimiento_1] PRIMARY KEY CLUSTERED ([Id] ASC)
);

