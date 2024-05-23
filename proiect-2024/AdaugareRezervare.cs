using Microsoft.Data.Sqlite;
using proiect_2024.helpers;
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
        private int _idRezervare;
        private int _totalPlata;
        private string _tipBalcon;
        private List<int> _pret_per_noapte;
        private DateTime _checkIn;
        private DateTime _checkOut;
        private List<DateTime> _unavailableDates;

        private List<int> _camerasPrices;
        private List<int> _camerasIds;
        private List<int> _cameraNumbers;
        private List<int> _camerasFloor;
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
            int index = listBoxAdaugareRezervare.SelectedIndex;
            _unavailableDates = new List<DateTime>();
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT check_in, check_out FROM Rezervare WHERE id_camera = @camera;";

                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@camera", _camerasIds[index]);

                    using(SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if(reader.IsDBNull(reader.GetOrdinal("check_in")) || reader.IsDBNull(reader.GetOrdinal("check_out")))
                            {
                                continue;
                            }
                            else
                            {
                                _unavailableDates.Add(DateTime.Parse(reader.GetString(reader.GetOrdinal("check_in"))));
                                _unavailableDates.Add(DateTime.Parse(reader.GetString(reader.GetOrdinal("check_out"))));
                            }
                        }
                    }
                }

                query = @"SELECT MAX(id_rezervare) FROM Rezervare;";
                _totalPlata = (_checkOut - _checkIn).Days * _pret_per_noapte[index];
                using(SqliteCommand command = new SqliteCommand(query, connection))
                {
                    using(SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            _idRezervare = reader.GetInt32(reader.GetOrdinal("MAX(id_rezervare")) + 1;
                        }
                    }
                }
            }
            _checkIn = datePickCheckIn.SelectionStart;
            _checkOut = datePickCheckOut.SelectionStart;
            if(_unavailableDates.Count <= 0)
            {
                return;
            }
            for(int i = 0; i < _unavailableDates.Count; i = i + 2)
            {
                if (StopUnavailableDates.validateCheckInCheckOut(_checkIn, _unavailableDates[i], _unavailableDates[i + 1]))
                {
                    ShowErrorForDates();
                    return;
                }
                if(StopUnavailableDates.validateCheckInCheckOut(_checkOut, _unavailableDates[i], _unavailableDates[i + 1])) 
                {
                    ShowErrorForDates();
                    return;
                }
                if (StopUnavailableDates.validateSmallerLargerInterval(_checkIn, _checkOut, _unavailableDates[i], _unavailableDates[i + 1]))
                {
                    ShowErrorForDates();
                    return;
                }
                if (StopUnavailableDates.validateSmallerLargerInterval(_unavailableDates[i], _unavailableDates[i + 1], _checkIn, _checkOut))
                {
                    ShowErrorForDates();
                    return;
                }

            }
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                string insertion = @"INSERT INTO Rezervare VALUES(@id, @client, @camera, @plata, @check_in, @check_out);";
                try
                {
                    using (SqliteCommand command = new SqliteCommand(insertion, connection))
                    {
                        command.Parameters.AddWithValue("@id", _idRezervare);
                        command.Parameters.AddWithValue("@client", UserSession.UserId);
                        command.Parameters.AddWithValue("@camera", _cameraNumbers[index]);
                        command.Parameters.AddWithValue("@plata", _totalPlata);
                        command.Parameters.AddWithValue("@check_in", _checkIn.ToString());
                        command.Parameters.AddWithValue("@check_out", _checkOut.ToString());

                        command.ExecuteNonQuery();
                    }
                }
                catch(Exception ex)
                {
                    throw new Exception("Baza de date a esuat\n", ex);
                }
                finally
                {
                    connection?.Close();
                }
            }
        }
        private void ShowErrorForDates()
        {
            MessageBox.Show("Alegeti alt intervald e date sau alta camera", "Camera ocupata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void buttonRezervareCautareCamera_Click(object sender, EventArgs e)
        {
            _tipCamera = comboBoxTipulCamerei.SelectedItem.ToString();
            _tipBalcon = comboBoxTipBalcon.SelectedItem.ToString();
            _capacitate = Convert.ToInt32(comboBoxCapacitate.SelectedItem.ToString());

            _camerasIds = new List<int>();
            _camerasPrices = new List<int>();
            _cameraNumbers = new List<int>();
            _camerasFloor = new List<int>();
            

            using(SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT id_camera, numar_camera, pret_per_noapte, etaj FROM Camera WHERE tip_camera = @tip AND tip_balcon = @balcon AND capacitate = @cap;";
                using (SqliteCommand command = new SqliteCommand(query, connection))
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
                                _cameraNumbers.Add(reader.GetInt32(reader.GetOrdinal("numar_camera")));
                                _camerasPrices.Add(reader.GetInt32(reader.GetOrdinal("pret_per_noapte")));
                                _camerasFloor.Add(reader.GetInt32(reader.GetOrdinal("etaj")));
                            }
                        }
                    }
                }
                if(_camerasIds.Count <= 0)
                {
                    MessageBox.Show("Nu s-au gasit camere cu aceste proprietati, contactati managerul", "Nu s-a gasit");
                    return;
                }
                for(int i = 0; i < _camerasIds.Count; i++)
                {
                    string formatted = $"Numar: {_cameraNumbers[i], -10}; Pret/Noapte: {_camerasPrices[i], -10}; Etaj: {_camerasFloor[i], -10}";
                    listBoxAdaugareRezervare.Items.Add(formatted);
                }

            }
        }
    }
}
