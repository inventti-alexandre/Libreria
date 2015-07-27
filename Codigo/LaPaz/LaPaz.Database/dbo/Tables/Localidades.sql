CREATE TABLE [dbo].[Localidades] (
    [Id]                     INT              NOT NULL,
    [Nombre]                 NVARCHAR (40)    NULL,
    [CP]                     NVARCHAR (10)    NULL,
    [ProvinciaId]            INT              NOT NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_Localidades_1] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_s00Localidades]
    ON [dbo].[Localidades]([Id] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_s00Localidades_1]
    ON [dbo].[Localidades]([ProvinciaId] ASC);

