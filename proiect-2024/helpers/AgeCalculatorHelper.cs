/**************************************************************************
 *                                                                        *
 *  File:        AgeCalculatorHelper.cs                                   *
 *  Copyright:   (c) 2024, Butnaru Raimond-Eduard,			              *
 *			   Maieczki Petronela-Sînziana,			                      *
 *			   Lupu Andreea-Sabina,				                          *
 *			   Guriuc Vlad-Ionuț                                          *
 *  E-mail:                                                               *
 *       raimond-eduard.butnaru@Student.tuiasi.ro 	                      *
 *		 petronela-sinziana.maieczki@student.tuiasi.ro		              *
 *		 andreea-sabina.lupu@student.tuiasi.ro 			                  *
 *		 vlad-ionut.guriuc@student.tuiasi.ro                              *
 *  Description: Acest helper are rolul de a calcula varsta utilizatorului*
 *              din data nasterii pentru a testa daca este major.         *
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
    /// Clasa statica pentru calculul varstei utilizatorului.
    /// </summary>
    /// <remarks>
    /// Aceasta clasa contine o metoda statica pentru calcularea varstei utilizatorului
    /// pe baza datei de nastere.
    /// </remarks>
    public static class AgeCalculatorHelper
    {
        /// <summary>
        /// Calculeaza varsta utilizatorului.
        /// </summary>
        /// <param name="birthDate">Data de nastere a utilizatorului.</param>
        /// <returns>Varsta calculata a utilizatorului.</returns>
        /// <remarks>
        /// Aceasta metoda calculeaza varsta utilizatorului in functie de data curenta.
        /// Daca data de nastere este dupa ziua curenta din anul curent, varsta este
        /// decrementata cu un an.
        /// </remarks>
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
