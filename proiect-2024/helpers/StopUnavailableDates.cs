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
    /// <summary>
    /// Clasa statica pentru validarea datelor de rezervare.
    /// </summary>
    /// <remarks>
    /// Aceasta clasa contine metode statice pentru a valida daca datele de check-in
    /// si check-out sunt in intervalele disponibile.
    /// </remarks>
    public static class StopUnavailableDates
    {
        /// <summary>
        /// Valideaza daca data de check-in este in intervalul dat.
        /// </summary>
        /// <param name="checkIn">Data de check-in.</param>
        /// <param name="date1">Prima data a intervalului.</param>
        /// <param name="date2">A doua data a intervalului.</param>
        /// <returns>True daca data de check-in este in interval, altfel false.</returns>
        public static bool validateCheckInCheckOut(DateTime checkIn, DateTime date1, DateTime date2)
        {
            if(checkIn >= date1 && checkIn <= date2)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Valideaza daca datele de check-in si check-out sunt in intervalul dat.
        /// </summary>
        /// <param name="checkIn">Data de check-in.</param>
        /// <param name="checkOut">Data de check-out.</param>
        /// <param name="date1">Prima data a intervalului.</param>
        /// <param name="date2">A doua data a intervalului.</param>
        /// <returns>True daca ambele date sunt in interval, altfel false.</returns>
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
