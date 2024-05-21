using proiect_2024.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_2024.strategies
{
    public class ValidateAgeStrategy : IStrategy
    {

        public bool Check(string text)
        {
            DateTime parsedDate = DateTime.Parse(text);
            DateTime now = DateTime.Now;
            if (now.Year - parsedDate.Year < 18)
            {
                return false;
            }
            return true;
        }
    }
}
