USE [master]
GO
/****** Object:  Database [Hakaton]    Script Date: 6/23/2022 10:58:38 PM ******/
CREATE DATABASE [Hakaton]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hakaton', FILENAME = N'C:\Users\milica\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\Hakaton.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hakaton_log', FILENAME = N'C:\Users\milica\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\Hakaton.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Hakaton] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hakaton].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hakaton] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [Hakaton] SET ANSI_NULLS ON 
GO
ALTER DATABASE [Hakaton] SET ANSI_PADDING ON 
GO
ALTER DATABASE [Hakaton] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [Hakaton] SET ARITHABORT ON 
GO
ALTER DATABASE [Hakaton] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hakaton] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hakaton] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hakaton] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hakaton] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [Hakaton] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [Hakaton] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hakaton] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [Hakaton] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hakaton] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hakaton] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hakaton] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hakaton] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hakaton] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hakaton] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hakaton] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hakaton] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hakaton] SET RECOVERY FULL 
GO
ALTER DATABASE [Hakaton] SET  MULTI_USER 
GO
ALTER DATABASE [Hakaton] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hakaton] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hakaton] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hakaton] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hakaton] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Hakaton] SET QUERY_STORE = OFF
GO
USE [Hakaton]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Hakaton]
GO
/****** Object:  Table [dbo].[KoordinatorLogistike]    Script Date: 6/23/2022 10:58:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KoordinatorLogistike](
	[KoordinatorId] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [varchar](50) NOT NULL,
	[Prezime] [varchar](50) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[KoordinatorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesto]    Script Date: 6/23/2022 10:58:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesto](
	[PostanskiBroj] [int] NOT NULL,
	[Naziv] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PostanskiBroj] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Plasman]    Script Date: 6/23/2022 10:58:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plasman](
	[RedniBroj] [int] NOT NULL,
	[TimId] [int] NOT NULL,
	[TakmicenjeId] [int] NOT NULL,
	[BrojPoena] [int] NULL,
	[Rang] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[TimId] ASC,
	[TakmicenjeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Takmicar]    Script Date: 6/23/2022 10:58:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Takmicar](
	[TakmicarId] [int] IDENTITY(1,1) NOT NULL,
	[JMBG] [varchar](50) NOT NULL,
	[Ime] [varchar](50) NOT NULL,
	[Prezime] [varchar](50) NOT NULL,
	[Pol] [varchar](50) NULL,
	[TimId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[TakmicarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Takmicenje]    Script Date: 6/23/2022 10:58:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Takmicenje](
	[TakmicenjeId] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [varchar](50) NOT NULL,
	[MestoId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TakmicenjeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tim]    Script Date: 6/23/2022 10:58:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tim](
	[TimId] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TimId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[KoordinatorLogistike] ON 

INSERT [dbo].[KoordinatorLogistike] ([KoordinatorId], [Ime], [Prezime], [Username], [Password]) VALUES (1, N'Milica', N'Simic', N'milica', N'milica')
SET IDENTITY_INSERT [dbo].[KoordinatorLogistike] OFF
GO
INSERT [dbo].[Mesto] ([PostanskiBroj], [Naziv]) VALUES (11000, N'Beograd')
INSERT [dbo].[Mesto] ([PostanskiBroj], [Naziv]) VALUES (11317, N'Lozovik')
INSERT [dbo].[Mesto] ([PostanskiBroj], [Naziv]) VALUES (18300, N'Pirot')
GO
INSERT [dbo].[Plasman] ([RedniBroj], [TimId], [TakmicenjeId], [BrojPoena], [Rang]) VALUES (1, 1, 3, 85, 5)
INSERT [dbo].[Plasman] ([RedniBroj], [TimId], [TakmicenjeId], [BrojPoena], [Rang]) VALUES (0, 1, 13, NULL, NULL)
INSERT [dbo].[Plasman] ([RedniBroj], [TimId], [TakmicenjeId], [BrojPoena], [Rang]) VALUES (0, 2, 13, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Takmicar] ON 

INSERT [dbo].[Takmicar] ([TakmicarId], [JMBG], [Ime], [Prezime], [Pol], [TimId]) VALUES (1, N'1234', N'Pera', N'Pera', N'm', 2)
INSERT [dbo].[Takmicar] ([TakmicarId], [JMBG], [Ime], [Prezime], [Pol], [TimId]) VALUES (1002, N'89468', N'Tatjana', N'Tatjana', N'z', 1002)
INSERT [dbo].[Takmicar] ([TakmicarId], [JMBG], [Ime], [Prezime], [Pol], [TimId]) VALUES (2002, N'1456', N'sanja', N'sanja', N'z', 1003)
INSERT [dbo].[Takmicar] ([TakmicarId], [JMBG], [Ime], [Prezime], [Pol], [TimId]) VALUES (2003, N'1222', N'minja', N'minja', N'm', NULL)
INSERT [dbo].[Takmicar] ([TakmicarId], [JMBG], [Ime], [Prezime], [Pol], [TimId]) VALUES (2004, N'', N'', N'', N'', NULL)
INSERT [dbo].[Takmicar] ([TakmicarId], [JMBG], [Ime], [Prezime], [Pol], [TimId]) VALUES (2005, N'567', N'Laza', N'Laza', N'm', NULL)
INSERT [dbo].[Takmicar] ([TakmicarId], [JMBG], [Ime], [Prezime], [Pol], [TimId]) VALUES (2006, N'1234', N'Milica', N'Mikic', N'z', NULL)
SET IDENTITY_INSERT [dbo].[Takmicar] OFF
GO
SET IDENTITY_INSERT [dbo].[Takmicenje] ON 

INSERT [dbo].[Takmicenje] ([TakmicenjeId], [Naziv], [MestoId]) VALUES (3, N'Girl''s hackaton', 11000)
INSERT [dbo].[Takmicenje] ([TakmicenjeId], [Naziv], [MestoId]) VALUES (5, N'Hakaton za srednjoskolce', 11000)
INSERT [dbo].[Takmicenje] ([TakmicenjeId], [Naziv], [MestoId]) VALUES (7, N'AI Hakaton', 11317)
INSERT [dbo].[Takmicenje] ([TakmicenjeId], [Naziv], [MestoId]) VALUES (13, N'mm', 11000)
SET IDENTITY_INSERT [dbo].[Takmicenje] OFF
GO
SET IDENTITY_INSERT [dbo].[Tim] ON 

INSERT [dbo].[Tim] ([TimId], [Naziv]) VALUES (1, N'BrziMomciIzmena2')
INSERT [dbo].[Tim] ([TimId], [Naziv]) VALUES (2, N'IdeGas')
INSERT [dbo].[Tim] ([TimId], [Naziv]) VALUES (3, N'Delegacija')
INSERT [dbo].[Tim] ([TimId], [Naziv]) VALUES (1002, N'NoviTim')
INSERT [dbo].[Tim] ([TimId], [Naziv]) VALUES (1003, N'SanjaAlone')
SET IDENTITY_INSERT [dbo].[Tim] OFF
GO
ALTER TABLE [dbo].[Plasman]  WITH CHECK ADD  CONSTRAINT [FK_Table_Takmicenje] FOREIGN KEY([TakmicenjeId])
REFERENCES [dbo].[Takmicenje] ([TakmicenjeId])
GO
ALTER TABLE [dbo].[Plasman] CHECK CONSTRAINT [FK_Table_Takmicenje]
GO
ALTER TABLE [dbo].[Plasman]  WITH CHECK ADD  CONSTRAINT [FK_Table_Tim] FOREIGN KEY([TimId])
REFERENCES [dbo].[Tim] ([TimId])
GO
ALTER TABLE [dbo].[Plasman] CHECK CONSTRAINT [FK_Table_Tim]
GO
ALTER TABLE [dbo].[Takmicar]  WITH CHECK ADD  CONSTRAINT [FK_Takmicar_Tim] FOREIGN KEY([TimId])
REFERENCES [dbo].[Tim] ([TimId])
GO
ALTER TABLE [dbo].[Takmicar] CHECK CONSTRAINT [FK_Takmicar_Tim]
GO
ALTER TABLE [dbo].[Takmicenje]  WITH CHECK ADD  CONSTRAINT [FK_Takmicenje_Mesto] FOREIGN KEY([MestoId])
REFERENCES [dbo].[Mesto] ([PostanskiBroj])
GO
ALTER TABLE [dbo].[Takmicenje] CHECK CONSTRAINT [FK_Takmicenje_Mesto]
GO
USE [master]
GO
ALTER DATABASE [Hakaton] SET  READ_WRITE 
GO
