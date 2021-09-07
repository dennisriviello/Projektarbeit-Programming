using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unterrichtseinheit_13
{
    class Customer : Person
    {
        public int CustomerNumber { get; set; }
        public string Company { get; set; }


        public Customer(string firstname, string lastname,
            int customerNumber, string company) : base(firstname, lastname)
        {
            CustomerNumber = customerNumber;
            Company = company;
        }

        public override string GetData()
        {
            return base.GetData() + ", " + CustomerNumber + ", " + Company;
        }

        public override string ToString()
        {
            return base.ToString() + ", " + CustomerNumber + ", " + Company;
        }
    }
}
