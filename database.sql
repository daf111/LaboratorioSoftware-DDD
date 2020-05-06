USE [laboratorio-software]
GO
/****** Object:  Table [dbo].[tipo_producto]    Script Date: 30/04/2020 3:49:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_producto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
 CONSTRAINT [PK_tipo_producto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tipo_producto] ON 
GO
INSERT [dbo].[tipo_producto] ([id], [nombre]) VALUES (1, N'Juegos')
GO
INSERT [dbo].[tipo_producto] ([id], [nombre]) VALUES (2, N'Computación')
GO
SET IDENTITY_INSERT [dbo].[tipo_producto] OFF
GO
