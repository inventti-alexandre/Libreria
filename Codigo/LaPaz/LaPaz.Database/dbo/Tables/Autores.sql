CREATE TABLE [dbo].[Autores] (
    [Id]                     INT              NOT NULL IDENTITY,
    [Nombre]                 VARCHAR (50)     NULL,
    [Abreviatura]            VARCHAR (10)     NULL,
    [Descripcion]            VARCHAR (50)     NULL,
    [Prioridad]              INT              NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_Autores] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Autores_SucursalesAlta] FOREIGN KEY ([SucursalAltaId]) REFERENCES [Sucursales]([Id]), 
    CONSTRAINT [FK_Autores_SucursalesModificacion] FOREIGN KEY ([SucursalModificacionId]) REFERENCES [Sucursales]([Id]), 
    CONSTRAINT [FK_Autores_OperadoresAlta] FOREIGN KEY ([OperadorAltaId]) REFERENCES [Operadores]([Id]), 
    CONSTRAINT [FK_Autores_OperadoresModificacion] FOREIGN KEY ([OperadorModificacionId]) REFERENCES [Operadores]([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Autores_Tunning1]
    ON [dbo].[Autores]([Id] ASC, [Nombre] ASC);

