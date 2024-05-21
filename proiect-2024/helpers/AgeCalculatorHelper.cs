using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_2024.helpers
{
    public static class AgeCalculatorHelper
    {
        public static int calculateAge(DateTime birthDate)
        {
            DateTime currentDate = DateTime.Today;

            int age = currentDate.Year - birthDate.Year;

            if(birthDate > currentDate.AddYears(-age)) {
                age--;
            }

            return age;
        }
    }

}
