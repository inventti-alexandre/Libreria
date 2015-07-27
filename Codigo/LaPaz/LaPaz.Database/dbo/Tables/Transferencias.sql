CREATE TABLE [dbo].[Transferencias] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [SucursalId]             INT              NOT NULL,
    [Numero]                 INT              NOT NULL,
    [LCN]                    NVARCHAR (13)    NULL,
    [CodSucDest]             TINYINT          NULL,
    [Fecha]                  SMALLDATETIME    NULL,
    [Concepto]               NVARCHAR (50)    NULL,
    [Obs]                    NVARCHAR (100)   NULL,
    [FAnula]                 SMALLDATETIME    NULL,
    [FRecibe]                SMALLDATETIME    NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_Transferencias] PRIMARY KEY CLUSTERED ([Id] ASC)
);

