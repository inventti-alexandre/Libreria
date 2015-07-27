CREATE TABLE [dbo].[ProveedoresBultos] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [ProveedorId]            UNIQUEIDENTIFIER NOT NULL,
    [Fecha]                  SMALLDATETIME    NULL,
    [TransporteId]           UNIQUEIDENTIFIER NULL,
    [Cantidad]               SMALLINT         NULL,
    [Estado]                 INT              NULL,
    [Peso]                   REAL             NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaAlta]              DATETIME         NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_ProveedoresBultos] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ProveedoresBultos_Transportes] FOREIGN KEY ([TransporteId]) REFERENCES [dbo].[Transportes] ([Id])
);

