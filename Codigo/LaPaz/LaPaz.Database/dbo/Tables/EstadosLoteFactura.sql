CREATE TABLE [dbo].[EstadosLoteFactura] (
    [Id]                     INT              NOT NULL,
    [Nombre]                 VARCHAR (50)     NOT NULL,
    [Abreviatura]            NVARCHAR (10)    NULL,
    [Decripcion]             NVARCHAR (50)    NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_EstadosLoteFactura] PRIMARY KEY CLUSTERED ([Id] ASC)
);

