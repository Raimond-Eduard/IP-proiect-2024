using proiect_2024.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_2024.states
{
    public class AddRoomState : IState
    {
        private MainForm _mainForm;
        public AddRoomState(MainForm mainForm)
        {
            _mainForm = mainForm;
        }
        public void Enter()
        {
            _mainForm.ShowAddRoomForm();
        }

        public void Exit()
        {
            _mainForm.HideAddRoomForm();
        }
    }
}
