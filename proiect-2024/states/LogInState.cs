using proiect_2024.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_2024.states
{
    public class LogInState : IState
    {
        private MainForm _mainForm;
        public LogInState(MainForm mainForm)
        {
            _mainForm = mainForm;
        }

        public void Enter()
        {
            _mainForm.ShowLogInForm();
        }

        public void Exit()
        {
            _mainForm.HideLogInForm();
        }
    }
}
