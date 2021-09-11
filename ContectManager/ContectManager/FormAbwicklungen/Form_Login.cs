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

namespace ContectManager
{
    public partial class Form_Login : Form
    {

        //Variablen Definition
        private string LoginFile;

        public void LoginCheck()
        {
            // Listen für Benutzernamen und Passwörter erstellen (für mehrere User-Logins
            List<string> users = new List<string>();
            List<string> pass = new List<string>();

            //Absoluten Pfad festlegen
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\login\");
            string sFilePath = Path.GetFullPath(sFile);

            //setzt Variabeln für den Pfad der Login Datei, String definieren
            LoginFile = sFilePath + "logindata.txt";
            string LoginString;

            // StreamReader für LoginData File (Benutzer muss existieren in diesem File)
            StreamReader reader = new StreamReader(LoginFile);
            LoginString = "";
            while((LoginString = reader.ReadLine()) != null)
            {
                //String Splitten in Username und Password, entferne leere Einträge
                string[] components = LoginString.Split(";".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
                users.Add(components[0]);
                pass.Add(components[1]);
            }
                reader.Close();

            // Benutzername und Passwort überprüfen auf Vollständigkeit und Übereinstimmung
            if (users.Contains(TxtUsername.Text) && pass.Contains(TxtPassword.Text) && 
                Array.IndexOf(users.ToArray(), TxtUsername.Text) == Array.IndexOf(pass.ToArray(), TxtPassword.Text))
            {
                this.Hide();
                Form_Menue fMenu = new Form_Menue();
                fMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Benutzername oder Kennwort ist falsch. \r\nBitte versuchen Sie es erneut.",
                        "Ungültiger Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public Form_Login()
        {
            InitializeComponent();
        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {
            LoginCheck();
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            //Applikation schliessen
            this.Close();
            Application.Exit();
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoginCheck();
        }
    }
}
