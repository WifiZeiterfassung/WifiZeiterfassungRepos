using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZeiterfassung.Model
{
    /// <summary>
    /// Listet die Erfolgsvarianten beim Speichern in der Datenbank auf.
    /// </summary>
    public enum DatenErfolg
    {
        /// <summary>
        /// Bei der Aktion ist ein Problem aufgetreten.
        /// </summary>
        Fehler = -1,
        /// <summary>
        /// Der Datensatz wurde verändert.
        /// </summary>
        Änderung = 0,
        /// <summary>
        /// Der Datensatz wurde neu angelegt.
        /// </summary>
        NeuAnlage = 1
    }
    /// <summary>
    /// Stellt eine Klasse für eine Liste der Zeiterfassung bereit
    /// </summary>
    public class ListeZeiterfassung : System.Collections.Generic.List<Zeiterfassung>
    {

    }
    /// <summary>
    /// Stellt die Klasse für das Objekt einer Zeiterfassung bereit 
    /// </summary>
    public class Zeiterfassung
    {
        /// <summary>
        /// Internes Hilfsfeld
        /// </summary>
        private int _ID = 0;
        /// <summary>
        /// Stellt eine Eigenschaft für die Id einer Zeiterfassung bereit
        /// </summary>
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        /// <summary>
        /// Internes Hilfsfeld
        /// </summary>
        private int _FK_Mitarbeiter_ID = 0;
        /// <summary>
        /// Stellt eine Eigenschaft für FK_Mitarbeiter_Id von Zeiterfassung bereit
        /// </summary>
        public int FK_Mitarbeiter_ID
        {
            get { return _FK_Mitarbeiter_ID; }
            set { _FK_Mitarbeiter_ID = value; }
        }
        /// <summary>
        /// Internes Hilfsfeld
        /// </summary>
        private DateTime _TagesDatum;
        /// <summary>
        /// Stellt eine Eigenschaft für TagesDatum von Zeiterfassung bereit
        /// </summary>
        public DateTime TagesDatum
        {
            get { return _TagesDatum; }
            set { _TagesDatum = value; }
        }
        /// <summary>
        /// Internes Hilfsfeld
        /// </summary>
        private DateTime _ArbeitsAnfang;
        /// <summary>
        /// Stellt eine Eigenschaft für ArbeitsAnfang von Zeiterfassung bereit
        /// </summary>
        public DateTime ArbeitsAnfang
        {
            get { return _ArbeitsAnfang; }
            set { _ArbeitsAnfang = value; }
        }
        /// <summary>
        /// Internes Hilfsfeld
        /// </summary>
        private DateTime _PauseAnfang;
        /// <summary>
        /// Stellt eine Eigenschaft von PauseAnfang von Zeiterfassung bereit
        /// </summary>
        public DateTime PauseAnfang
        {
            get { return _PauseAnfang; }
            set { _PauseAnfang = value; }
        }
        /// <summary>
        /// Internes Hilfsfeld
        /// </summary>
        private DateTime _PauseEnde;
        /// <summary>
        /// Stellt eine Eigenschaft von PauseEnde von Zeiterfassung bereit
        /// </summary>
        public DateTime PauseEnde
        {
            get { return _PauseEnde; }
            set { _PauseEnde = value; }
        }
        /// <summary>
        /// Internes Hilfsfeld
        /// </summary>
        private DateTime _ArbeitsEnde;
        /// <summary>
        /// Stellt eine Eigenschaft von ArbeitsEnde von Zeiterfassung bereit
        /// </summary>
        public DateTime ArbeitsEnde
        {
            get { return _ArbeitsEnde; }
            set { _ArbeitsEnde = value; }
        }
        /// <summary>
        /// Internes Hilfsfeld
        /// </summary>
        private decimal _TagesIstZeit;
        /// <summary>
        /// Stellt eine Eigenschaft von TagesIstZeit von Zeiterfassung bereit
        /// </summary>
        public decimal TagesIstZeit
        {
            get { return _TagesIstZeit; }
            set { _TagesIstZeit = value; }
        }

        Datenbankverbindung Verbindung = new Datenbankverbindung();
        /// <summary>
        /// Speichert die Daten zur Person in die Datenbank
        /// </summary>
        /// <param name="p">Objekt der Zeiterfassung</param>
        /// <returns>int ob gespeichert(1) oder nicht(0)</returns>
        public DatenErfolg SpeichereZeit(Zeiterfassung p)
        {
            DatenErfolg Ergebnis = DatenErfolg.Fehler;
            
            //Öffnet eine Verbindung mit der Datenbank
            using (var con = new System.Data.SqlClient.SqlConnection(Verbindung.DbConnection))
            {
                //con.Open();
                //speichert die übergebenen Daten in der Datenbank
                using (var cmd = new System.Data.SqlClient.SqlCommand("dbo.SpeichereTagesArbeitsZeit", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("@FK_Mitarbeiter", System.Data.SqlDbType.Int).Value = p.FK_Mitarbeiter_ID;
                    cmd.Parameters.Add("@TagesDatum", System.Data.SqlDbType.SmallDateTime).Value = p.TagesDatum;
                    cmd.Parameters.Add("@ArbeitsAnfang", System.Data.SqlDbType.SmallDateTime).Value = p.ArbeitsAnfang;
                    cmd.Parameters.Add("@PauseAnfang", System.Data.SqlDbType.SmallDateTime).Value = p.PauseAnfang;
                    cmd.Parameters.Add("@PauseEnde", System.Data.SqlDbType.SmallDateTime).Value = p.PauseEnde;
                    cmd.Parameters.Add("@ArbeitsEnde", System.Data.SqlDbType.SmallDateTime).Value = p.ArbeitsEnde;
                    cmd.Parameters.Add("@TagesIstZeit", System.Data.SqlDbType.SmallDateTime).Value = p.TagesIstZeit;

                    //Rückgabewert ob funktioniert oder nicht
                    cmd.Parameters.Add("@RC", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;

                    //Datenbankserver cachet die Daten
                    cmd.Prepare();

                    //ausführung des speicherns und liefert die anzal der reihen die gespeichert wurden
                    cmd.ExecuteNonQuery();

                    //Wurde der Datensatz angelegt oder geändert?
                    switch ((int)cmd.Parameters["@RC"].Value)
                    {
                        case 0:
                            Ergebnis = DatenErfolg.Änderung;
                            break;
                        case 1:
                            Ergebnis = DatenErfolg.NeuAnlage;
                            break;
                    }
                }
                con.Close();
            }
            return Ergebnis;
        }
    }
}
