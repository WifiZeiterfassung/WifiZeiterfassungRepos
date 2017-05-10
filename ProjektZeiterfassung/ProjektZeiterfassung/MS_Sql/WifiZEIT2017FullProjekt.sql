-- -----------------------------------------------------
-- Überprüfen und löschen der Datenbank
-- -----------------------------------------------------
IF NOT DB_ID('ZEIT2017Full') IS NULL ALTER DATABASE ZEIT2017Full SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO

IF NOT DB_ID('ZEIT2017Full') IS NULL DROP DATABASE ZEIT2017Full;
GO

--------------------------------------------------------
--Erstellen von ZEIT2017Full und verwenden
--------------------------------------------------------
CREATE DATABASE ZEIT2017Full;
GO

USE ZEIT2017Full;
GO
-- -----------------------------------------------------
-- Table ZEIT2017Full.Mitarbeiter
-- -----------------------------------------------------
CREATE TABLE Mitarbeiter (
  ID INT IDENTITY(1,1) NOT NULL,
  Personalnummer NVARCHAR(6) NOT NULL,
  Vorname NVARCHAR(20) NOT NULL,
  Nachname NVARCHAR(30) NOT NULL,
  IstAktiv BIT NOT NULL
  );
GO

-- -----------------------------------------------------
-- Table ZEIT2017Full.EintrittAustritt
-- -----------------------------------------------------
CREATE TABLE EintrittAustritt (
  ID INT IDENTITY(1,1) NOT NULL,
  FK_Mitarbeiter INT NOT NULL,
  EintrittsDatum SMALLDATETIME NULL,
  AustrittsDatum SMALLDATETIME NULL,
  TagesSollZeit DECIMAL(5,2) NOT NULL,
  );
GO


-- -----------------------------------------------------
-- Table ZEIT2017Full.Zeiterfassung
-- -----------------------------------------------------
CREATE TABLE Zeiterfassung (
  ID INT IDENTITY(1,1) NOT NULL,
  TagesDatum SMALLDATETIME NULL,
  ArbeitsAnfang SMALLDATETIME NULL,
  ArbeitsEnde SMALLDATETIME NULL,
  TagesIstZeit DECIMAL(5,2) NULL,
  FK_Mitarbeiter_ID INT NOT NULL
  );
GO

----------------------------------------------------------
--Table ZEIT2017Full.PauseZeiten
----------------------------------------------------------
CREATE TABLE PauseZeiten (
  ID INT IDENTITY(1,1) NOT NULL,
  PauseAnfang SMALLDATETIME NULL,
  PauseEnde SMALLDATETIME NULL,
  FK_Mitarbeiter INT NOT NULL
  );
GO
  

---------------------------------------------------------
--Primary Keys für Tabellen
----Mitarbeiter
----Zeiterfassung
---------------------------------------------------------
ALTER TABLE Mitarbeiter
ADD
CONSTRAINT PK_Mitarbeiter
PRIMARY KEY(ID);
GO

ALTER TABLE EintrittAustritt
ADD
CONSTRAINT PK_EintrittAustritt
PRIMARY KEY(ID);
GO

ALTER TABLE Zeiterfassung
ADD
CONSTRAINT PK_Zeiterfassung
PRIMARY KEY(ID);
GO

ALTER TABLE PauseZeiten
ADD
CONSTRAINT PK_PauseZeiten
PRIMARY KEY(ID);
GO

---------------------------------------------------------
--Foreign Keys für Tabelle
----Zeiterfassung
---------------------------------------------------------
ALTER TABLE EintrittAustritt
ADD
CONSTRAINT FK_EintrittAustritt_Mitarbeiter
FOREIGN KEY (FK_Mitarbeiter)
REFERENCES Mitarbeiter(ID);
GO

ALTER TABLE Zeiterfassung
ADD
CONSTRAINT FK_Zeiterfassung_Mitarbeiter
FOREIGN KEY (FK_Mitarbeiter_ID)
REFERENCES Mitarbeiter(ID);
GO

