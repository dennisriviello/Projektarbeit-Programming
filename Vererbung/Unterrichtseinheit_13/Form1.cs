using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unterrichtseinheit_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            /*
            Person p1 = new Person("Max", "Muster");
            TxtOut.Text = p1 + "\r\n";


            Customer c1 = new Customer("Hans", "Nötig", 1000, "TechMed");
            TxtOut.Text += c1 + "\r\n";

            Employee e1 = new Employee("Peter", "Haanson", 100, new DateTime(1970, 3, 12));
            TxtOut.Text += e1 + "\r\n";

            Trainee t1 = new Trainee("Ueli", "Stift", 114, new DateTime(1998, 6, 30), 3, 1);
            TxtOut.Text += t1 + "\r\n";
            */

            List<Person> data = new List<Person>();
            data.Add(new Person("Max", "Muster"));
            data.Add(new Customer("Hans", "Nötig", 1000, "TechMed"));
            data.Add(new Employee("Peter", "Haanson", new DateTime(1970, 3, 12)));
            data.Add(new Trainee("Ueli", "Stift", new DateTime(1998, 6, 30), 3, 1));

            // Object o = new Trainee("Ueli", "Stift", 114, new DateTime(1998, 6, 30), 3, 1);


            TxtOut.Text = Employee.EmployeeCounter.ToString() +"\r\n";

            foreach (Person p in data)
            {
                TxtOut.Text += p.GetData() + "\r\n";
                if(p is Trainee)
                ((Trainee)p).IncreaseTraineeYear();
            }

        }
    }
}
