/**************************************************************************
 *                                                                        *
 *  File:        ValidateUsernameStrategy.cs                              *
 *  Copyright:   (c) 2024, Butnaru Raimond-Eduard,			              *
 *			   Maieczki Petronela-Sînziana,			                      *
 *			   Lupu Andreea-Sabina,				                          *
 *			   Guriuc Vlad-Ionuț                                          *
 *  E-mail:                                                               *
 *       raimond-eduard.butnaru@Student.tuiasi.ro 	                      *
 *		 petronela-sinziana.maieczki@student.tuiasi.ro		              *
 *		 andreea-sabina.lupu@student.tuiasi.ro 			                  *
 *		 vlad-ionut.guriuc@student.tuiasi.ro                              *
 *  Description:  Clasă folosită pentru validarea numelui de utilizator   *
 *              astfel încat acesta să nu fie null.                       *
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
    /// Clasa folosita pentru validarea numelui de utilizator astfel incat acesta sa nu fie null.
    /// </summary>
    public class ValidateUsernameStrategy : IStrategy
    {
        /// <summary>
        /// Verifica daca numele de utilizator dat nu contine spatii.
        /// </summary>
        /// <param name="username">Numele de utilizator care trebuie verificat.</param>
        /// <returns>True daca numele de utilizator este valid, altfel false.</returns>
        public bool Check(string username)
        {
            for(int i = 0; i < username.Length; i++)
            {
                if (username[i] == ' ')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
