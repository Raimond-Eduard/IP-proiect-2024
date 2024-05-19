using proiect_2024.states;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace proiect_2024
{
    public partial class LogIn : Form
    {
        private MainForm _mainForm;
        public LogIn(MainForm mainForm)
        {
            _mainForm = mainForm;

            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            _mainForm.SetState(new SignUpState(_mainForm));
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Sigur vrei sa inchizi?", "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
