/**************************************************************************
 *                                                                        *
 *  File:        IStrategy.cs                                             *
 *  Copyright:   (c) 2024, Butnaru Raimond-Eduard,			              *
 *			   Maieczki Petronela-Sînziana,			                      *
 *			   Lupu Andreea-Sabina,				                          *
 *			   Guriuc Vlad-Ionuț                                          *
 *  E-mail:                                                               *
 *       raimond-eduard.butnaru@Student.tuiasi.ro 	                      *
 *		 petronela-sinziana.maieczki@student.tuiasi.ro		              *
 *		 andreea-sabina.lupu@student.tuiasi.ro 			                  *
 *		 vlad-ionut.guriuc@student.tuiasi.ro                              *
 *  Description: Clasă folosită pentru implementarea șablonului Strategy  *
 *              in interfețele aplicației.                                *
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

namespace proiect_2024.interfaces
{
    /// <summary>
    /// Interfata pentru implementarea sablonului Strategy in interfețele aplicației.
    /// </summary>
    public interface IStrategy
    {
        /// <summary>
        /// Verifica daca textul dat corespunde strategiei.
        /// </summary>
        /// <param name="text">Textul care trebuie verificat.</param>
        /// <returns>True daca textul corespunde strategiei, altfel false.</returns>
        bool Check(string text);
    }
}
