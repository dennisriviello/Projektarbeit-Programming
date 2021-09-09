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
    public partial class Form_Suche : Form
    {
        private string[] hinweis = { "Nur Zahlen zur Eingabe erlaubt", "Nur Buchstaben Erlaubt", "Zahlen und Buchstaben erlaubt", "True oder False eingeben" };
        public Form_Suche()
        {
            InitializeComponent();
            Controller.FirstUseCheck();
        }

        private void cmd_Menue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Menue fMenue = new Form_Menue();
            fMenue.ShowDialog();
        }

        private void CmdSuchen_Click(object sender, EventArgs e)
        {
            Filtern();
        }
        private void Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Filtern();
            }
        }

        private void Filtern()
        {
            try
            {
                if (TxtEmployee.Text != "" || TxtCustomer.Text != "" || TxtTrainee.Text != "")
                {
                    var Mitarbeiter = Model.Mitarbeiter;
                    var Kunden = Model.Kunden;
                    var Lernender = Model.Lehrlinge;
                    bool exist = false;

                    if (RadEmployee.Checked)
                    {
                        LstOutput.Items.Clear();
                        SetSelectedEmployee(CmbEmployee.Text, TxtEmployee.Text, exist);
                    }
                    else if (RadCustomer.Checked)
                    {
                        LstOutput.Items.Clear();
                        SetSelectedCustomer(CmbCustomer.Text, TxtCustomer.Text, exist);
                    }
                    else if (RadTrainee.Checked)
                    {
                        LstOutput.Items.Clear();
                        SetSelectedTrainee(CmbTrainee.Text, TxtTrainee.Text, exist);
                    }
                }
                else
                    MessageBox.Show("Bitte geben Sie etwas in das Suchfeld ein!", "Eingabe falsch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Kein gültiger Wert", "Eingabe falsch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void RadEmployee_CheckedChanged(object sender, EventArgs e)
        {
            CmbEmployee.SelectedIndex = 0;
            CmbCustomer.Visible = false;
            CmbTrainee.Visible = false;

            TxtCustomer.Visible = false;
            TxtTrainee.Visible = false;

            LblCustomer.Visible = false;
            LblTrainee.Visible = false;


            CmbEmployee.Visible = true;
            TxtEmployee.Visible = true;
            LblEmployee.Visible = true;
        }

        private void RadCustomer_CheckedChanged(object sender, EventArgs e)
        {
            CmbCustomer.SelectedIndex = 0;
            CmbTrainee.Visible = false;
            CmbEmployee.Visible = false;

            TxtTrainee.Visible = false;
            TxtEmployee.Visible = false;

            LblEmployee.Visible = false;
            LblTrainee.Visible = false;

            CmbCustomer.Visible = true;
            TxtCustomer.Visible = true;
            // LblCustomer.Visible = true;
        }

        private void RadTrainee_CheckedChanged(object sender, EventArgs e)
        {
            CmbTrainee.SelectedIndex = 0;
            CmbCustomer.Visible = false;
            CmbEmployee.Visible = false;

            TxtCustomer.Visible = false;
            TxtEmployee.Visible = false;

            LblEmployee.Visible = false;
            LblCustomer.Visible = false;

            CmbTrainee.Visible = true;
            TxtTrainee.Visible = true;
            // LblTrainee.Visible = true;
        }

        public string SetSelectedEmployee(string cat, string value, bool exist)
        {
            
                switch (cat)
                {

                    case "EmployeeID":
                        foreach (var mitarbeiter in Model.Mitarbeiter)
                        {
                            
                            if (mitarbeiter.MitarbeiterID == Convert.ToInt32(value)) 
                            {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname + mitarbeiter.EntryDate + mitarbeiter.QuitDate);
                            exist = true;
                            }  
                        }
                    if (exist == false)
                        MessageBox.Show("Kein Mitarbeiter gefunden");
                        break;


                case "Salutation":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.Salutation == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                            exist = true;
                        }

                    }
                    if (exist == false)
                        MessageBox.Show("Kein Mitarbeiter gefunden");
                    break;


                case "Firstname":
                        foreach (var mitarbeiter in Model.Mitarbeiter)
                        {
                            if (mitarbeiter.Firstname.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                            {
                                LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                                exist = true;
                            }
                        }
                    if (exist == false)
                        MessageBox.Show("Kein Mitarbeiter gefunden");
                    break;


                    case "Lastname":
                        foreach (var mitarbeiter in Model.Mitarbeiter)
                        {
                            if (mitarbeiter.Lastname.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                            {
                                LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                                exist = true;
                            }
                        }
                    if (exist == false)
                        MessageBox.Show("Kein Mitarbeiter gefunden");
                    break;



                case "Gender":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.Gender.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Mitarbeiter gefunden");
                    break;

                case "Title":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.Title.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Mitarbeiter gefunden");
                    break;

                case "Telwork":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.TelWork.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Mitarbeiter gefunden");
                    break;


                case "Faxwork":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.FaxWork.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Mitarbeiter gefunden");
                    break;



                case "Adress":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.Adress.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Mitarbeiter gefunden");
                    break;


                case "Zipcode":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.Zipcode.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Mitarbeiter gefunden");
                    break;

                case "Residence":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.Residence.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Mitarbeiter gefunden");
                    break;

                case "Telprivate":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.TelPrivate.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Mitarbeiter gefunden");
                    break;

                case "Telmobile":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.TelMobile.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Mitarbeiter gefunden");
                    break;


                case "Email":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.EMail.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Mitarbeiter gefunden");
                    break;

                case "Active":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.Active.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Mitarbeiter gefunden");
                    break;

                case "Department":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.Department.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Mitarbeiter gefunden");
                    break;


                case "Ahvnumber":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.AHVNumber.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Mitarbeiter gefunden");
                    break;



                case "Nationality":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.Nationality.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Mitarbeiter gefunden");
                    break;


                case "Employmentlevel":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.EmploymentLevel.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Mitarbeiter gefunden");
                    break;


                case "Role":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.Role.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Mitarbeiter gefunden");
                    break;

                case "Managementlevel":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.ManagementLevel.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Mitarbeiter gefunden");
                    break;

                default:
                        Console.WriteLine("Nothing");
                        break;
                }

            return null;
        }

        public string SetSelectedCustomer(string cat, string value, bool exist)
        {

            switch (cat)
            {
                case "Salutation":
                    foreach (var kunde in Model.Kunden)
                    {
                        if (kunde.Salutation.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(kunde.Firstname + " " + kunde.Lastname + ": " + kunde.CompanyName);
                            exist = true;
                        }
                        
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Kunde gefunden");
                    break;


                case "Firstname":
                    foreach (var kunde in Model.Kunden)
                    {
                        if (kunde.Firstname.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(kunde.Firstname + " " + kunde.Lastname + ": " + kunde.CompanyName);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Kunde gefunden");
                    break;


                case "Lastname":
                    foreach (var kunde in Model.Kunden)
                    {
                        if (kunde.Lastname.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(kunde.Firstname + " " + kunde.Lastname + ": " + kunde.CompanyName);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Kunde gefunden");
                    break;



                case "Gender":
                    foreach (var kunde in Model.Kunden)
                    {
                        if (kunde.Gender.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(kunde.Firstname + " " + kunde.Lastname + ": " + kunde.CompanyName);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Kunde gefunden");
                    break;

                case "Title":
                    foreach (var kunde in Model.Kunden)
                    {
                        if (kunde.Title.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(kunde.Firstname + " " + kunde.Lastname + ": " + kunde.CompanyName);
                            exist = true;
                        }
                    }
                    break;

                case "Telwork":
                    foreach (var kunde in Model.Kunden)
                    {
                        if (kunde.TelWork.ToString() == value)
                        {
                            LstOutput.Items.Add(kunde.Firstname + " " + kunde.Lastname + ": " + kunde.CompanyName);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Kunde gefunden");
                    break;


                case "Faxwork":
                    foreach (var kunde in Model.Kunden)
                    {
                        if (kunde.FaxWork.ToString() == value)
                        {
                            LstOutput.Items.Add(kunde.Firstname + " " + kunde.Lastname + ": " + kunde.CompanyName);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Kunde gefunden");
                    break;



                case "Adress":
                    foreach (var kunde in Model.Kunden)
                    {
                        if (kunde.Adress.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(kunde.Firstname + " " + kunde.Lastname + ": " + kunde.CompanyName);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Kunde gefunden");
                    break;


                case "Zipcode":
                    foreach (var kunde in Model.Kunden)
                    {
                        if (kunde.Zipcode.ToString() == value)
                        {
                            LstOutput.Items.Add(kunde.Firstname + " " + kunde.Lastname + ": " + kunde.CompanyName);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Kunde gefunden");
                    break;

                case "Residence":
                    foreach (var kunde in Model.Kunden)
                    {
                        if (kunde.Residence.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(kunde.Firstname + " " + kunde.Lastname + ": " + kunde.CompanyName);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Kunde gefunden");
                    break;

                case "Telprivate":
                    foreach (var kunde in Model.Kunden)
                    {
                        if (kunde.TelPrivate.ToString().Contains(value))
                        {
                            LstOutput.Items.Add(kunde.Firstname + " " + kunde.Lastname + ": " + kunde.CompanyName);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Kunde gefunden");
                    break;

                case "Telmobile":
                    foreach (var kunde in Model.Kunden)
                    {
                        if (kunde.TelMobile.ToString() == value)
                        {
                            LstOutput.Items.Add(kunde.Firstname + " " + kunde.Lastname + ": " + kunde.CompanyName);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Kunde gefunden");
                    break;


                case "Email":
                    foreach (var kunde in Model.Kunden)
                    {
                        if (kunde.EMail.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(kunde.Firstname + " " + kunde.Lastname + ": " + kunde.CompanyName);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Kunde gefunden");
                    break;

                case "Active":
                    foreach (var kunde in Model.Kunden)
                    {
                        if (kunde.Active.ToString() == value)
                        {
                            LstOutput.Items.Add(kunde.Firstname + " " + kunde.Lastname + ": " + kunde.CompanyName);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Kunde gefunden");
                    break;


                case "Companyname":
                    foreach (var kunde in Model.Kunden)
                    {
                        if (kunde.CompanyName.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(kunde.Firstname + " " + kunde.Lastname + ": " + kunde.CompanyName);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Kunde gefunden");
                    break;


                case "Companyadress":
                    foreach (var kunde in Model.Kunden)
                    {
                        if (kunde.CompanyAdress.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(kunde.Firstname + " " + kunde.Lastname + ": " + kunde.CompanyName);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Kunde gefunden");
                    break;

                case "Customertype":
                    foreach (var kunde in Model.Kunden)
                    {
                        if (kunde.CustomerType.ToString() == value)
                        {
                            LstOutput.Items.Add(kunde.Firstname + " " + kunde.Lastname + ": " + kunde.CompanyName);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Kunde gefunden");
                    break;


                default:
                    Console.WriteLine("Nothing");
                    break;
            }

            return null;
        }

        public string SetSelectedTrainee(string cat, string value, bool exist)
        {
            switch (cat)
            {

                case "EmployeeID":
                    foreach (var lehrling in Model.Lehrlinge)
                    {
                        if (lehrling.MitarbeiterID == Convert.ToInt32(value))
                        {
                            LstOutput.Items.Add(lehrling.MitarbeiterID + ": " + lehrling.Firstname + " " + lehrling.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Lehrling gefunden");
                    break;


                case "Salutation":
                    foreach (var lehrling in Model.Lehrlinge)
                    {
                        if (lehrling.Salutation.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(lehrling.MitarbeiterID + ": " + lehrling.Firstname + " " + lehrling.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Lehrling gefunden");
                    break;


                case "Firstname":
                    foreach (var lehrling in Model.Lehrlinge)
                    {
                        if (lehrling.Firstname.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(lehrling.MitarbeiterID + ": " + lehrling.Firstname + " " + lehrling.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Lehrling gefunden");
                    break;


                case "Lastname":
                    foreach (var lehrling in Model.Lehrlinge)
                    {
                        if (lehrling.Lastname.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(lehrling.MitarbeiterID + ": " + lehrling.Firstname + " " + lehrling.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Lehrling gefunden");
                    break;



                case "Gender":
                    foreach (var lehrling in Model.Lehrlinge)
                    {
                        if (lehrling.Gender.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(lehrling.MitarbeiterID + ": " + lehrling.Firstname + " " + lehrling.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Lehrling gefunden");
                    break;

                case "Title":
                    foreach (var lehrling in Model.Lehrlinge)
                    {
                        if (lehrling.Title.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(lehrling.MitarbeiterID + ": " + lehrling.Firstname + " " + lehrling.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Lehrling gefunden");
                    break;

                case "Telwork":
                    foreach (var lehrling in Model.Lehrlinge)
                    {
                        if (lehrling.TelWork.ToString() == value)
                        {
                            LstOutput.Items.Add(lehrling.MitarbeiterID + ": " + lehrling.Firstname + " " + lehrling.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Lehrling gefunden");
                    break;


                case "Faxwork":
                    foreach (var lehrling in Model.Lehrlinge)
                    {
                        if (lehrling.FaxWork.ToString() == value)
                        {
                            LstOutput.Items.Add(lehrling.MitarbeiterID + ": " + lehrling.Firstname + " " + lehrling.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Lehrling gefunden");
                    break;



                case "Adress":
                    foreach (var lehrling in Model.Lehrlinge)
                    {
                        if (lehrling.Adress.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(lehrling.MitarbeiterID + ": " + lehrling.Firstname + " " + lehrling.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Lehrling gefunden");
                    break;


                case "Zipcode":
                    foreach (var lehrling in Model.Lehrlinge)
                    {
                        if (lehrling.Zipcode.ToString() == value)
                        {
                            LstOutput.Items.Add(lehrling.MitarbeiterID + ": " + lehrling.Firstname + " " + lehrling.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Lehrling gefunden");
                    break;

                case "Residence":
                    foreach (var lehrling in Model.Lehrlinge)
                    {
                        if (lehrling.Residence.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(lehrling.MitarbeiterID + ": " + lehrling.Firstname + " " + lehrling.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Lehrling gefunden");
                    break;

                case "Telprivate":
                    foreach (var lehrling in Model.Lehrlinge)
                    {
                        if (lehrling.TelPrivate.ToString() == value)
                        {
                            LstOutput.Items.Add(lehrling.MitarbeiterID + ": " + lehrling.Firstname + " " + lehrling.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Lehrling gefunden");
                    break;

                case "Telmobile":
                    foreach (var lehrling in Model.Lehrlinge)
                    {
                        if (lehrling.TelMobile.ToString() == value)
                        {
                            LstOutput.Items.Add(lehrling.MitarbeiterID + ": " + lehrling.Firstname + " " + lehrling.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Lehrling gefunden");
                    break;


                case "Email":
                    foreach (var lehrling in Model.Lehrlinge)
                    {
                        if (lehrling.EMail.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(lehrling.MitarbeiterID + ": " + lehrling.Firstname + " " + lehrling.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Lehrling gefunden");
                    break;

                case "Active":
                    foreach (var lehrling in Model.Lehrlinge)
                    {
                        if (lehrling.Active.ToString() == value)
                        {
                            LstOutput.Items.Add(lehrling.MitarbeiterID + ": " + lehrling.Firstname + " " + lehrling.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Lehrling gefunden");
                    break;

                case "Department":
                    foreach (var lehrling in Model.Lehrlinge)
                    {
                        if (lehrling.Department.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(lehrling.MitarbeiterID + ": " + lehrling.Firstname + " " + lehrling.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Lehrling gefunden");
                    break;


                case "Ahvnumber":
                    foreach (var lehrling in Model.Lehrlinge)
                    {
                        if (lehrling.AHVNumber.ToString() == value)
                        {
                            LstOutput.Items.Add(lehrling.MitarbeiterID + ": " + lehrling.Firstname + " " + lehrling.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Lehrling gefunden");
                    break;



                case "Nationality":
                    foreach (var lehrling in Model.Lehrlinge)
                    {
                        if (lehrling.Nationality.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(lehrling.MitarbeiterID + ": " + lehrling.Firstname + " " + lehrling.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Lehrling gefunden");
                    break;


                case "Employmentlevel":
                    foreach (var lehrling in Model.Lehrlinge)
                    {
                        if (lehrling.EmploymentLevel.ToString() == value)
                        {
                            LstOutput.Items.Add(lehrling.MitarbeiterID + ": " + lehrling.Firstname + " " + lehrling.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Lehrling gefunden");
                    break;


                case "Role":
                    foreach (var lehrling in Model.Lehrlinge)
                    {
                        if (lehrling.Role.Equals(value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            LstOutput.Items.Add(lehrling.MitarbeiterID + ": " + lehrling.Firstname + " " + lehrling.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Lehrling gefunden");
                    break;

                case "Managementlevel":
                    foreach (var lehrling in Model.Lehrlinge)
                    {
                        if (lehrling.ManagementLevel.ToString() == value)
                        {
                            LstOutput.Items.Add(lehrling.MitarbeiterID + ": " + lehrling.Firstname + " " + lehrling.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Lehrling gefunden");
                    break;

                case "Apprenticeshipyears":
                    foreach (var lehrling in Model.Lehrlinge)
                    {
                        if (lehrling.Role.ToString() == value)
                        {
                            LstOutput.Items.Add(lehrling.MitarbeiterID + ": " + lehrling.Firstname + " " + lehrling.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Lehrling gefunden");
                    break;

                case "Currentyear":
                    foreach (var lehrling in Model.Lehrlinge)
                    {
                        if (lehrling.ManagementLevel.ToString() == value)
                        {
                            LstOutput.Items.Add(lehrling.MitarbeiterID + ": " + lehrling.Firstname + " " + lehrling.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Lehrling gefunden");
                    break;
              

                default:
                    Console.WriteLine("Nothing");
                    break;
            }
            return null;
        }

        
        private void CmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if      (CmbEmployee.SelectedIndex == 0)
                LblEmployee.Text = hinweis[0];
            else if (CmbEmployee.SelectedIndex == 1)
                LblEmployee.Text = hinweis[1];
            else if (CmbEmployee.SelectedIndex == 2)
                LblEmployee.Text = hinweis[1];
            else if (CmbEmployee.SelectedIndex == 3)
                LblEmployee.Text = hinweis[1];
            else if (CmbEmployee.SelectedIndex == 4)
                LblEmployee.Text = hinweis[1];
            else if (CmbEmployee.SelectedIndex == 5)
                LblEmployee.Text = hinweis[1];
            else if (CmbEmployee.SelectedIndex == 6)
                LblEmployee.Text = hinweis[0];
            else if (CmbEmployee.SelectedIndex == 7)
                LblEmployee.Text = hinweis[0];
            else if (CmbEmployee.SelectedIndex == 8)
                LblEmployee.Text = hinweis[2];
            else if (CmbEmployee.SelectedIndex == 9)
                LblEmployee.Text = hinweis[0];
            else if (CmbEmployee.SelectedIndex == 10)
                LblEmployee.Text = hinweis[1];
            else if (CmbEmployee.SelectedIndex == 11)
                LblEmployee.Text = hinweis[0];
            else if (CmbEmployee.SelectedIndex == 12)
                LblEmployee.Text = hinweis[0];
            else if (CmbEmployee.SelectedIndex == 13)
                LblEmployee.Text = hinweis[2];
            else if (CmbEmployee.SelectedIndex == 14)
                LblEmployee.Text = hinweis[3];
            else if (CmbEmployee.SelectedIndex == 15)
                LblEmployee.Text = hinweis[0];
            else if (CmbEmployee.SelectedIndex == 16)
                LblEmployee.Text =  "Zahlen und Punkte erlaubt";
            else if (CmbEmployee.SelectedIndex == 17)
                LblEmployee.Text = hinweis[0];
            else if (CmbEmployee.SelectedIndex == 18)
                LblEmployee.Text = hinweis[0];
            else if (CmbEmployee.SelectedIndex == 19)
                LblEmployee.Text = hinweis[1];
            else if (CmbEmployee.SelectedIndex == 20)
                LblEmployee.Text = hinweis[0];
        }

        private void CmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CmbCustomer.SelectedIndex == 13)
            {
                LblCustomer.Text = "'True' oder 'False' eingeben";
                LblCustomer.Visible = true;
            }
            else
                LblCustomer.Visible = false;

        }

        private void CmbTrainee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbTrainee.SelectedIndex == 14)
            {
                LblTrainee.Text = "'True' oder 'False' eingeben";
                LblTrainee.Visible = true;
            }
            else
                LblTrainee.Visible = false;
        }
    }
}
