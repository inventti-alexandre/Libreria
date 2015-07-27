CREATE TABLE [dbo].[ProveedoresCuentasCorriente] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [CompraId]               UNIQUEIDENTIFIER NOT NULL,
    [ProveedorId]            UNIQUEIDENTIFIER NOT NULL,
    [Cuota]                  INT              NOT NULL,
    [Fecha]                  DATETIME         NULL,
    [FechaVencimiento]       DATETIME         NULL,
    [Importe]                MONEY            NULL,
    [Pagado]                 MONEY            NULL,
    [Observaciones]          VARCHAR (255)    NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_s00CCProv] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_ProveedoresCuentasCorriente_Compras] FOREIGN KEY ([CompraId]) REFERENCES [dbo].[Compras] ([Id]),
    CONSTRAINT [FK_ProveedoresCuentasCorriente_OperadoresAlta] FOREIGN KEY ([OperadorAltaId]) REFERENCES [dbo].[Operadores] ([Id]),
    CONSTRAINT [FK_ProveedoresCuentasCorriente_OperadoresModificacion] FOREIGN KEY ([OperadorModificacionId]) REFERENCES [dbo].[Operadores] ([Id]),
    CONSTRAINT [FK_ProveedoresCuentasCorriente_Proveedores] FOREIGN KEY ([ProveedorId]) REFERENCES [dbo].[Proveedores] ([Id]),
    CONSTRAINT [FK_ProveedoresCuentasCorriente_SucursalesAlta] FOREIGN KEY ([SucursalAltaId]) REFERENCES [dbo].[Sucursales] ([Id]),
    CONSTRAINT [FK_ProveedoresCuentasCorriente_SucursalesModificacion] FOREIGN KEY ([SucursalModificacionId]) REFERENCES [dbo].[Sucursales] ([Id])
);




GO
CREATE NONCLUSTERED INDEX [IX_s00CCProv_2]
    ON [dbo].[ProveedoresCuentasCorriente]([Fecha] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_s00CCProv_3]
    ON [dbo].[ProveedoresCuentasCorriente]([FechaVencimiento] ASC);

