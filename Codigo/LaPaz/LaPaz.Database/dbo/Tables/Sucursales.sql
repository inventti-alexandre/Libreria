CREATE TABLE [dbo].[Sucursales] (
    [Id]                     INT              NOT NULL,
    [Nombre]                 NVARCHAR (30)    NULL,
    [NombreCorto]            NVARCHAR (10)    NULL,
    [ProvinciaId]            INT              NULL,
    [LocalidadId]            INT              NULL,
    [Direccion]              NVARCHAR (50)    NULL,
    [TelPart]                NVARCHAR (20)    NULL,
    [TelCel]                 NVARCHAR (20)    NULL,
    [Fax]                    NVARCHAR (20)    NULL,
    [Responsable]            NVARCHAR (30)    NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [MaximoImporteVenta] MONEY NOT NULL DEFAULT 1000, 
    [MaximoPorcentajeDescuento] DECIMAL(18, 2) NOT NULL DEFAULT 0, 
    [MaximoNroLineasPorVenta] INT NOT NULL DEFAULT 10, 
    CONSTRAINT [PK_s00Sucursales] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Sucursales_Provincias] FOREIGN KEY ([ProvinciaId]) REFERENCES [Provincias]([Id]), 
    CONSTRAINT [FK_Sucursales_Localidades] FOREIGN KEY ([LocalidadId]) REFERENCES [Localidades]([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_s00Sucursales]
    ON [dbo].[Sucursales]([Id] ASC);

