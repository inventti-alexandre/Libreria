﻿CREATE TABLE [dbo].[Personal] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [ContactoId]             UNIQUEIDENTIFIER NULL,
    [Nombre]                 NVARCHAR (50)    NULL,
    [Cuit]                   NVARCHAR (50)    NULL,
    [Domicilio]              NVARCHAR (100)   NULL,
    [ProvinciaId]            INT              NULL,
    [LocalidadId]            INT              NULL,
    [CategoriaId]            INT              NULL,
    [SucursalId]             INT              NULL,
    [TipoLiquidacionId]      INT              NULL,
    [Telefono]               NVARCHAR (50)    NULL,
    [Celular]                NVARCHAR (50)    NULL,
    [Fax]                    NVARCHAR (50)    NULL,
    [FechaAlta]              DATETIME         NULL,
    [HoraDesdeM]             CHAR (4)         NULL,
    [HoraHastaM]             CHAR (4)         NULL,
    [HoraDesdeT]             CHAR (4)         NULL,
    [HoraHastaT]             CHAR (4)         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_Personal] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Personal_CategoriasOperadores] FOREIGN KEY ([CategoriaId]) REFERENCES [dbo].[CategoriasOperadores] ([Id]), 
    CONSTRAINT [FK_Personal_Provincia] FOREIGN KEY ([ProvinciaId]) REFERENCES [Provincias]([Id]), 
    CONSTRAINT [FK_Personal_Localidad] FOREIGN KEY ([LocalidadId]) REFERENCES [Localidades]([Id])
);

