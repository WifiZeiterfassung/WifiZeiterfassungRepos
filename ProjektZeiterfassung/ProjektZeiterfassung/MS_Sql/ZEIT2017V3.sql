USE [master]
GO

IF NOT DB_ID('ZEIT2017V3') IS NULL DROP DATABASE ZEIT2017V3;
GO

/****** Object:  Database [ZEIT2017V3]    Script Date: 16.05.2017 20:05:25 ******/
CREATE DATABASE [ZEIT2017V3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ZEIT2017V3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ZEIT2017V3.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ZEIT2017V3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ZEIT2017V3_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ZEIT2017V3] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ZEIT2017V3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ZEIT2017V3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ZEIT2017V3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ZEIT2017V3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ZEIT2017V3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ZEIT2017V3] SET ARITHABORT OFF 
GO
ALTER DATABASE [ZEIT2017V3] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ZEIT2017V3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ZEIT2017V3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ZEIT2017V3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ZEIT2017V3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ZEIT2017V3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ZEIT2017V3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ZEIT2017V3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ZEIT2017V3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ZEIT2017V3] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ZEIT2017V3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ZEIT2017V3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ZEIT2017V3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ZEIT2017V3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ZEIT2017V3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ZEIT2017V3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ZEIT2017V3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ZEIT2017V3] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ZEIT2017V3] SET  MULTI_USER 
GO
ALTER DATABASE [ZEIT2017V3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ZEIT2017V3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ZEIT2017V3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ZEIT2017V3] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ZEIT2017V3] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ZEIT2017V3]
GO
/****** Object:  Table [dbo].[EintrittAustritt]    Script Date: 16.05.2017 20:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EintrittAustritt](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FK_Mitarbeiter] [int] NOT NULL,
	[EintrittsDatum] [smalldatetime] NOT NULL,
	[AustrittsDatum] [smalldatetime] NULL,
	[TagesSollZeit] [decimal](5, 2) NOT NULL,
 CONSTRAINT [PK_EintrittAustritt] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Mitarbeiter]    Script Date: 16.05.2017 20:05:25 ******/
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
	[Passwort] [varbinary](max) NULL,
	[IstAktiv] [bit] NOT NULL,
	[IsAdmin] [bit] NOT NULL,
 CONSTRAINT [PK_Mitarbeiter] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Stempelzeiten]    Script Date: 16.05.2017 20:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stempelzeiten](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TagesDatum] [smalldatetime] NOT NULL,
	[Zeitpunkt] TIME(0) NOT NULL,
	[Zeittyp] [tinyint] NOT NULL,
	[FK_Mitarbeiter] [int] NOT NULL,
 CONSTRAINT [PK_Stempelzeiten] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Zeittypen]    Script Date: 16.05.2017 20:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zeittypen](
	[Typ] [tinyint] NULL,
	[TypBezeichnung] [nvarchar](50) NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[EintrittAustritt]  WITH CHECK ADD  CONSTRAINT [FK_EintrittAustritt_Mitarbeiter] FOREIGN KEY([FK_Mitarbeiter])
REFERENCES [dbo].[Mitarbeiter] ([ID])
GO
ALTER TABLE [dbo].[EintrittAustritt] CHECK CONSTRAINT [FK_EintrittAustritt_Mitarbeiter]
GO
ALTER TABLE [dbo].[Stempelzeiten]  WITH CHECK ADD  CONSTRAINT [FK_Stempelzeiten_Mitarbeiter] FOREIGN KEY([FK_Mitarbeiter])
REFERENCES [dbo].[Mitarbeiter] ([ID])
GO
ALTER TABLE [dbo].[Stempelzeiten] CHECK CONSTRAINT [FK_Stempelzeiten_Mitarbeiter]
GO

---------------------------------------------------------
--Insert Dummy Werte in Stammdatenbank Person
---------------------------------------------------------
INSERT INTO Mitarbeiter (Personalnummer,Vorname,Nachname,IstAktiv,IsAdmin) VALUES ('1031','Hans','Moser',0,0);
INSERT INTO Mitarbeiter (Personalnummer,Vorname,Nachname,IstAktiv,IsAdmin) VALUES ('1032','Franz','Valentin',0,0);
INSERT INTO Mitarbeiter (Personalnummer,Vorname,Nachname,IstAktiv,IsAdmin) VALUES ('1033','Silvia','Schlögl',0,0);
INSERT INTO Mitarbeiter (Personalnummer,Vorname,Nachname,IstAktiv,IsAdmin) VALUES ('1034','Karl','Gruber',0,0);
INSERT INTO Mitarbeiter (Personalnummer,Vorname,Nachname,IstAktiv,IsAdmin) VALUES ('1035','Hans','Huber',0,0);
INSERT INTO Mitarbeiter (Personalnummer,Vorname,Nachname,IstAktiv,IsAdmin) VALUES ('1036','Karl','Koller',0,0);
INSERT INTO Mitarbeiter (Personalnummer,Vorname,Nachname,IstAktiv,IsAdmin) VALUES ('1000','Mister','Admin',0,1);
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
INSERT INTO EintrittAustritt (FK_Mitarbeiter,EintrittsDatum,TagesSollZeit) VALUES (7,'25-07-2000',8);
GO

INSERT INTO Zeittypen(Typ,TypBezeichnung) VALUES (1,'ArbeitsBeginn');
INSERT INTO Zeittypen(Typ,TypBezeichnung) VALUES (2,'PauseBeginn');
INSERT INTO Zeittypen(Typ,TypBezeichnung) VALUES (3,'PauseEnde');
INSERT INTO Zeittypen(Typ,TypBezeichnung) VALUES (4,'ArbeitsEnde');
GO
------------------------------------------------------------------
--Passwort den Mitarbeitern geben
------------------------------------------------------------------
DECLARE @HashThis nvarchar(4000) = null
SET @HashThis = '123user!'
DECLARE @HashPw VARBINARY(max) = null
SET @HashPw = HASHBYTES('SHA2_512', @HashThis)
UPDATE dbo.Mitarbeiter
	SET dbo.Mitarbeiter.Passwort = @HashPw
WHERE dbo.Mitarbeiter.ID = 1
UPDATE dbo.Mitarbeiter
	SET dbo.Mitarbeiter.Passwort = @HashPw
WHERE dbo.Mitarbeiter.ID = 2
UPDATE dbo.Mitarbeiter
	SET dbo.Mitarbeiter.Passwort = @HashPw
WHERE dbo.Mitarbeiter.ID = 3
UPDATE dbo.Mitarbeiter
	SET dbo.Mitarbeiter.Passwort = @HashPw
WHERE dbo.Mitarbeiter.ID = 4
UPDATE dbo.Mitarbeiter
	SET dbo.Mitarbeiter.Passwort = @HashPw
WHERE dbo.Mitarbeiter.ID = 5
UPDATE dbo.Mitarbeiter
	SET dbo.Mitarbeiter.Passwort = @HashPw
WHERE dbo.Mitarbeiter.ID = 6
UPDATE dbo.Mitarbeiter
	SET dbo.Mitarbeiter.Passwort = @HashPw
WHERE dbo.Mitarbeiter.ID = 7;
GO

/****** Object:  StoredProcedure [dbo].[HashPasswort]    Script Date: 16.05.2017 20:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-------------------------------------------------------------
--Procedur Hasht das Passwort das übergeben wird
-------------------------------------------------------------
CREATE PROCEDURE [dbo].[HashPasswort]
	 @Text NVARCHAR(4000)
	,@ID INT  
AS
DECLARE @HashThis nvarchar(4000) = @Text
DECLARE @HashPw VARBINARY(max) = null
SET @HashPw = HASHBYTES('SHA2_512', @HashThis)
UPDATE dbo.Mitarbeiter
	SET dbo.Mitarbeiter.Passwort = @HashPw
WHERE dbo.Mitarbeiter.ID = @ID;

GO
/****** Object:  StoredProcedure [dbo].[Pr_SucheIdMitarbeiter]    Script Date: 16.05.2017 20:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

---------------------------------------------------------
 --Prozedur zum lesen der ID des Mitarbeiters für die 
 --Speicherung in der Zeiterfassungstabelle als FK_Mitarbeiter
 ---------------------------------------------------------
 CREATE PROCEDURE [dbo].[Pr_SucheIdMitarbeiter]
	@PersonalNummer Nvarchar(6)
	,@Password VARBINARY(MAX)
	,@Ergebnis INT OUT 
AS
SET @Ergebnis = (SELECT m.ID
				 FROM [dbo].[Mitarbeiter] As m
				 WHERE @PersonalNummer = m.Personalnummer
					   AND @Password = m.Passwort
				)
RETURN @Ergebnis;

GO
/****** Object:  StoredProcedure [dbo].[Procedur_MitarbeiterSuchen]    Script Date: 16.05.2017 20:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[PruefeHashPasswort]    Script Date: 16.05.2017 20:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------------------------
--Procedur sucht anhand der Personalnummer , der Mitarbeiter id und dem Passwort nach übereinstmmung
--liefert 1 bei erfolg und 0 bei mißerfolg
---------------------------------------------------------------------------------------------------- 
CREATE PROCEDURE [dbo].[PruefeHashPasswort]
	 @Text NVARCHAR(4000)
	,@ID INT
	,@Ergebnis INT OUT 
AS
DECLARE @HashThis nvarchar(4000) = null
SET @HashThis = @Text
DECLARE @HashPw VARBINARY(max) = null
DECLARE @tmp int = null
SET @HashPw = HASHBYTES('SHA2_512', @HashThis)
SET @tmp = (
			SELECT m.ID
			FROM dbo.Mitarbeiter AS m
			WHERE m.ID = @ID AND m.Passwort = @HashPw
			)
IF NOT @tmp IS NULL
BEGIN
	SET @Ergebnis = @tmp
END
ELSE
	SET @Ergebnis = 0;

RETURN @Ergebnis;

GO
USE [master]
GO
ALTER DATABASE [ZEIT2017V3] SET  READ_WRITE 
GO
