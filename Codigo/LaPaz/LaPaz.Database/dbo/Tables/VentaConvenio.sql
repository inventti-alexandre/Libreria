CREATE TABLE [dbo].[VentaConvenio] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [VentaId]                UNIQUEIDENTIFIER NULL,
    [AlumnoId]               INT              NOT NULL,
    [ConvenioId]             INT              NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_VentaConvenio] PRIMARY KEY CLUSTERED ([Id] ASC)
);

