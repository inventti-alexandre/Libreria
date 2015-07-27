CREATE TABLE [dbo].[OrdenesPagoTransferencia]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [OrdenPagoId] UNIQUEIDENTIFIER NOT NULL, 
    [CuentaId] INT NOT NULL, 
    [Numero] VARCHAR(50) NOT NULL, 
    [Fecha] DATETIME NOT NULL, 
    [Importe] MONEY NOT NULL, 
    [BancoDestino] VARCHAR(50) NOT NULL, 
    [FechaAlta] DATETIME NOT NULL, 
    [SucursalAltaId] INT NOT NULL, 
    [OperadorAltaId] UNIQUEIDENTIFIER NOT NULL, 
    [FechaModificacion] DATETIME NULL, 
    [SucursalModificacionId] INT NULL, 
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL, 
    [FechaAnulacion] DATETIME NULL, 
    CONSTRAINT [FK_OrdenesPagoTransferencia_OrdenesPago] FOREIGN KEY ([OrdenPagoId]) REFERENCES [OrdenesPago]([Id]), 
    CONSTRAINT [FK_OrdenesPagoTransferencia_Cuentas] FOREIGN KEY ([CuentaId]) REFERENCES [Cuentas]([Id]),
	CONSTRAINT [FK_OrdenesPagoTransferencia_SucursalesAlta] FOREIGN KEY ([SucursalAltaId]) REFERENCES [Sucursales]([Id]), 
    CONSTRAINT [FK_OrdenesPagoTransferencia_SucursalesModificacion] FOREIGN KEY ([SucursalModificacionId]) REFERENCES [Sucursales]([Id]), 
    CONSTRAINT [FK_OrdenesPagoTransferencia_OperadoresAlta] FOREIGN KEY ([OperadorAltaId]) REFERENCES [Operadores]([Id]), 
    CONSTRAINT [FK_OrdenesPagoTransferencia_OperadoresModificacion] FOREIGN KEY ([OperadorModificacionId]) REFERENCES [Operadores]([Id])
)
