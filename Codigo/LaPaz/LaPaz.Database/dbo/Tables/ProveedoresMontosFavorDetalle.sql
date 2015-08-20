CREATE TABLE [dbo].[ProveedoresMontosFavorDetalle]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ProveedoresMontosFavor] UNIQUEIDENTIFIER NOT NULL, 
    [TitulosId] UNIQUEIDENTIFIER NOT NULL, 
    [CantidadPropia] INT NULL, 
    [CantidadConsignada] INT NULL, 
    [FechaAlta] DATETIME NULL, 
    [SucursalAltaId] INT NULL, 
    [OperadorAltaId] UNIQUEIDENTIFIER NULL, 
    [FechaModificacion] DATETIME NULL, 
    [SucursalModificacionId] INT NULL, 
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL, 
    CONSTRAINT [FK_ProveedoresMontosFavorDetalle_ProveedorMontoFavor] FOREIGN KEY (ProveedoresMontosFavor) REFERENCES ProveedoresMontosFavor(Id), 
    CONSTRAINT [FK_ProveedoresMontosFavorDetalle_Titulos] FOREIGN KEY (TitulosId) REFERENCES Titulos(Id), 
    CONSTRAINT [FK_ProveedoresMontosFavorDetalle_SucursalAlta] FOREIGN KEY (SucursalAltaId) REFERENCES Sucursales(Id), 
    CONSTRAINT [FK_ProveedoresMontosFavorDetalle_OperadorAlta] FOREIGN KEY (OperadorAltaId) REFERENCES Operadores(Id), 
    CONSTRAINT [FK_ProveedoresMontosFavorDetalle_SucursalModificacion] FOREIGN KEY (SucursalModificacionId) REFERENCES Sucursales(Id),
    CONSTRAINT [FK_ProveedoresMontosFavorDetalle_OperadorModificacion] FOREIGN KEY (OperadorModificacionId) REFERENCES Operadores(Id)
)
