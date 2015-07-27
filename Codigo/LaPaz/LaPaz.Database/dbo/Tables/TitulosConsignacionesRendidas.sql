CREATE TABLE [dbo].[TitulosConsignacionesRendidas]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [LCN] NCHAR(13) NOT NULL, 
    [ProveedorId] UNIQUEIDENTIFIER NOT NULL, 
    [FechaAlta] DATETIME NOT NULL, 
    [Importe] MONEY NOT NULL, 
    [Observaciones] VARCHAR(1000) NULL, 
    [OperadorAltaId] UNIQUEIDENTIFIER NOT NULL, 
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL, 
    [SucursalAltaId] INT NOT NULL, 
    [SucursalModificacionId] INT NULL, 
    [FechaConsignacion] DATETIME NOT NULL, 
    [TipoConsignacionId] INT NOT NULL, 
    [Pagado] MONEY NULL, 
    [UltimaFechaPago] DATETIME NULL, 
    CONSTRAINT [FK_TitulosConsignacionesRendidas_Proveedores] FOREIGN KEY ([ProveedorId]) REFERENCES [Proveedores]([Id]), 
    CONSTRAINT [FK_TitulosConsignacionesRendidas_OperadorAlta] FOREIGN KEY ([OperadorAltaId]) REFERENCES [Operadores]([Id]),
	CONSTRAINT [FK_TitulosConsignacionesRendidas_OperadorModificacion] FOREIGN KEY ([OperadorModificacionId]) REFERENCES [Operadores]([Id]),
	CONSTRAINT [FK_TitulosConsignacionesRendidas_SucursalAlta] FOREIGN KEY ([SucursalAltaId]) REFERENCES [Sucursales]([Id]),
	CONSTRAINT [FK_TitulosConsignacionesRendidas_SucursalModificacion] FOREIGN KEY ([SucursalModificacionId]) REFERENCES [Sucursales]([Id]),
	CONSTRAINT [FK_TitulosConsignacionesRendidas_TipoConsignacion] FOREIGN KEY ([TipoConsignacionId]) REFERENCES [TiposConsignaciones]([Id])
)
