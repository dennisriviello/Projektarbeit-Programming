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
        //public static string MutationsTyp;
        private static string GeloeschterMitarbeiter;
        private static string GeloeschterKunde;
        private static string GeloeschterLehrling;

        //Variabeln für Pfäde
        private static string Counter;
        private static string MitarbeiterDB;
        private static string KundenDB;
        private static string LehrlingDB;
        public static string LogFile;

        //Variabeln für Import aus CSV
        public static string SelectedImportPath;

        public static bool ImportedCustomer = false;
        public static string[] KundenImportDaten;
        public static int CounterImportedCustomer = 0;

        public static bool ImportedEmployee = false;
        public static string[] EmployeeImportDaten;
        public static string[] TraineeImportDaten;

        public static int CounterImportedEmployeeOrTrainee = 0;

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
            LehrlingDB = sFilePath + "lehrlinge.dat";


            // Falls der Pfad bzw. der Ordner nicht existiert true
            if (!Directory.Exists(sFilePath))
            {
                //Erstellt den Ordner Datenbanken
                DirectoryInfo di = Directory.CreateDirectory(sFilePath);

                //Erstellt 4 Files - Counter - MitarbeiterDB - KundenDB - LogFile
                using (StreamWriter w = File.AppendText(Counter)) ;
                using (StreamWriter w = File.AppendText(MitarbeiterDB)) ;
                using (StreamWriter w = File.AppendText(KundenDB)) ;
                using (StreamWriter w = File.AppendText(LehrlingDB)) ;
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

               
                //Lädt das kunden.dat-File in die Liste (Customer) Kunden
                // wenn das File Daten enthält
                if (new FileInfo(KundenDB).Length > 0)
                {
                    LoadDataCu();
                }

                //Lädt das lehrling.dat-File in die Liste (Trainee) Lehrlinge
                // wenn das File Daten enthält
                if (new FileInfo(LehrlingDB).Length > 0)
                {
                    LoadDataTr();
                }

                //Lädt aktuellen Counter = MitarbeiterID
                // wenn das File Daten enthält
                if (new FileInfo(Counter).Length > 0)
                {
                    ImportCounter();
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
                MitarbeiterID = MitarbeiterID + 1;                            // Hier von Joel geändert für MitarbeiterID 2/2
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
        }
        public static void WriteDataCu() //Schreibt/Serialisiert Daten binär ins kunden.dat
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(KundenDB, FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, Model.Kunden);
            stream.Close();
        }

        public static void LoadDataMa() //Ladet/Deserialisiert die binären Daten vom mitarbeiter.dat in die Liste Mitarbeiter
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream readstream = new FileStream(MitarbeiterDB, FileMode.Open, FileAccess.Read);
            Model.Mitarbeiter = (List<Employee>)formatter.Deserialize(readstream);
            readstream.Close();
        }
        public static void WriteDataMa() //Schreibt/Serialisiert Daten binär ins mitarbeiter.dat
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(MitarbeiterDB, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, Model.Mitarbeiter);
            stream.Close();
        }
        public static void LoadDataTr() //Ladet/Deserialisiert die binären Daten vom lehrlinge.dat in die Liste Mitarbeiter
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream readstream = new FileStream(LehrlingDB, FileMode.Open, FileAccess.Read);
            Model.Lehrlinge = (List<Trainee>)formatter.Deserialize(readstream);
            readstream.Close();
        }
        public static void WriteDataTr() //Schreibt/Serialisiert Daten binär ins mitarbeiter.dat
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(LehrlingDB, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, Model.Lehrlinge);
            stream.Close();
        }

        //public static System.IO.FileStream OpenFileFromPath(string path, System.IO.FileMode mode);

        //public static System.IO.Stream OpenFile();

        public static void WriteLog(string typ) //In der Funktion beschrieben
        {
            string Typ = typ;

            //Mitarbeiter Logfile Types
            if (Typ == "MaErstellt")
            {
                HistoryExport = Controller.HistoryNew + "\r\n" + Trennzeichen;
            }

            if (Typ == "MaGeloescht")
            {
                HistoryExport = GeloeschterMitarbeiter + "\r\n" + Trennzeichen;
            }


            if (Typ=="MaBearbeitet")
            {
                HistoryExport = History + "\r\n" + HistoryNew + "\r\n" + Trennzeichen;
            }

            //Kunde Logfile Types
            if (Typ == "CuErstellt")
            {
                HistoryExport = Controller.HistoryNew + "\r\n" + Trennzeichen;
            }

            if (Typ == "CuGeloescht")
            {
                HistoryExport = GeloeschterKunde + "\r\n" + Trennzeichen;
                
            }

            if (Typ=="CuBearbeitet")
            {
                HistoryExport = History + "\r\n" + HistoryNew + "\r\n" + Trennzeichen;

            }

            //Lehrling Logfile Types

            if (Typ == "TrErstellt")
            {
                HistoryExport = Controller.HistoryNew + "\r\n" + Trennzeichen;
            }

            if (Typ == "TrGeloescht")
            {
                HistoryExport = GeloeschterLehrling + "\r\n" + Trennzeichen;

            }

            if (Typ == "TrBearbeitet")
            {
                HistoryExport = Controller.History + "\r\n" + HistoryNew + "\r\n" + Trennzeichen;

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

            if (Typ == "Lehrling")
            {
                DialogResult dialogResult = MessageBox.Show("Sind Sie sicher?", "Lehrling löschen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GeloeschterLehrling =
                      "LG: " +
                      "Zeit der Löschung        : " +
                      DateTime.Now.ToString() + "| " +
                      Model.Lehrlinge[SelectedData].MitarbeiterID + "; " +
                      Model.Lehrlinge[SelectedData].Salutation + "; " +
                      Model.Lehrlinge[SelectedData].Firstname + "; " +
                      Model.Lehrlinge[SelectedData].Lastname + "; " +
                      Model.Lehrlinge[SelectedData].Birthday + "; " +
                      Model.Lehrlinge[SelectedData].Gender + "; " +
                      Model.Lehrlinge[SelectedData].Title + "; " +
                      Model.Lehrlinge[SelectedData].TelWork + "; " +
                      Model.Lehrlinge[SelectedData].FaxWork + "; " +
                      Model.Lehrlinge[SelectedData].Adress + "; " +
                      Model.Lehrlinge[SelectedData].Zipcode + "; " +
                      Model.Lehrlinge[SelectedData].Residence + "; " +
                      Model.Lehrlinge[SelectedData].TelPrivate + "; " +
                      Model.Lehrlinge[SelectedData].TelMobile + "; " +
                      Model.Lehrlinge[SelectedData].EMail + "; " +
                      Model.Lehrlinge[SelectedData].Active + "; " +
                      Model.Lehrlinge[SelectedData].Department + "; " +
                      Model.Lehrlinge[SelectedData].AHVNumber + "; " +
                      Model.Lehrlinge[SelectedData].Nationality + "; " +
                      Model.Lehrlinge[SelectedData].EntryDate + "; " +
                      Model.Lehrlinge[SelectedData].QuitDate + "; " +
                      Model.Lehrlinge[SelectedData].EmploymentLevel + "; " +
                      Model.Lehrlinge[SelectedData].Role + "; " +
                      Model.Lehrlinge[SelectedData].ManagementLevel + "; " +
                      Model.Lehrlinge[selectedData].ApprenticeshipYears + "; " +
                      Model.Lehrlinge[selectedData].CurrentYear;

                    MessageBox.Show(
                    "Lehrling: " +
                    Model.Lehrlinge[selectedData].MitarbeiterID + " " +
                    Model.Lehrlinge[SelectedData].Firstname + " " +
                    Model.Lehrlinge[SelectedData].Lastname + " wurde gelöscht!");

                    Model.Lehrlinge.RemoveAt(SelectedData);
                }
                else if (dialogResult == DialogResult.No) // Falls abgebrochen wird (verklickt z.B.)
                {
                    MessageBox.Show("Lehrling nicht gelöscht!");
                }


            }


        }

        public static bool CheckString(string eingabe, TextBox t)
        {
            if (eingabe.Any(char.IsDigit))
            {
                t.BackColor = Color.Red;
                return true;
            }
            else
            {
                t.BackColor = Color.White;
                return false;
            }
        }
        public static bool CheckInt(string eingabe, TextBox t)
        {
            char[] check = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                             'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            bool temp = false;
            for (int e = 0; e < eingabe.Length; e++)
            {
                for (int b = 0; b < check.Length; b++)
                {
                    if (eingabe[e].Equals(check[b]))
                        temp = true;
                }
            }
            if (temp == true)
            {
                t.BackColor = Color.Red;
                return true;
            }
            else
            {
                t.BackColor = Color.White;
                return false;
            }

        }

        // Überprüft auf Vorname, Nachname und Geburtsdatum ob dieser Mitarbeiter in der Liste Employee bereits vorhanden ist
        public static bool EqualsEmployee(string firstname, string lastname, DateTime birthday)
        {
            bool temp = false;;
            firstname = firstname.ToLower();
            lastname = lastname.ToLower();
            foreach (var Mitarbeiter in Model.Mitarbeiter)
            {
                if (Mitarbeiter.Firstname.ToLower().Equals(firstname) && Mitarbeiter.Lastname.ToLower().Equals(lastname) &&
                    Mitarbeiter.Birthday.Equals(birthday))
                {
                    temp = true;
                } 
            }
            if (temp == true)
                return true;
            else
                return false;
        }
        public static bool EqualsCustomer(string firstname, string lastname, DateTime birthday)
        {
            bool temp = false;
            firstname = firstname.ToLower();
            lastname = lastname.ToLower();
            foreach (var Customer in Model.Kunden)
            {
                if (Customer.Firstname.ToLower().Equals(firstname) && Customer.Lastname.ToLower().Equals(lastname) && 
                    Customer.Birthday.Equals(birthday))
                {
                    temp = true;
                }
            }
            if (temp == true)
                return true;
            else
                return false;
        }
        public static bool EqualsTrainee(string firstname, string lastname, DateTime birthday)
        {
            bool temp = false;
            firstname = firstname.ToLower();
            lastname = lastname.ToLower();
            foreach (var Trainee in Model.Lehrlinge)
            {
                if (Trainee.Firstname.ToLower().Equals(firstname) && Trainee.Lastname.ToLower().Equals(lastname) &&
                    Trainee.Birthday.Equals(birthday))
                {
                    temp = true;
                }
            }
            if (temp == true)
                return true;
            else
                return false;
        }
    }
}
