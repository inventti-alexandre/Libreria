USE [lapaz]
GO

SET IDENTITY_INSERT [dbo].[TiposGastos] ON

INSERT INTO [dbo].[TiposGastos]
           ([Id],
		   [Nombre],
           [BienDeUso])
     VALUES
           (46,'Pago Anticipado a Proveedor',0),
		   (47,'Pago a Proveedor',0),
		   (48,'Pago de Cuota a Proveedor',0)
GO

SET IDENTITY_INSERT [dbo].[TiposGastos] OFF


