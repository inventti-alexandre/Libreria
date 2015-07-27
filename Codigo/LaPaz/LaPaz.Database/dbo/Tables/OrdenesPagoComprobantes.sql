CREATE TABLE [dbo].[OrdenesPagoComprobantes] (
    [Id]                         UNIQUEIDENTIFIER NOT NULL,
    [OrdenPagoId]                UNIQUEIDENTIFIER NOT NULL,
    [ProveedorCuentaCorrienteId] UNIQUEIDENTIFIER NOT NULL,
    [Importe]                    MONEY            NULL,
    [ImportePagado]              MONEY            NULL,
    [SucursalAltaId]             INT              NULL,
    [FechaAlta]                  DATETIME         NULL,
    [OperadorAltaId]             UNIQUEIDENTIFIER NULL,
    [FechaModificacion]          DATETIME         NULL,
    [OperadorModificacionId]     UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId]     INT              NULL,
    CONSTRAINT [PK_OrdenesPagoComprobantes] PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_OrdenesPagoComprobantes_OrdenesPago] FOREIGN KEY ([OrdenPagoId]) REFERENCES [OrdenesPago]([Id]), 
    CONSTRAINT [FK_OrdenesPagoComprobantes_ProveedoresCuentasCorriente] FOREIGN KEY ([ProveedorCuentaCorrienteId]) REFERENCES [ProveedoresCuentasCorriente]([Id]),
	CONSTRAINT [FK_OrdenesPagoComprobantes_SucursalesAlta] FOREIGN KEY ([SucursalAltaId]) REFERENCES [dbo].[Sucursales]([Id]), 
	CONSTRAINT [FK_OrdenesPagoComprobantes_SucursalesModificacion] FOREIGN KEY ([SucursalModificacionId]) REFERENCES [dbo].[Sucursales]([Id]), 
	CONSTRAINT [FK_OrdenesPagoComprobantes_OperadoresAlta] FOREIGN KEY ([OperadorAltaId]) REFERENCES [dbo].[Operadores]([Id]), 
	CONSTRAINT [FK_OrdenesPagoComprobantes_OperadoresModificacion] FOREIGN KEY ([OperadorModificacionId]) REFERENCES [dbo].[Operadores]([Id])
);


GO
