CREATE TABLE [dbo].[MutualesMovimientos] (
    [ID]                     UNIQUEIDENTIFIER NOT NULL,
    [MutualId]               INT              NOT NULL,
    [CajaMovimientoId]       UNIQUEIDENTIFIER NOT NULL,
    [Importe]                MONEY            NOT NULL,
    [LiquidacionMutualesId]  UNIQUEIDENTIFIER NULL,
    [Fecha]                  DATETIME         NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_MutualesMovimientos] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_MutualesMovimientos_CajasMovimientos] FOREIGN KEY ([CajaMovimientoId]) REFERENCES [dbo].[CajasMovimientos] ([Id]),
    CONSTRAINT [FK_MutualesMovimientos_Mutuales] FOREIGN KEY ([MutualId]) REFERENCES [dbo].[Mutuales] ([Id]),
    CONSTRAINT [FK_MutualesMovimientos_MutualesLiquidacion] FOREIGN KEY ([LiquidacionMutualesId]) REFERENCES [dbo].[MutualesLiquidacion] ([Id])
);

