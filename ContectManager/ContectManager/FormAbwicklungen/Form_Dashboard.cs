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
    public partial class Form_Dashboard : Form
    {
        public Form_Dashboard()
        {
            InitializeComponent();

            //FirstUseCheck -> Lädt Listen und Variabeln
            Controller.FirstUseCheck();

            //Daten in Lbl herauslesen
            LoadDataDashboard();
        }


        private void LoadDataDashboard()
        {
            ImportCostumer();
            ImportEmployee();
            ImportTrainee(); 
        }


        private void ImportCostumer()
        {
            int CounterActiv = 0;
            int CounterInactiv = 0;

            foreach (var kunde in Model.Kunden)
            {
                if (kunde.Active == true)
                {
                    CounterActiv++;
                }
                if (kunde.Active == false)
                {
                    CounterInactiv++;
                }
            }


            LblKundenAktiv.Text = CounterActiv.ToString();
            LblKundenInaktiv.Text = CounterInactiv.ToString();

            int Total = 0;
            Total = CounterActiv + CounterInactiv;
            LblKundenTotal.Text = Total.ToString();
        }

        private void ImportEmployee()
        {
            int CounterActiv = 0;
            int CounterInactiv = 0;

            foreach (var mitarbeiter in Model.Mitarbeiter)
            {
                if (mitarbeiter.Active == true)
                {
                    CounterActiv++;
                }
                if (mitarbeiter.Active == false)
                {
                    CounterInactiv++;
                }
            }


            LblMitarbeiterAktiv.Text = CounterActiv.ToString();
            LblMitarbeiterInaktiv.Text = CounterInactiv.ToString();

            int Total = 0;
            Total = CounterActiv + CounterInactiv;
            LblMitarbeiterTotal.Text = Total.ToString();
        }


        private void ImportTrainee()
        {
            int CounterActiv = 0;
            int CounterInactiv = 0;

            foreach (var lehrling in Model.Lehrlinge)
            {
                if (lehrling.Active == true)
                {
                    CounterActiv++;
                }
                if (lehrling.Active == false)
                {
                    CounterInactiv++;
                }
            }


            LblLehrlingAktiv.Text = CounterActiv.ToString();
            LblLehrlingInaktiv.Text = CounterInactiv.ToString();

            int Total = 0;
            Total = CounterActiv + CounterInactiv;
            LblLehrlingTotal.Text = Total.ToString();
        }
        
        private void CmdMenue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Menue fMenue = new Form_Menue();
            fMenue.ShowDialog();
        }

        private void CmdOpenLogFile_Click(object sender, EventArgs e)
        {
            // öffnet das Logfile im Standart-Texteditor
            System.Diagnostics.Process.Start(Controller.LogFile);
        }
    }
}
