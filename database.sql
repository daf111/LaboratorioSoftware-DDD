USE [laboratorio-software]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 05/07/2020 23:59:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](10) NULL,
	[fechaNac] [date] NULL,
 CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tipo_producto]    Script Date: 05/07/2020 23:59:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_producto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](10) NULL,
 CONSTRAINT [PK_tipo_producto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[cliente] ON 

INSERT [dbo].[cliente] ([id], [nombre], [fechaNac]) VALUES (1, N'Fatima', CAST(N'1996-04-09' AS Date))
INSERT [dbo].[cliente] ([id], [nombre], [fechaNac]) VALUES (2, N'Pepito', CAST(N'1994-03-22' AS Date))
INSERT [dbo].[cliente] ([id], [nombre], [fechaNac]) VALUES (3, N'Renata', CAST(N'1986-09-30' AS Date))
INSERT [dbo].[cliente] ([id], [nombre], [fechaNac]) VALUES (4, N'Jacinta', CAST(N'1985-06-01' AS Date))
INSERT [dbo].[cliente] ([id], [nombre], [fechaNac]) VALUES (5, N'Ambar', CAST(N'1965-05-10' AS Date))
SET IDENTITY_INSERT [dbo].[cliente] OFF
SET IDENTITY_INSERT [dbo].[tipo_producto] ON 

INSERT [dbo].[tipo_producto] ([id], [nombre]) VALUES (1, N'tecnologia')
INSERT [dbo].[tipo_producto] ([id], [nombre]) VALUES (2, N'hogar     ')
INSERT [dbo].[tipo_producto] ([id], [nombre]) VALUES (5, N'juguetes  ')
SET IDENTITY_INSERT [dbo].[tipo_producto] OFF
USE [master]
GO
ALTER DATABASE [laboratorio-software] SET  READ_WRITE 
GO
