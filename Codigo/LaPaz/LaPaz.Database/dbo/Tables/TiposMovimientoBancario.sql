CREATE TABLE [dbo].[TiposMovimientoBancario] (
    [Id]                     INT              NOT NULL,
    [Nombre]                 NVARCHAR (50)    NOT NULL,
    [Abreviatura]            NVARCHAR (10)    NULL,
    [Descripcion]            NVARCHAR (50)    NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_TiposMovimientoBancario] PRIMARY KEY CLUSTERED ([Id] ASC)
);

