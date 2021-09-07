using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unterrichtseinheit_13
{
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
        public DateTime Birthday { get; set; }


        public static int EmployeeCounter { get; set; }

        public Employee(string firstname, string lastname,
            DateTime birthday) :base(firstname, lastname)
        {
            EmployeeNumber = 100+EmployeeCounter;
            Birthday = birthday;
            EmployeeCounter++;
        }

        public override string GetData()
        {
            return base.GetData() + ", "+EmployeeNumber+", "+Birthday.ToShortDateString();
        }

        public override string ToString()
        {
            return base.ToString() + ", " + EmployeeNumber + ", " + Birthday.ToShortDateString();
        }
    }
}
