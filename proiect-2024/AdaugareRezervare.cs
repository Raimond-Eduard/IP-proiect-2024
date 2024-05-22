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
    public partial class AdaugareRezervare : Form
    {
        //state manager
        private MainForm _mainForm;

        //Campuri de initializare private
        private string _tipCamera;
        private int _capacitate;
        private string _tipBalcon;
        private int _pret_per_noapte;
        private DateTime _checkIn;
        private DateTime _checkOut;
        public AdaugareRezervare(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
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

        private void buttonRezervari_Click(object sender, EventArgs e)
        {
            _mainForm.SetState(new ClientViewState(_mainForm));

        }
        
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            _mainForm.SetState(new LogInState(_mainForm));

        }
    }
}
