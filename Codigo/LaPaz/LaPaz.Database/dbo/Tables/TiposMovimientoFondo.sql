CREATE TABLE [dbo].[TiposMovimientoFondo] (
    [Id]                     INT              IDENTITY (1, 1) NOT NULL,
    [Nombre]                 NVARCHAR (50)    NOT NULL,
    [Abreviatura]            NVARCHAR (10)    NULL,
    [Descripcion]            NVARCHAR (50)    NULL,
    [Prioridad]              INT              NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    [SucursalAltaId]         INT              NULL,
    CONSTRAINT [PK_TiposMovimientoFondo] PRIMARY KEY CLUSTERED ([Id] ASC)
);

