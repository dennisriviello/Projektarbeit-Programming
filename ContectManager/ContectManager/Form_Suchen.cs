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
           

                var Mitarbeiter = Model.Mitarbeiter;
                var Kunden = Model.Kunden;
            //var Lehrling = Model.Lehrling;

            if (RadEmployee.Checked)
                {
                LstOutput.Items.Clear();
                SetSelectedEmployee(CmbEmployee.Text, TxtEmployee.Text);
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

        public string SetSelectedEmployee(string cat, string value)
        {
            
                switch (cat)
                {

                    case "EmployeeID":
                        foreach (var mitarbeiter in Model.Mitarbeiter)
                        {
                            if (mitarbeiter.MitarbeiterID == Convert.ToInt32(value)) 
                            {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname + mitarbeiter.EntryDate + mitarbeiter.QuitDate);
                            }
                        }
                        break;


                case "Salutation":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.Salutation == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                        }
                    }
                    break;


                case "Firstname":
                        foreach (var mitarbeiter in Model.Mitarbeiter)
                        {
                            if (mitarbeiter.Firstname == value)
                            {
                                LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                            }
                        }
                    break;


                    case "Lastname":
                        foreach (var mitarbeiter in Model.Mitarbeiter)
                        {
                            if (mitarbeiter.Lastname == value)
                            {
                                LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                            }
                        }
                    break;



                case "Gender":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.Gender.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                        }
                    }
                    break;

                case "Title":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.Title.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                        }
                    }
                    break;

                case "Telwork":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.TelWork.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                        }
                    }
                    break;


                case "Faxwork":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.FaxWork.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                        }
                    }
                    break;



                case "Adress":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.Adress.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                        }
                    }
                    break;


                case "Zipcode":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.Zipcode.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                        }
                    }
                    break;

                case "Residence":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.Residence.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                        }
                    }
                    break;

                case "Telprivate":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.TelPrivate.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                        }
                    }
                    break;

                case "Telmobile":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.TelMobile.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                        }
                    }
                    break;


                case "Email":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.EMail.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                        }
                    }
                    break;

                case "Active":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.Active.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                        }
                    }
                    break;

                case "Department":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.Department.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                        }
                    }
                    break;


                case "Ahvnumber":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.AHVNumber.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                        }
                    }
                    break;



                case "Nationality":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.Nationality.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                        }
                    }
                    break;


                case "Employmentlevel":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.EmploymentLevel.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                        }
                    }
                    break;


                case "Role":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.Role.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                        }
                    }
                    break;

                case "Managementlevel":
                    foreach (var mitarbeiter in Model.Mitarbeiter)
                    {
                        if (mitarbeiter.ManagementLevel.ToString() == value)
                        {
                            LstOutput.Items.Add(mitarbeiter.MitarbeiterID + ": " + mitarbeiter.Firstname + " " + mitarbeiter.Lastname);
                        }
                    }
                    break;


                default:
                        Console.WriteLine("Nothing");
                        break;
                }

            return null;
        }


    }
}
