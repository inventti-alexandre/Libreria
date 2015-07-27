CREATE TABLE [dbo].[Alumnos] (
    [Id]                     INT              IDENTITY (1, 1) NOT NULL,
    [ClienteId]              UNIQUEIDENTIFIER NULL,
    [AlumnoCuit]             VARCHAR (11)     NOT NULL,
    [ntipoDoc]               INT              NOT NULL,
    [AlumnoNomyApe]          NVARCHAR (80)    NOT NULL,
    [AlumnoDomicilo]         NVARCHAR (90)    NOT NULL,
    [AlumnoTelefono]         NVARCHAR (40)    NOT NULL,
    [AlumnoColegio]          VARCHAR (80)     NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_Alumnos] PRIMARY KEY CLUSTERED ([Id] ASC)
);

