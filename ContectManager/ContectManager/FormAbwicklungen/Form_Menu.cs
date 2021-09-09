using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContectManager
{
    public partial class Form_Menue : Form //Hauptformular bzw. das Menu
    {
        public Form_Menue()
        {
            InitializeComponent();
        }

      
        private void cmd_KundenMenue_Click(object sender, EventArgs e) // Öffnet das Formular "KundenMenue"
        {
            this.Hide();
            Form_KundeReg fkunde = new Form_KundeReg();
            fkunde.ShowDialog();
        }

        private void cmd_MitarbeiterMenue_Click(object sender, EventArgs e) // Öffnet das Formular "MitarbeiterMenue"
        {
            this.Hide();
            Form_MitarbeiterReg fMitarbeiter = new Form_MitarbeiterReg();
            fMitarbeiter.ShowDialog();
        }

        private void cmd_InformationenMenue_Click(object sender, EventArgs e) // Öffnet das Formular "Suche"
        {
            this.Hide();
            Form_Suche fSuche = new Form_Suche();
            fSuche.ShowDialog();
        }

        private void CmdLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login fLogin = new Form_Login();
            fLogin.ShowDialog();
        }

        private void cmd_DashboardMenue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Dashboard fDashboard = new Form_Dashboard();
            fDashboard.ShowDialog();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            //Applikation schliessen
            this.Close();
            Application.Exit();
        }
    }
}
