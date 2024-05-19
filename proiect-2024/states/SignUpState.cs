using proiect_2024.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_2024.states
{
    public class SignUpState : IState
    {
        private MainForm _mainForm;

        public SignUpState(MainForm mainForm)
        {
            _mainForm = mainForm;
        }

        public void Enter()
        {
            _mainForm.ShowSignUpForm();
        }
        public void Exit()
        {
            _mainForm.HideSignUpForm();
        }
    }
}
