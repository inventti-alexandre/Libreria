CREATE TABLE [dbo].[Temas] (
    [Id]                     INT              NOT NULL IDENTITY,
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
    CONSTRAINT [PK_Temas] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_Temas_SucursalesAlta] FOREIGN KEY ([SucursalAltaId]) REFERENCES [Sucursales]([Id]), 
    CONSTRAINT [FK_Temas_SucursalesModificacion] FOREIGN KEY ([SucursalModificacionId]) REFERENCES [Sucursales]([Id]), 
    CONSTRAINT [FK_Temas_OperadoresAlta] FOREIGN KEY ([OperadorAltaId]) REFERENCES [Operadores]([Id]), 
    CONSTRAINT [FK_Temas_OperadoresModificacion] FOREIGN KEY ([OperadorModificacionId]) REFERENCES [Operadores]([Id])
);

