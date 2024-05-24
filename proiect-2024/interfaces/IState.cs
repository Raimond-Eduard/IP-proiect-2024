/**************************************************************************
 *                                                                        *
 *  File:        IState.cs                                                *
 *  Copyright:   (c) 2024, Butnaru Raimond-Eduard,			              *
 *			   Maieczki Petronela-Sînziana,			                      *
 *			   Lupu Andreea-Sabina,				                          *
 *			   Guriuc Vlad-Ionuț                                          *
 *  E-mail:                                                               *
 *       raimond-eduard.butnaru@Student.tuiasi.ro 	                      *
 *		 petronela-sinziana.maieczki@student.tuiasi.ro		              *
 *		 andreea-sabina.lupu@student.tuiasi.ro 			                  *
 *		 vlad-ionut.guriuc@student.tuiasi.ro                              *
 *  Description: Clasă folosită pentru implementarea șablonului State     *
 *              în interfețele aplicației.                                *
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
    /// Interfata pentru implementarea sablonului State in interfețele aplicației.
    /// </summary>
    public interface IState
    {
        /// <summary>
        /// Metoda apelata la intrarea in starea specifica.
        /// </summary>
        void Enter();

        /// <summary>
        /// Metoda apelata la iesirea din starea specifica.
        /// </summary>
        void Exit();
    }
}
