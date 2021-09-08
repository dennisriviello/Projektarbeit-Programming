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

namespace ContectManager
{
    public partial class Form_Suche : Form
    {
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
        {   try
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
                    MessageBox.Show("Bitte geben Sie etwas in das Suchfeld ein!", "Eingabe falsch",MessageBoxButtons.OK ,MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Kein gültiger Wert");
            }



        }

        private void RadCustomer_CheckedChanged(object sender, EventArgs e)
        {
            CmbTrainee.Visible = false;
            CmbEmployee.Visible = false;

            TxtTrainee.Visible = false;
            TxtEmployee.Visible = false;

            CmbCustomer.Visible = true;
            TxtCustomer.Visible = true;
        }

        private void RadEmployee_CheckedChanged(object sender, EventArgs e)
        {
            CmbCustomer.Visible = false;
            CmbTrainee.Visible = false;

            TxtCustomer.Visible = false;
            TxtTrainee.Visible = false;


            CmbEmployee.Visible = true;
            TxtEmployee.Visible = true;
        }

        private void RadTrainee_CheckedChanged(object sender, EventArgs e)
        {
            CmbCustomer.Visible = false;
            CmbEmployee.Visible = false;

            TxtCustomer.Visible = false;
            TxtEmployee.Visible = false;

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

    }
}
