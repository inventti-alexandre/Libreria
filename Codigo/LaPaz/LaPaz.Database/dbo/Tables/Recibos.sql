CREATE TABLE [dbo].[Recibos] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [SucursalCompId]         INT              NULL,
    [Tipo]                   CHAR (1)         NULL,
    [PuntoVenta]             INT              NULL,
    [Numero]                 CHAR (14)        NULL,
    [FechaAnulacion]         DATETIME         NULL,
    [FechaPago]              DATETIME         NULL,
    [Total]                  MONEY            NULL,
    [CobradorId]             INT              NULL,
    [OperadorAuId]           UNIQUEIDENTIFIER NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_Recibos] PRIMARY KEY CLUSTERED ([Id] ASC)
);

