/**************************************************************************
 *                                                                        *
 *  File:        AddManagerState.cs                                             *
 *  Copyright:   (c) 2024, Butnaru Raimond-Eduard,			              *
 *			   Maieczki Petronela-Sînziana,			                      *
 *			   Lupu Andreea-Sabina,				                          *
 *			   Guriuc Vlad-Ionuț                                          *
 *  E-mail:                                                               *
 *       raimond-eduard.butnaru@Student.tuiasi.ro 	                      *
 *		 petronela-sinziana.maieczki@student.tuiasi.ro		              *
 *		 andreea-sabina.lupu@student.tuiasi.ro 			                  *
 *		 vlad-ionut.guriuc@student.tuiasi.ro                              *
 *  Description: Clasă folosită pentru adăugarea de manager din postura   *
 *              de admin                                                  *
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
    /// Clasa AddManagerState implementeaza interfata IState si gestioneaza 
    /// tranzitiile starii pentru adaugarea unui manager din postura de admin.
    /// </summary>
    public class AddManagerState : IState
    {
        private MainForm _mainForm;
        
        /// <summary>
        /// Constructor pentru clasa AddManagerState.
        /// </summary>
        /// <param name="mainForm">Referinta catre instanta MainForm.</param>
        public AddManagerState(MainForm mainForm)
        {
            _mainForm = mainForm;
        }

        /// <summary>
        /// Metoda care este apelata atunci cand se intra in starea AddManager.
        /// </summary>
        /// <remarks>
        /// Aceasta metoda afiseaza formularul pentru adaugarea unui manager.
        /// </remarks>
        public void Enter()
        {
            _mainForm.ShowAddManagerForm();
        }

        /// <summary>
        /// Metoda care este apelata atunci cand se iese din starea AddManager.
        /// </summary>
        /// <remarks>
        /// Aceasta metoda ascunde formularul pentru adaugarea unui manager.
        /// </remarks>
        public void Exit()
        {
            _mainForm.HideAddManagerForm();
        }
    }
}
