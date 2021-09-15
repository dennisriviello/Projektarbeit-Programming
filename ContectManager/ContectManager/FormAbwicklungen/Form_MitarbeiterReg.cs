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

using System.Xml;

namespace ContectManager
{
    public partial class Form_MitarbeiterReg : Form
    {
        public string fehlermeldung = "";
        
        public Form_MitarbeiterReg()
        {
            InitializeComponent();

            //Erklärungen in Klasse Controller
            Controller.FirstUseCheck();

            // generiert Vorschau der Mitarbeiter in LsbOutputMa
            RadMitarbeiter.Checked = true;
            MaListToLsbOutput();

            //MitarbeiterID in Textfeld der Form laden
            TxtMitarbeiterID.Text = Controller.MitarbeiterID.ToString();

            //Das etwas schon vorselektiert ist
            CmbDepartment.SelectedIndex = 0;
            CmbEmploymentlevel.SelectedIndex = 0;
            CmbGender.SelectedIndex = 0;
            CmbRole.SelectedIndex = 0;

        }

        // Variable "ausgewählter Mitarbeiter" initialisieren damit sie in Form abgeändert werden kann
        private int SelectedMA;
        // Stattet fast jedes Textfeld mit boolean aus für CheckInt oder CheckString 
        bool titel= false; bool salutation=false; bool firstname = false; bool lastname = false; bool telprivate = false;
        bool telwork = false; bool telmobile = false; bool fax = false; bool zipcode = false; bool residence = false;
        bool nationalaty = false; bool apprenticeyears = false; bool currentyear = false;

