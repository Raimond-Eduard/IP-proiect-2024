using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_2024.helpers
{
    public static class StopUnavailableDates
    {
        public static bool validateCheckInCheckOut(DateTime checkIn, DateTime date1, DateTime date2)
        {
            if(checkIn >= date1 && checkIn <= date2)
            {
                return true;
            }
            return false;
        }

        public static bool validateSmallerLargerInterval(DateTime checkIn,DateTime checkOut, DateTime date1, DateTime date2)
        {
            if(checkIn >= date1 && checkIn <= date2 && checkOut >= date1 && checkOut <= date2)
            {
                return true;
            }
            return false;
        }

        
    }
}
