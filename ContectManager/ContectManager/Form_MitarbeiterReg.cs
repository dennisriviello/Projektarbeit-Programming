﻿using System;
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
        public Form_MitarbeiterReg()
        {
            InitializeComponent();

            //Erklärungen in Klasse Controller
            Controller.FirstUseCheck();

            // generiert Vorschau der Mitarbeiter in LsbOutputMa
            MaListToLsbOutput();

            //MitarbeiterID in Textfeld der Form laden
            TxtMitarbeiterID.Text = Controller.MitarbeiterID.ToString();
        }

        //Variable "ausgewählter Mitarbeiter" initialisieren damit sie in Form abgeändert werden kann
        private int SelectedMA;

        private void CmdAddEmployee_Click(object sender, EventArgs e) // Beschreibung in der Methode
        {
            //Alle Textfelder werden in die Liste Mitarbeiter eingepflegt
            Model.Mitarbeiter.Add(new Employee(
                TxtSalutation.Text,
                TxtFirstname.Text,
                TxtLastname.Text,
                DtpBirthday.Value,
                CmbGender.Text,
                TxtTitle.Text,
                TxtTelWork.Text,
                TxtFaxWork.Text,
                TxtAdress.Text,
                TxtZipcode.Text,
                TxtResidence.Text,
                TxtTelPrivate.Text,
                TxtTelMobile.Text,
                TxtEMail.Text,
                ChkActive.Checked,
                Controller.MitarbeiterID,
                CmbDepartment.Text,
                TxtAhvNr.Text,
                TxtNationalaty.Text,
                DtpEntrydate.Value,
                DtpQuitdate.Value,
                CmbEmploymentlevel.Text,
                CmbRole.Text,
                Convert.ToInt32(NumManagementLevel.Value))
                );


            //Counter ums eins erhöhen, da der Mitarbeiter nun ja im .dat-File mit dem richtigen Counter
            // bzw. Kunden-ID eingetragen ist
            //Extra nicht in der Methode SaveEmployeDB da sonst beim zurückkehren ins Menu
            //z.B. der Counter auch erhöht wird
            Controller.MitarbeiterID++;
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

            ClearForm();
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
            else //Erster Durchgang beim Bearbeiten des Mitarbeits
            {
                //Abgfage ob Kunde aus Vorschau ausgewählt wurde
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
                {
                    MessageBox.Show("Bitte Mitarbeiter auswählen!");
                }



            }
        }
        
        private void CmdDelEmployee_Click(object sender, EventArgs e)
        {
            // Falls ein Mitarbeiter ausgewählt true
            if (LsbOutputMA.SelectedItem != null)
            {
                //zu löschenden Mitarbeiter in Variable schreiben
                SelectedMA = LsbOutputMA.SelectedIndex;

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

            //leert Listbox
            LsbOutputMA.Items.Clear();

            //befüllt Listbox mit Inhalt der Liste Kunden
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
            TxtMitarbeiterID.Text = "";
            CmbDepartment.Text = "";
            TxtAhvNr.Text = "";
            TxtNationalaty.Text = "";
            CmbEmploymentlevel.Text = "";
            CmbRole.Text = "";
            TxtMitarbeiterID.Text = Controller.MitarbeiterID.ToString();
        }

    }

    
}
