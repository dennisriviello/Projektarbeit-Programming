using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unterrichtseinheit_13
{
    class Person
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        
        }

        public virtual string GetData()
        {
            return Firstname + ", " + Lastname;
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   Firstname == person.Firstname &&
                   Lastname == person.Lastname;
        }

        public override string ToString()
        {
            return Firstname + ", " + Lastname;
        }

        

    }
}
