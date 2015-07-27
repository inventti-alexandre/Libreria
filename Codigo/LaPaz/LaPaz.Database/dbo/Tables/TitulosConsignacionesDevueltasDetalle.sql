CREATE TABLE [dbo].[TitulosConsignacionesDevueltasDetalle]
(
	[Id] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY, 
    [TituloConsignacionDevueltaId] int NOT NULL, 
	[TituloId] UNIQUEIDENTIFIER NOT NULL, 
    [Cantidad] INT NOT NULL, 
	CONSTRAINT [FK_TitulosConsignacionesDevueltasDetalle_Titulos] FOREIGN KEY ([TituloId]) REFERENCES [Titulos]([Id]),
	CONSTRAINT [FK_TitulosConsignacionesDevueltasDetalle_TitulosConsignacionesDevueltas] FOREIGN KEY ([TituloConsignacionDevueltaId]) REFERENCES [TitulosConsignacionesDevueltas]([Id])
)
