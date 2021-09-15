using System;
using System.IO;
using System.Windows.Forms;




namespace ContectManager
{
    public partial class Form_KundeReg : Form
    {
        public Form_KundeReg()
        {
            InitializeComponent();

            //Erklärungen in Klasse Controller
            Controller.FirstUseCheck();

            // generiert Vorschau der Kunden in LsbOutputKu
            CuListToLsbOutput();

            // Das etwas schon vorselektiert ist
            CmbCustomerType.SelectedIndex = 0;
            CmbGender.SelectedIndex = 0;
        }

        //Variable "ausgewählter Kunde" initialisieren damit sie in Form abgeändert werden kann
        private int SelectedCu;

        // Stattet fast jedes Textfeld mit boolean aus für CheckInt oder CheckString 
        bool titel = false; bool salutation = false; bool firstname = false; bool lastname = false; bool telprivate = false;
        bool telwork = false; bool telmobile = false; bool fax = false; bool zipcode = false; bool residence = false;
        private void CmdAddCustomer_Click(object sender, EventArgs e)
        {
            Controller.ImportedCustomer = false;
            NewCustomerGetValues();
        }

        private void CmdEditCustomer_Click(object sender, EventArgs e)
        {
         

            //damit richtiger Kunde geladen wird
            SelectedCu = LsbOutputKU.SelectedIndex;

            //wenn Kunde bearbeitet und auf "Änderung speichern" geklickt wurde
            if (CmdAddCustomer.Enabled == false)
            {
                //Text auf Button zurücksetzen
                CmdEditCustomer.Text = "Kunde \r\n bearbeiten";

                //Buttons aktivieren
                CmdAddCustomer.Enabled = true;
                CmdMenue.Enabled = true;
                CmdDelCustomer.Enabled = true;

                //Listbox aktivieren
                LsbOutputKU.Enabled = true;

                //Werte aus Textboxen in Liste speichern
                Model.Kunden[SelectedCu].Salutation = TxtSalutation.Text;
                Model.Kunden[SelectedCu].Firstname = TxtFirstname.Text;
                Model.Kunden[SelectedCu].Lastname = TxtLastname.Text;
                Model.Kunden[SelectedCu].Birthday = DtpBirthday.Value;
                Model.Kunden[SelectedCu].Gender = CmbGender.Text;
                Model.Kunden[SelectedCu].Title = TxtTitle.Text;
                Model.Kunden[SelectedCu].TelWork = TxtTelWork.Text;
                Model.Kunden[SelectedCu].FaxWork = TxtFaxWork.Text;
                Model.Kunden[SelectedCu].Adress = TxtAdress.Text;
                Model.Kunden[SelectedCu].Zipcode = TxtZipcode.Text;
                Model.Kunden[SelectedCu].Residence = TxtResidence.Text;
                Model.Kunden[SelectedCu].TelPrivate = TxtTelPrivate.Text;
                Model.Kunden[SelectedCu].TelMobile = TxtTelMobile.Text;
                Model.Kunden[SelectedCu].EMail = TxtEMail.Text;
                Model.Kunden[SelectedCu].Active = ChkActive.Checked;
                Model.Kunden[SelectedCu].CompanyName = TxtCompanyName.Text;
                Model.Kunden[SelectedCu].CompanyAdress = TxtCompanyAdress.Text;
                Model.Kunden[SelectedCu].CustomerType = CmbCustomerType.Text;
                Model.Kunden[SelectedCu].CustomerNote = TxtCustomerNote.Text;

                //Vorschau in Listbox generieren
                CuListToLsbOutput();

                //Daten in kunden.dat schreiben
                Controller.WriteDataCu();

                //Variable für History nach Bearbeitung erstellen
                Controller.HistoryNew =
                "KB: " +
                "Endzeit der Bearbeitung  : " +
                DateTime.Now.ToString() + "| " +
                TxtSalutation.Text + ";" +
                TxtFirstname.Text + ";" +
                TxtLastname.Text + ";" +
                DtpBirthday.Value + ";" +
                CmbGender.Text + ";" +
                TxtTitle.Text + ";" +
                TxtTelWork.Text + ";" +
                TxtFaxWork.Text + ";" +
                TxtAdress.Text + ";" +
                TxtZipcode.Text + ";" +
                TxtResidence.Text + ";" +
                TxtTelPrivate.Text + ";" +
                TxtTelMobile.Text + ";" +
                TxtEMail.Text + ";" +
                ChkActive.Checked + ";" +
                TxtCompanyName.Text + ";" +
                TxtCompanyAdress.Text + ";" +
                CmbCustomerType.Text + "; " +
                TxtCustomerNote.Text;

                //Kundenbearbeitung ins Log schreiben
                Controller.WriteLog("CuBearbeitet");

                //Textfelder leeren
                ClearForm();
            }

            //wenn ein Kunde ausgewählt und auf "Kunde bearbeiten" geklickt wird
            else
            {
                //Abgfage ob Kunde aus Vorschau ausgewählt wurde
                if (LsbOutputKU.SelectedItem != null && CmdAddCustomer.Enabled == true)
                {
                    //Text auf Button ändern
                    CmdEditCustomer.Text = "Änderung \r\n speichern!";

                    //Buttons deaktivieren
                    CmdAddCustomer.Enabled = false;
                    CmdMenue.Enabled = false;
                    CmdDelCustomer.Enabled = false;

                    //Listbox deaktivieren
                    LsbOutputKU.Enabled = false;

                    //Lädt die Werte in die entsprechenden Felder des Forms
                    TxtSalutation.Text = Model.Kunden[SelectedCu].Salutation;
                    TxtFirstname.Text = Model.Kunden[SelectedCu].Firstname;
                    TxtLastname.Text = Model.Kunden[SelectedCu].Lastname;
                    DtpBirthday.Value = Model.Kunden[SelectedCu].Birthday;
                    CmbGender.Text = Model.Kunden[SelectedCu].Gender;
                    TxtTitle.Text = Model.Kunden[SelectedCu].Title;
                    TxtTelWork.Text = Model.Kunden[SelectedCu].TelWork;
                    TxtFaxWork.Text = Model.Kunden[SelectedCu].FaxWork;
                    TxtAdress.Text = Model.Kunden[SelectedCu].Adress;
                    TxtZipcode.Text = Model.Kunden[SelectedCu].Zipcode;
                    TxtResidence.Text = Model.Kunden[SelectedCu].Residence;
                    TxtTelPrivate.Text = Model.Kunden[SelectedCu].TelPrivate;
                    TxtTelMobile.Text = Model.Kunden[SelectedCu].TelMobile;
                    TxtEMail.Text = Model.Kunden[SelectedCu].EMail;
                    ChkActive.Checked = Model.Kunden[SelectedCu].Active;
                    TxtCompanyName.Text = Model.Kunden[SelectedCu].CompanyName;
                    TxtCompanyAdress.Text = Model.Kunden[SelectedCu].CompanyAdress;
                    CmbCustomerType.Text = Model.Kunden[SelectedCu].CustomerType;
                    TxtCustomerNote.Text = Model.Kunden[SelectedCu].CustomerNote;


                    //Variable für History vor Bearbeitung erstellen
                    Controller.History =
                    "KB: " +
                    "Startzeit der Bearbeitung: " +
                    DateTime.Now.ToString() + "| " +
                    TxtSalutation.Text + ";" +
                    TxtFirstname.Text + ";" +
                    TxtLastname.Text + ";" +
                    DtpBirthday.Value + ";" +
                    CmbGender.Text + ";" +
                    TxtTitle.Text + ";" +
                    TxtTelWork.Text + ";" +
                    TxtFaxWork.Text + ";" +
                    TxtAdress.Text + ";" +
                    TxtZipcode.Text + ";" +
                    TxtResidence.Text + ";" +
                    TxtTelPrivate.Text + ";" +
                    TxtTelMobile.Text + ";" +
                    TxtEMail.Text + ";" +
                    ChkActive.Checked + ";" +
                    TxtCompanyName.Text + ";" +
                    TxtCompanyAdress.Text + ";" +
                    CmbCustomerType.Text + "; " +
                    TxtCustomerNote.Text;
                }
                else
                {
                    MessageBox.Show("Bitte Kunde auswählen!");
                }
            }
        }

