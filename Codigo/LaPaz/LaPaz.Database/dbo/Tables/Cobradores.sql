CREATE TABLE [dbo].[Cobradores] (
    [Id]                     INT              IDENTITY (1, 1) NOT NULL,
    [Nombre]                 NVARCHAR (50)    NOT NULL,
    [Abreviatura]            NVARCHAR (10)    NULL,
    [FechaAlta]              DATETIME         NOT NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NOT NULL,
    [SucursalAltaId]         INT              NOT NULL,
    [FechaModificacion]      DATETIME         NOT NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NOT NULL,
    [SucursalModificacionId] INT              NOT NULL,
    CONSTRAINT [PK_Cobradores] PRIMARY KEY CLUSTERED ([Id] ASC)
);

