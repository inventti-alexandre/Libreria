CREATE TABLE [dbo].[MutualesLiquidacion] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [MutualId]               INT              NOT NULL,
    [CajaId]                 UNIQUEIDENTIFIER NOT NULL,
    [FechaEmision]           DATETIME         NOT NULL,
    [Importe]                REAL             NOT NULL,
    [Imp2]                   REAL             NULL,
    [Imp3]                   REAL             NULL,
    [Imp4]                   REAL             NULL,
    [Imp5]                   REAL             NULL,
    [Imp6]                   REAL             NULL,
    [FechaAlta]              DATETIME         NOT NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NOT NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_MutualesLiquidacion] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_MutualesLiquidacion_Cajas] FOREIGN KEY ([CajaId]) REFERENCES [dbo].[Cajas] ([Id])
);