        private void CmdDelCustomer_Click(object sender, EventArgs e)
        {
            if (LsbOutputKU.SelectedItem != null)
            {
                //zu löschenden Kunden in Variable schreiben
                SelectedCu = LsbOutputKU.SelectedIndex;

                //ausgewählten Kunden aus Liste Kunde löschen
                Controller.DeleteSelected("Kunde", SelectedCu);

                //Kundendaten serialisieren und ins .dat-File schreiben
                Controller.WriteDataCu();

                Controller.WriteLog("CuGeloescht");

                //Listbox neu aufbauen
                CuListToLsbOutput();
            }

            else
            {
                MessageBox.Show("Bitte Kunde selektieren");
            }
        }

        private void CmdMenue_Click(object sender, EventArgs e)
        {
            //zur Sicherheit nochmals serialisieren
            Controller.WriteDataCu();

            this.Hide();
            Form_Menue fkunde = new Form_Menue();
            fkunde.ShowDialog();
        }

        private void CuListToLsbOutput()
        {
            //leert Listbox
            LsbOutputKU.Items.Clear();

            //befüllt Listbox mit Inhalt der Liste Kunden
            int tempCounter = 0;
            foreach (Customer kunde in Model.Kunden)
            {
                LsbOutputKU.Items.Add(
                Model.Kunden[tempCounter].CompanyName + " " +
                Model.Kunden[tempCounter].Salutation + " " +
                Model.Kunden[tempCounter].Firstname + " " +
                Model.Kunden[tempCounter].Lastname
                );
                tempCounter++;
            }
        }

