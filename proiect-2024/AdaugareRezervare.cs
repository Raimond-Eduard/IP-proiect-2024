using Microsoft.Data.Sqlite;
using proiect_2024.states;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private List<int> _pret_per_noapte;
        private DateTime _checkIn;
        private DateTime _checkOut;
        
        

        private List<int> _camerasIds;
        //baza de date
        private string ConnectionString = "Data source=" + Directory.GetCurrentDirectory() + "\\hotel_db.db";


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

        private void buttonAdaugaRezervare_Click(object sender, EventArgs e)
        {
            _tipCamera = comboBoxTipulCamerei.SelectedItem.ToString();
            _tipBalcon = comboBoxTipBalcon.SelectedItem.ToString();
            _capacitate = Convert.ToInt32(comboBoxCapacitate.SelectedItem.ToString());
            _checkIn = datePickCheckIn.SelectionStart;
            _checkOut = datePickCheckOut.SelectionStart;

            using(SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                string query = @"SELECT id_camera, pret_per_naopte FROM Camera WHERE tip_camera = @tip AND " +
                    "tip_balcon = @balcon AND capcitate = @cap;";
                using(SqliteCommand command = new SqliteCommand(query, connection)) 
                {
                    command.Parameters.AddWithValue("@tip", _tipCamera);
                    command.Parameters.AddWithValue("@balcon", _tipBalcon);
                    command.Parameters.AddWithValue("@cap", _capacitate);

                    using(SqliteDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            if (reader.IsDBNull(reader.GetOrdinal("id_camera")))
                            {
                                continue;
                            }
                            else
                            {
                                _camerasIds.Add(reader.GetInt32(reader.GetOrdinal("id_camera")));
                                _pret_per_noapte.Add(reader.GetInt32(reader.GetOrdinal("pret_per_noapte")));
                            }
                        }
                    }
                }

                query = @"SELECT check_in, check_out FROM Rezervare WHERE id_camera = @camera;";
                using(SqliteCommand command = new SqliteCommand(@query, connection))
                {
                    for(int i = 0; i < _camerasIds.Count; i++)
                    {
                        if (_camerasIds[i] == -1)
                        {
                            continue ;
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@camera", _camerasIds[i]);

                            using (SqliteDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    if(reader.IsDBNull(reader.GetOrdinal("check_in")) || reader.IsDBNull(reader.GetOrdinal("check_out")))
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
