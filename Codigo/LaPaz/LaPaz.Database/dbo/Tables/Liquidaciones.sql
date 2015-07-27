CREATE TABLE [dbo].[Liquidaciones] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [LiquidacionId]          UNIQUEIDENTIFIER NOT NULL,
    [Importe]                REAL             NULL,
    [Total]                  REAL             NULL,
    [Comentario]             NVARCHAR (50)    NULL,
    [FechaAlta]              DATETIME         NOT NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NOT NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_s00SueLiqDet] PRIMARY KEY CLUSTERED ([Id] ASC)
);