        private void ClearForm()
        {

            TxtSalutation.Text = "";
            TxtFirstname.Text = "";
            TxtLastname.Text = "";
            CmbGender.Text = "";
            TxtTitle.Text = "";
            TxtTelWork.Text = "";
            TxtFaxWork.Text = "";
            TxtAdress.Text = "";
            TxtZipcode.Text = "";
            TxtResidence.Text = "";
            TxtTelPrivate.Text = "";
            TxtTelMobile.Text = "";
            TxtEMail.Text = "";
            ChkActive.Checked = true;
            TxtCompanyName.Text = "";
            TxtCompanyAdress.Text = "";
            CmbCustomerType.Text = "A";
            TxtCustomerNote.Text = "";
        }

        private void CmdKundenImport_Click(object sender, EventArgs e)
        {
            Controller.ImportedCustomer = true; // ImportedCustomer wird auf true gesetzt, da es ja ein importierter Kunde ist (Für Abfrage später)
            GetImportPath(); //CSV-Pfad herholen
            ImportKunden(); //Kunden importieren
        }

        private void GetImportPath() //Pfad des angegebenen CSV-File in Controller.SelectedImportPath schreiben
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                //Setzt die Initalwerte für den File-Explorer fest  (nur CSV-Dateien!)
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "csv files (*.csv)|*.csv";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                
                //Öffnet File-Explorer und setzt den Pfad auf Controller.SelectedImportPath
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Controller.SelectedImportPath = openFileDialog1.FileName;
                }  
            }
        }

        private void ImportKunden()
        {
            //Variable um Code leserlicher zu machen
            string CsvPath = Controller.SelectedImportPath;

            //Variable Reader öffnet das selectierte  CSV-File
            var reader = new StreamReader(File.OpenRead(CsvPath));
            
            int counter = 0; // Counter initialisieren um Anzahl Kunden dem Benutzer auszugeben
            Controller.CounterImportedCustomer = 0; //Auf 0 setzen, da wir mehrere Imports machen können und der Counter sonst nicht stimmt
            while (!reader.EndOfStream) //While solange true bis eine leere Zeile kommt
                {
                string Zeile = reader.ReadLine(); // Variabel Zeile wird vereinfacht dargestellt
                
                // KundenImportDaten ist ein Array, welcher mit den einzelnen Werten der Zeile die
                //durch ; getrennt sind einspeichert
                Controller.KundenImportDaten = Zeile.Split(';');

                NewCustomerGetValues();
                counter++;
                }
            if(counter == 0)
            {
                MessageBox.Show("CSV-File ist leer!");

            }
            else
            {
                counter = counter - Controller.CounterImportedCustomer;
                MessageBox.Show(counter + " Kunden wurden importiert");

            }


        }

        private void NewCustomerGetValues() //Um Daten aus dem Importieren CSV-File oder aus den Textboxen zu lesen
        {
            //Falls es ein importierter Kunde ist bekommt er die Daten aus dem Array
            if(Controller.ImportedCustomer == true)
            {
                try //Falls CSV-File korrekt aufgebaut ist fügt er es hinzu, ansonsten geht er ins catch
                {
                    if(Controller.KundenImportDaten.Length > 19 || Controller.KundenImportDaten.Length < 19) //Würde heissen falsches CSV -> Mitarbeiter/Lehrling(oder korruptes) statt Kunden ausgewählt
                    {
                        if(Controller.CounterImportedCustomer == 0)
                        {
                            MessageBox.Show("CSV-File enthält korrupte Datensätze(Korrekte werden importiert!)");
                        }
                        Controller.CounterImportedCustomer++;
                    }
                    else
                    {
                        Model.Kunden.Add(new Customer
                 (
                    Controller.KundenImportDaten[0],
                    Controller.KundenImportDaten[1],
                    Controller.KundenImportDaten[2],
                    DateTime.Parse(Controller.KundenImportDaten[3]), // Format: 01.01.1996 00:00:00
                    Controller.KundenImportDaten[4],
                    Controller.KundenImportDaten[5],
                    Controller.KundenImportDaten[6],
                    Controller.KundenImportDaten[7],
                    Controller.KundenImportDaten[8],
                    Controller.KundenImportDaten[9],
                    Controller.KundenImportDaten[10],
                    Controller.KundenImportDaten[11],
                    Controller.KundenImportDaten[12],
                    Controller.KundenImportDaten[13],
                    bool.Parse(Controller.KundenImportDaten[14]),
                    Controller.KundenImportDaten[15],
                    Controller.KundenImportDaten[16],
                    Controller.KundenImportDaten[17],
                    Controller.KundenImportDaten[18]
                    ));

                        // generiert Vorschau in LsbOutputKu
                        CuListToLsbOutput();

                        //serialisiert Liste Kunden in .dat-File
                        Controller.WriteDataCu();

                        //Variable für History erstellen
                        Controller.HistoryNew =
                        "KE: " +
                        "Zeit der Erstellung      : " +
                        DateTime.Now.ToString() + "| " +
                        Controller.KundenImportDaten[0] + "; " +
                        Controller.KundenImportDaten[1] + "; " +
                        Controller.KundenImportDaten[2] + "; " +
                        DateTime.Parse(Controller.KundenImportDaten[3]) + "; " +//01.01.1996 00:00:00
                        Controller.KundenImportDaten[4] + "; " +
                        Controller.KundenImportDaten[5] + "; " +
                        Controller.KundenImportDaten[6] + "; " +
                        Controller.KundenImportDaten[7] + "; " +
                        Controller.KundenImportDaten[8] + "; " +
                        Controller.KundenImportDaten[9] + "; " +
                        Controller.KundenImportDaten[10] + "; " +
                        Controller.KundenImportDaten[11] + "; " +
                        Controller.KundenImportDaten[12] + "; " +
                        Controller.KundenImportDaten[13] + "; " +
                        bool.Parse(Controller.KundenImportDaten[14]) + "; " +
                        Controller.KundenImportDaten[15] + "; " +
                        Controller.KundenImportDaten[16] + "; " +
                        Controller.KundenImportDaten[17] + "; " +
                        Controller.KundenImportDaten[18];

                        Controller.WriteLog("CuErstellt");
                    }
                  
                }
                catch //Falls wir im catch landen, ist die aktuelle Zeile Defekt
                {
                    MessageBox.Show("CSV-File enthält korrupte Daten");
                    Controller.CounterImportedCustomer++;
                }
            }

            if(Controller.ImportedCustomer == false)
            {
                // Fast jedes Textfeld durchläuft CheckInt oder  CheckString Methode im Controller. Wenn fehlerhaft -> true
                titel = Controller.CheckString(TxtTitle.Text.Trim(), TxtTitle);
                salutation = Controller.CheckString(TxtSalutation.Text.Trim(), TxtSalutation);
                firstname = Controller.CheckString(TxtFirstname.Text.Trim(), TxtFirstname);
                lastname = Controller.CheckString(TxtLastname.Text.Trim(), TxtLastname);
                telprivate = Controller.CheckInt(TxtTelPrivate.Text.Trim(), TxtTelPrivate);
                telwork = Controller.CheckInt(TxtTelWork.Text.Trim(), TxtTelWork);
                telmobile = Controller.CheckInt(TxtTelMobile.Text.Trim(), TxtTelMobile);
                fax = Controller.CheckInt(TxtFaxWork.Text.Trim(), TxtFaxWork);
                zipcode = Controller.CheckInt(TxtZipcode.Text.Trim(), TxtZipcode);
                residence = Controller.CheckString(TxtResidence.Text.Trim(), TxtResidence);

                // Überprüft ob ein Textfeld fehlerhaft ist
                if (titel == true || salutation == true || firstname == true || lastname == true || telprivate == true || telwork == true ||
                    telmobile == true || fax == true || zipcode == true || residence == true)
                {
                    titel = false; salutation = false; firstname = false; lastname = false; telprivate = false; telwork = false;
                    telmobile = false; fax = false; zipcode = false; residence = false;
                    MessageBox.Show("Ups! Sie haben einen unzulässigen Wert eingegeben", "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                // Überprüft ob Person bereits existiert
                else if (Controller.EqualsCustomer(TxtFirstname.Text.Trim(), TxtLastname.Text.Trim(), DtpBirthday.Value.Date))
                {
                    MessageBox.Show("Kunde bereits registriert", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //erzeugt neuen Customer
                    Model.Kunden.Add(new Customer(
                        TxtSalutation.Text.Trim(),
                        TxtFirstname.Text.Trim(),
                        TxtLastname.Text.Trim(),
                        DtpBirthday.Value,
                        CmbGender.Text,
                        TxtTitle.Text.Trim(),
                        TxtTelWork.Text.Trim(),
                        TxtFaxWork.Text.Trim(),
                        TxtAdress.Text,
                        TxtZipcode.Text.Trim(),
                        TxtResidence.Text.Trim(),
                        TxtTelPrivate.Text.Trim(),
                        TxtTelMobile.Text.Trim(),
                        TxtEMail.Text.Trim(),
                        ChkActive.Checked,
                        TxtCompanyName.Text.Trim(),
                        TxtCompanyAdress.Text.Trim(),
                        CmbCustomerType.Text,
                        TxtCustomerNote.Text
                        ));
                    // Console.WriteLine(DtpBirthday.Value.ToString());
                    //serialisiert Liste Kunden in .dat-File
                    Controller.WriteDataCu();

                    // generiert Vorschau in LsbOutputKu
                    CuListToLsbOutput();

                    //Variable für History erstellen
                    Controller.HistoryNew =
                    "KE: " +
                    "Zeit der Erstellung      : " +
                    DateTime.Now.ToString() + "| " +
                    TxtSalutation.Text + "; " +
                        TxtFirstname.Text + "; " +
                        TxtLastname.Text + "; " +
                        DtpBirthday.Value + "; " +
                        CmbGender.Text + "; " +
                        TxtTitle.Text + "; " +
                        TxtTelWork.Text + "; " +
                        TxtFaxWork.Text + "; " +
                        TxtAdress.Text + "; " +
                        TxtZipcode.Text + "; " +
                        TxtResidence.Text + "; " +
                        TxtTelPrivate.Text + "; " +
                        TxtTelMobile.Text + "; " +
                        TxtEMail.Text + "; " +
                        ChkActive.Checked + "; " +
                        TxtCompanyName.Text + "; " +
                        TxtCompanyAdress.Text + "; " +
                        CmbCustomerType.Text + "; " +
                        TxtCustomerNote.Text;

                    Controller.WriteLog("CuErstellt");


                    //leert Textboxen
                    ClearForm();
                }
            }
         

        }
    }
}

