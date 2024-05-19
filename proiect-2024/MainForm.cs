using proiect_2024.interfaces;
using proiect_2024.states;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_2024
{
    public partial class MainForm : Form
    {
        public IState _currentState;
        public IState _logInState;
        public IState _signUpState;

        private LogIn _logInForm;
        private SignUp _signUpForm;

        public MainForm()
        {
            InitializeComponent();
            this.Visible = false;
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            
            _logInForm = new LogIn(this);
            _signUpForm = new SignUp(this);

            _logInState = new LogInState(this);
            _signUpState = new SignUpState(this);

            // Set initial state to LogInState
            SetState(_logInState);
        }

        public void SetState(IState newState)
        {
            _currentState?.Exit();
            _currentState = newState;
            _currentState.Enter();
        }

        public void ShowLogInForm()
        {
            _logInForm.Show();
        }

        public void HideLogInForm()
        {
            _logInForm.Hide();
        }

        public void ShowSignUpForm()
        {
            _signUpForm.Show();
        }

        public void HideSignUpForm()
        {
            _signUpForm.Hide();
        }
    }
}
