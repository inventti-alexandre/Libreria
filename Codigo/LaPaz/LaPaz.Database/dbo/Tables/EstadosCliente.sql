CREATE TABLE [dbo].[EstadosCliente] (
    [Id]                     INT              NOT NULL,
    [Nombre]                 VARCHAR (50)     NOT NULL,
    [Abreviatura]            NVARCHAR (10)    NULL,
    [Descripcion]            NVARCHAR (50)    NULL,
    [Prioridad]              INT              NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_EstadosClientes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

