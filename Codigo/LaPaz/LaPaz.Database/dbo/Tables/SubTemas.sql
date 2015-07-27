CREATE TABLE [dbo].[SubTemas] (
    [Id]                     INT              IDENTITY (1, 1) NOT NULL,
    [TemaId]                 INT              NOT NULL,
    [Nombre]                 VARCHAR (50)     NULL,
    [Abreviatura]            VARCHAR (10)     NULL,
    [Descripcion]            VARCHAR (50)     NULL,
    [Prioridad]              INT              NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_SubTemas] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_SubTemas_Tema] FOREIGN KEY (TemaId) REFERENCES Temas(Id), 
    CONSTRAINT [FK_SubTemas_SusursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_SubTemas_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_SubTemas_SusursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_SubTemas_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id), 
);


GO
CREATE NONCLUSTERED INDEX [IX_s00LibrosSubTemas]
    ON [dbo].[SubTemas]([Id] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_s00LibrosSubTemas_1]
    ON [dbo].[SubTemas]([TemaId] ASC);

