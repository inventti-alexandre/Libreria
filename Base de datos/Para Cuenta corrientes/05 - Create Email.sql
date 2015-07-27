USE [lapaz]
GO

/****** Object:  Table [dbo].[Email]    Script Date: 15/01/2015 03:59:42 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Email](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClienteId] [uniqueidentifier] NOT NULL,
	[FechaEmail] [datetime] NULL,
	[Email] [nchar](100) NULL,
	[Saldo] [money] NULL,
	[FechaVencimiento] [datetime] NULL,
 CONSTRAINT [PK_Email] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO


