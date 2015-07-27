CREATE TABLE [dbo].[LiquidacionPersonal] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [LiquidacionMesAnio]     NVARCHAR (20)    NOT NULL,
    [TipoLiquidacion]        TINYINT          NULL,
    [Importe]                REAL             NOT NULL,
    [Fecha]                  DATETIME         NOT NULL,
    [ImportePagado]          REAL             NULL,
    [LiquidacionId]          UNIQUEIDENTIFIER NULL,
    [PersonalId]             UNIQUEIDENTIFIER NOT NULL,
    [FechaAlta]              DATETIME         NOT NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NOT NULL,
    [FechaModificacion]      NCHAR (10)       NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_NovedadesLiquidadas] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_LiquidacionPersonal_Liquidaciones] FOREIGN KEY ([LiquidacionId]) REFERENCES [dbo].[Liquidaciones] ([Id]),
    CONSTRAINT [FK_LiquidacionPersonal_Personal] FOREIGN KEY ([PersonalId]) REFERENCES [dbo].[Personal] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_s00SueLiqCab]
    ON [dbo].[LiquidacionPersonal]([LiquidacionMesAnio] ASC);

