USE [master];
GO

CREATE DATABASE [ZEIT2017];
GO

USE [ZEIT2017];
GO
/****** Object:  Table [dbo].[EintrittAustritt]    Script Date: 23.05.2017 17:54:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EintrittAustritt](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FK_Mitarbeiter] [int] NOT NULL,
	[Personalnummer] [nvarchar](4) NULL,
	[EintrittsDatum] [datetime] NOT NULL,
	[AustrittsDatum] [datetime] NULL,
	[TagesSollZeit] [decimal](5, 2) NOT NULL,
	[IsAdmin] [bit] NULL,
 CONSTRAINT [PK_EintrittAustritt] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
GO

USE [ZEIT2017];
GO

INSERT INTO dbo.EintrittAustritt (FK_Mitarbeiter,Personalnummer,EintrittsDatum,TagesSollZeit,IsAdmin) VALUES (1,'1031','1980-08-01',8.00,0);
INSERT INTO dbo.EintrittAustritt (FK_Mitarbeiter,Personalnummer,EintrittsDatum,TagesSollZeit,IsAdmin) VALUES (2,'1032','1990-07-01',8.00,0);
INSERT INTO dbo.EintrittAustritt (FK_Mitarbeiter,Personalnummer,EintrittsDatum,TagesSollZeit,IsAdmin) VALUES (3,'1033','1999-05-01',6.00,0);
INSERT INTO dbo.EintrittAustritt (FK_Mitarbeiter,Personalnummer,EintrittsDatum,TagesSollZeit,IsAdmin) VALUES (4,'1034','2010-04-01',8.00,0);
INSERT INTO dbo.EintrittAustritt (FK_Mitarbeiter,Personalnummer,EintrittsDatum,TagesSollZeit,IsAdmin) VALUES (5,'1035','2000-01-01',5.00,0);
INSERT INTO dbo.EintrittAustritt (FK_Mitarbeiter,Personalnummer,EintrittsDatum,TagesSollZeit,IsAdmin) VALUES (6,'1036','2016-02-01',8.00,0);
INSERT INTO dbo.EintrittAustritt (FK_Mitarbeiter,Personalnummer,EintrittsDatum,TagesSollZeit,IsAdmin) VALUES (7,'1000','2000-12-07',8.00,1);
GO

/****** Object:  Table [dbo].[Mitarbeiter]    Script Date: 23.05.2017 17:54:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mitarbeiter](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Vorname] [nvarchar](20) NOT NULL,
	[Nachname] [nvarchar](30) NOT NULL,
	[Passwort] [varbinary](max) NULL,
 CONSTRAINT [PK_Mitarbeiter_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY];
GO

USE [ZEIT2017];
GO

INSERT INTO dbo.Mitarbeiter (Vorname,Nachname,Passwort) VALUES ('Hans','Moser',0x82D3D6AB3BC52D66064268898582AF07127CE0BFF3274771179483FFBB6129FB04D809BC64CE84341E6451154E06A624D702E328F1EFFD81F07721E0E70F5F53);
INSERT INTO dbo.Mitarbeiter (Vorname,Nachname,Passwort) VALUES ('Franz','Valentin',0x82D3D6AB3BC52D66064268898582AF07127CE0BFF3274771179483FFBB6129FB04D809BC64CE84341E6451154E06A624D702E328F1EFFD81F07721E0E70F5F53);
INSERT INTO dbo.Mitarbeiter (Vorname,Nachname,Passwort) VALUES ('Silvia','Schlögl',0x82D3D6AB3BC52D66064268898582AF07127CE0BFF3274771179483FFBB6129FB04D809BC64CE84341E6451154E06A624D702E328F1EFFD81F07721E0E70F5F53);
INSERT INTO dbo.Mitarbeiter (Vorname,Nachname,Passwort) VALUES ('Karl','Gruber',0x82D3D6AB3BC52D66064268898582AF07127CE0BFF3274771179483FFBB6129FB04D809BC64CE84341E6451154E06A624D702E328F1EFFD81F07721E0E70F5F53);
INSERT INTO dbo.Mitarbeiter (Vorname,Nachname,Passwort) VALUES ('Hans','Huber',0x82D3D6AB3BC52D66064268898582AF07127CE0BFF3274771179483FFBB6129FB04D809BC64CE84341E6451154E06A624D702E328F1EFFD81F07721E0E70F5F53);
INSERT INTO dbo.Mitarbeiter (Vorname,Nachname,Passwort) VALUES ('Karl','Koller',0x82D3D6AB3BC52D66064268898582AF07127CE0BFF3274771179483FFBB6129FB04D809BC64CE84341E6451154E06A624D702E328F1EFFD81F07721E0E70F5F53);
INSERT INTO dbo.Mitarbeiter (Vorname,Nachname,Passwort) VALUES ('Mister','Admin',0x82D3D6AB3BC52D66064268898582AF07127CE0BFF3274771179483FFBB6129FB04D809BC64CE84341E6451154E06A624D702E328F1EFFD81F07721E0E70F5F53);
GO

SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Stempelzeiten]    Script Date: 23.05.2017 17:54:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stempelzeiten](
	[FK_Mitarbeiter] [int] NOT NULL,
	[Zeitpunkt] [datetime] NOT NULL,
	[ZeitTyp] [int] NOT NULL,
 CONSTRAINT [PK_Stempelzeiten] PRIMARY KEY CLUSTERED 
(
	[FK_Mitarbeiter] ASC,
	[Zeitpunkt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
GO

/****** Object:  Table [dbo].[Zeittypen]    Script Date: 23.05.2017 17:54:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Zeittypen](
	[ID] [int] NOT NULL,
	[Bezeichnung] [nvarchar](50) NULL,
	[Modus] [nvarchar](10) NULL,
	[Von] [int] NULL,
	[Hauptsatz] [bit] NULL,
 CONSTRAINT [PK_Zeittypen] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
GO

USE [ZEIT2017];
GO

INSERT INTO Zeittypen (ID,Bezeichnung,Modus,Von,Hauptsatz) VALUES (1,'ArbeitsBegin','A',2,1);
INSERT INTO Zeittypen (ID,Bezeichnung,Modus,Von,Hauptsatz) VALUES (2,'ArbeitsEnde','E',1,0);
INSERT INTO Zeittypen (ID,Bezeichnung,Modus,Von,Hauptsatz) VALUES (3,'PauseBegin','A',4,1);
INSERT INTO Zeittypen (ID,Bezeichnung,Modus,Von,Hauptsatz) VALUES (4,'PauseEnde','E',3,0);

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[EintrittAustritt]  WITH CHECK ADD  CONSTRAINT [FK_EintrittAustritt_Mitarbeiter1] FOREIGN KEY([FK_Mitarbeiter])
REFERENCES [dbo].[Mitarbeiter] ([ID]);
GO

ALTER TABLE [dbo].[EintrittAustritt] CHECK CONSTRAINT [FK_EintrittAustritt_Mitarbeiter1];
GO

ALTER TABLE [dbo].[Stempelzeiten]  WITH CHECK ADD  CONSTRAINT [FK_Stempelzeiten_Mitarbeiter] FOREIGN KEY([FK_Mitarbeiter])
REFERENCES [dbo].[Mitarbeiter] ([ID]);
GO

ALTER TABLE [dbo].[Stempelzeiten] CHECK CONSTRAINT [FK_Stempelzeiten_Mitarbeiter];
GO

ALTER TABLE [dbo].[Stempelzeiten]  WITH CHECK ADD  CONSTRAINT [FK_Stempelzeiten_Zeittypen] FOREIGN KEY([ZeitTyp])
REFERENCES [dbo].[Zeittypen] ([ID]);
GO

ALTER TABLE [dbo].[Stempelzeiten] CHECK CONSTRAINT [FK_Stempelzeiten_Zeittypen];
GO

/****** Object:  StoredProcedure [dbo].[HashPasswort]    Script Date: 23.05.2017 17:54:51 ******/
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

