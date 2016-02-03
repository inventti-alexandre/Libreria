CREATE TABLE [dbo].[TitulosConsignacionesDevueltasDetalles]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[TituloConsignacionDevueltaId] UNIQUEIDENTIFIER NOT NULL, 
	[TituloId] UNIQUEIDENTIFIER NOT NULL, 
    [Cantidad] INT NULL, 
	[CantidadPropia] INT NULL, 
    CONSTRAINT [FK_TitulosConsignacionesDevueltasDetalle_Titulos] FOREIGN KEY ([TituloId]) REFERENCES [Titulos]([Id]), 
    CONSTRAINT [FK_TitulosConsignacionesDevueltasDetalle_Id] FOREIGN KEY (TituloConsignacionDevueltaId) REFERENCES TitulosConsignacionesDevueltas(Id),
)
