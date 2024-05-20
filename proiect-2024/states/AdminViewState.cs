using proiect_2024.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_2024.states
{
    public class AdminViewState : IState
    {
        private MainForm _mainForm;

        public AdminViewState(MainForm mainForm)
        {
            _mainForm = mainForm;
        }

        public void Enter()
        {
            _mainForm.ShowAdminForm();
        }

        public void Exit()
        {
            _mainForm.HideAdminForm();
        }
    }
}
