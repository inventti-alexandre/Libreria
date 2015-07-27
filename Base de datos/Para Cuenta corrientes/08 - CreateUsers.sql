USE [lapaz]
GO

/****** Object:  Table [dbo].[users]    Script Date: 15/01/2015 04:57:32 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [nvarchar](50) NULL,
	[password] [nvarchar](max) NULL,
	[rol] [int] NOT NULL,
	[lapazUser] [uniqueidentifier] NOT NULL,
	[Sucursal] [int] NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_users_roles] FOREIGN KEY([rol])
REFERENCES [dbo].[rolesCtaCte] ([id])
GO

ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_users_roles]
GO


