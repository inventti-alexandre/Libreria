CREATE TABLE [dbo].[PersonalConcepto] (
    [ID]                     UNIQUEIDENTIFIER NOT NULL,
    [PersonalId]             UNIQUEIDENTIFIER NOT NULL,
    [ConceptoId]             INT              NOT NULL,
    [Importe]                NCHAR (10)       NOT NULL,
    [Vigente]                BIT              NULL,
    [FechaAlta]              DATETIME         NOT NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NOT NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_PersonalConcepto] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_PersonalConcepto_Conceptos] FOREIGN KEY ([ConceptoId]) REFERENCES [dbo].[Conceptos] ([Id]),
    CONSTRAINT [FK_PersonalConcepto_Personal] FOREIGN KEY ([PersonalId]) REFERENCES [dbo].[Personal] ([Id])
);

