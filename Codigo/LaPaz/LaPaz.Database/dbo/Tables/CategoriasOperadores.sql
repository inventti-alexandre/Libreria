CREATE TABLE [dbo].[CategoriasOperadores] (
    [Id]                     INT              IDENTITY (1, 1) NOT NULL,
    [Nombre]                 VARCHAR (50)     NULL,
    [Abreviatura]            NVARCHAR (10)    NULL,
    [Descripcion]            NVARCHAR (50)    NULL,
    [Prioridad]              INT              NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_CategoriasOperadores] PRIMARY KEY CLUSTERED ([Id] ASC)
);

