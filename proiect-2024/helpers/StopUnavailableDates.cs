/**************************************************************************
 *                                                                        *
 *  File:        StopUnavailableDates.cs                                  *
 *  Copyright:   (c) 2024, Butnaru Raimond-Eduard,			              *
 *			   Maieczki Petronela-Sînziana,			                      *
 *			   Lupu Andreea-Sabina,				                          *
 *			   Guriuc Vlad-Ionuț                                          *
 *  E-mail:                                                               *
 *       raimond-eduard.butnaru@Student.tuiasi.ro 	                      *
 *		 petronela-sinziana.maieczki@student.tuiasi.ro		              *
 *		 andreea-sabina.lupu@student.tuiasi.ro 			                  *
 *		 vlad-ionut.guriuc@student.tuiasi.ro                              *
 *  Description: Acest helper interzice utilizatorului să facă o          *
 *              rezervare la o dată imposibilă.                           *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

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
