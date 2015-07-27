CREATE TABLE [dbo].[Transportes] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [Nombre]                 NVARCHAR (30)    NULL,
    [Abreviatura]            NVARCHAR (10)    NULL,
    [ProvinciaId]            NUMERIC (18)     NULL,
    [LocalidadId]            NUMERIC (18)     NULL,
    [Direccion]              NVARCHAR (50)    NULL,
    [TelPart]                NVARCHAR (20)    NULL,
    [TelCel]                 NVARCHAR (20)    NULL,
    [Fax]                    NVARCHAR (20)    NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaAlta]              DATETIME         NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    [codant]                 INT              NULL,
    CONSTRAINT [PK_s00Transportes_1] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_s00Transportes_1]
    ON [dbo].[Transportes]([Nombre] ASC) WITH (FILLFACTOR = 90);

