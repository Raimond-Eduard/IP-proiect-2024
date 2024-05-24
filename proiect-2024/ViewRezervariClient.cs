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
using proiect_2024.helpers;

namespace proiect_2024
{
    public partial class ViewRezervariClient : Form
    {
        private MainForm _mainForm;

        private string ConnectionString = "Data source=" + Directory.GetCurrentDirectory() + "\\hotel_db.db";

        private List<int> _camerasId;
        private List<int> _reservationId;
        private List<int> _payment;
        private List<int> _camerasNumber;
        private List<DateTime> _checkInCheckOut;

        public ViewRezervariClient(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            _mainForm.SetState(new LogInState(_mainForm));
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

        private void buttonViewAdaugaRezervare_Click(object sender, EventArgs e)
        {
            _mainForm.SetState(new AddReservationState(_mainForm));
        }
        private void UpdateInterface()
        {
            _reservationId = new List<int>();
            _camerasId = new List<int>();
            _reservationId = new List<int>();
            _payment = new List<int>();
            _camerasNumber = new List<int>();
            _checkInCheckOut = new List<DateTime>();
            
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT id_rezervare, id_camera, total_plata, check_in, check_out FROM Rezervare WHERE id_client = @id;";

                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", UserSession.UserId);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read() && !reader.IsDBNull(reader.GetOrdinal("id_rezervare")))
                        {
                            _reservationId.Add(reader.GetInt32(reader.GetOrdinal("id_rezervare")));
                            _camerasId.Add(reader.GetInt32(reader.GetOrdinal("id_camera")));
                            _payment.Add(reader.GetInt32(reader.GetOrdinal("total_plata")));
                            _checkInCheckOut.Add(DateTime.Parse(reader.GetString(reader.GetOrdinal("check_in"))));
                            _checkInCheckOut.Add(DateTime.Parse(reader.GetString(reader.GetOrdinal("check_out"))));
                        }
                    }
                }
                query = @"SELECT numar_camera FROM Camera WHERE id_camera = @camera;";
                if (_camerasId.Count > 0)
                {
                    for (int i = 0; i < _camerasId.Count; i++)
                    {
                        using (SqliteCommand command = new SqliteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@camera", _camerasId[i]);
                            using (SqliteDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    _camerasNumber.Add(reader.GetInt32(reader.GetOrdinal("numar_camera")));
                                }
                            }
                        }
                        
                    }
                }
               
            }
            int j = 0;
            if (_reservationId.Count > 0)
            {
                for (int i = 0; i < _reservationId.Count; i++)
                {
                    string formatted = $"ID: {_reservationId[i],-10}; Camera: {_camerasNumber[i],-10}; Cost ( Lei ): {_payment[i],-10}; Check In: {_checkInCheckOut[j],-20}; " +
                        $"Check Out: {_checkInCheckOut[j + 1],-20};";
                    listBoxDetaliiRezervari.Items.Add(formatted);
                    j = j + 2;
                }
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateInterface();
        }

        private void buttonClientRefresh_Click(object sender, EventArgs e)
        {
            listBoxDetaliiRezervari.Items.Clear();
            UpdateInterface();
        }
    }
}
