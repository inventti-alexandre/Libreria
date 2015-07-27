CREATE TABLE [dbo].[Especialidades] (
    [Id]                     INT              IDENTITY (1, 1) NOT NULL,
    [Nombre]                 VARCHAR (50)     NULL,
    [ProfesionId]            INT              NOT NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_EspecialidadesClientes] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Especialidades_Profesion] FOREIGN KEY (ProfesionId) REFERENCES Profesiones(Id)
);


GO
CREATE NONCLUSTERED INDEX [IX_s00CliEspe]
    ON [dbo].[Especialidades]([Id] ASC);

