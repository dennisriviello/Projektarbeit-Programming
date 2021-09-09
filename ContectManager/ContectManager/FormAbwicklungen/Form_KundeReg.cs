﻿using System;
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
        }

        //Variable "ausgewählter Kunde" initialisieren damit sie in Form abgeändert werden kann
        private int SelectedCu;

        private void CmdAddCustomer_Click(object sender, EventArgs e)
        {
            //erzeugt neuen Customer
            Model.Kunden.Add(new Customer(
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
                TxtCompanyName.Text,
                TxtCompanyAdress.Text,
                CmbCustomerType.Text
                ));

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
                CmbCustomerType.Text;

            Controller.WriteLog("CuErstellt");

            //leert Textboxen
            ClearForm();

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
                CmbCustomerType.Text;

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
                    CmbCustomerType.Text;

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
            CmbCustomerType.Text = "";


        }

      
    }


}
