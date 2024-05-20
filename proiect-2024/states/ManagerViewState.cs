using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proiect_2024.interfaces;

namespace proiect_2024.states
{
    public class ManagerViewState : IState
    {
        private MainForm _mainForm;

        public ManagerViewState(MainForm mainForm)
        {
            _mainForm = mainForm;
        }

        public void Enter()
        {
            _mainForm.ShowManagerForm();
        }
        public void Exit()
        {
            _mainForm.HideManagerForm();
        }
    }
}