        private void AddEmployeeOrTrainee(string type)
        {

            if (Controller.ImportedEmployee == false)
            { 
                if (type == "Mitarbeiter")
                            {
                                // Fast jedes Textfeld durchläuft CheckInt oder  CheckString Methode im Controller. Wenn fehlerhaft -> true
                                titel = Controller.CheckString(TxtTitle.Text.Trim(), TxtTitle);
                                salutation = Controller.CheckString(TxtSalutation.Text.Trim(), TxtSalutation);
                                firstname= Controller.CheckString(TxtFirstname.Text.Trim(), TxtFirstname);
                                lastname = Controller.CheckString(TxtLastname.Text.Trim(), TxtLastname);
                                telprivate = Controller.CheckInt(TxtTelPrivate.Text.Trim(), TxtTelPrivate);
                                telwork = Controller.CheckInt(TxtTelWork.Text.Trim(), TxtTelWork);
                                telmobile = Controller.CheckInt(TxtTelMobile.Text.Trim(), TxtTelMobile);
                                fax = Controller.CheckInt(TxtFaxWork.Text.Trim(), TxtFaxWork);
                                zipcode = Controller.CheckInt(TxtZipcode.Text.Trim(), TxtZipcode);
                                residence = Controller.CheckString(TxtResidence.Text.Trim(), TxtResidence);
                                nationalaty = Controller.CheckString(TxtNationalaty.Text.Trim(), TxtNationalaty);

                                // Überprüft ob ein Textfeld fehlerhaft ist
                                if (titel == true || salutation == true || firstname == true || lastname == true || telprivate == true || telwork == true ||
                                    telmobile == true || fax == true || zipcode == true || residence == true || nationalaty == true)
                                {
                                    titel = false; salutation = false; firstname = false; lastname = false; telprivate = false; telwork = false;
                                    telmobile = false; fax = false; zipcode = false; residence = false; nationalaty = false;
                                    MessageBox.Show("Ups! Sie haben einen unzulässigen Wert eingegeben", "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }
                                // Überprüft ob Person bereits existiert
                                else if (Controller.EqualsEmployee(TxtFirstname.Text.Trim(), TxtLastname.Text.Trim(), DtpBirthday.Value))
                                {
                                    MessageBox.Show("Mitarbeiter bereits registriert", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                else
                                {
                                    //Alle Textfelder werden in die Liste Mitarbeiter eingepflegt
                                    Model.Mitarbeiter.Add(new Employee(
                                        TxtSalutation.Text.Trim(),
                                        TxtFirstname.Text.Trim(),
                                        TxtLastname.Text.Trim(),
                                        DtpBirthday.Value,
                                        CmbGender.Text,
                                        TxtTitle.Text.Trim(),
                                        TxtTelWork.Text.Trim(),
                                        TxtFaxWork.Text.Trim(),
                                        TxtAdress.Text.Trim(),
                                        TxtZipcode.Text.Trim(),
                                        TxtResidence.Text.Trim(),
                                        TxtTelPrivate.Text.Trim(),
                                        TxtTelMobile.Text.Trim(),
                                        TxtEMail.Text.Trim(),
                                        ChkActive.Checked,
                                        Controller.MitarbeiterID,
                                        CmbDepartment.Text,
                                        TxtAhvNr.Text.Trim(),
                                        TxtNationalaty.Text.Trim(),
                                        DtpEntrydate.Value,
                                        DtpQuitdate.Value,
                                        CmbEmploymentlevel.Text,
                                        CmbRole.Text,
                                        Convert.ToInt32(NumManagementLevel.Value))
                                        );

                                    TxtMitarbeiterID.Text = Controller.MitarbeiterID.ToString();


                                    //Speichern bzw. serialisieren ins .dat-File der List Employee nicht der Listbox!
                                    Controller.WriteDataMa();

                                    //Schreibt Counter in counter.txt
                                    Controller.ExportCounter();

                                    // Eine Art Vorschau um Mitarbeiter auszuwählen - Alle Daten wären too much!
                                    // Man hätte keine Übersicht mehr
                                    MaListToLsbOutput();

                                    //Variable für History erstellen
                                    Controller.HistoryNew =
                                    "ME: " +
                                    "Zeit der Erstellung      : " +
                                    DateTime.Now.ToString() + "| " +
                                        Controller.MitarbeiterID + "; " +
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
                                        CmbDepartment.Text + "; " +
                                        TxtAhvNr.Text + "; " +
                                        TxtNationalaty.Text + "; " +
                                        DtpEntrydate.Value + "; " +
                                        DtpQuitdate.Value + "; " +
                                        CmbEmploymentlevel.Text + "; " +
                                        CmbRole.Text + "; " +
                                        NumManagementLevel.Value;

                                    Controller.WriteLog("MaErstellt");

                                    //Counter ums eins erhöhen, da der Mitarbeiter nun ja im .dat-File mit dem richtigen Counter
                                    // bzw. Kunden-ID eingetragen ist
                                    //Extra nicht in der Methode SaveEmployeDB da sonst beim zurückkehren ins Menu
                                    //z.B. der Counter auch erhöht wird
                                    Controller.MitarbeiterID++;

                                    ClearForm();
                                }
                            }
                            else if (type == "Lehrling")
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
                                // ahv = CheckInt(TxtAhvNr.Text, TxtAhvNr);                              // Eingabe muss mit '.' folgen 
                                zipcode = Controller.CheckInt(TxtZipcode.Text.Trim(), TxtZipcode);
                                residence = Controller.CheckString(TxtResidence.Text.Trim(), TxtResidence);
                                nationalaty = Controller.CheckString(TxtNationalaty.Text.Trim(), TxtNationalaty);
                                apprenticeyears = Controller.CheckInt(TxtApprenticeYears.Text.Trim(), TxtApprenticeYears);
                                currentyear = Controller.CheckInt(TxtCurrentYear.Text.Trim(), TxtCurrentYear);

                                // Überprüft ob ein Textfeld fehlerhaft ist
                                if (titel == true || salutation == true || firstname == true || lastname == true || telprivate == true || telwork == true ||
                                    telmobile == true || fax == true || zipcode == true || residence == true || nationalaty == true || apprenticeyears == true ||
                                    currentyear == true )
                                {
                                    titel = false; salutation = false; firstname = false; lastname = false; telprivate = false; telwork = false;
                                    telmobile = false; fax = false; zipcode = false; residence = false; nationalaty = false; apprenticeyears = false; currentyear = false; ;
                                    MessageBox.Show("Ups! Sie haben einen unzulässigen Wert eingegeben", "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }
                                // Überprüft ob Person bereits existiert
                                else if (Controller.EqualsTrainee(TxtFirstname.Text.Trim(), TxtLastname.Text.Trim(), DtpBirthday.Value))
                                {
                                    MessageBox.Show("Lehrling bereits registriert", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                                }
                                else
                                {
                                    //Alle Textfelder werden in die Liste Lehrlinge eingepflegt
                                    Model.Lehrlinge.Add(new Trainee
                                        (
                                        TxtSalutation.Text.Trim(),
                                        TxtFirstname.Text.Trim(),
                                        TxtLastname.Text.Trim(),
                                        DtpBirthday.Value,
                                        CmbGender.Text,
                                        TxtTitle.Text.Trim(),
                                        TxtTelWork.Text,
                                        TxtFaxWork.Text,
                                        TxtAdress.Text,
                                        TxtZipcode.Text,
                                        TxtResidence.Text.Trim(),
                                        TxtTelPrivate.Text,
                                        TxtTelMobile.Text,
                                        TxtEMail.Text.Trim(),
                                        ChkActive.Checked,
                                        Controller.MitarbeiterID,
                                        CmbDepartment.Text,
                                        TxtAhvNr.Text.Trim(),
                                        TxtNationalaty.Text.Trim(),
                                        DtpEntrydate.Value,
                                        DtpQuitdate.Value,
                                        CmbEmploymentlevel.Text,
                                        CmbRole.Text,
                                        Convert.ToInt32(NumManagementLevel.Value),
                                        TxtApprenticeYears.Text,
                                        TxtCurrentYear.Text)
                                        );

                                    TxtMitarbeiterID.Text = Controller.MitarbeiterID.ToString();

                                    //Speichern bzw. serialisieren ins .dat-File der List Employee nicht der Listbox!
                                    Controller.WriteDataTr();



                                    //Schreibt Counter in counter.txt
                                    Controller.ExportCounter();

                                    // Eine Art Vorschau um Mitarbeiter auszuwählen - Alle Daten wären too much!
                                    // Man hätte keine Übersicht mehr
                                    MaListToLsbOutput();

                                    //Variable für History erstellen
                                    Controller.HistoryNew =
                                    "LE: " +
                                    "Zeit der Erstellung      : " +
                                    DateTime.Now.ToString() + "| " +
                                        Controller.MitarbeiterID + "; " +
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
                                        CmbDepartment.Text + "; " +
                                        TxtAhvNr.Text + "; " +
                                        TxtNationalaty.Text + "; " +
                                        DtpEntrydate.Value + "; " +
                                        DtpQuitdate.Value + "; " +
                                        CmbEmploymentlevel.Text + "; " +
                                        CmbRole.Text + "; " +
                                        NumManagementLevel.Value + "; " +
                                        TxtApprenticeYears.Text + "; " +
                                        TxtCurrentYear.Text;

                                    Controller.WriteLog("TrErstellt");


                                    //Counter ums eins erhöhen, da der Lehrling nun ja im .dat-File mit dem richtigen Counter
                                    // bzw. Kunden-ID eingetragen ist
                                    //Extra nicht in der Methode SaveEmployeDB da sonst beim zurückkehren ins Menu
                                    //z.B. der Counter auch erhöht wird
                                    Controller.MitarbeiterID++;
                                    ClearForm();
                                }
                            }
            }

            if (Controller.ImportedEmployee == true)
            {
                if (type == "Mitarbeiter")
                {
                    try
                     {
                        if (Controller.EmployeeImportDaten.Length > 23 || Controller.EmployeeImportDaten.Length < 23) //Würde heissen falsches CSV -> Mitarbeiter/Lehrling(oder korruptes) statt Kunden ausgewählt
                        {
                            if(Controller.CounterImportedEmployeeOrTrainee == 0)
                            {
                                MessageBox.Show("CSV-File enthält korrupte Datensätze(Korrekte werden importiert!)");
                            }
                            Controller.CounterImportedEmployeeOrTrainee++;

                        }
                        else
                        {
                                //Alle Textfelder werden in die Liste Mitarbeiter eingepflegt
                                Model.Mitarbeiter.Add(new Employee(
                                    Controller.EmployeeImportDaten[0],
                                    Controller.EmployeeImportDaten[1],
                                    Controller.EmployeeImportDaten[2],
                                    DateTime.Parse(Controller.EmployeeImportDaten[3]), //Format: //01.01.1996 00:00:00,
                                    Controller.EmployeeImportDaten[4],
                                    Controller.EmployeeImportDaten[5],
                                    Controller.EmployeeImportDaten[6],
                                    Controller.EmployeeImportDaten[7],
                                    Controller.EmployeeImportDaten[8],
                                    Controller.EmployeeImportDaten[9],
                                    Controller.EmployeeImportDaten[10],
                                    Controller.EmployeeImportDaten[11],
                                    Controller.EmployeeImportDaten[12],
                                    Controller.EmployeeImportDaten[13],
                                    bool.Parse(Controller.EmployeeImportDaten[14]),
                                    Controller.MitarbeiterID,
                                    Controller.EmployeeImportDaten[15],
                                    Controller.EmployeeImportDaten[16],
                                    Controller.EmployeeImportDaten[17],
                                    DateTime.Parse(Controller.EmployeeImportDaten[18]),
                                    DateTime.Parse(Controller.EmployeeImportDaten[19]),
                                    Controller.EmployeeImportDaten[20],
                                    Controller.EmployeeImportDaten[21],
                                    Convert.ToInt32(Controller.EmployeeImportDaten[22])

                                    ));


                                //Speichern bzw. serialisieren ins .dat-File der List Employee nicht der Listbox!
                                Controller.WriteDataMa();

                                //Schreibt Counter in counter.txt
                                Controller.ExportCounter();

                                // Eine Art Vorschau um Mitarbeiter auszuwählen - Alle Daten wären too much!
                                // Man hätte keine Übersicht mehr
                                MaListToLsbOutput();

                                //Variable für History erstellen
                                Controller.HistoryNew =
                                "ME: " +
                                "Zeit der Erstellung      : " +
                                DateTime.Now.ToString() + "| " +
                                    Controller.MitarbeiterID + "; " +
                                    Controller.EmployeeImportDaten[0] + "; " +
                                    Controller.EmployeeImportDaten[1] + "; " +
                                    Controller.EmployeeImportDaten[2] + "; " +
                                   Controller.EmployeeImportDaten[3] + "; " +
                                    Controller.EmployeeImportDaten[4] + "; " +
                                    Controller.EmployeeImportDaten[5] + "; " +
                                    Controller.EmployeeImportDaten[6] + "; " +
                                    Controller.EmployeeImportDaten[7] + "; " +
                                    Controller.EmployeeImportDaten[8] + "; " +
                                    Controller.EmployeeImportDaten[9] + "; " +
                                    Controller.EmployeeImportDaten[10] + "; " +
                                    Controller.EmployeeImportDaten[11] + "; " +
                                    Controller.EmployeeImportDaten[12] + "; " +
                                    Controller.EmployeeImportDaten[13] + "; " +
                                    Controller.EmployeeImportDaten[14] + "; " +
                                    Controller.EmployeeImportDaten[15] + "; " +
                                    Controller.EmployeeImportDaten[16] + "; " +
                                    Controller.EmployeeImportDaten[17] + "; " +
                                    Controller.EmployeeImportDaten[18] + "; " +
                                    Controller.EmployeeImportDaten[19] + "; " +
                                    Controller.EmployeeImportDaten[20] + "; " +
                                    Controller.EmployeeImportDaten[21] + "; " +
                                    Controller.EmployeeImportDaten[22];

                                Controller.WriteLog("MaErstellt");

                                //Counter ums eins erhöhen, da der Mitarbeiter nun ja im .dat-File mit dem richtigen Counter
                                // bzw. Kunden-ID eingetragen ist
                                //Extra nicht in der Methode SaveEmployeDB da sonst beim zurückkehren ins Menu
                                //z.B. der Counter auch erhöht wird
                                Controller.MitarbeiterID++;

                        
                    

                    }
                }
                catch
                {
                    MessageBox.Show("CSV-File enthält korrupte Daten");
                    Controller.CounterImportedEmployeeOrTrainee++;
                }

            }



                if (type == "Lehrling")
                    {
                        try
                        {
                            if (Controller.TraineeImportDaten.Length > 25 || Controller.TraineeImportDaten.Length < 25) //Würde heissen falsches CSV -> Mitarbeiter/Lehrling(oder korruptes) statt Kunden ausgewählt
                            {
                                if (Controller.CounterImportedEmployeeOrTrainee == 0)
                                {
                                    MessageBox.Show("CSV-File enthält korrupte Datensätze(Korrekte werden importiert!)");
                                }
                                Controller.CounterImportedEmployeeOrTrainee++;
                            }
                        else
                        {

                            //Alle Textfelder werden in die Liste Mitarbeiter eingepflegt
                            Model.Lehrlinge.Add(new Trainee(
                                Controller.TraineeImportDaten[0],
                                Controller.TraineeImportDaten[1],
                                Controller.TraineeImportDaten[2],
                                DateTime.Parse(Controller.TraineeImportDaten[3]), //Format: //01.01.1996 00:00:00,
                                Controller.TraineeImportDaten[4],
                                Controller.TraineeImportDaten[5],
                                Controller.TraineeImportDaten[6],
                                Controller.TraineeImportDaten[7],
                                Controller.TraineeImportDaten[8],
                                Controller.TraineeImportDaten[9],
                                Controller.TraineeImportDaten[10],
                                Controller.TraineeImportDaten[11],
                                Controller.TraineeImportDaten[12],
                                Controller.TraineeImportDaten[13],
                                bool.Parse(Controller.TraineeImportDaten[14]),
                                Controller.MitarbeiterID,
                                Controller.TraineeImportDaten[15],
                                Controller.TraineeImportDaten[16],
                                Controller.TraineeImportDaten[17],
                                DateTime.Parse(Controller.TraineeImportDaten[18]),
                                DateTime.Parse(Controller.TraineeImportDaten[19]),
                                Controller.TraineeImportDaten[20],
                                Controller.TraineeImportDaten[21],
                                Convert.ToInt32(Controller.TraineeImportDaten[22]),
                                Controller.TraineeImportDaten[22],
                                Controller.TraineeImportDaten[23]
                                ));


                            //Speichern bzw. serialisieren ins .dat-File der List Employee nicht der Listbox!
                            Controller.WriteDataTr();



                            //Schreibt Counter in counter.txt
                            Controller.ExportCounter();

                            // Eine Art Vorschau um Mitarbeiter auszuwählen - Alle Daten wären too much!
                            // Man hätte keine Übersicht mehr
                            MaListToLsbOutput();

                            //Variable für History erstellen
                            Controller.HistoryNew =
                            "LE: " +
                            "Zeit der Erstellung      : " +
                            DateTime.Now.ToString() + "| " +
                            Controller.MitarbeiterID + "; " +
                            Controller.TraineeImportDaten[0] + "; " +
                            Controller.TraineeImportDaten[1] + "; " +
                            Controller.TraineeImportDaten[2] + "; " +
                            Controller.TraineeImportDaten[3] + "; " +
                            Controller.TraineeImportDaten[4] + "; " +
                            Controller.TraineeImportDaten[5] + "; " +
                            Controller.TraineeImportDaten[6] + "; " +
                            Controller.TraineeImportDaten[7] + "; " +
                            Controller.TraineeImportDaten[8] + "; " +
                            Controller.TraineeImportDaten[9] + "; " +
                            Controller.TraineeImportDaten[10] + "; " +
                            Controller.TraineeImportDaten[11] + "; " +
                            Controller.TraineeImportDaten[12] + "; " +
                            Controller.TraineeImportDaten[13] + "; " +
                            Controller.TraineeImportDaten[14] + "; " +
                            Controller.TraineeImportDaten[15] + "; " +
                            Controller.TraineeImportDaten[16] + "; " +
                            Controller.TraineeImportDaten[17] + "; " +
                            Controller.TraineeImportDaten[18] + "; " +
                            Controller.TraineeImportDaten[19] + "; " +
                            Controller.TraineeImportDaten[20] + "; " +
                            Controller.TraineeImportDaten[21] + "; " +
                            Controller.TraineeImportDaten[22] + "; " +
                            Controller.TraineeImportDaten[23] + "; " +
                            Controller.TraineeImportDaten[24];

                            Controller.WriteLog("TrErstellt");


                            //Counter ums eins erhöhen, da der Lehrling nun ja im .dat-File mit dem richtigen Counter
                            // bzw. Kunden-ID eingetragen ist
                            //Extra nicht in der Methode SaveEmployeDB da sonst beim zurückkehren ins Menu
                            //z.B. der Counter auch erhöht wird
                            Controller.MitarbeiterID++;
                            ClearForm();
                        }


                        }
                        catch
                        {

                        }
                }
               
               
            }

            
        }

        private void CmdAddEmployee_Click(object sender, EventArgs e) 
        {
            Controller.ImportedEmployee = false;
            SelectRightList();
        }

        private void SelectRightList()
        {
            if (ChkTrainee.Checked == false)
                AddEmployeeOrTrainee("Mitarbeiter");

            if (ChkTrainee.Checked == true)
                AddEmployeeOrTrainee("Lehrling");
        }
       
        private void CmdEditEmployee_Click(object sender, EventArgs e)
        {
            //damit richtiger Mitarbeiter geladen wird
            SelectedMA = LsbOutputMA.SelectedIndex;

            // Falls Button Mitarbeiter hinzufügen deaktivert ist wieder aktivieren
            // Wird erst true nachdem ein markierter Mitarbeiter bearbeitet wurde
            if (CmdAddEmployee.Enabled == false)
            {

                //Text auf Button zurücksetzen
                CmdEditEmployee.Text = "Mitarbeiter \r\n bearbeiten";

                //Buttons aktivieren
                CmdAddEmployee.Enabled = true;
                CmdMenue.Enabled = true;
                CmdDelEmployee.Enabled = true;

                //Listbox aktivieren
                LsbOutputMA.Enabled = true;

                if(RadMitarbeiter.Checked == true)
                {
                    //Werte aus Textboxen in Liste speichern
                    Model.Mitarbeiter[SelectedMA].Salutation = TxtSalutation.Text;
                    Model.Mitarbeiter[SelectedMA].Firstname = TxtFirstname.Text;
                    Model.Mitarbeiter[SelectedMA].Lastname = TxtLastname.Text;
                    Model.Mitarbeiter[SelectedMA].Birthday = DtpBirthday.Value;
                    Model.Mitarbeiter[SelectedMA].Gender = CmbGender.Text;
                    Model.Mitarbeiter[SelectedMA].Title = TxtTitle.Text;
                    Model.Mitarbeiter[SelectedMA].TelWork = TxtTelWork.Text;
                    Model.Mitarbeiter[SelectedMA].FaxWork = TxtFaxWork.Text;
                    Model.Mitarbeiter[SelectedMA].Adress = TxtAdress.Text;
                    Model.Mitarbeiter[SelectedMA].Zipcode = TxtZipcode.Text;
                    Model.Mitarbeiter[SelectedMA].Residence = TxtResidence.Text;
                    Model.Mitarbeiter[SelectedMA].TelPrivate = TxtTelPrivate.Text;
                    Model.Mitarbeiter[SelectedMA].TelMobile = TxtTelMobile.Text;
                    Model.Mitarbeiter[SelectedMA].EMail = TxtEMail.Text;
                    Model.Mitarbeiter[SelectedMA].Active = ChkActive.Checked;
                    Model.Mitarbeiter[SelectedMA].MitarbeiterID = Convert.ToInt32(TxtMitarbeiterID.Text);
                    Model.Mitarbeiter[SelectedMA].Department = CmbDepartment.Text;
                    Model.Mitarbeiter[SelectedMA].AHVNumber = TxtAhvNr.Text;
                    Model.Mitarbeiter[SelectedMA].Nationality = TxtNationalaty.Text;
                    Model.Mitarbeiter[SelectedMA].EntryDate = DtpEntrydate.Value;
                    Model.Mitarbeiter[SelectedMA].QuitDate = DtpQuitdate.Value;
                    Model.Mitarbeiter[SelectedMA].EmploymentLevel = CmbEmploymentlevel.Text;
                    Model.Mitarbeiter[SelectedMA].Role = CmbRole.Text;
                    Model.Mitarbeiter[SelectedMA].ManagementLevel = Convert.ToInt32(NumManagementLevel.Value);

                    //Vorschau in Listbox generieren
                    MaListToLsbOutput();

                    //In File schreiben um Änderung anzupassen
                    Controller.WriteDataMa();

                    //Variable für History nach Bearbeitung erstellen

                Controller.HistoryNew =
                    "MB: " +
                    "Endzeit der Bearbeitung  : " +
                    DateTime.Now.ToString() + "| " +
                    TxtMitarbeiterID.Text + ":" +
                    TxtSalutation.Text + ";" +
                    TxtFirstname.Text + ";" +
                    TxtLastname.Text + ";" +
                    DtpBirthday.Value.ToString() + ";" +
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
                    ChkActive.Checked.ToString() + ";" +
                    TxtMitarbeiterID.Text + ";" +
                    CmbDepartment.Text + ";" +
                    TxtAhvNr.Text + ";" +
                    TxtNationalaty.Text + ";" +
                    DtpEntrydate.Value.ToString() + ";" +
                    DtpQuitdate.Value.ToString() + ";" +
                    CmbEmploymentlevel.Text + ";" +
                    CmbRole.Text + ";" +
                    NumManagementLevel.Value.ToString();

                //Mitarbeiterbearbeitung ins Log schreiben
                Controller.WriteLog("MaBearbeitet");

                //Textfelder leeren
                ClearForm();      
                }

                if(RadLehrling.Checked == true)
                {
                    //Werte aus Textboxen in Liste speichern
                    Model.Lehrlinge[SelectedMA].Salutation = TxtSalutation.Text;
                    Model.Lehrlinge[SelectedMA].Firstname = TxtFirstname.Text;
                    Model.Lehrlinge[SelectedMA].Lastname = TxtLastname.Text;
                    Model.Lehrlinge[SelectedMA].Birthday = DtpBirthday.Value;
                    Model.Lehrlinge[SelectedMA].Gender = CmbGender.Text;
                    Model.Lehrlinge[SelectedMA].Title = TxtTitle.Text;
                    Model.Lehrlinge[SelectedMA].TelWork = TxtTelWork.Text;
                    Model.Lehrlinge[SelectedMA].FaxWork = TxtFaxWork.Text;
                    Model.Lehrlinge[SelectedMA].Adress = TxtAdress.Text;
                    Model.Lehrlinge[SelectedMA].Zipcode = TxtZipcode.Text;
                    Model.Lehrlinge[SelectedMA].Residence = TxtResidence.Text;
                    Model.Lehrlinge[SelectedMA].TelPrivate = TxtTelPrivate.Text;
                    Model.Lehrlinge[SelectedMA].TelMobile = TxtTelMobile.Text;
                    Model.Lehrlinge[SelectedMA].EMail = TxtEMail.Text;
                    Model.Lehrlinge[SelectedMA].Active = ChkActive.Checked;
                    Model.Lehrlinge[SelectedMA].MitarbeiterID = Convert.ToInt32(TxtMitarbeiterID.Text);
                    Model.Lehrlinge[SelectedMA].Department = CmbDepartment.Text;
                    Model.Lehrlinge[SelectedMA].AHVNumber = TxtAhvNr.Text;
                    Model.Lehrlinge[SelectedMA].Nationality = TxtNationalaty.Text;
                    Model.Lehrlinge[SelectedMA].EntryDate = DtpEntrydate.Value;
                    Model.Lehrlinge[SelectedMA].QuitDate = DtpQuitdate.Value;
                    Model.Lehrlinge[SelectedMA].EmploymentLevel = CmbEmploymentlevel.Text;
                    Model.Lehrlinge[SelectedMA].Role = CmbRole.Text;
                    Model.Lehrlinge[SelectedMA].ManagementLevel = Convert.ToInt32(NumManagementLevel.Value);
                    Model.Lehrlinge[SelectedMA].ApprenticeshipYears = TxtApprenticeYears.Text;
                    Model.Lehrlinge[SelectedMA].CurrentYear = TxtCurrentYear.Text;

                    //Vorschau in Listbox generieren
                    MaListToLsbOutput();

                    //In File schreiben um Änderung anzupassen
                    Controller.WriteDataTr();

                    //Variable für History nach Bearbeitung erstellen
              Controller.HistoryNew =
                    "LB: " +
                    "Endzeit der Bearbeitung  : " +
                    DateTime.Now.ToString() + "| " +
                    TxtMitarbeiterID.Text + ":" +
                    TxtSalutation.Text + ";" +
                    TxtFirstname.Text + ";" +
                    TxtLastname.Text + ";" +
                    DtpBirthday.Value.ToString() + ";" +
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
                    ChkActive.Checked.ToString() + ";" +
                    TxtMitarbeiterID.Text + ";" +
                    CmbDepartment.Text + ";" +
                    TxtAhvNr.Text + ";" +
                    TxtNationalaty.Text + ";" +
                    DtpEntrydate.Value.ToString() + ";" +
                    DtpQuitdate.Value.ToString() + ";" +
                    CmbEmploymentlevel.Text + ";" +
                    CmbRole.Text + ";" +
                    NumManagementLevel.Value.ToString() + ";" +
                    TxtApprenticeYears.Text + "; " +
                    TxtCurrentYear.Text; ;

                //Mitarbeiterbearbeitung ins Log schreiben
                Controller.WriteLog("TrBearbeitet");

                //Textfelder leeren
                ClearForm();
                   
                }
            }
            else //Erster Durchgang beim Bearbeiten des Mitarbeits
            {
                if(RadMitarbeiter.Checked == true)
                {
                    //Abgfage ob Mitarbeiter aus Vorschau ausgewählt wurde
                    if (LsbOutputMA.SelectedItem != null && CmdAddEmployee.Enabled == true)
                    {
                        //Text auf Button ändern
                        CmdEditEmployee.Text = "Änderung \r\n speichern!";

                        //Buttons deaktivieren
                        CmdAddEmployee.Enabled = false;
                        CmdMenue.Enabled = false;
                        CmdDelEmployee.Enabled = false;

                        //Listbox deaktivieren
                        LsbOutputMA.Enabled = false;

                        //Lädt die Werte in die entsprechenden Felder des Forms
                        TxtSalutation.Text = Model.Mitarbeiter[SelectedMA].Salutation;
                        TxtFirstname.Text = Model.Mitarbeiter[SelectedMA].Firstname;
                        TxtLastname.Text = Model.Mitarbeiter[SelectedMA].Lastname;
                        DtpBirthday.Value = Model.Mitarbeiter[SelectedMA].Birthday;
                        CmbGender.Text = Model.Mitarbeiter[SelectedMA].Gender;
                        TxtTitle.Text = Model.Mitarbeiter[SelectedMA].Title;
                        TxtTelWork.Text = Model.Mitarbeiter[SelectedMA].TelWork;
                        TxtFaxWork.Text = Model.Mitarbeiter[SelectedMA].FaxWork;
                        TxtAdress.Text = Model.Mitarbeiter[SelectedMA].Adress;
                        TxtZipcode.Text = Model.Mitarbeiter[SelectedMA].Zipcode;
                        TxtResidence.Text = Model.Mitarbeiter[SelectedMA].Residence;
                        TxtTelPrivate.Text = Model.Mitarbeiter[SelectedMA].TelPrivate;
                        TxtTelMobile.Text = Model.Mitarbeiter[SelectedMA].TelMobile;
                        TxtEMail.Text = Model.Mitarbeiter[SelectedMA].EMail;
                        ChkActive.Checked = Model.Mitarbeiter[SelectedMA].Active;
                        TxtMitarbeiterID.Text = Model.Mitarbeiter[SelectedMA].MitarbeiterID.ToString();
                        CmbDepartment.Text = Model.Mitarbeiter[SelectedMA].Department;
                        TxtAhvNr.Text = Model.Mitarbeiter[SelectedMA].AHVNumber;
                        TxtNationalaty.Text = Model.Mitarbeiter[SelectedMA].Nationality;
                        DtpEntrydate.Value = Model.Mitarbeiter[SelectedMA].EntryDate;
                        DtpQuitdate.Value = Model.Mitarbeiter[SelectedMA].QuitDate;
                        CmbEmploymentlevel.Text = Model.Mitarbeiter[SelectedMA].EmploymentLevel;
                        CmbRole.Text = Model.Mitarbeiter[SelectedMA].Role;
                        NumManagementLevel.Value = Model.Mitarbeiter[SelectedMA].ManagementLevel;

                        //Variable für History vor Bearbeitung erstellen
                        Controller.History =
                            "MB: " +
                            "Startzeit der Bearbeitung: " +
                            DateTime.Now.ToString() + "| " +
                            TxtMitarbeiterID.Text + ":" +
                            TxtSalutation.Text + ";" +
                            TxtFirstname.Text + ";" +
                            TxtLastname.Text + ";" +
                            DtpBirthday.Value.ToString() + ";" +
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
                            ChkActive.Checked.ToString() + ";" +
                            TxtMitarbeiterID.Text + ";" +
                            CmbDepartment.Text + ";" +
                            TxtAhvNr.Text + ";" +
                            TxtNationalaty.Text + ";" +
                            DtpEntrydate.Value.ToString() + ";" +
                            DtpQuitdate.Value.ToString() + ";" +
                            CmbEmploymentlevel.Text + ";" +
                            CmbRole.Text + ";" +
                            NumManagementLevel.Value.ToString();
                    }
                    else
                        MessageBox.Show("Bitte Mitarbeiter auswählen!");
                }
                if(RadLehrling.Checked == true)
                {
                    //Abgfage ob Lehrling aus Vorschau ausgewählt wurde
                    if (LsbOutputMA.SelectedItem != null && CmdAddEmployee.Enabled == true)
                    {
                        //Text auf Button ändern
                        CmdEditEmployee.Text = "Änderung \r\n speichern!";

                        //Buttons deaktivieren
                        CmdAddEmployee.Enabled = false;
                        CmdMenue.Enabled = false;
                        CmdDelEmployee.Enabled = false;

                        //Listbox deaktivieren
                        LsbOutputMA.Enabled = false;

                        //Lädt die Werte in die entsprechenden Felder des Forms
                        TxtSalutation.Text = Model.Lehrlinge[SelectedMA].Salutation;
                        TxtFirstname.Text = Model.Lehrlinge[SelectedMA].Firstname;
                        TxtLastname.Text = Model.Lehrlinge[SelectedMA].Lastname;
                        DtpBirthday.Value = Model.Lehrlinge[SelectedMA].Birthday;
                        CmbGender.Text = Model.Lehrlinge[SelectedMA].Gender;
                        TxtTitle.Text = Model.Lehrlinge[SelectedMA].Title;
                        TxtTelWork.Text = Model.Lehrlinge[SelectedMA].TelWork;
                        TxtFaxWork.Text = Model.Lehrlinge[SelectedMA].FaxWork;
                        TxtAdress.Text = Model.Lehrlinge[SelectedMA].Adress;
                        TxtZipcode.Text = Model.Lehrlinge[SelectedMA].Zipcode;
                        TxtResidence.Text = Model.Lehrlinge[SelectedMA].Residence;
                        TxtTelPrivate.Text = Model.Lehrlinge[SelectedMA].TelPrivate;
                        TxtTelMobile.Text = Model.Lehrlinge[SelectedMA].TelMobile;
                        TxtEMail.Text = Model.Lehrlinge[SelectedMA].EMail;
                        ChkActive.Checked = Model.Lehrlinge[SelectedMA].Active;
                        TxtMitarbeiterID.Text = Model.Lehrlinge[SelectedMA].MitarbeiterID.ToString();
                        CmbDepartment.Text = Model.Lehrlinge[SelectedMA].Department;
                        TxtAhvNr.Text = Model.Lehrlinge[SelectedMA].AHVNumber;
                        TxtNationalaty.Text = Model.Lehrlinge[SelectedMA].Nationality;
                        DtpEntrydate.Value = Model.Lehrlinge[SelectedMA].EntryDate;
                        DtpQuitdate.Value = Model.Lehrlinge[SelectedMA].QuitDate;
                        CmbEmploymentlevel.Text = Model.Lehrlinge[SelectedMA].EmploymentLevel;
                        CmbRole.Text = Model.Lehrlinge[SelectedMA].Role;
                        NumManagementLevel.Value = Model.Lehrlinge[SelectedMA].ManagementLevel;
                        TxtApprenticeYears.Text = Model.Lehrlinge[SelectedMA].ApprenticeshipYears;
                        TxtCurrentYear.Text = Model.Lehrlinge[SelectedMA].CurrentYear;

                        //Variable für History vor Bearbeitung erstellen
                        Controller.History =
                            "LB: " +
                            "Startzeit der Bearbeitung: " +
                            DateTime.Now.ToString() + "| " +
                            TxtMitarbeiterID.Text + ":" +
                            TxtSalutation.Text + ";" +
                            TxtFirstname.Text + ";" +
                            TxtLastname.Text + ";" +
                            DtpBirthday.Value.ToString() + ";" +
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
                            ChkActive.Checked.ToString() + ";" +
                            TxtMitarbeiterID.Text + ";" +
                            CmbDepartment.Text + ";" +
                            TxtAhvNr.Text + ";" +
                            TxtNationalaty.Text + ";" +
                            DtpEntrydate.Value.ToString() + ";" +
                            DtpQuitdate.Value.ToString() + ";" +
                            CmbEmploymentlevel.Text + ";" +
                            CmbRole.Text + ";" +
                            NumManagementLevel.Value.ToString() + ";" +
                            TxtApprenticeYears.Text + ";" +
                            TxtCurrentYear.Text;
                    }
                    else
                    {
                        MessageBox.Show("Bitte Lehrling auswählen!");
                    }
                }
            }
        }
        
        private void CmdDelEmployee_Click(object sender, EventArgs e)
        {

            if(RadMitarbeiter.Checked == true)
            {
                // Falls ein Mitarbeiter ausgewählt true
                if (LsbOutputMA.SelectedItem != null)
                {
                    //zu löschenden Mitarbeiter in Variable schreiben
                    SelectedMA = LsbOutputMA.SelectedIndex;

                    //aktuellene Mitarbeiternummer exportieren
                    //Controller.ExportCounter();                          //Hier von Joel geändert für MitarbeiterID   1/2

                    //ausgewählten Mitarbeiter aus Liste Mitarbeiter löschen
                    Controller.DeleteSelected("Mitarbeiter", SelectedMA);

                    Controller.WriteDataMa();

                    Controller.WriteLog("MaGeloescht");

                    MaListToLsbOutput();

                }
                // Sonst Meldung an User
                else
                {
                    MessageBox.Show("Bitte Mitarbeiter selektieren");
                }
            }
           
            if(RadLehrling.Checked == true)
            {
                // Falls ein Mitarbeiter ausgewählt true
                if (LsbOutputMA.SelectedItem != null)
                {
                    //zu löschenden Lehrling in Variable schreiben
                    SelectedMA = LsbOutputMA.SelectedIndex;

                    //ausgewählten Lehrling aus Liste Lehrlinge löschen
                    Controller.DeleteSelected("Lehrling", SelectedMA);

                    Controller.WriteDataTr();

                    Controller.WriteLog("TrGeloescht");

                    MaListToLsbOutput();

                }
                // Sonst Meldung an User
                else
                {
                    MessageBox.Show("Bitte Lehrling selektieren");
                }
            }
        }

        private void CmdMenue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Menue fkunde = new Form_Menue();
            fkunde.ShowDialog();

            //Automatisches Sichern
            Controller.WriteDataMa();
        }

        private void MaListToLsbOutput()
    {
            if(RadMitarbeiter.Checked == true)
            {
                //leert Listbox
                LsbOutputMA.Items.Clear();

                //befüllt Listbox mit Inhalt der Liste Mitarbeiter
                int tempCounter = 0;
                foreach (Employee mitarbeiter in Model.Mitarbeiter)
                {
                    LsbOutputMA.Items.Add(
                        "Mitarbeiter ID: " +
                Model.Mitarbeiter[tempCounter].MitarbeiterID + ": " +
                Model.Mitarbeiter[tempCounter].Salutation + " " +
                Model.Mitarbeiter[tempCounter].Firstname + " " +
                Model.Mitarbeiter[tempCounter].Lastname + "," +
                Model.Mitarbeiter[tempCounter].Department + "," +
                Model.Mitarbeiter[tempCounter].Role + "," +
                Model.Mitarbeiter[tempCounter].Residence + "," +
                Model.Mitarbeiter[tempCounter].TelWork
                );
                    tempCounter++;
                }
            }
            if(RadLehrling.Checked == true)
            {
                //leert Listbox
                LsbOutputMA.Items.Clear();

                //befüllt Listbox mit Inhalt der Liste Lehrlinge
                int tempCounter = 0;
                foreach (Trainee lehrling in Model.Lehrlinge)
                {
                    LsbOutputMA.Items.Add(
                        "Mitarbeiter ID: " + //Lehrlinge sind auch Mitarbeiter, daher eigene MitarbeiterID
                Model.Lehrlinge[tempCounter].MitarbeiterID + ": " +
                Model.Lehrlinge[tempCounter].Salutation + " " +
                Model.Lehrlinge[tempCounter].Firstname + " " +
                Model.Lehrlinge[tempCounter].Lastname + "," +
                Model.Lehrlinge[tempCounter].Department + "," +
                Model.Lehrlinge[tempCounter].Role + "," +
                Model.Lehrlinge[tempCounter].Residence + "," +
                Model.Lehrlinge[tempCounter].TelWork
                );
                    tempCounter++;
                }
            }         
        }

        private void ClearForm()
        {
            TxtSalutation.Text = "";
            TxtFirstname.Text = "";
            TxtLastname.Text = "";
            CmbGender.SelectedIndex = 0;
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
            TxtMitarbeiterID.Text = "";
            CmbDepartment.SelectedIndex=0 ;
            TxtAhvNr.Text = "";
            TxtNationalaty.Text = "";
            CmbEmploymentlevel.SelectedIndex = 5;
            CmbRole.SelectedIndex = 0;
            TxtMitarbeiterID.Text = Controller.MitarbeiterID.ToString();
            TxtApprenticeYears.Text = "";
            TxtCurrentYear.Text = "";
            

        }

        private void ChkTrainee_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkTrainee.Checked)
            {
                LblCurrentYear.Visible = true;
                LblApprenticeYears.Visible = true;
                TxtApprenticeYears.Visible = true;
                TxtCurrentYear.Visible = true;

                RadLehrling.Checked = true;
            }
            else
            {
                LblCurrentYear.Visible = false;
                LblApprenticeYears.Visible = false;
                TxtApprenticeYears.Visible = false;
                TxtCurrentYear.Visible = false;

                RadMitarbeiter.Checked = true;

            }
        }

        private void RadMitarbeiter_CheckedChanged(object sender, EventArgs e)
        {
            if(RadMitarbeiter.Checked == true)
            {
                MaListToLsbOutput();
                ChkTrainee.Checked = false;
                CmdMitarbeiterImport.Text = "Mitarbeiter importieren aus CSV-Datei";
            }          
        }

        private void RadLehrling_CheckedChanged(object sender, EventArgs e)
        {
            if (RadLehrling.Checked == true)
            {
                MaListToLsbOutput();
                ChkTrainee.Checked = true;
                CmdMitarbeiterImport.Text = "Lehrling(e) importieren aus CSV-Datei";
            }
        }

        private void CmdMitarbeiterImport_Click(object sender, EventArgs e)
        {
            Controller.ImportedEmployee = true;
            GetImportPath(); //CSV-Pfad herholen
            //Controller.SelectedImportPath = "C:\\NeuesProjekt\\ContectManager\\ContectManager\\Kontaktdaten-Beispiele\\Lehrlinge\\3Lehrlinge1Korrupt.csv";

            ImportMitarbeiter();
        }
        private void ImportMitarbeiter()
        {
           

            //Variable um Code leserlicher zu machen
            string CsvPath = Controller.SelectedImportPath;
            //Variable Reader öffnet das selectierte  CSV-File
            var reader = new StreamReader(File.OpenRead(CsvPath));

            int counter = 0; // Counter initialisieren um Anzahl Lehrlinge/Mitarbeiter dem Benutzer auszugeben
            Controller.CounterImportedEmployeeOrTrainee = 0; //Auf 0 setzen, da wir mehrere Imports machen können und der Counter sonst nicht stimmt
            while (!reader.EndOfStream) //While solange true bis eine leere Zeile kommt
            {
                string Zeile = reader.ReadLine(); // Variabel Zeile wird vereinfacht dargestellt

                // EmployeeImportDaten ist ein Array, welcher mit den einzelnen Werten der Zeile die
                //durch ; getrennt sind einspeichert
               if (ChkTrainee.Checked == false)
                { 
                  Controller.EmployeeImportDaten = Zeile.Split(';');
                    AddEmployeeOrTrainee("Mitarbeiter");
                }
               if (ChkTrainee.Checked == true)
               {
                    Controller.TraineeImportDaten = Zeile.Split(';');
                    AddEmployeeOrTrainee("Lehrling");
               }
                Controller.EmployeeImportDaten = Zeile.Split(';');
               

                counter++;
            }
            if (counter == 0)
            {
                MessageBox.Show("CSV-File ist leer!");

            }
            else
            {
                if (ChkTrainee.Checked == false)
                {
                    counter = counter - Controller.CounterImportedEmployeeOrTrainee;
                    MessageBox.Show(counter + " Mitarbeiter wurden importiert");


                }
                if (ChkTrainee.Checked == true)
                {
                    counter = counter - Controller.CounterImportedEmployeeOrTrainee;
                    MessageBox.Show(counter + " Lehrlinge wurden importiert");


                }

            }


        }

        private void GetImportPath()
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
    }  
}
