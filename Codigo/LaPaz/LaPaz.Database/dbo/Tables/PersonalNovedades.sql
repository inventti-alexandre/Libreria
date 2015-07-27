CREATE TABLE [dbo].[PersonalNovedades] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [PersonalId]             UNIQUEIDENTIFIER NOT NULL,
    [TipoNovedad]            INT              NOT NULL,
    [ConceptoId]             INT              NOT NULL,
    [Cantidad]               INT              NULL,
    [MesImputacion]          INT              NOT NULL,
    [AnioImputacion]         INT              NOT NULL,
    [Importe]                REAL             NOT NULL,
    [Total]                  REAL             NULL,
    [LiquidacionPersonalId]  UNIQUEIDENTIFIER NULL,
    [FechaAlta]              DATETIME         NOT NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NOT NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_s00SueCpto] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_PersonalNovedades_Conceptos] FOREIGN KEY ([ConceptoId]) REFERENCES [dbo].[Conceptos] ([Id]),
    CONSTRAINT [FK_PersonalNovedades_Personal] FOREIGN KEY ([PersonalId]) REFERENCES [dbo].[Personal] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_s00SueCpto]
    ON [dbo].[PersonalNovedades]([PersonalId] ASC, [TipoNovedad] ASC);

