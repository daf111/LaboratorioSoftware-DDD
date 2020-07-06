USE [master]
GO
/****** Object:  Database [laboratorio-software]    Script Date: 05/07/2020 23:59:10 ******/
CREATE DATABASE [laboratorio-software]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'laboratorio-software', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\laboratorio-software.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'laboratorio-software_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\laboratorio-software_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [laboratorio-software] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [laboratorio-software].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [laboratorio-software] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [laboratorio-software] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [laboratorio-software] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [laboratorio-software] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [laboratorio-software] SET ARITHABORT OFF 
GO
ALTER DATABASE [laboratorio-software] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [laboratorio-software] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [laboratorio-software] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [laboratorio-software] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [laboratorio-software] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [laboratorio-software] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [laboratorio-software] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [laboratorio-software] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [laboratorio-software] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [laboratorio-software] SET  DISABLE_BROKER 
GO
ALTER DATABASE [laboratorio-software] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [laboratorio-software] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [laboratorio-software] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [laboratorio-software] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [laboratorio-software] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [laboratorio-software] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [laboratorio-software] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [laboratorio-software] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [laboratorio-software] SET  MULTI_USER 
GO
ALTER DATABASE [laboratorio-software] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [laboratorio-software] SET DB_CHAINING OFF 
GO
ALTER DATABASE [laboratorio-software] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [laboratorio-software] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [laboratorio-software] SET DELAYED_DURABILITY = DISABLED 
GO
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
