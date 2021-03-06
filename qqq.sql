USE [master]
GO
/****** Object:  Database [BusStation]    Script Date: 21.03.2022 14:02:24 ******/
CREATE DATABASE [BusStation]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BusStation', FILENAME = N'C:\Users\is12866\BusStation.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BusStation_log', FILENAME = N'C:\Users\is12866\BusStation_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BusStation] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BusStation].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BusStation] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BusStation] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BusStation] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BusStation] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BusStation] SET ARITHABORT OFF 
GO
ALTER DATABASE [BusStation] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BusStation] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BusStation] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BusStation] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BusStation] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BusStation] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BusStation] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BusStation] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BusStation] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BusStation] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BusStation] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BusStation] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BusStation] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BusStation] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BusStation] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BusStation] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BusStation] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BusStation] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BusStation] SET  MULTI_USER 
GO
ALTER DATABASE [BusStation] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BusStation] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BusStation] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BusStation] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BusStation] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BusStation] SET QUERY_STORE = OFF
GO
USE [BusStation]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [BusStation]
GO
/****** Object:  Table [dbo].[Bus]    Script Date: 21.03.2022 14:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bus](
	[№ bus] [int] NOT NULL,
	[Brand] [nvarchar](max) NULL,
	[Color] [nvarchar](max) NULL,
 CONSTRAINT [PK_Bus] PRIMARY KEY CLUSTERED 
(
	[№ bus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departure]    Script Date: 21.03.2022 14:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departure](
	[№ bus] [int] NULL,
	[Rout] [int] NULL,
	[Full name of the passenger] [int] NULL,
	[Full name of the driver] [int] NULL,
	[№ seat] [int] NULL,
	[Date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Driver]    Script Date: 21.03.2022 14:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Driver](
	[ID driver] [int] NOT NULL,
	[Full name of the driver] [nvarchar](max) NULL,
	[Experience] [int] NULL,
	[Telephone] [int] NULL,
 CONSTRAINT [PK_Driver] PRIMARY KEY CLUSTERED 
(
	[ID driver] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Passengers]    Script Date: 21.03.2022 14:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passengers](
	[ID passenger] [int] NOT NULL,
	[Full name of the passenger] [nvarchar](max) NULL,
	[Telephone] [int] NULL,
	[Age] [int] NULL,
 CONSTRAINT [PK_Passengers] PRIMARY KEY CLUSTERED 
(
	[ID passenger] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Route]    Script Date: 21.03.2022 14:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Route](
	[ID route] [int] NOT NULL,
	[RouteName] [nvarchar](max) NULL,
	[Travel time] [time](7) NULL,
	[Arrival time] [time](7) NULL,
	[Distance] [int] NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_Route] PRIMARY KEY CLUSTERED 
(
	[ID route] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Bus] ([№ bus], [Brand], [Color]) VALUES (158, N'Peugeot', N'Белый')
INSERT [dbo].[Bus] ([№ bus], [Brand], [Color]) VALUES (163, N'Hyundai', N'Серый')
INSERT [dbo].[Bus] ([№ bus], [Brand], [Color]) VALUES (228, N'Scania', N'Синий')
INSERT [dbo].[Bus] ([№ bus], [Brand], [Color]) VALUES (263, N'Mercedes-Benz', N'Черный')
INSERT [dbo].[Bus] ([№ bus], [Brand], [Color]) VALUES (532, N'Volkswagen', N'Черный')
INSERT [dbo].[Bus] ([№ bus], [Brand], [Color]) VALUES (616, N'MAN', N'Красный')
GO
INSERT [dbo].[Driver] ([ID driver], [Full name of the driver], [Experience], [Telephone]) VALUES (1, N'Иванов А. А.', 10, 636774)
INSERT [dbo].[Driver] ([ID driver], [Full name of the driver], [Experience], [Telephone]) VALUES (2, N'Романов И. Б.', 5, 643754)
INSERT [dbo].[Driver] ([ID driver], [Full name of the driver], [Experience], [Telephone]) VALUES (3, N'Абдщха А. В.', 18, 324850)
GO
INSERT [dbo].[Passengers] ([ID passenger], [Full name of the passenger], [Telephone], [Age]) VALUES (2, N'Иванов И. И.', 523643, 15)
INSERT [dbo].[Passengers] ([ID passenger], [Full name of the passenger], [Telephone], [Age]) VALUES (3, N'Сидоров Р. А.', 552352, 25)
INSERT [dbo].[Passengers] ([ID passenger], [Full name of the passenger], [Telephone], [Age]) VALUES (4, N'Романов Е. Н.', 902392, 40)
GO
INSERT [dbo].[Route] ([ID route], [RouteName], [Travel time], [Arrival time], [Distance], [Price]) VALUES (1, N'Абакан - Красноярск', CAST(N'12:15:00' AS Time), CAST(N'19:39:00' AS Time), 410, 1500)
INSERT [dbo].[Route] ([ID route], [RouteName], [Travel time], [Arrival time], [Distance], [Price]) VALUES (2, N'Абакан - Томск', CAST(N'14:50:00' AS Time), CAST(N'00:23:00' AS Time), 717, 2600)
INSERT [dbo].[Route] ([ID route], [RouteName], [Travel time], [Arrival time], [Distance], [Price]) VALUES (3, N'Абакан - Красноярск', CAST(N'15:40:00' AS Time), CAST(N'23:04:00' AS Time), 410, 1500)
INSERT [dbo].[Route] ([ID route], [RouteName], [Travel time], [Arrival time], [Distance], [Price]) VALUES (4, N'Абакан - Кемерово', CAST(N'09:20:00' AS Time), CAST(N'17:46:00' AS Time), 637, 1800)
INSERT [dbo].[Route] ([ID route], [RouteName], [Travel time], [Arrival time], [Distance], [Price]) VALUES (5, N'Абакан - Кемерово', CAST(N'10:00:00' AS Time), CAST(N'18:26:00' AS Time), 637, 1000)
GO
ALTER TABLE [dbo].[Departure]  WITH CHECK ADD  CONSTRAINT [FK_Departure_Bus] FOREIGN KEY([№ bus])
REFERENCES [dbo].[Bus] ([№ bus])
GO
ALTER TABLE [dbo].[Departure] CHECK CONSTRAINT [FK_Departure_Bus]
GO
ALTER TABLE [dbo].[Departure]  WITH CHECK ADD  CONSTRAINT [FK_Departure_Driver] FOREIGN KEY([Full name of the driver])
REFERENCES [dbo].[Driver] ([ID driver])
GO
ALTER TABLE [dbo].[Departure] CHECK CONSTRAINT [FK_Departure_Driver]
GO
ALTER TABLE [dbo].[Departure]  WITH CHECK ADD  CONSTRAINT [FK_Departure_Passengers] FOREIGN KEY([Full name of the passenger])
REFERENCES [dbo].[Passengers] ([ID passenger])
GO
ALTER TABLE [dbo].[Departure] CHECK CONSTRAINT [FK_Departure_Passengers]
GO
ALTER TABLE [dbo].[Departure]  WITH CHECK ADD  CONSTRAINT [FK_Departure_Route] FOREIGN KEY([Rout])
REFERENCES [dbo].[Route] ([ID route])
GO
ALTER TABLE [dbo].[Departure] CHECK CONSTRAINT [FK_Departure_Route]
GO
USE [master]
GO
ALTER DATABASE [BusStation] SET  READ_WRITE 
GO
