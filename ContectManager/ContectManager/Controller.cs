using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ContectManager
{
    class Controller
    {
        //Variabeln welche mit mit selektierten oder allgemein mit der MitarbeiterID zu tun haben
        
        public static int MitarbeiterID;
        
        //Variabeln für das Logfile
        public static string History;
        public static string HistoryNew;
        private static string Trennzeichen = "-----";
        private static string HistoryExport;
        public static string MutationsTyp;
        private static string GeloeschterMitarbeiter;
        private static string GeloeschterKunde;

        //Variabeln für Pfäde
        public static string Counter;
        public static string MitarbeiterDB;
        public static string KundenDB;
        public static string LogFile;

        public static void FirstUseCheck() //Kommentar in Funktion
        {
            //Sicherheitsabfrage
            //Falls das Programm zum ersten Mal die Datenbank mitarbeiter.dat benutzt
            //werden unten kommentierte Ordner/Dateien erstellt - Da Erstbenutztung/Initialisierung

            //Absoluten Pfad festlegen
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\Datenbanken\");
            string sFilePath = Path.GetFullPath(sFile);

            //setzt Variabeln für die jeweiligen Datenbanken, Lofile und den Counter für die MitarbeiterID
            Counter = sFilePath + "counter.txt";
            MitarbeiterDB = sFilePath + "mitarbeiter.dat";
            KundenDB = sFilePath + "kunden.dat";
            LogFile = sFilePath + "logfile.txt";


            // Falls der Pfad bzw. der Ordner nicht existiert true
            if (!Directory.Exists(sFilePath))
            {
                //Erstellt den Ordner Datenbanken
                DirectoryInfo di = Directory.CreateDirectory(sFilePath);

                //Erstellt 4 Files - Counter - MitarbeiterDB - KundenDB - LogFile
                using (StreamWriter w = File.AppendText(Counter)) ;
                using (StreamWriter w = File.AppendText(MitarbeiterDB)) ;
                using (StreamWriter w = File.AppendText(KundenDB)) ;
                using (StreamWriter w = File.AppendText(LogFile)) ;

                //Schreibt den Counter mit dem Wert 100 in das counter.txt - da noch leer
                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(Counter);
                SaveFile.WriteLine(100);
                SaveFile.Close();

                //Schreibt Beschreibung ins Logfile.txt damit es eine Struktur(Logik) hat
                System.IO.StreamWriter SaveFile2 = new System.IO.StreamWriter(LogFile);
                SaveFile2.WriteLine("Erster Buchstabe Bezeichung: M = Mitarbeiter | L = Lehrling | K = Kunde");
                SaveFile2.WriteLine("Zweiter Buchstabe Bezeichung: B = Bearbeitet | G = Gelöscht | E = Erstellt");
                SaveFile2.WriteLine("\r\n");
                SaveFile2.Close();

                //Counter mit der MitarbeiterID 100 wird importiert und ins Textfeld geschrieben
                ImportCounter();
                // TxtMitarbeiterID.Text = MitarbeiterID.ToString();
                // geht leider nicht, da TxtMitarbeiterID nicht verfügbar ist!
            }
            else
            {
                //Lädt das mitarbeiter.dat-File in die Liste (Employee) Mitarbeiter
                // wenn das File Daten enthält
                if (new FileInfo(MitarbeiterDB).Length >0)
                {
                    LoadDataMa();
                }


                //Lädt aktuellen Counter = MitarbeiterID
                // wenn das File Daten enthält
                if (new FileInfo(Counter).Length > 0)
                {
                    ImportCounter();
                }

                //Lädt das kunden.dat-File in die Liste (Customer) Kunden
                // wenn das File Daten enthält
                if (new FileInfo(KundenDB).Length > 0)
                {
                    LoadDataCu();
                }
                

            }
        }
        
        public static void ImportCounter() //Import des Counters von counter.txt
        {
            using (StreamReader file = new StreamReader(Counter))
            {
                //Variable MitarbeiterID wird beim Laden des Formulars gesetzt(ausgelesen) falls vorhanden
                MitarbeiterID = Convert.ToInt32(file.ReadLine());
                file.Close(); // Zugriff auf File schliessen
            }
        }
        
        public static void ExportCounter() //Export des Counters ins counter.txt
        {
            //Überschreibt Counter im counter.txt-File
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(Counter);
            SaveFile.WriteLine(MitarbeiterID);
            SaveFile.Close();
        }

        public static void LoadDataCu() //Ladet/Deserialisiert die binären Daten vom kunden.dat in die Liste Kunden
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream readstream = new FileStream(KundenDB, FileMode.Open, FileAccess.Read);
            Model.Kunden = (List<Customer>)formatter.Deserialize(readstream);
            readstream.Close();
            //MaListToLsbOutput();
        }

        public static void LoadDataMa() //Ladet/Deserialisiert die binären Daten vom mitarbeiter.dat in die Liste Mitarbeiter
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream readstream = new FileStream(MitarbeiterDB, FileMode.Open, FileAccess.Read);
            Model.Mitarbeiter = (List<Employee>)formatter.Deserialize(readstream);
            readstream.Close();
        }

        public static void WriteDataCu() //Schreibt/Serialisiert Daten binär ins kunden.dat
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(KundenDB, FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, Model.Kunden);
            stream.Close();
        }

        public static void WriteDataMa() //Schreibt/Serialisiert Daten binär ins mitarbeiter.dat
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(MitarbeiterDB, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, Model.Mitarbeiter);
            stream.Close();
        }

        public static void WriteLog(string typ) //In der Funktion beschrieben
        {
            string Typ = typ;
            if (Typ == "MaErstellt")
            {
                HistoryExport = HistoryNew + "\r\n" + Trennzeichen;
            }

            if (Typ == "MaGeloescht")
            {
                HistoryExport = GeloeschterMitarbeiter + "\r\n" + Trennzeichen;
            }


            if (Typ=="MaBearbeitet")
            {
                HistoryExport = History + "\r\n" + HistoryNew + "\r\n" + Trennzeichen;
            }

            if (Typ == "CuErstellt")
            {
                HistoryExport = HistoryNew + "\r\n" + Trennzeichen;
            }

            if (Typ == "CuGeloescht")
            {
                HistoryExport = GeloeschterKunde + "\r\n" + Trennzeichen;
                
            }

            if (Typ=="CuBearbeitet")
            {
                HistoryExport = History + "\r\n" + HistoryNew + "\r\n" + Trennzeichen;

            }

            System.IO.StreamWriter sw = File.AppendText(LogFile);
            sw.WriteLine(HistoryExport);
            sw.Close();

        }

        public static void DeleteSelected(string typ, int selectedData) // Löschen eines selektierten Users
        {
            string Typ = typ;
            int SelectedData = selectedData;
            if (Typ=="Kunde")
            {
                DialogResult dialogResult = MessageBox.Show("Sind Sie sicher?", "Kunde löschen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {


                    GeloeschterKunde = "KG: " +
                    "Zeit der Löschung        : " +
                    DateTime.Now.ToString() + "| " +
                    Model.Kunden[SelectedData].Salutation + "; " +
                    Model.Kunden[SelectedData].Firstname + "; " +
                    Model.Kunden[SelectedData].Lastname + "; " +
                    Model.Kunden[SelectedData].Birthday + "; " +
                    Model.Kunden[SelectedData].Gender + "; " +
                    Model.Kunden[SelectedData].Title + "; " +
                    Model.Kunden[SelectedData].TelWork + "; " +
                    Model.Kunden[SelectedData].FaxWork + "; " +
                    Model.Kunden[SelectedData].Adress + "; " +
                    Model.Kunden[SelectedData].Zipcode + "; " +
                    Model.Kunden[SelectedData].Residence + "; " +
                    Model.Kunden[SelectedData].TelPrivate + "; " +
                    Model.Kunden[SelectedData].TelMobile + "; " +
                    Model.Kunden[SelectedData].EMail + "; " +
                    Model.Kunden[SelectedData].Active + "; " +
                    Model.Kunden[SelectedData].CompanyName + "; " +
                    Model.Kunden[SelectedData].CompanyAdress + "; " +
                    Model.Kunden[SelectedData].CustomerType;

                    MessageBox.Show(
                   "Kunde: " +
                   Model.Kunden[SelectedData].Firstname + " " +
                   Model.Kunden[SelectedData].Lastname + " wurde gelöscht!");

                  Model.Kunden.RemoveAt(SelectedData);
                }

                else if (dialogResult == DialogResult.No) // Falls abgebrochen wird (verklickt z.B.)
                {
                    MessageBox.Show("Kunde nicht gelöscht!");
                }

            }

            if (Typ=="Mitarbeiter")
            {
                DialogResult dialogResult = MessageBox.Show("Sind Sie sicher?", "Mitarbeiter löschen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GeloeschterMitarbeiter =
                      "MG: " +
                      "Zeit der Löschung        : " +
                      DateTime.Now.ToString() + "| " +
                      Model.Mitarbeiter[SelectedData].MitarbeiterID + "; " +
                      Model.Mitarbeiter[SelectedData].Salutation + "; " +
                      Model.Mitarbeiter[SelectedData].Firstname + "; " +
                      Model.Mitarbeiter[SelectedData].Lastname + "; " +
                      Model.Mitarbeiter[SelectedData].Birthday + "; " +
                      Model.Mitarbeiter[SelectedData].Gender + "; " +
                      Model.Mitarbeiter[SelectedData].Title + "; " +
                      Model.Mitarbeiter[SelectedData].TelWork + "; " +
                      Model.Mitarbeiter[SelectedData].FaxWork + "; " +
                      Model.Mitarbeiter[SelectedData].Adress + "; " +
                      Model.Mitarbeiter[SelectedData].Zipcode + "; " +
                      Model.Mitarbeiter[SelectedData].Residence + "; " +
                      Model.Mitarbeiter[SelectedData].TelPrivate + "; " +
                      Model.Mitarbeiter[SelectedData].TelMobile + "; " +
                      Model.Mitarbeiter[SelectedData].EMail + "; " +
                      Model.Mitarbeiter[SelectedData].Active + "; " +
                      Model.Mitarbeiter[SelectedData].Department + "; " +
                      Model.Mitarbeiter[SelectedData].AHVNumber + "; " +
                      Model.Mitarbeiter[SelectedData].Nationality + "; " +
                      Model.Mitarbeiter[SelectedData].EntryDate + "; " +
                      Model.Mitarbeiter[SelectedData].QuitDate + "; " +
                      Model.Mitarbeiter[SelectedData].EmploymentLevel + "; " +
                      Model.Mitarbeiter[SelectedData].Role + "; " +
                      Model.Mitarbeiter[SelectedData].ManagementLevel;

                    MessageBox.Show(
                    "Mitarbeiter: " +
                    Model.Mitarbeiter[selectedData].MitarbeiterID + " " +
                    Model.Mitarbeiter[SelectedData].Firstname + " " +
                    Model.Mitarbeiter[SelectedData].Lastname + " wurde gelöscht!");

                    Model.Mitarbeiter.RemoveAt(SelectedData);
                }
                else if (dialogResult == DialogResult.No) // Falls abgebrochen wird (verklickt z.B.)
                {
                    MessageBox.Show("Mitarbeiter nicht gelöscht!");
                }
            }


        }


    }


}
