CREATE TABLE [dbo].[TiposCuenta] (
    [Id]                     INT              NOT NULL,
    [Nombre]                 NVARCHAR (50)    NOT NULL,
    [Abreviatura]            NVARCHAR (50)    NULL,
    [Descripción]            NVARCHAR (50)    NULL,
    [Prioridad]              INT              NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_TiposCuenta] PRIMARY KEY CLUSTERED ([Id] ASC)
);

