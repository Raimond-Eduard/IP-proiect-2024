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
    public partial class ViewRezervariClient : Form
    {
        private MainForm _mainForm;
        public ViewRezervariClient(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }
    }
}
