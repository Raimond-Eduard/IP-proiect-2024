using proiect_2024.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_2024.states
{
<<<<<<< Updated upstream
    /// <summary>
    /// Clasa AddRoomState implementeaza interfata IState si gestioneaza 
    /// tranzitiile starii pentru adaugarea unei camere din postura de manager.
    /// </summary>
    public class AddRoomState : IState
    {
        private MainForm _mainForm;

        /// <summary>
        /// Constructor pentru clasa AddRoomState.
        /// </summary>
        /// <param name="mainForm">Referinta catre instanta MainForm.</param>
=======
    public class AddRoomState : IState
    {
        private MainForm _mainForm;
>>>>>>> Stashed changes
        public AddRoomState(MainForm mainForm)
        {
            _mainForm = mainForm;
        }
<<<<<<< Updated upstream

        /// <summary>
        /// Metoda care este apelata atunci cand se intra in starea AddRoom.
        /// </summary>
        /// <remarks>
        /// Aceasta metoda afiseaza formularul pentru adaugarea unei camere.
        /// </remarks>
=======
>>>>>>> Stashed changes
        public void Enter()
        {
            _mainForm.ShowAddRoomForm();
        }

<<<<<<< Updated upstream
        /// <summary>
        /// Metoda care este apelata atunci cand se iese din starea AddRoom.
        /// </summary>
        /// <remarks>
        /// Aceasta metoda ascunde formularul pentru adaugarea unei camere.
        /// </remarks>
=======
>>>>>>> Stashed changes
        public void Exit()
        {
            _mainForm.HideAddRoomForm();
        }
    }
}
