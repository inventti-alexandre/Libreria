CREATE TABLE [dbo].[TitulosUbicacion] (
    [Id]                     INT              NOT NULL,
    [Piso]                   INT              NULL,
    [AreaId]                 INT              NULL,
    [TemaId]                 INT              NULL,
    [EspecialidadId]         INT              NULL,
    [SubEspecialidadId]      INT              NULL,
    [Path]                   VARCHAR (300)    NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_s00LibUbi] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TitulosUbicacion_Areas] FOREIGN KEY ([AreaId]) REFERENCES [dbo].[Areas] ([Id]),
    CONSTRAINT [FK_TitulosUbicacion_Especialidades] FOREIGN KEY ([EspecialidadId]) REFERENCES [dbo].[Especialidades] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_s00LibUbi]
    ON [dbo].[TitulosUbicacion]([Id] ASC);

