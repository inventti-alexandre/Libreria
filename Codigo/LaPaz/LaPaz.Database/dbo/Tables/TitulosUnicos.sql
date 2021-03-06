﻿CREATE TABLE [dbo].[TitulosUnicos] (
    [Id]                     UNIQUEIDENTIFIER CONSTRAINT [DF_TitulosUnicos_Id] DEFAULT (newid()) NOT NULL,
    [ISBN]                   VARCHAR (15)     NULL,
    [NombreTitulo]           VARCHAR (50)     NULL,
    [AutorId]                INT              NULL,
    [EditorialId]            INT              NULL,
    [TemaId]                 INT              NULL,
    [SubtemaId]              INT              NULL,
    [PrecioVentaTitulo]      MONEY            NULL,
    [CodigoBarra]            VARCHAR (50)     NULL,
    [UnidadesId]             INT              NULL,
    [TomosTitulosId]         INT              NULL,
    [EstadoTituloId]         INT              NULL,
    [nAdicional]             INT              NULL,
    [PesoTitulo]             INT              NULL,
    [PaisId]                 INT              NULL,
    [FechaEdicion]           DATETIME         NULL,
    [IdiomaId]               INT              NULL,
    [nParte]                 INT              NULL,
    [rParte]                 VARCHAR (50)     NULL,
    [Paginas]                INT              NULL,
    [Encuad]                 INT              NULL,
    [Comentario]             VARCHAR (100)    NULL,
    [StkMin]                 INT              NULL,
    [FUltVta]                DATETIME         NULL,
    [Fingreso]               DATETIME         NULL,
    [nControl]               INT              NULL,
    [PresentacionId]         INT              NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_TitulosUnicos] PRIMARY KEY NONCLUSTERED ([Id] ASC)
);

