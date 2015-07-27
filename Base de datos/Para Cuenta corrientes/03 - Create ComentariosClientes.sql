USE [lapaz]
GO

/****** Object:  Table [dbo].[ComentariosClientes]    Script Date: 15/01/2015 03:55:25 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ComentariosClientes](
	[Cliente] [uniqueidentifier] NULL,
	[Comentario] [uniqueidentifier] NULL,
	[baja] [bit] NULL,
	[Fecha] [datetime] NULL
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[ComentariosClientes]  WITH CHECK ADD  CONSTRAINT [FK_ComentariosClientes_Comentarios] FOREIGN KEY([Comentario])
REFERENCES [dbo].[Comentarios] ([id])
GO

ALTER TABLE [dbo].[ComentariosClientes] CHECK CONSTRAINT [FK_ComentariosClientes_Comentarios]
GO


