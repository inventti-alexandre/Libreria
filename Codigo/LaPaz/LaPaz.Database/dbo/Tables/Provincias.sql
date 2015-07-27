CREATE TABLE [dbo].[Provincias] (
    [Id]                     INT              NOT NULL,
    [Nombre]                 VARCHAR (50)     NULL,
    [NombreCorto]            NCHAR (10)       NULL,
    [PaisId]                 INT              NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_Provincias_1] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Provincias_Paises] FOREIGN KEY ([PaisId]) REFERENCES [dbo].[Paises] ([Id])
);

