CREATE TABLE [dbo].[Convenios] (
    [ConvenioId]             INT              NOT NULL,
    [ConvenioNombre]         NVARCHAR (50)    NOT NULL,
    [ConvenioFechaInicio]    DATETIME         NOT NULL,
    [ConvenioFechaFin]       DATETIME         NOT NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_Convenios] PRIMARY KEY CLUSTERED ([ConvenioId] ASC)
);

