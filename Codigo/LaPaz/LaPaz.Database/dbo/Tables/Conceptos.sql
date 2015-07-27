CREATE TABLE [dbo].[Conceptos] (
    [Id]                     INT              NOT NULL,
    [Nombre]                 VARCHAR (50)     COLLATE Traditional_Spanish_CI_AS NULL,
    [Abreviatura]            NCHAR (10)       COLLATE Traditional_Spanish_CI_AS NULL,
    [TipoConcepto]           CHAR (1)         COLLATE Traditional_Spanish_CI_AS NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_Conceptos] PRIMARY KEY CLUSTERED ([Id] ASC)
);

