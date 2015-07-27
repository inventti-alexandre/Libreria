CREATE TABLE [dbo].[SubEspecialidades] (
    [Id]                     INT              IDENTITY (1, 1) NOT NULL,
    [Nombre]                 VARCHAR (50)     NULL,
    [Especialidad_Id]        INT              NOT NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_EspecialidadesDetalle] PRIMARY KEY CLUSTERED ([Id] ASC)
);

