CREATE TABLE [dbo].[Idiomas] (
    [Id]                     INT              NOT NULL,
    [Nombre]                 VARCHAR (50)     NOT NULL,
    [Abreviatura]            VARCHAR (10)     NULL,
    [Descripcion]            VARCHAR (50)     NULL,
    [Prioridad]              INT              NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_Idiomas] PRIMARY KEY CLUSTERED ([Id] ASC)
);

