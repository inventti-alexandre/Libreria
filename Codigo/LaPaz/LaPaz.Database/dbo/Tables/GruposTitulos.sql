CREATE TABLE [dbo].[GruposTitulos] (
    [Id]                     INT              NOT NULL,
    [Nombre]                 NVARCHAR (50)    NOT NULL,
    [Abreviatura]            NVARCHAR (10)    NULL,
    [Descripcion]            NVARCHAR (50)    NULL,
    [Prioridad]              INT              NULL,
    [SucursalAltaId]         INT              NOT NULL,
    [FechaAlta]              DATETIME         NOT NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NOT NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_GruposTitulos] PRIMARY KEY CLUSTERED ([Id] ASC)
);

