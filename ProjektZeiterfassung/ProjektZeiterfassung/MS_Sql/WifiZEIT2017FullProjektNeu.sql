USE [master];
GO
/****** Object:  Database [ZEIT2017Full]    Script Date: 14.05.2017 17:26:16 ******/
if not db_id('ZEIT2017Full') is null
DROP DATABASE [ZEIT2017Full];
GO

CREATE DATABASE [ZEIT2017Full];
GO

USE [ZEIT2017Full];
GO

CREATE TABLE [dbo].[Auswertungstabelle](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Tagesdatum] [smalldatetime] NULL,
	[Arbeitzeit] [decimal](5, 2) NULL,
	[Pausenzeit] [decimal](5, 2) NULL,
	[Nettoarbeitszeit] [decimal](5, 2) NULL,
	[Differenz] [decimal](5, 2) NULL,
	[FK_Mitarbeiter] [int] NOT NULL
) ON [PRIMARY];
GO
/****** Object:  Table [dbo].[EintrittAustritt]    Script Date: 14.05.2017 17:26:16 ******/
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
) ON [PRIMARY];
GO
/****** Object:  Table [dbo].[Hilfstabelle]    Script Date: 14.05.2017 17:26:16 ******/
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
/****** Object:  Table [dbo].[Mitarbeiter]    Script Date: 14.05.2017 17:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[Zeiterfassung]    Script Date: 14.05.2017 17:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zeiterfassung](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TagesDatum] [smalldatetime] NULL,
	[Zeit] [time](0) NULL,
	[Zeittyp] [nvarchar](20) NULL,
	[FK_Mitarbeiter_ID] [int] NOT NULL,
 CONSTRAINT [PK_Zeiterfassung] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
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
ALTER TABLE [dbo].[Zeiterfassung]  WITH CHECK ADD  CONSTRAINT [FK_Zeiterfassung_Mitarbeiter] FOREIGN KEY([FK_Mitarbeiter_ID])
REFERENCES [dbo].[Mitarbeiter] ([ID])
GO
ALTER TABLE [dbo].[Zeiterfassung] CHECK CONSTRAINT [FK_Zeiterfassung_Mitarbeiter]
GO
/****** Object:  StoredProcedure [dbo].[Pr_SucheIdMitarbeiter]    Script Date: 14.05.2017 17:26:16 ******/
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

/****** Object:  StoredProcedure [dbo].[Procedur_MitarbeiterSuchen]    Script Date: 14.05.2017 17:26:16 ******/
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
-------------------------------------------------------------
--Procedur Hasht das Passwort das übergeben wird
-------------------------------------------------------------
CREATE PROCEDURE HashPasswort
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
WHERE dbo.Mitarbeiter.ID = 6;

GO
USE [master]
GO
ALTER DATABASE [ZEIT2017Full] SET  READ_WRITE 
GO
