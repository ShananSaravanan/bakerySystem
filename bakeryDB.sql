USE [master]
GO
/****** Object:  Database [bakerysystem]    Script Date: 2/5/2023 12:24:55 AM ******/
CREATE DATABASE [bakerysystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bakerysystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\bakerysystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'bakerysystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\bakerysystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [bakerysystem] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bakerysystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bakerysystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bakerysystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bakerysystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bakerysystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bakerysystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [bakerysystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bakerysystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bakerysystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bakerysystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bakerysystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bakerysystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bakerysystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bakerysystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bakerysystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bakerysystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [bakerysystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bakerysystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bakerysystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bakerysystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bakerysystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bakerysystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bakerysystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bakerysystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [bakerysystem] SET  MULTI_USER 
GO
ALTER DATABASE [bakerysystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bakerysystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bakerysystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bakerysystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [bakerysystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [bakerysystem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [bakerysystem] SET QUERY_STORE = OFF
GO
USE [bakerysystem]
GO
/****** Object:  Table [dbo].[Cake]    Script Date: 2/5/2023 12:24:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cake](
	[ID] [varchar](50) NOT NULL,
	[cakeName] [varchar](max) NOT NULL,
	[typeID] [varchar](50) NOT NULL,
	[pricePerSlice] [float] NOT NULL,
	[cakeImage] [image] NOT NULL,
 CONSTRAINT [PK_Cake] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CakeTypes]    Script Date: 2/5/2023 12:24:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CakeTypes](
	[ID] [varchar](50) NOT NULL,
	[TypeName] [varchar](max) NOT NULL,
 CONSTRAINT [PK_CakeTypes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerScreen]    Script Date: 2/5/2023 12:24:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerScreen](
	[ID] [varchar](50) NOT NULL,
	[orderID] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CustomerScreen] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Log]    Script Date: 2/5/2023 12:24:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Log](
	[logID] [varchar](50) NOT NULL,
	[logInTime] [timestamp] NOT NULL,
	[staffID] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Log] PRIMARY KEY CLUSTERED 
(
	[logID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 2/5/2023 12:24:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[ID] [varchar](50) NOT NULL,
	[cakeID] [varchar](50) NOT NULL,
	[customerID] [varchar](50) NOT NULL,
	[orderQuantity] [int] NOT NULL,
	[addOnWish] [varchar](max) NULL,
	[orderTotal] [decimal](18, 0) NOT NULL,
	[TimeOfOrder] [timestamp] NOT NULL,
	[statusID] [int] NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 2/5/2023 12:24:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[ID] [varchar](50) NOT NULL,
	[staffIcNo] [varchar](50) NOT NULL,
	[staffName] [varchar](max) NOT NULL,
	[staffPhoneNo] [varchar](50) NOT NULL,
	[staffPassword] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusTypes]    Script Date: 2/5/2023 12:24:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusTypes](
	[ID] [int] NOT NULL,
	[statusName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_StatusTypes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cake]  WITH CHECK ADD  CONSTRAINT [FK_Cake_Cake] FOREIGN KEY([typeID])
REFERENCES [dbo].[CakeTypes] ([ID])
GO
ALTER TABLE [dbo].[Cake] CHECK CONSTRAINT [FK_Cake_Cake]
GO
ALTER TABLE [dbo].[CakeTypes]  WITH CHECK ADD  CONSTRAINT [FK_CakeTypes_CakeTypes] FOREIGN KEY([ID])
REFERENCES [dbo].[CakeTypes] ([ID])
GO
ALTER TABLE [dbo].[CakeTypes] CHECK CONSTRAINT [FK_CakeTypes_CakeTypes]
GO
ALTER TABLE [dbo].[Log]  WITH CHECK ADD  CONSTRAINT [FK_Log_Staff] FOREIGN KEY([staffID])
REFERENCES [dbo].[Staff] ([ID])
GO
ALTER TABLE [dbo].[Log] CHECK CONSTRAINT [FK_Log_Staff]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Cake] FOREIGN KEY([cakeID])
REFERENCES [dbo].[Cake] ([ID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Cake]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_CustomerScreen] FOREIGN KEY([customerID])
REFERENCES [dbo].[CustomerScreen] ([ID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_CustomerScreen]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_StatusTypes] FOREIGN KEY([statusID])
REFERENCES [dbo].[StatusTypes] ([ID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_StatusTypes]
GO
USE [master]
GO
ALTER DATABASE [bakerysystem] SET  READ_WRITE 
GO
