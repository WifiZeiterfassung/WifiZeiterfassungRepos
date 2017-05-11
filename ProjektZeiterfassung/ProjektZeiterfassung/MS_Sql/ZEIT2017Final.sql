USE [master]
GO
/****** Object:  Database [ZEIT2017Full]    Script Date: 11.05.2017 19:50:19 ******/
CREATE DATABASE [ZEIT2017Full]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ZEIT2017Full', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ZEIT2017Full.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ZEIT2017Full_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ZEIT2017Full_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ZEIT2017Full] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ZEIT2017Full].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ZEIT2017Full] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ZEIT2017Full] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ZEIT2017Full] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ZEIT2017Full] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ZEIT2017Full] SET ARITHABORT OFF 
GO
ALTER DATABASE [ZEIT2017Full] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ZEIT2017Full] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ZEIT2017Full] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ZEIT2017Full] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ZEIT2017Full] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ZEIT2017Full] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ZEIT2017Full] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ZEIT2017Full] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ZEIT2017Full] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ZEIT2017Full] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ZEIT2017Full] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ZEIT2017Full] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ZEIT2017Full] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ZEIT2017Full] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ZEIT2017Full] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ZEIT2017Full] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ZEIT2017Full] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ZEIT2017Full] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ZEIT2017Full] SET  MULTI_USER 
GO
ALTER DATABASE [ZEIT2017Full] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ZEIT2017Full] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ZEIT2017Full] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ZEIT2017Full] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ZEIT2017Full] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ZEIT2017Full]
GO
/****** Object:  Table [dbo].[Auswertungstabelle]    Script Date: 11.05.2017 19:50:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Auswertungstabelle](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Tagesdatum] [smalldatetime] NULL,
	[Arbeitzeit] [decimal](5, 2) NULL,
	[Pausenzeit] [decimal](5, 2) NULL,
	[Nettoarbeitszeit] [decimal](5, 2) NULL,
	[Differenz] [decimal](5, 2) NULL,
	[FK_Mitarbeiter] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EintrittAustritt]    Script Date: 11.05.2017 19:50:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EintrittAustritt](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FK_Mitarbeiter] [int] NOT NULL,
	[EintrittsDatum] [smalldatetime] NULL,
	[AustrittsDatum] [smalldatetime] NULL,
	[TagesSollZeit] [decimal](5, 2) NOT NULL,
 CONSTRAINT [PK_EintrittAustritt] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hilfstabelle]    Script Date: 11.05.2017 19:50:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hilfstabelle](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Hilfseigenschaft] [nvarchar](20) NULL,
	[FK_Mitarbeiter] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Mitarbeiter]    Script Date: 11.05.2017 19:50:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mitarbeiter](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Personalnummer] [nvarchar](6) NOT NULL,
	[Vorname] [nvarchar](20) NOT NULL,
	[Nachname] [nvarchar](30) NOT NULL,
	[IstAktiv] [bit] NOT NULL,
	[Passwort] [varbinary](max) NULL,
 CONSTRAINT [PK_Mitarbeiter] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PauseZeiten]    Script Date: 11.05.2017 19:50:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PauseZeiten](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PauseAnfang] [smalldatetime] NULL,
	[PauseEnde] [smalldatetime] NULL,
	[FK_Mitarbeiter] [int] NOT NULL,
 CONSTRAINT [PK_PauseZeiten] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Zeiterfassung]    Script Date: 11.05.2017 19:50:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zeiterfassung](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TagesDatum] [smalldatetime] NULL,
	[Zeit] [time](0) NULL,
	[Zeittyp] [nvarchar](20) NULL,
	[TagesIstZeit] [decimal](5, 2) NULL,
	[FK_Mitarbeiter_ID] [int] NOT NULL,
 CONSTRAINT [PK_Zeiterfassung] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Zeiterfassung_Mitarbeiter]    Script Date: 11.05.2017 19:50:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zeiterfassung_Mitarbeiter](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FK_Mitarbeiter] [int] NOT NULL,
	[FK_Zeiterfassung] [int] NOT NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Auswertungstabelle]  WITH CHECK ADD  CONSTRAINT [FK_Auswertungstabelle_Mitarbeiter] FOREIGN KEY([FK_Mitarbeiter])
REFERENCES [dbo].[Mitarbeiter] ([ID])
GO
ALTER TABLE [dbo].[Auswertungstabelle] CHECK CONSTRAINT [FK_Auswertungstabelle_Mitarbeiter]
GO
ALTER TABLE [dbo].[EintrittAustritt]  WITH CHECK ADD  CONSTRAINT [FK_EintrittAustritt_Mitarbeiter] FOREIGN KEY([FK_Mitarbeiter])
REFERENCES [dbo].[Mitarbeiter] ([ID])
GO
ALTER TABLE [dbo].[EintrittAustritt] CHECK CONSTRAINT [FK_EintrittAustritt_Mitarbeiter]
GO
ALTER TABLE [dbo].[PauseZeiten]  WITH CHECK ADD  CONSTRAINT [FK_PauseZeiten_Mitarbeiter] FOREIGN KEY([FK_Mitarbeiter])
REFERENCES [dbo].[Mitarbeiter] ([ID])
GO
ALTER TABLE [dbo].[PauseZeiten] CHECK CONSTRAINT [FK_PauseZeiten_Mitarbeiter]
GO
ALTER TABLE [dbo].[Zeiterfassung]  WITH CHECK ADD  CONSTRAINT [FK_Zeiterfassung_Mitarbeiter] FOREIGN KEY([FK_Mitarbeiter_ID])
REFERENCES [dbo].[Mitarbeiter] ([ID])
GO
ALTER TABLE [dbo].[Zeiterfassung] CHECK CONSTRAINT [FK_Zeiterfassung_Mitarbeiter]
GO
ALTER TABLE [dbo].[Zeiterfassung_Mitarbeiter]  WITH CHECK ADD  CONSTRAINT [FK_Zeiterfassung_Mitarbeiter_Mitarbeiter] FOREIGN KEY([FK_Mitarbeiter])
REFERENCES [dbo].[Mitarbeiter] ([ID])
GO
ALTER TABLE [dbo].[Zeiterfassung_Mitarbeiter] CHECK CONSTRAINT [FK_Zeiterfassung_Mitarbeiter_Mitarbeiter]
GO
ALTER TABLE [dbo].[Zeiterfassung_Mitarbeiter]  WITH CHECK ADD  CONSTRAINT [FK_Zeiterfassung_Mitarbeiter_Zeiterfassung] FOREIGN KEY([FK_Zeiterfassung])
REFERENCES [dbo].[Zeiterfassung] ([ID])
GO
ALTER TABLE [dbo].[Zeiterfassung_Mitarbeiter] CHECK CONSTRAINT [FK_Zeiterfassung_Mitarbeiter_Zeiterfassung]
GO
/****** Object:  StoredProcedure [dbo].[Pr_SucheIdMitarbeiter]    Script Date: 11.05.2017 19:50:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 ---------------------------------------------------------
 --Prozedur zum lesen der ID des Mitarbeiters für die 
 --Speicherung in der Zeiterfassungstabelle als FK_Mitarbeiter
 ---------------------------------------------------------
 CREATE PROCEDURE [dbo].[Pr_SucheIdMitarbeiter]
	@ID int = 0,
	@PersonalNummer Nvarchar(6)
AS
	SELECT ID
	FROM [dbo].[Mitarbeiter]
	WHERE @PersonalNummer = Mitarbeiter.Personalnummer;

GO
/****** Object:  StoredProcedure [dbo].[Procedur_MitarbeiterSuchen]    Script Date: 11.05.2017 19:50:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

---------------------------------------------------------
--Insert Dummy Werte in Stammdatenbank Person
---------------------------------------------------------
INSERT INTO Mitarbeiter (Personalnummer,Vorname,Nachname,IstAktiv) VALUES ('1031','Hans','Moser',0);
INSERT INTO Mitarbeiter (Personalnummer,Vorname,Nachname,IstAktiv) VALUES ('1032','Franz','Valentin',0);
INSERT INTO Mitarbeiter (Personalnummer,Vorname,Nachname,IstAktiv) VALUES ('1033','Silvia','Schlögl',0);
INSERT INTO Mitarbeiter (Personalnummer,Vorname,Nachname,IstAktiv) VALUES ('1034','Karl','Gruber',0);
INSERT INTO Mitarbeiter (Personalnummer,Vorname,Nachname,IstAktiv) VALUES ('1035','Hans','Huber',0);
INSERT INTO Mitarbeiter (Personalnummer,Vorname,Nachname,IstAktiv) VALUES ('1036','Karl','Koller',0);
GO

---------------------------------------------------------
--Insert Dummy Werte in Stammdatenbank EintrittAustritt
---------------------------------------------------------

INSERT INTO EintrittAustritt (FK_Mitarbeiter,EintrittsDatum,TagesSollZeit) VALUES (1,'01-08-1980',8);
INSERT INTO EintrittAustritt (FK_Mitarbeiter,EintrittsDatum,TagesSollZeit) VALUES (2,'01-07-1990',8);
INSERT INTO EintrittAustritt (FK_Mitarbeiter,EintrittsDatum,TagesSollZeit) VALUES (3,'01-05-1999',6);
INSERT INTO EintrittAustritt (FK_Mitarbeiter,EintrittsDatum,TagesSollZeit) VALUES (4,'01-04-2010',8);
INSERT INTO EintrittAustritt (FK_Mitarbeiter,EintrittsDatum,TagesSollZeit) VALUES (5,'01-01-2000',5);
INSERT INTO EintrittAustritt (FK_Mitarbeiter,EintrittsDatum,TagesSollZeit) VALUES (6,'01-02-2016',8);
GO

----------------------------------------------------------------
--Prozedur Suche eines Mitarbeiters mit seiner Personalnummer 
--zur Anzeige seiner Daten in der Hauptansicht wenn null angegeben
--wird werden alle Mitarbeiter in die Liste geladen 
----------------------------------------------------------------
CREATE PROCEDURE [dbo].[Procedur_MitarbeiterSuchen]
		 @Id int = null
        ,@PersonalNummer nvarchar(6) = null
AS
SET NOCOUNT ON

-- Falls keine Parameter angegeben wurden,
-- alle Daten liefern
IF @ID IS NULL AND @PersonalNummer IS NULL  
	BEGIN
		SELECT m.[ID]
			  ,m.[Personalnummer]
			  ,m.[Vorname]
			  ,m.[Nachname]
			  ,ea.[EintrittsDatum]
			  ,ea.[AustrittsDatum]
			  ,ea.[TagesSollZeit]
			  ,m.[IstAktiv]
		FROM [dbo].[Mitarbeiter] AS m
			LEFT JOIN [dbo].[EintrittAustritt] AS ea
				ON m.[ID] = ea.[FK_Mitarbeiter]
	END 
ELSE 
BEGIN
-- Falls ein Schlüssel vorhanden ist,
-- nur diesen Datensatz zurückgeben...
	IF NOT @PersonalNummer IS NULL 
	BEGIN
		SELECT m.[ID]
			  ,m.[Personalnummer]
			  ,m.[Vorname]
			  ,m.[Nachname]
			  ,ea.[EintrittsDatum]
			  ,ea.[AustrittsDatum]
			  ,ea.[TagesSollZeit]
			  ,m.[IstAktiv]
		FROM [dbo].[Mitarbeiter] AS m
			LEFT JOIN [dbo].[EintrittAustritt] AS ea
				ON m.[ID] = ea.[FK_Mitarbeiter]
		WHERE m.[Personalnummer] = @PersonalNummer
	END
END;

GO
USE [master]
GO
ALTER DATABASE [ZEIT2017Full] SET  READ_WRITE 
GO
