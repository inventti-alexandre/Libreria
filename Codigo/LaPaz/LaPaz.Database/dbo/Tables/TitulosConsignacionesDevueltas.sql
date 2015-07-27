CREATE TABLE [dbo].[TitulosConsignacionesDevueltas]
(
	[Id] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY, 
    [ProveedorId] UNIQUEIDENTIFIER NOT NULL, 
	[LCN] nchar(13) NOT NULL,
    [Observaciones] VARCHAR(2000) NULL, 
    [FechaAlta] DATETIME NOT NULL, 
    [OperadorAltaId] UNIQUEIDENTIFIER NOT NULL, 
    [SucursalAltaId] INT NOT NULL, 
    CONSTRAINT [FK_TitulosConsignacionesDevueltas_Proveedores] FOREIGN KEY ([ProveedorId]) REFERENCES [Proveedores]([Id]),
	CONSTRAINT [FK_TitulosConsignacionesDevueltas_Operadores] FOREIGN KEY ([OperadorAltaId]) REFERENCES [Operadores]([Id]),
	CONSTRAINT [FK_TitulosConsignacionesDevueltas_Sucursales] FOREIGN KEY ([SucursalAltaId]) REFERENCES [Sucursales]([Id])
)
