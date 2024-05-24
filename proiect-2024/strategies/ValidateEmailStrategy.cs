/**************************************************************************
 *                                                                        *
 *  File:        ValidateEmailStrategy.cs                                 *
 *  Copyright:   (c) 2024, Butnaru Raimond-Eduard,			              *
 *			   Maieczki Petronela-Sînziana,			                      *
 *			   Lupu Andreea-Sabina,				                          *
 *			   Guriuc Vlad-Ionuț                                          *
 *  E-mail:                                                               *
 *       raimond-eduard.butnaru@Student.tuiasi.ro 	                      *
 *		 petronela-sinziana.maieczki@student.tuiasi.ro		              *
 *		 andreea-sabina.lupu@student.tuiasi.ro 			                  *
 *		 vlad-ionut.guriuc@student.tuiasi.ro                              *
 *  Description:  Clasă folosită pentru validarea email-ului              *
 *               utilizatorului.                                          *
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
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace proiect_2024.strategies
{
    /// <summary>
    /// Clasa folosita pentru validarea email-ului utilizatorului.
    /// </summary>
    public class ValidateEmailStrategy : IStrategy
    {
        /// <summary>
        /// Verifica daca textul dat reprezinta un email valid.
        /// </summary>
        /// <param name="text">Textul care trebuie verificat.</param>
        /// <returns>True daca textul reprezinta un email valid, altfel false.</returns>
        public bool Check(string text)
        {
            try
            {
                MailAddress mail = new MailAddress(text);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

    }
}