ALTER TABLE PauseZeiten
ADD
CONSTRAINT FK_PauseZeiten_Mitarbeiter
FOREIGN KEY (FK_Mitarbeiter)
REFERENCES Mitarbeiter(ID);
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
----------------------------------------------------------
--SpeicherProzedur für Zeiterfassung
----------------------------------------------------------
 CREATE PROCEDURE Pr_SpeichereTagesArbeitsZeit
			@Mitarbeiter_ID INT
           ,@TagesDatum SMALLDATETIME NULL
           ,@ArbeitsAnfang SMALLDATETIME NULL
           ,@PauseAnfang SMALLDATETIME NULL
           ,@PauseEnde SMALLDATETIME NULL
		   ,@ArbeitsEnde SMALLDATETIME NULL
		   ,@TagesIstZeit DECIMAL(5,2) NULL  
  AS

  SET NOCOUNT ON

  DECLARE @Ergebnis int = 0

  -- Versuchen, den Datensatz zu ändern
  UPDATE 
	Zeiterfassung
  SET
	-- Schlüssel beim UPDATE nicht notwendig
	-- Schlüsselwerte ändern SICH NIE!!! (Sonst Design Problem)
       TagesDatum = @TagesDatum
      ,ArbeitsAnfang = @ArbeitsAnfang
      ,ArbeitsEnde = @ArbeitsEnde
	  ,TagesIstZeit = @TagesIstZeit
 -- AUF KEINEN FALL BEIM UPDATE AUF DIE
 -- WHERE EINSCHRÄNKUNG VERGESSEN!!!
 -- (ohne WHERE werden ALLE DATEN geändert)
 WHERE [ID] = @Mitarbeiter_ID

 UPDATE
 PauseZeiten
 SET
	-- Schlüssel beim UPDATE nicht notwendig
	-- Schlüsselwerte ändern SICH NIE!!! (Sonst Design Problem)
       PauseAnfang = @PauseAnfang
      ,PauseEnde = @PauseEnde
  
 -- AUF KEINEN FALL BEIM UPDATE AUF DIE
 -- WHERE EINSCHRÄNKUNG VERGESSEN!!!
 -- (ohne WHERE werden ALLE DATEN geändert)
 WHERE [ID] = @Mitarbeiter_ID
 
  -- Fall nichts verändert wurde, 
  -- den Datensatz neu anlegen
 IF @@ROWCOUNT = 0 
 BEGIN
	 INSERT INTO Zeiterfassung
			   (
				    TagesDatum
				   ,ArbeitsAnfang
				   ,ArbeitsEnde
				   ,TagesIstZeit
				   ,FK_Mitarbeiter_ID
			   )
		 VALUES
			   (
				    @TagesDatum
				   ,@ArbeitsAnfang
				   ,@ArbeitsEnde
				   ,@TagesIstZeit	
				   ,@Mitarbeiter_ID
			   )

	INSERT INTO PauseZeiten
			   (
					FK_Mitarbeiter
				   ,PauseAnfang
				   ,PauseEnde
				  
				   
			   )
		 VALUES
			   (
					@Mitarbeiter_ID
				   ,@PauseAnfang
				   ,@PauseEnde		   
			   )
	SET @Ergebnis = 1
 END 
 RETURN @Ergebnis;
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

--------------------------------------------------------------------
--Holt eine Liste der Zeiterfassung von einem  Mitarbeiter
--------------------------------------------------------------------
CREATE FUNCTION Fn_UebersichtArbeitszeitenIdMitarbeiter (@IdMitarbeiter INT)
RETURNS TABLE
AS
RETURN
(	
	SELECT m.Personalnummer
			,m.Vorname
			,m.Nachname
			,ea.EintrittsDatum
			,CAST(z.TagesDatum AS date) AS Tagesdatum
			,CAST(z.ArbeitsAnfang AS time(0)) AS Anfang
			,CAST(p.PauseAnfang AS time(0)) AS PauseAnfang 
			,CAST(p.PauseEnde AS time(0)) AS PauseEnde
			,CAST(z.ArbeitsEnde AS time(0)) AS Ende	  
			,z.TagesIstZeit
			,ea.TagesSollZeit
			,(z.TagesIstZeit - ea.TagesSollZeit) AS Differenz
	FROM Mitarbeiter AS m
		LEFT JOIN EintrittAustritt AS ea ON ea.FK_Mitarbeiter = m.ID
			LEFT JOIN Zeiterfassung AS z ON m.ID = z.FK_Mitarbeiter_ID
				LEFT JOIN PauseZeiten AS p ON p.FK_Mitarbeiter = m.ID
		where m.ID = @IdMitarbeiter
);
GO

