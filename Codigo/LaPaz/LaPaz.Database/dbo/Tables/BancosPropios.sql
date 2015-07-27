CREATE TABLE [dbo].[BancosPropios] (
    [Id]                     INT              NOT NULL,
    [Nombre]                 NVARCHAR (50)    NOT NULL,
    [Cuenta]                 NCHAR (30)       NULL,
    [Descuento]              INT              NULL,
    [Abreviatura]            CHAR (10)        NULL,
    [ProvinciaId]            INT              NULL,
    [LocalidadId]            INT              NULL,
    [Direccion]              NVARCHAR (50)    NULL,
    [TelPart]                NVARCHAR (20)    NULL,
    [TelCel]                 NVARCHAR (20)    NULL,
    [Fax]                    NVARCHAR (20)    NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_BancosPropios] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_BancosPropios_Localidades] FOREIGN KEY ([LocalidadId]) REFERENCES [dbo].[Localidades] ([Id]),
    CONSTRAINT [FK_BancosPropios_Provincias] FOREIGN KEY ([ProvinciaId]) REFERENCES [dbo].[Provincias] ([Id])
);

