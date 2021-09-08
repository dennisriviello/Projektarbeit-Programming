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
    
    class Model
    {

        //Liste(Array) Kunden erstellen - Objekte sind Customer
        public static List<Customer> Kunden = new List<Customer>();


        //Liste(Array) Mitarbeiter erstellen - Objekte sind Employees
        public static List<Employee> Mitarbeiter = new List<Employee>();

        //Liste(Array) Lehrlinge erstellen - Objekte sind Trainee
        public static List<Trainee> Lehrlinge = new List<Trainee>();

    }
}
