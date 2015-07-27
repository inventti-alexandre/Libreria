CREATE TABLE [dbo].[TransferenciasDetalle] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [TransferenciaId]        UNIQUEIDENTIFIER NOT NULL,
    [TituloId]               UNIQUEIDENTIFIER NOT NULL,
    [CntPr]                  SMALLINT         NULL,
    [CntCn]                  SMALLINT         NULL,
    [CntVn]                  TINYINT          NULL,
    [PrcVta]                 REAL             NULL,
    [CntAud]                 SMALLINT         NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_TransferenciasDetalle] PRIMARY KEY CLUSTERED ([Id] ASC)
);

