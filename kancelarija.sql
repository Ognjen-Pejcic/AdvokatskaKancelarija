USE [master]
GO
/****** Object:  Database [AdvokatskaKancelarija]    Script Date: 2/20/2021 1:57:10 AM ******/
CREATE DATABASE [AdvokatskaKancelarija]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AdvokatskaKancelarija', FILENAME = N'C:\Users\Ognjen\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\AdvokatskaKancelarija.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AdvokatskaKancelarija_log', FILENAME = N'C:\Users\Ognjen\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\AdvokatskaKancelarija.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [AdvokatskaKancelarija] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AdvokatskaKancelarija].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AdvokatskaKancelarija] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET ANSI_NULLS ON 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET ANSI_PADDING ON 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET ARITHABORT ON 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET RECOVERY FULL 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET  MULTI_USER 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AdvokatskaKancelarija] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AdvokatskaKancelarija] SET QUERY_STORE = OFF
GO
USE [AdvokatskaKancelarija]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [AdvokatskaKancelarija]
GO
/****** Object:  Table [dbo].[Advokat]    Script Date: 2/20/2021 1:57:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Advokat](
	[AdvokatID] [int] IDENTITY(1,1) NOT NULL,
	[ImeAdvokata] [varchar](50) NOT NULL,
	[PrezimeAdvokata] [varchar](50) NULL,
	[TelefonAdvokata] [varchar](50) NULL,
	[Specijalnost] [varchar](50) NULL,
 CONSTRAINT [PK_Advokat] PRIMARY KEY CLUSTERED 
(
	[AdvokatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Angazovanje]    Script Date: 2/20/2021 1:57:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Angazovanje](
	[PredmetID] [int] NOT NULL,
	[AdvokatID] [int] NOT NULL,
	[KlijentID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[KlijentID] ASC,
	[AdvokatID] ASC,
	[PredmetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Klijent]    Script Date: 2/20/2021 1:57:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Klijent](
	[KlijentID] [int] IDENTITY(1,1) NOT NULL,
	[JMBGKlijenta] [varchar](50) NOT NULL,
	[ImeKlijenta] [varchar](50) NOT NULL,
	[PrezimeKlijenta] [varchar](50) NOT NULL,
	[TelefonKlijenta] [varchar](50) NOT NULL,
	[AdresaKlijenta] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[KlijentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Predmet]    Script Date: 2/20/2021 1:57:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Predmet](
	[PredmetID] [int] IDENTITY(1,1) NOT NULL,
	[KlijentID] [int] NOT NULL,
	[NazivPredmeta] [varchar](50) NULL,
	[DatumOtvaranja] [datetime] NULL,
	[Arhiviran] [bit] NULL,
	[OpisPredmeta] [varchar](50) NULL,
	[Faza] [varchar](50) NULL,
	[VrstaPostupkaID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PredmetID] ASC,
	[KlijentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sastanak]    Script Date: 2/20/2021 1:57:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sastanak](
	[SastanakID] [int] IDENTITY(1,1) NOT NULL,
	[DatumVreme] [datetime] NULL,
	[AdvokatID] [int] NULL,
	[KlijentID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SastanakID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sekretar]    Script Date: 2/20/2021 1:57:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sekretar](
	[SektretarID] [int] NOT NULL,
	[KorisnickoIme] [varchar](50) NOT NULL,
	[Lozinka] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SektretarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VrstaPostupka]    Script Date: 2/20/2021 1:57:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VrstaPostupka](
	[VrstaPostupkaID] [int] IDENTITY(1,1) NOT NULL,
	[NazivVrstePostupka] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[VrstaPostupkaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Advokat] ON 

INSERT [dbo].[Advokat] ([AdvokatID], [ImeAdvokata], [PrezimeAdvokata], [TelefonAdvokata], [Specijalnost]) VALUES (1, N'Nemanja', N'Pejcic', N'064438653', N'Privredno pravo')
INSERT [dbo].[Advokat] ([AdvokatID], [ImeAdvokata], [PrezimeAdvokata], [TelefonAdvokata], [Specijalnost]) VALUES (2, N'Nikolina', N'Pasic', N'0698756', N'Medjunarodno')
INSERT [dbo].[Advokat] ([AdvokatID], [ImeAdvokata], [PrezimeAdvokata], [TelefonAdvokata], [Specijalnost]) VALUES (3, N'Andrijana', N'Milovanovic', N'123', N'Ostavina')
INSERT [dbo].[Advokat] ([AdvokatID], [ImeAdvokata], [PrezimeAdvokata], [TelefonAdvokata], [Specijalnost]) VALUES (1002, N'Milos', N'Ninkovic', N'065456456', N'Privatno pravo')
SET IDENTITY_INSERT [dbo].[Advokat] OFF
GO
INSERT [dbo].[Angazovanje] ([PredmetID], [AdvokatID], [KlijentID]) VALUES (6002, 1002, 4002)
INSERT [dbo].[Angazovanje] ([PredmetID], [AdvokatID], [KlijentID]) VALUES (6021, 1, 5003)
GO
SET IDENTITY_INSERT [dbo].[Klijent] ON 

INSERT [dbo].[Klijent] ([KlijentID], [JMBGKlijenta], [ImeKlijenta], [PrezimeKlijenta], [TelefonKlijenta], [AdresaKlijenta]) VALUES (1, N'123456789', N'Aleksa', N'Miletic', N'0644444444', N'GK bez broja')
INSERT [dbo].[Klijent] ([KlijentID], [JMBGKlijenta], [ImeKlijenta], [PrezimeKlijenta], [TelefonKlijenta], [AdresaKlijenta]) VALUES (4, N'2309998732512', N'Vuk', N'Djordjevic', N'0644797909', N'Filip')
INSERT [dbo].[Klijent] ([KlijentID], [JMBGKlijenta], [ImeKlijenta], [PrezimeKlijenta], [TelefonKlijenta], [AdresaKlijenta]) VALUES (3002, N'2309998732512', N'Ognjen', N'Pejcic', N'06565656', N'Filipa Visnjica 23')
INSERT [dbo].[Klijent] ([KlijentID], [JMBGKlijenta], [ImeKlijenta], [PrezimeKlijenta], [TelefonKlijenta], [AdresaKlijenta]) VALUES (4002, N'2309998732512', N'Nemanja', N'Pavlovic', N'06123489', N'Krusevac bb')
INSERT [dbo].[Klijent] ([KlijentID], [JMBGKlijenta], [ImeKlijenta], [PrezimeKlijenta], [TelefonKlijenta], [AdresaKlijenta]) VALUES (5003, N'2309998123456', N'Ognjen', N'Pejcic', N'069987654324', N'Vitanovacka, 15')
SET IDENTITY_INSERT [dbo].[Klijent] OFF
GO
SET IDENTITY_INSERT [dbo].[Predmet] ON 

INSERT [dbo].[Predmet] ([PredmetID], [KlijentID], [NazivPredmeta], [DatumOtvaranja], [Arhiviran], [OpisPredmeta], [Faza], [VrstaPostupkaID]) VALUES (2, 1, N'Okrivljeni Stojkovic', CAST(N'2021-02-02T14:08:59.000' AS DateTime), 1, N'opis1', N'Prvostepeni postupak', 1)
INSERT [dbo].[Predmet] ([PredmetID], [KlijentID], [NazivPredmeta], [DatumOtvaranja], [Arhiviran], [OpisPredmeta], [Faza], [VrstaPostupkaID]) VALUES (1008, 1, N'Tuzilac Petrovic protiv tuzenog Jankovica', CAST(N'2021-03-04T13:35:06.000' AS DateTime), 1, N'opis2', N'Drugostepeni postupak', 1)
INSERT [dbo].[Predmet] ([PredmetID], [KlijentID], [NazivPredmeta], [DatumOtvaranja], [Arhiviran], [OpisPredmeta], [Faza], [VrstaPostupkaID]) VALUES (2004, 1, N'Tuzilac Petrovic protiv tuzenog Mirkovic', CAST(N'2021-02-17T00:54:25.000' AS DateTime), 1, N'opis3', N'Drugostepeni postupak', 2)
INSERT [dbo].[Predmet] ([PredmetID], [KlijentID], [NazivPredmeta], [DatumOtvaranja], [Arhiviran], [OpisPredmeta], [Faza], [VrstaPostupkaID]) VALUES (3002, 4, N'Ostavina Maric', CAST(N'2021-02-17T17:47:29.000' AS DateTime), 0, N'opis', N'Drugostepeni postupak', 2)
INSERT [dbo].[Predmet] ([PredmetID], [KlijentID], [NazivPredmeta], [DatumOtvaranja], [Arhiviran], [OpisPredmeta], [Faza], [VrstaPostupkaID]) VALUES (6002, 4002, N'Prekrsaj neki', CAST(N'2021-02-14T12:09:52.000' AS DateTime), 0, N'opis opis opis', N'Prvostepeni postupak', 1)
INSERT [dbo].[Predmet] ([PredmetID], [KlijentID], [NazivPredmeta], [DatumOtvaranja], [Arhiviran], [OpisPredmeta], [Faza], [VrstaPostupkaID]) VALUES (6021, 5003, N'Neki drugi prekrsaj', CAST(N'2021-02-27T12:53:38.000' AS DateTime), 1, N'Bas bas prekrsaj', N'Drugostepeni postupak', 2)
SET IDENTITY_INSERT [dbo].[Predmet] OFF
GO
SET IDENTITY_INSERT [dbo].[Sastanak] ON 

INSERT [dbo].[Sastanak] ([SastanakID], [DatumVreme], [AdvokatID], [KlijentID]) VALUES (5006, CAST(N'2021-02-25T14:21:22.000' AS DateTime), 1, 1)
INSERT [dbo].[Sastanak] ([SastanakID], [DatumVreme], [AdvokatID], [KlijentID]) VALUES (5007, CAST(N'2021-03-13T14:21:22.000' AS DateTime), 1, 1)
INSERT [dbo].[Sastanak] ([SastanakID], [DatumVreme], [AdvokatID], [KlijentID]) VALUES (5008, CAST(N'2021-03-05T15:29:00.000' AS DateTime), 1, 4)
INSERT [dbo].[Sastanak] ([SastanakID], [DatumVreme], [AdvokatID], [KlijentID]) VALUES (5009, CAST(N'2021-04-10T15:29:00.000' AS DateTime), 1, 4)
SET IDENTITY_INSERT [dbo].[Sastanak] OFF
GO
INSERT [dbo].[Sekretar] ([SektretarID], [KorisnickoIme], [Lozinka]) VALUES (1, N'ognjen', N'ognjen')
INSERT [dbo].[Sekretar] ([SektretarID], [KorisnickoIme], [Lozinka]) VALUES (2, N'lele', N'lele')
GO
SET IDENTITY_INSERT [dbo].[VrstaPostupka] ON 

INSERT [dbo].[VrstaPostupka] ([VrstaPostupkaID], [NazivVrstePostupka]) VALUES (1, N'Preksrajni')
INSERT [dbo].[VrstaPostupka] ([VrstaPostupkaID], [NazivVrstePostupka]) VALUES (2, N'Privredni')
SET IDENTITY_INSERT [dbo].[VrstaPostupka] OFF
GO
ALTER TABLE [dbo].[Angazovanje]  WITH CHECK ADD  CONSTRAINT [FK_Angazovanje_Advokat] FOREIGN KEY([AdvokatID])
REFERENCES [dbo].[Advokat] ([AdvokatID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Angazovanje] CHECK CONSTRAINT [FK_Angazovanje_Advokat]
GO
ALTER TABLE [dbo].[Angazovanje]  WITH CHECK ADD  CONSTRAINT [FK_Angazovanje_Predmet] FOREIGN KEY([PredmetID], [KlijentID])
REFERENCES [dbo].[Predmet] ([PredmetID], [KlijentID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Angazovanje] CHECK CONSTRAINT [FK_Angazovanje_Predmet]
GO
ALTER TABLE [dbo].[Predmet]  WITH CHECK ADD  CONSTRAINT [FK_Predmet_Klijent] FOREIGN KEY([KlijentID])
REFERENCES [dbo].[Klijent] ([KlijentID])
GO
ALTER TABLE [dbo].[Predmet] CHECK CONSTRAINT [FK_Predmet_Klijent]
GO
ALTER TABLE [dbo].[Predmet]  WITH CHECK ADD  CONSTRAINT [FK_Premdet_VrstaPostupka] FOREIGN KEY([VrstaPostupkaID])
REFERENCES [dbo].[VrstaPostupka] ([VrstaPostupkaID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Predmet] CHECK CONSTRAINT [FK_Premdet_VrstaPostupka]
GO
ALTER TABLE [dbo].[Sastanak]  WITH CHECK ADD  CONSTRAINT [FK_Sastanak_Advokat] FOREIGN KEY([AdvokatID])
REFERENCES [dbo].[Advokat] ([AdvokatID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Sastanak] CHECK CONSTRAINT [FK_Sastanak_Advokat]
GO
ALTER TABLE [dbo].[Sastanak]  WITH CHECK ADD  CONSTRAINT [FK_Sastanak_Korisnik] FOREIGN KEY([KlijentID])
REFERENCES [dbo].[Klijent] ([KlijentID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Sastanak] CHECK CONSTRAINT [FK_Sastanak_Korisnik]
GO
USE [master]
GO
ALTER DATABASE [AdvokatskaKancelarija] SET  READ_WRITE 
GO