--------------------------------------------------------------------
--Holt eine Liste aller Mitarbeiter
--------------------------------------------------------------------
CREATE FUNCTION Fn_UebersichtAlleArbeitszeiten()
RETURNS TABLE
AS
RETURN
(	
	SELECT m.Personalnummer
			,m.Vorname
			,m.Nachname
			,ea.EintrittsDatum
			,CAST(z.TagesDatum AS date) AS Tagesdatum
			,CAST(z.ArbeitsAnfang AS time(0)) AS Anfang
			,CAST(p.PauseAnfang AS time(0)) AS PauseAnfang 
			,CAST(p.PauseEnde AS time(0)) AS PauseEnde
			,CAST(z.ArbeitsEnde AS time(0)) AS Ende	  
			,z.TagesIstZeit
			,ea.TagesSollZeit
			,(z.TagesIstZeit - ea.TagesSollZeit) AS Differenz
	FROM Mitarbeiter AS m
		LEFT JOIN EintrittAustritt AS ea ON ea.FK_Mitarbeiter = m.ID
			LEFT JOIN Zeiterfassung AS z ON m.ID = z.FK_Mitarbeiter_ID
				LEFT JOIN PauseZeiten AS p ON p.FK_Mitarbeiter = m.ID
);
GO

CREATE FUNCTION Fn_UebersichtArbeitszeitenIdMitarbeiterMitSuchZeitraum (@IdMitarbeiter INT, @Von DATETIME, @Bis DATETIME)
RETURNS TABLE
AS
RETURN
(	
	SELECT m.Personalnummer
			,m.Vorname
			,m.Nachname
			,ea.EintrittsDatum
			,CAST(z.TagesDatum AS date) AS Tagesdatum
			,CAST(z.ArbeitsAnfang AS time(0)) AS Anfang
			,CAST(p.PauseAnfang AS time(0)) AS PauseAnfang 
			,CAST(p.PauseEnde AS time(0)) AS PauseEnde
			,CAST(z.ArbeitsEnde AS time(0)) AS Ende	  
			,z.TagesIstZeit
			,ea.TagesSollZeit
			,(z.TagesIstZeit - ea.TagesSollZeit) AS Differenz
	FROM Mitarbeiter AS m
		LEFT JOIN EintrittAustritt AS ea ON ea.FK_Mitarbeiter = m.ID
			LEFT JOIN Zeiterfassung AS z ON m.ID = z.FK_Mitarbeiter_ID
				LEFT JOIN PauseZeiten AS p ON p.FK_Mitarbeiter = m.ID
		where m.ID = @IdMitarbeiter AND z.TagesDatum BETWEEN @Von AND @Bis
);
GO

--SELECT * FROM Fn_UebersichtArbeitszeitenIdMitarbeiter (3);
--SELECT * FROM FN_UebersichtAlleArbeitszeiten ();


--test einer Prozedur
------------------------------------------------------------------
 --DECLARE @Time SMALLDATETIME = CURRENT_TIMESTAMP;
 --DECLARE @Time3 SMALLDATETIME = CURRENT_TIMESTAMP;
 ----exec SpeichereTagesArbeitsZeit 1,@Time,null,null,null,null,null;
 --exec SpeichereTagesArbeitsZeit 1,@Time,@Time3,null,null,null,null;
