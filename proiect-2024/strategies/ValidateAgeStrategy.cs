/**************************************************************************
 *                                                                        *
 *  File:        ValidateAgeStrategy.cs                                   *
 *  Copyright:   (c) 2024, Butnaru Raimond-Eduard,			              *
 *			   Maieczki Petronela-Sînziana,			                      *
 *			   Lupu Andreea-Sabina,				                          *
 *			   Guriuc Vlad-Ionuț                                          *
 *  E-mail:                                                               *
 *       raimond-eduard.butnaru@Student.tuiasi.ro 	                      *
 *		 petronela-sinziana.maieczki@student.tuiasi.ro		              *
 *		 andreea-sabina.lupu@student.tuiasi.ro 			                  *
 *		 vlad-ionut.guriuc@student.tuiasi.ro                              *
 *  Description:  Clasă folosită pentru validarea vârstei utilizatorului  *
 *               astfel încat acesta să fie major.                        *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/


using proiect_2024.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_2024.strategies
{
    /// <summary>
    /// Clasa folosita pentru validarea varstei utilizatorului astfel incat acesta sa fie major.
    /// </summary>
    public class ValidateAgeStrategy : IStrategy
    {
        /// <summary>
        /// Verifica daca textul dat reprezinta o varsta majora.
        /// </summary>
        /// <param name="text">Textul care trebuie verificat.</param>
        /// <returns>True daca varsta este majora, altfel false.</returns>
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
