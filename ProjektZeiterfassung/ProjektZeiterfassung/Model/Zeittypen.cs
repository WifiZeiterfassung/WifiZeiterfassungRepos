using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZeiterfassung.Model
{
    
    /// <summary>
    /// Stellt die Klasse für das Objekt einer Zeiterfassung bereit 
    /// </summary>
    public class Zeittypen
    {
        /// <summary>
        /// internes Hilfsfeld
        /// </summary>
        private int _ID;
        /// <summary>
        /// Stellt eine Eigenschaft für den jeweiligen Zeittyp bereit 
        /// </summary>
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        /// <summary>
        /// internes Hilfsfeld
        /// </summary>
        private string _Bezeichnung;
        /// <summary>
        /// Stellt die Eigenschaft für eine Bezeichnung des Zeittyps bereit
        /// </summary>
        public string Bezeichnung
        {
            get { return _Bezeichnung; }
            set { _Bezeichnung = value; }
        }
        /// <summary>
        /// internes Hilfsfeld
        /// </summary>
        private char _Modus;

        /// <summary>
        /// Stellt eine Eigenschaft für den Modus A-Anfang E-Ende bereit
        /// </summary>
        public char Modus
        {
            get { return _Modus; }
            set { _Modus = value; }
        }

        /// <summary>
        /// internes Hilfsfeld
        /// </summary>
        private int _Von;
        /// <summary>
        /// Stellt eine Eigenschaft Von welchem Anfang und von welchem Ende bereit
        /// </summary>
        public int Von
        {
            get { return _Von; }
            set { _Von = value; }
        }

        /// <summary>
        /// internes Hilfsfeld
        /// </summary>
        private bool _Hauptsatz;

        /// <summary>
        /// Stellt eine Eigenschaft für den Hauptsatz bereit
        /// </summary>
        public bool Hauptsatz
        {
            get { return _Hauptsatz; }
            set { _Hauptsatz = value; }
        }


        //Datenbankverbindung Verbindung = new Datenbankverbindung();

        //public DatenErfolg SpeichereZeit(Zeittypen p)
        //{
        //    DatenErfolg Ergebnis = DatenErfolg.Fehler;

        //    Öffnet eine Verbindung mit der Datenbank
        //    using (var con = new System.Data.SqlClient.SqlConnection(Verbindung.DbConnection))
        //    {
        //        con.Open();
        //        speichert die übergebenen Daten in der Datenbank
        //        using (var cmd = new System.Data.SqlClient.SqlCommand("dbo.SpeichereTagesArbeitsZeit", con))
        //        {
        //            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        //            cmd.Parameters.Add("@FK_Mitarbeiter", System.Data.SqlDbType.Int).Value = p.FK_Mitarbeiter_ID;
        //            cmd.Parameters.Add("@TagesDatum", System.Data.SqlDbType.SmallDateTime).Value = p.TagesDatum;
        //            cmd.Parameters.Add("@ArbeitsAnfang", System.Data.SqlDbType.SmallDateTime).Value = p.ArbeitsAnfang;
        //            cmd.Parameters.Add("@ArbeitsEnde", System.Data.SqlDbType.SmallDateTime).Value = p.ArbeitsEnde;
        //            cmd.Parameters.Add("@TagesIstZeit", System.Data.SqlDbType.SmallDateTime).Value = p.TagesIstZeit;
        //            Rückgabewert ob funktioniert oder nicht
        //            cmd.Parameters.Add("@RC", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;

        //            Datenbankserver cachet die Daten
        //            cmd.Prepare();

        //            ausführung des speicherns und liefert die anzal der reihen die gespeichert wurden
        //            cmd.ExecuteNonQuery();

        //            Wurde der Datensatz angelegt oder geändert?
        //            switch ((int)cmd.Parameters["@RC"].Value)
        //            {
        //                case 0:
        //                    Ergebnis = DatenErfolg.Änderung;
        //                    break;
        //                case 1:
        //                    Ergebnis = DatenErfolg.NeuAnlage;
        //                    break;
        //            }
        //        }
        //        con.Close();
        //    }
        //    return Ergebnis;
        //}
    }
}
