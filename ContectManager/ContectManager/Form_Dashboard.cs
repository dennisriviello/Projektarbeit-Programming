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
        }

        private void CmdMenue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Menue fMenue = new Form_Menue();
            fMenue.ShowDialog();
        }

        private void CmdOpenLogFile_Click(object sender, EventArgs e)
        {
            //Controller.OpenFileFromPath(Controller.LogFile, FileMode.Open);
            //System.Diagnostics.Process.Start(@"notepad.exe", Controller.LogFile);
            //Console.WriteLine(Controller.LogFile);
        }
    }
}
