CREATE TABLE [dbo].[EstadosRemito] (
    [Id]                     INT              NOT NULL,
    [Nombre]                 VARCHAR (50)     NULL,
    [Descripcion]            VARCHAR (50)     NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_EstadosRemito] PRIMARY KEY CLUSTERED ([Id] ASC)
);

