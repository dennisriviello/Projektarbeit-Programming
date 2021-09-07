using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unterrichtseinheit_13
{
    class Trainee : Employee
    {
        public int MaxTraineeYears { get; private set; }
        public int CurrentTraineeYear { get; private set; }


        public Trainee(string firstname, string lastname,
            DateTime birthday, int maxTraineeYears, int currentTraineeYear)
            : base(firstname, lastname, birthday)
        {
            CurrentTraineeYear = currentTraineeYear;
            MaxTraineeYears = maxTraineeYears;
        }

        public override string GetData()
        {
            return base.GetData()+", "+MaxTraineeYears+", "+CurrentTraineeYear;
        }

        public override string ToString()
        {
            return base.ToString() + ", " + MaxTraineeYears + ", " + CurrentTraineeYear;
        }

        public void IncreaseTraineeYear()
        {
            if (CurrentTraineeYear<MaxTraineeYears)
            {
                CurrentTraineeYear++;
            } 
        }


    }
}
