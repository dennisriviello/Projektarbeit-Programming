using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ContectManager
{
    [Serializable]
    public class Customer : Person
    {
        public string CompanyName { get; set; }
        public string CompanyAdress { get; set; }
        public string CustomerType { get; set; }

        public string CustomerNote { get; set; }

        public Customer(string salutation, string firstname, string lastname,
            DateTime birthday, string gender, string title, string telwork,
            string faxwork, string adress, string zipcode, string residence,
            string telprivate, string telmobile, string email, bool active,
            string companyname, string companyadress, string customertype, string customernote)

            : base(salutation, firstname, lastname, birthday, gender, title, telwork,
            faxwork, adress, zipcode, residence, telprivate, telmobile, email, active)
        {
            CompanyName = companyname;
            CompanyAdress = companyadress;
            CustomerType = customertype;
            CustomerNote = customernote;
        }

     

        public override string GetData()
        {
            return base.GetData() + ";" + CompanyName + ";" + CompanyAdress + ";" + CustomerType + ";" + CustomerNote;
        }

    }
}
