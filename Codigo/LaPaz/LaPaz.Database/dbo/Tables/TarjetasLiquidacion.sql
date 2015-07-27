CREATE TABLE [dbo].[TarjetasLiquidacion] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [TarjetaId]              INT              NOT NULL,
    [CajaId]                 UNIQUEIDENTIFIER NOT NULL,
    [TrjLiq]                 NCHAR (10)       NULL,
    [Entidad]                INT              NULL,
    [FechaEmision]           DATETIME         NULL,
    [Importe]                MONEY            NOT NULL,
    [Imp2]                   MONEY            NULL,
    [Imp3]                   MONEY            NULL,
    [Imp4]                   MONEY            NULL,
    [Imp5]                   MONEY            NULL,
    [Imp6]                   MONEY            NULL,
    [FechaAlta]              DATETIME         NOT NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NOT NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_TarjetasLiquidacion] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TarjetasLiquidacion_Cajas] FOREIGN KEY ([CajaId]) REFERENCES [dbo].[Cajas] ([Id])
);

