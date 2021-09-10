using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization.Formatters.Soap;

namespace ContectManager
{
    [Serializable]

    public class Employee : Person
    {
        public int MitarbeiterID { get; set; }
        public string Department { get; set; }
        public string AHVNumber { get; set; }
        public string Nationality { get; set; }

        public DateTime EntryDate { get; set; }
        public DateTime QuitDate { get; set; }
        public string EmploymentLevel { get; set; }
        public string Role { get; set; }

        public int ManagementLevel { get; set; }

        public Employee(string salutation, string firstname, string lastname,
            DateTime birthday, string gender, string title, string telwork,
            string faxwork, string adress, string zipcode, string residence,
            string telprivate, string telmobile, string email, bool active,
            int mitarbeiterID, string department, string ahvnumber, string nationality,
            DateTime entrydate, DateTime quitdate, string employmentlevel, string role,
            int managementlevel)

            : base(salutation, firstname, lastname, birthday, gender, title, telwork,
            faxwork, adress, zipcode, residence, telprivate, telmobile, email, active)

        {
            MitarbeiterID = mitarbeiterID;
            Department = department;
            AHVNumber = ahvnumber;
            Nationality = nationality;
            EntryDate = entrydate;
            QuitDate = quitdate;
            EmploymentLevel = employmentlevel;
            Role = role;
            ManagementLevel = managementlevel;
        


        }

  
        public override string GetData()
        {
            return MitarbeiterID + ":" + Department +base.GetData();
        }


    }
}
