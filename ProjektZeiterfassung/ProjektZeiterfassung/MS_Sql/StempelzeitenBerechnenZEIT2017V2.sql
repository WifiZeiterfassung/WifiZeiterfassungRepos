-- Button Arbeits Anfang
--In der früh beim Arbeitanfang Stempeln tagesdatum und Arbeitsanfangszeit  in auswertungstabelle nachher hilfseigenschaft Arbeit in tabelle 
--Stempelzeiten ArbeitsBeginn schreiben
INSERT INTO Auswertungstabelle (TagesDatum,ArbeitsAnfang,FK_Mitarbeiter) VALUES ('14-05-2017 08:00','08:00',1)
INSERT INTO Stempelzeiten (HilfseigenschaftArbeit,FK_Mitarbeiter) VALUES ('ArbeitsBeginn',1)
--------------------------------------------------------------------------------------------------------------
--Button Pause Anfang
--Erste Pause Stempel Anfang in Tabelle Stempelzeiten mit Update der jeweiligen Person
update Stempelzeiten 
	SET Kommen= '12:00'
	   ,HilfseigenschaftPause = 'PauseAnfang'
where FK_Mitarbeiter = 1 AND HilfseigenschaftArbeit = 'ArbeitsBeginn'

-------------------------------------------------------------------------------------------------------------
--Button Pause Ende
--Person beendet erste Pause 
update Stempelzeiten 
	SET Gehen = '12:30'
where FK_Mitarbeiter = 1 AND HilfseigenschaftArbeit = 'ArbeitsBeginn' AND HilfseigenschaftPause = 'PauseAnfang'
--Variablen deklarieren
DECLARE @tmpKomma decimal(5,2) = null
DECLARE @differenz TIME, @starttime TIME,@endtime TIME = null
--kommen ermitteln und auf variable speichern
SET @starttime = (SELECT s.Kommen
				  from Stempelzeiten as s
				  where FK_Mitarbeiter = 1
				 )
--gehen ermitteln und auf Variable speichern
SET @endtime = (SELECT s.Gehen
				from Stempelzeiten as s
				where FK_Mitarbeiter = 1
				)
--differenz in Time berechnen
SET @differenz = (SELECT CONVERT(TIME,DATEADD(MS,DATEDIFF(SS, @starttime, @endtime )*1000,0),114))
--differenz auf decimal Convertieren
SET @tmpKomma = (SELECT DATEDIFF(ss,0,@differenz)/(60.0 *60.0))
-- Update der Auswertungstabelle Feld PauseZeitSumme
UPDATE Auswertungstabelle
	SET PauseZeitSumme = @tmpKomma
WHERE FK_Mitarbeiter = 1 AND TagesDatum = '14-05-2017 08:00'
--Update Stempelzeiten HilfseigenschaftPause auf PauseEnde und 
UPDATE Stempelzeiten
	SET HilfseigenschaftPause = 'PauseEnde'
Where FK_Mitarbeiter = 1 AND HilfseigenschaftArbeit = 'ArbeitsBeginn'
-----------------------------------------------------------------------------------------
--Button Arbeitsende
--Person geht nach hause
DECLARE @NettoArbeit decimal(5,2),@diffTag decimal(5,2) = null
DECLARE @BerechnungTagesarbeitszeit TIME = null
UPDATE Auswertungstabelle
	SET ArbeitsEnde = '18:00'
Where FK_Mitarbeiter = 1 AND TagesDatum = '14-05-2017 08:00'

select * from Auswertungstabelle
select * from Stempelzeiten








