-- -----------------------------------------------------
-- Überprüfen und löschen der Datenbank
-- -----------------------------------------------------
IF NOT DB_ID('ZEIT2017') IS NULL ALTER DATABASE ZEIT2017 SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO

IF NOT DB_ID('ZEIT2017') IS NULL DROP DATABASE ZEIT2017;
GO

--------------------------------------------------------
--Erstellen von ZEIT2017 und verwenden
--------------------------------------------------------
CREATE DATABASE ZEIT2017;
GO

USE ZEIT2017;
GO
-- -----------------------------------------------------
-- Table ZEIT2017.Mitarbeiter
-- -----------------------------------------------------
CREATE TABLE Mitarbeiter (
  ID INT IDENTITY(1,1) NOT NULL,
  Personalnummer NVARCHAR(6) NOT NULL,
  EintrittsDatum SMALLDATETIME NOT NULL,
  Vorname NVARCHAR(20) NOT NULL,
  Nachname NVARCHAR(30) NOT NULL,
  TagesSollZeit DECIMAL(5,2) NOT NULL,
  IstAktiv BIT NOT NULL
  );
GO

-- -----------------------------------------------------
-- Table ZEIT2017.Zeiterfassung
-- -----------------------------------------------------
CREATE TABLE Zeiterfassung (
  ID INT IDENTITY(1,1) NOT NULL,
  TagesDatum SMALLDATETIME NULL,
  ArbeitsAnfang SMALLDATETIME NULL,
  PauseAnfang SMALLDATETIME NULL,
  PauseEnde SMALLDATETIME NULL,
  ArbeitsEnde SMALLDATETIME NULL,
  TagesIstZeit DECIMAL(5,2) NULL,
  FK_Mitarbeiter_ID INT NOT NULL
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

ALTER TABLE Zeiterfassung
ADD
CONSTRAINT PK_Zeiterfassung
PRIMARY KEY(ID);
GO

---------------------------------------------------------
--Foreign Keys für Tabelle
----Zeiterfassung
---------------------------------------------------------
ALTER TABLE Zeiterfassung
ADD
CONSTRAINT FK_Zeiterfassung_Mitarbeiter
FOREIGN KEY (FK_Mitarbeiter_ID)
REFERENCES Mitarbeiter(ID);
GO

---------------------------------------------------------
--Insert Dummy Werte in Stammdatenbank
---------------------------------------------------------
INSERT INTO Mitarbeiter (Personalnummer,EintrittsDatum,Vorname,Nachname,TagesSollZeit,IstAktiv) VALUES ('1031','01-08-1980','Hans','Moser',8,0);
INSERT INTO Mitarbeiter (Personalnummer,EintrittsDatum,Vorname,Nachname,TagesSollZeit,IstAktiv) VALUES ('1032','01-07-1990','Franz','Valentin',8,0);
INSERT INTO Mitarbeiter (Personalnummer,EintrittsDatum,Vorname,Nachname,TagesSollZeit,IstAktiv) VALUES ('1033','01-05-1999','Silvia','Schlögl',6,0);
INSERT INTO Mitarbeiter (Personalnummer,EintrittsDatum,Vorname,Nachname,TagesSollZeit,IstAktiv) VALUES ('1034','01-04-2010','Karl','Gruber',8,0);
INSERT INTO Mitarbeiter (Personalnummer,EintrittsDatum,Vorname,Nachname,TagesSollZeit,IstAktiv) VALUES ('1035','01-01-2000','Hans','Huber',5,0);
INSERT INTO Mitarbeiter (Personalnummer,EintrittsDatum,Vorname,Nachname,TagesSollZeit,IstAktiv) VALUES ('1036','01-02-2016','Karl','Koller',8,0);
GO
----------------------------------------------------------
--SpeicherProzedur für Zeiterfassung
----------------------------------------------------------
 CREATE PROCEDURE SpeichereTagesArbeitsZeit
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
      ,PauseAnfang = @PauseAnfang
      ,PauseEnde = @PauseEnde
      ,ArbeitsEnde = @ArbeitsEnde
      ,TagesIstZeit = @TagesIstZeit
 -- AUF KEINEN FALL BEIM UPDATE AUF DIE
 -- WHERE EINSCHRÄNKUNG VERGESSEN!!!
 -- (ohne WHERE werden ALLE DATEN geändert)
 WHERE [ID] = @Mitarbeiter_ID
 
  -- Fall nichts verändert wurde, 
  -- den Datensatz neu anlegen
 IF @@ROWCOUNT = 0 BEGIN
	 INSERT INTO Zeiterfassung
			   (
				    TagesDatum
				   ,ArbeitsAnfang
				   ,PauseAnfang
				   ,PauseEnde
				   ,ArbeitsEnde
				   ,TagesIstZeit
				   ,FK_Mitarbeiter_ID
			   )
		 VALUES
			   (
				    @TagesDatum
				   ,@ArbeitsAnfang
				   ,@PauseAnfang
				   ,@PauseEnde
				   ,@ArbeitsEnde
				   ,@TagesIstZeit
				   ,@Mitarbeiter_ID
			   )
	SET @Ergebnis = 1
 END 

 RETURN @Ergebnis;
 GO

 ---------------------------------------------------------
 --Prozedur zum lesen der ID des Mitarbeiters für die 
 --Speicherung in der Zeiterfassungstabelle als FK_Mitarbeiter
 ---------------------------------------------------------
 CREATE PROCEDURE [dbo].[SucheIdMitarbeiter]
	@ID int = 0,
	@PersonalNummer Nvarchar(6)
AS
	SELECT MAX(id)
	FROM [dbo].[Mitarbeiter]
	WHERE @PersonalNummer = Mitarbeiter.Personalnummer;
GO


----------------------------------------------------------------
--Prozedur Suche eines Mitarbeiters mit seiner Personalnummer 
--zur Anzeige seiner Daten in der Hauptansicht wenn null angegeben
--wird werden alle Mitarbeiter in die Liste geladen 
----------------------------------------------------------------
CREATE PROCEDURE [dbo].[MitarbeiterSuchen]
		 @Id int = null
        ,@PersonalNummer nvarchar(6) = null
AS
SET NOCOUNT ON

-- Falls keine Parameter angegeben wurden,
-- alle Daten liefern
IF @ID IS NULL AND @PersonalNummer IS NULL  
	BEGIN
		SELECT [ID]
			  ,[Personalnummer]
			  ,[EintrittsDatum]
			  ,[Vorname]
			  ,[Nachname]
			  ,TagesSollZeit
			  ,IstAktiv
		FROM [dbo].[Mitarbeiter]
	END 
ELSE 
BEGIN
-- Falls ein Schlüssel vorhanden ist,
-- nur diesen Datensatz zurückgeben...
	IF NOT @PersonalNummer IS NULL 
	BEGIN
		SELECT [ID]
			  ,[Personalnummer]
			  ,[EintrittsDatum]
			  ,[Vorname]
			  ,[Nachname]
			  ,TagesSollZeit
			  ,IstAktiv
		FROM [dbo].[Mitarbeiter]
		WHERE [Personalnummer] = @PersonalNummer
	END
END;
GO


--------------------------------------------------------------------
--test einer Prozedur
------------------------------------------------------------------
 --DECLARE @Time SMALLDATETIME = CURRENT_TIMESTAMP;
 --DECLARE @Time3 SMALLDATETIME = CURRENT_TIMESTAMP;
 ----exec SpeichereTagesArbeitsZeit 1,@Time,null,null,null,null,null;
 --exec SpeichereTagesArbeitsZeit 1,@Time,@Time3,null,null,null,null;
