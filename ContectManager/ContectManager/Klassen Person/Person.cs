using System;


namespace ContectManager
{
    [Serializable]
    public class Person
    {
        public string Salutation { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public DateTime Birthday { get; set; }

        public string Gender { get; set; }

        public string Title { get; set; }

        public string TelWork { get; set; }
        public string FaxWork { get; set; }
        public string Adress { get; set; }
        public string Zipcode { get; set; }
        public string Residence { get; set; }
        public string TelPrivate { get; set; }

        public string TelMobile { get; set; }
        public string EMail { get; set; }
        public bool Active { get; set; }


        

        public Person(string salutation, string firstname, string lastname, 
            DateTime birthday, string gender, string title, string telwork, 
            string faxwork, string adress, string zipcode, string residence, 
            string telprivate, string telmobile, string email, bool active)
        {
            Salutation = salutation;
            Firstname = firstname;
            Lastname = lastname;
            Birthday = birthday;
            Gender = gender;
            Title = title;
            TelWork = telwork;
            FaxWork = faxwork;
            Adress = adress;
            Zipcode = zipcode;
            Residence = residence;
            TelPrivate = telprivate;
            TelMobile = telmobile;
            EMail = email;
            Active = active;
        }

        public virtual string GetData()
        {
            return 
                Salutation + " " + 
                Firstname + " " + 
                Lastname + ", " + 
                Zipcode + " " + 
                Residence + ", " + 
                TelPrivate + ", "+ 
                Active;

             
        }
        
    }

}
