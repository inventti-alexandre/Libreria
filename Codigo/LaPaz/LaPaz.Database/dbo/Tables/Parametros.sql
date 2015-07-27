CREATE TABLE [dbo].[Parametros] (
    [Id]                      TINYINT       NOT NULL,
    [AudPeriodo]              TINYINT       NULL,
    [AudCerrado]              TINYINT       NULL,
    [MailServer]              NVARCHAR (50) NULL,
    [MailMio]                 NVARCHAR (50) NULL,
    [Version]                 INT           NULL,
    [FechaCtaCteProveedores]  DATETIME      NULL,
    [SucursalFisicaId]        INT           NULL,
    [TiempoCaja]              DATETIME      NULL,
    [SucursalConcentradoraId] INT           NULL,
    [SucursalImpresion]       INT           NULL,
    CONSTRAINT [PK_Parametros] PRIMARY KEY CLUSTERED ([Id] ASC)
);

