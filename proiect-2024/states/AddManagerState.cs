using proiect_2024.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_2024.states
{
    public class AddManagerState : IState
    {
        private MainForm _mainForm;
        public AddManagerState(MainForm mainForm)
        {
            _mainForm = mainForm;
        }

        public void Enter()
        {
            _mainForm.ShowAddManagerForm();
        }

        public void Exit()
        {
            _mainForm.HideAddManagerForm();
        }
    }
}
