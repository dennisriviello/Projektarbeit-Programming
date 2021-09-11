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
        private string[] hinweis = { "Nur Zahlen zur Eingabe erlaubt", "Nur Buchstaben erlaubt", "Zahlen und Buchstaben erlaubt", "' true ' oder ' false ' eingeben" };
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
            if (TxtEmployee.Text != "" || TxtCustomer.Text != "" || TxtTrainee.Text != "")
            {

                var Mitarbeiter = Model.Mitarbeiter;
                var Kunden = Model.Kunden;
                var Lernender = Model.Lehrlinge;
                bool exist = false;

                if (RadEmployee.Checked)
                {
                    if (CmbEmployee.SelectedIndex == 0 || CmbEmployee.SelectedIndex == 6 || CmbEmployee.SelectedIndex == 7 || CmbEmployee.SelectedIndex == 9 || CmbEmployee.SelectedIndex == 11 ||
                    CmbEmployee.SelectedIndex == 12 || CmbEmployee.SelectedIndex == 18 || CmbEmployee.SelectedIndex == 20)
                    {
                        if (Controller.CheckInt(TxtEmployee.Text, TxtEmployee) == true)
                        {
                            MessageBox.Show("'" + TxtEmployee.Text + "' Ist kein gültiger Wert", "Falsche Eingabe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LblEmployee.Visible = true;
                        }
                            
                        else
                        {
                            LblEmployee.Visible = false;
                            LstOutput.Items.Clear();
                            SetSelectedEmployee(CmbEmployee.Text, TxtEmployee.Text, exist);
                        }
                    }
                    else if (CmbEmployee.SelectedIndex == 1 || CmbEmployee.SelectedIndex == 2 || CmbEmployee.SelectedIndex == 3 || CmbEmployee.SelectedIndex == 4 || CmbEmployee.SelectedIndex == 5 ||
                               CmbEmployee.SelectedIndex == 10 || CmbEmployee.SelectedIndex == 15 || CmbEmployee.SelectedIndex == 17 || CmbEmployee.SelectedIndex == 19)
                    {
                        if (Controller.CheckString(TxtEmployee.Text, TxtEmployee) == true)
                        {
                            LblEmployee.Visible = true;
                            MessageBox.Show("'" + TxtEmployee.Text + "' Ist kein gültiger Wert", "Falsche Eingabe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                            
                        else
                        {
                            LblEmployee.Visible = false;
                            LstOutput.Items.Clear();
                            SetSelectedEmployee(CmbEmployee.Text, TxtEmployee.Text, exist);
                        }
                    }
                    else
                    {
                        LblEmployee.Visible = false;
                        LstOutput.Items.Clear();
                        SetSelectedEmployee(CmbEmployee.Text, TxtEmployee.Text, exist);
                    }
                }

                else if (RadCustomer.Checked)
                {
                    if (CmbCustomer.SelectedIndex == 5 || CmbCustomer.SelectedIndex == 6 || CmbCustomer.SelectedIndex == 8 || CmbCustomer.SelectedIndex == 10 || CmbCustomer.SelectedIndex == 11)
                    {
                        if (Controller.CheckInt(TxtCustomer.Text, TxtCustomer) == true)
                        {
                            MessageBox.Show("'" + TxtCustomer.Text + "' Ist kein gültiger Wert", "Falsche Eingabe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LblCustomer.Visible = true;
                        }
                            
                        else
                        {
                            LblCustomer.Visible = false;
                            LstOutput.Items.Clear();
                            SetSelectedCustomer(CmbCustomer.Text, TxtCustomer.Text, exist);
                        }
                    }
                    else if (CmbCustomer.SelectedIndex == 0 || CmbCustomer.SelectedIndex == 1 || CmbCustomer.SelectedIndex == 2 || CmbCustomer.SelectedIndex == 3 || CmbCustomer.SelectedIndex == 4 ||
                            CmbCustomer.SelectedIndex == 9 || CmbCustomer.SelectedIndex == 14 || CmbCustomer.SelectedIndex == 16)
                    {
                        if (Controller.CheckString(TxtCustomer.Text, TxtCustomer) == true)
                        {
                            LblCustomer.Visible = true;
                            MessageBox.Show("'" + TxtCustomer.Text + "' Ist kein gültiger Wert", "Falsche Eingabe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                            
                        else
                        {
                            LblCustomer.Visible = false;
                            LstOutput.Items.Clear();
                            SetSelectedCustomer(CmbCustomer.Text, TxtCustomer.Text, exist);
                        }
                    }
                    else
                    {
                        LblCustomer.Visible = false;
                        LstOutput.Items.Clear();
                        SetSelectedCustomer(CmbCustomer.Text, TxtCustomer.Text, exist);
                    }

                }
                else if (RadTrainee.Checked)
                {
                    if (CmbTrainee.SelectedIndex == 0 || CmbTrainee.SelectedIndex == 6 || CmbTrainee.SelectedIndex == 7 || CmbTrainee.SelectedIndex == 9 || CmbTrainee.SelectedIndex == 11 ||
                    CmbTrainee.SelectedIndex == 12 || CmbTrainee.SelectedIndex == 18 || CmbTrainee.SelectedIndex == 20 || CmbTrainee.SelectedIndex == 21)
                    {
                        if (Controller.CheckInt(TxtTrainee.Text, TxtTrainee) == true)
                        {
                            LblTrainee.Visible = true;
                            MessageBox.Show("'" + TxtTrainee.Text + "' Ist kein gültiger Wert", "Falsche Eingabe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                            
                        else
                        {
                            LblTrainee.Visible = false;
                            LstOutput.Items.Clear();
                            SetSelectedTrainee(CmbTrainee.Text, TxtTrainee.Text, exist);
                        }
                    }
                    else if (CmbTrainee.SelectedIndex == 1 || CmbTrainee.SelectedIndex == 2 || CmbTrainee.SelectedIndex == 3 || CmbTrainee.SelectedIndex == 4 || CmbTrainee.SelectedIndex == 5 ||
                            CmbTrainee.SelectedIndex == 10 || CmbTrainee.SelectedIndex == 15 || CmbTrainee.SelectedIndex == 17 || CmbTrainee.SelectedIndex == 19)
                    {
                        if (Controller.CheckString(TxtTrainee.Text, TxtTrainee) == true)
                        {
                            LblTrainee.Visible = true;
                            MessageBox.Show("'" + TxtTrainee.Text + "' Ist kein gültiger Wert", "Falsche Eingabe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                            
                        else
                        {
                            LblTrainee.Visible = false;
                            LstOutput.Items.Clear();
                            SetSelectedEmployee(CmbTrainee.Text, TxtTrainee.Text, exist);
                        }

                    }
                    else
                    {
                        LblTrainee.Visible = false;
                        LstOutput.Items.Clear();
                        SetSelectedEmployee(CmbTrainee.Text, TxtTrainee.Text, exist);
                    }


                }
            }
            else
                MessageBox.Show("Bitte geben Sie etwas in das Suchfeld ein!", "Eingabe falsch", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        private void RadEmployee_CheckedChanged(object sender, EventArgs e)
        {
            TxtEmployee.Text = "";
            CmbEmployee.SelectedIndex = 0;
            CmbCustomer.Visible = false;
            CmbTrainee.Visible = false;

            TxtCustomer.Visible = false;
            TxtTrainee.Visible = false;

            LblCustomer.Visible = false;
            LblTrainee.Visible = false;


            CmbEmployee.Visible = true;
            TxtEmployee.Visible = true;
            
        }

        private void RadCustomer_CheckedChanged(object sender, EventArgs e)
        {
            TxtCustomer.Text = "";
            CmbCustomer.SelectedIndex = 0;
            CmbTrainee.Visible = false;
            CmbEmployee.Visible = false;

            TxtTrainee.Visible = false;
            TxtEmployee.Visible = false;

            LblEmployee.Visible = false;
            LblTrainee.Visible = false;

            CmbCustomer.Visible = true;
            TxtCustomer.Visible = true;
            
        }

        private void RadTrainee_CheckedChanged(object sender, EventArgs e)
        {
            TxtTrainee.Text = "";
            CmbTrainee.SelectedIndex = 0;
            CmbCustomer.Visible = false;
            CmbEmployee.Visible = false;

            TxtCustomer.Visible = false;
            TxtEmployee.Visible = false;

            LblEmployee.Visible = false;
            LblCustomer.Visible = false;

            CmbTrainee.Visible = true;
            TxtTrainee.Visible = true;
            
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
                        MessageBox.Show("Kein Mitarbeiter mit '" + TxtEmployee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Mitarbeiter mit '" + TxtEmployee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Mitarbeiter mit '" + TxtEmployee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Mitarbeiter '" + TxtEmployee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Mitarbeiter mit '" + TxtEmployee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Mitarbeiter mit '" + TxtEmployee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Mitarbeiter mit '" + TxtEmployee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Mitarbeiter mit '" + TxtEmployee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Mitarbeiter mit '" + TxtEmployee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Mitarbeiter mit '" + TxtEmployee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Mitarbeiter mit '" + TxtEmployee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Mitarbeiter mit '" + TxtEmployee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Mitarbeiter mit '" + TxtEmployee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Mitarbeiter mit '" + TxtEmployee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case "Active":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.Active.ToString().ToLower() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Mitarbeiter mit '" + TxtEmployee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Mitarbeiter mit '" + TxtEmployee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Mitarbeiter mit '" + TxtEmployee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Mitarbeiter mit '" + TxtEmployee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Mitarbeiter mit '" + TxtEmployee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Mitarbeiter mit '" + TxtEmployee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Mitarbeiter mit '" + TxtEmployee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Kunde mit '" + TxtCustomer.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Kunde mit '" + TxtCustomer.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Kunde mit '" + TxtCustomer.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Kunde mit '" + TxtCustomer.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    if (exist == false)
                        MessageBox.Show("Kein Kunde mit '" + TxtCustomer.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Kunde mit '" + TxtCustomer.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Kunde mit '" + TxtCustomer.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Kunde mit '" + TxtCustomer.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Kunde mit '" + TxtCustomer.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Kunde mit '" + TxtCustomer.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Kunde mit '" + TxtCustomer.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Kunde mit '" + TxtCustomer.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Kunde mit '" + TxtCustomer.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case "Active":
                    foreach (var kunde in Model.Kunden)
                    {
                        if (kunde.Active.ToString().ToLower() == value)
                        {
                            LstOutput.Items.Add(kunde.Firstname + " " + kunde.Lastname + ": " + kunde.CompanyName);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Kunde mit '" + TxtCustomer.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Kunde mit '" + TxtCustomer.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Kunde mit '" + TxtCustomer.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Kunde mit '" + TxtCustomer.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Lehrling mit '" + TxtTrainee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Lehrling mit '" + TxtTrainee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Lehrling mit '" + TxtTrainee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Lehrling mit '" + TxtTrainee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Lehrling mit '" + TxtTrainee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Lehrling mit '" + TxtTrainee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Lehrling mit '" + TxtTrainee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Lehrling mit '" + TxtTrainee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Lehrling mit '" + TxtTrainee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Lehrling mit '" + TxtTrainee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Lehrling mit '" + TxtTrainee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Lehrling mit '" + TxtTrainee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Lehrling mit '" + TxtTrainee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Lehrling mit '" + TxtTrainee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case "Active":
                    foreach (var lehrling in Model.Lehrlinge)
                    {
                        if (lehrling.Active.ToString().ToLower() == value)
                        {
                            LstOutput.Items.Add(lehrling.MitarbeiterID + ": " + lehrling.Firstname + " " + lehrling.Lastname);
                            exist = true;
                        }
                    }
                    if (exist == false)
                        MessageBox.Show("Kein Lehrling mit '" + TxtTrainee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Lehrling mit '" + TxtTrainee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Lehrling mit '" + TxtTrainee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Lehrling mit '" + TxtTrainee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Lehrling mit '" + TxtTrainee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Lehrling mit '" + TxtTrainee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Lehrling mit '" + TxtTrainee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Lehrling mit '" + TxtTrainee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Kein Lehrling mit '" + TxtTrainee.Text + "' gefunden!", "Nicht in der Datenbank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;


                default:
                    Console.WriteLine("Nothing");
                    break;
            }
            return null;
        }


        private void CmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbEmployee.SelectedIndex == 0)
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
                LblEmployee.Text = "Zahlen und Punkte erlaubt";
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

            if (CmbCustomer.SelectedIndex == 0)
                LblCustomer.Text = hinweis[1];
            else if (CmbCustomer.SelectedIndex == 1)
                LblCustomer.Text = hinweis[1];
            else if (CmbCustomer.SelectedIndex == 2)
                LblCustomer.Text = hinweis[1];
            else if (CmbCustomer.SelectedIndex == 3)
                LblCustomer.Text = hinweis[1];
            else if (CmbCustomer.SelectedIndex == 4)
                LblCustomer.Text = hinweis[1];
            else if (CmbCustomer.SelectedIndex == 5)
                LblCustomer.Text = hinweis[0];
            else if (CmbCustomer.SelectedIndex == 6)
                LblCustomer.Text = hinweis[0];
            else if (CmbCustomer.SelectedIndex == 7)
                LblCustomer.Text = hinweis[2];
            else if (CmbCustomer.SelectedIndex == 8)
                LblCustomer.Text = hinweis[0];
            else if (CmbCustomer.SelectedIndex == 9)
                LblCustomer.Text = hinweis[1];
            else if (CmbCustomer.SelectedIndex == 10)
                LblCustomer.Text = hinweis[0];
            else if (CmbCustomer.SelectedIndex == 11)
                LblCustomer.Text = hinweis[0];
            else if (CmbCustomer.SelectedIndex == 12)
                LblCustomer.Text = hinweis[2];
            else if (CmbCustomer.SelectedIndex == 13)
                LblCustomer.Text = hinweis[3];
            else if (CmbCustomer.SelectedIndex == 14)
                LblCustomer.Text = hinweis[1];
            else if (CmbCustomer.SelectedIndex == 15)
                LblCustomer.Text = hinweis[2];
            else if (CmbCustomer.SelectedIndex == 16)
                LblCustomer.Text = " ' A ' - ' E ' zur Eingabe erlaubt ";



        }

        private void CmbTrainee_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (CmbTrainee.SelectedIndex == 0)
                LblTrainee.Text = hinweis[0];
            else if (CmbTrainee.SelectedIndex == 1)
                LblTrainee.Text = hinweis[1];
            else if (CmbTrainee.SelectedIndex == 2)
                LblTrainee.Text = hinweis[1];
            else if (CmbTrainee.SelectedIndex == 3)
                LblTrainee.Text = hinweis[1];
            else if (CmbTrainee.SelectedIndex == 4)
                LblTrainee.Text = hinweis[1];
            else if (CmbTrainee.SelectedIndex == 5)
                LblTrainee.Text = hinweis[1];
            else if (CmbTrainee.SelectedIndex == 6)
                LblTrainee.Text = hinweis[0];
            else if (CmbTrainee.SelectedIndex == 7)
                LblTrainee.Text = hinweis[0];
            else if (CmbTrainee.SelectedIndex == 8)
                LblTrainee.Text = hinweis[2];
            else if (CmbTrainee.SelectedIndex == 9)
                LblTrainee.Text = hinweis[0];
            else if (CmbTrainee.SelectedIndex == 10)
                LblTrainee.Text = hinweis[1];
            else if (CmbTrainee.SelectedIndex == 11)
                LblTrainee.Text = hinweis[0];
            else if (CmbTrainee.SelectedIndex == 12)
                LblTrainee.Text = hinweis[0];
            else if (CmbTrainee.SelectedIndex == 13)
                LblTrainee.Text = hinweis[2];
            else if (CmbTrainee.SelectedIndex == 14)
                LblTrainee.Text = hinweis[3];
            else if (CmbTrainee.SelectedIndex == 15)
                LblTrainee.Text = hinweis[1];
            else if (CmbTrainee.SelectedIndex == 16)
                LblTrainee.Text = "Zahlen und Punkte erlaubt";
            else if (CmbTrainee.SelectedIndex == 17)
                LblTrainee.Text = hinweis[1];
            else if (CmbEmployee.SelectedIndex == 18)
                LblTrainee.Text = hinweis[0];
            else if (CmbTrainee.SelectedIndex == 19)
                LblTrainee.Text = hinweis[1];
            else if (CmbTrainee.SelectedIndex == 20)
                LblTrainee.Text = hinweis[0];
            else if (CmbTrainee.SelectedIndex == 21)
                LblTrainee.Text = hinweis[0];
            else if (CmbTrainee.SelectedIndex == 22)
                LblTrainee.Text = hinweis[0];
        }


    }
}
