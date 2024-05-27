/**************************************************************************
 *                                                                        *
 *  File:        ClientViewState.cs                                       *
 *  Copyright:   (c) 2024, Butnaru Raimond-Eduard,			              *
 *			   Maieczki Petronela-Sînziana,			                      *
 *			   Lupu Andreea-Sabina,				                          *
 *			   Guriuc Vlad-Ionuț                                          *
 *  E-mail:                                                               *
 *       raimond-eduard.butnaru@Student.tuiasi.ro 	                      *
 *		 petronela-sinziana.maieczki@student.tuiasi.ro		              *
 *		 andreea-sabina.lupu@student.tuiasi.ro 			                  *
 *		 vlad-ionut.guriuc@student.tuiasi.ro                              *
 *  Description: Clasă cu metode folosite pentru afișarea interfeței      *
 *              clientului.                                               *
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

namespace proiect_2024.states
{
    /// <summary>
    /// Clasa ClientViewState implementeaza interfata IState si gestioneaza 
    /// tranzitiile starii pentru afisarea interfetei clientului.
    /// </summary>
    public class ClientViewState : IState
    {
        private MainForm _mainForm;

        /// <summary>
        /// Constructor pentru clasa ClientViewState.
        /// </summary>
        /// <param name="mainForm">Referinta catre instanta MainForm.</param>
        public ClientViewState(MainForm mainForm)
        {
            _mainForm = mainForm;
        }

        /// <summary>
        /// Metoda care este apelata atunci cand se intra in starea ClientView.
        /// </summary>
        /// <remarks>
        /// Aceasta metoda afiseaza interfata pentru client.
        /// </remarks>
        public void Enter()
        {
            _mainForm.ShowClientView();
        }

        /// <summary>
        /// Metoda care este apelata atunci cand se iese din starea ClientView.
        /// </summary>
        /// <remarks>
        /// Aceasta metoda ascunde interfata pentru client.
        /// </remarks>
        public void Exit()
        {
            _mainForm.HideClientView();
        }
    }
}
