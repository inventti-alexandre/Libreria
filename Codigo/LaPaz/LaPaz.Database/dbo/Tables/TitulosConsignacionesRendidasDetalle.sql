CREATE TABLE [dbo].[TitulosConsignacionesRendidasDetalle]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [TituloConsignacionRendidaId] UNIQUEIDENTIFIER NOT NULL, 
    [TituloId] UNIQUEIDENTIFIER NOT NULL, 
    [PorcentajeDescuento] DECIMAL(18, 2) NOT NULL, 
    [PrecioCompra] MONEY NOT NULL, 
    [PrecioVenta] MONEY NOT NULL, 
    [Cantidad] INT NOT NULL, 
    [Importe] MONEY NOT NULL, 
    CONSTRAINT [FK_TitulosConsignacionesRendidasDetalle_TitulosConsignacionesRendidas] FOREIGN KEY ([TituloConsignacionRendidaId]) REFERENCES [TitulosConsignacionesRendidas]([Id]), 
    CONSTRAINT [FK_TitulosConsignacionesRendidasDetalle_Titulos] FOREIGN KEY ([TituloId]) REFERENCES [Titulos]([Id])
)