/****** Object:  StoredProcedure [dbo].[PruefeHashPasswort]    Script Date: 23.05.2017 17:54:51 ******/
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
	SET @Ergebnis = 0

RETURN @Ergebnis;
GO

SELECT ea.Personalnummer
	  ,m.Vorname
	  ,m.Nachname
	  ,ea.EintrittsDatum
	  ,ea.AustrittsDatum
	  ,ea.TagesSollZeit
	  ,ea.IsAdmin 
FROM [ZEIT2017].dbo.Mitarbeiter AS m
	JOIN [ZEIT2017].dbo.EintrittAustritt AS ea
		ON m.ID = ea.FK_Mitarbeiter;
GO 

/****** Object:  View [dbo].[View_1]    Script Date: 13.06.2017 19:54:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_1]
AS
SELECT        dbo.EintrittAustritt.Personalnummer, dbo.EintrittAustritt.EintrittsDatum, dbo.EintrittAustritt.AustrittsDatum, dbo.EintrittAustritt.TagesSollZeit, dbo.EintrittAustritt.IsAdmin, dbo.Mitarbeiter.Vorname, dbo.Mitarbeiter.Nachname
FROM            dbo.EintrittAustritt INNER JOIN
                         dbo.Mitarbeiter ON dbo.EintrittAustritt.FK_Mitarbeiter = dbo.Mitarbeiter.ID;
GO

USE [master];
GO