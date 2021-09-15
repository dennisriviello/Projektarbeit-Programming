using System;

namespace ContectManager
{
    [Serializable]
    public class Trainee : Employee
    {
        public string ApprenticeshipYears { get; set; }
        public string CurrentYear { get; set; }

        public Trainee(string salutation, string firstname, string lastname,
            DateTime birthday, string gender, string title, string telwork,
            string faxwork, string adress, string zipcode, string residence,
            string telprivate, string telmobile, string email, bool active,
            int employeecounter, string department, string ahvnumber, string nationality,
            DateTime entrydate, DateTime quitdate, string employmentlevel, string role,
            int managementlevel, string apprenticeshipyears, string currentyear)

            : base(salutation, firstname, lastname, birthday, gender, title, telwork,
            faxwork, adress, zipcode, residence, telprivate, telmobile, email, active,
            employeecounter, department, ahvnumber, nationality, entrydate, quitdate, employmentlevel,
            role, managementlevel)

        {
            ApprenticeshipYears = apprenticeshipyears;
            CurrentYear = currentyear;
        
        }

       

    }
}
