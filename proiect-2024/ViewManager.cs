using Microsoft.Data.Sqlite;
using proiect_2024.states;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_2024
{
    public partial class ViewManager : Form
    {
        //state manager
        private MainForm _mainForm;

        //database connection
        private string ConnectionString = "Data source=" + Directory.GetCurrentDirectory() + "\\hotel_db.db";

        //campuri ce vor fi utilizate in afisarea si eventual stergerea datelor de la camere
        private List<int> _id;
        private List<int> _numarCamera;
        private List<int> _pret_per_noapte;
        private List<int> _etaj;
        private List<string> _tip_camera;
        private List<string> _tip_balcon;
        private List<int> _numar_persoane;

        //campuri private ce vor fi utilizate in afisarea si stergarea rezervarilor
        private List<int> _reservationId;
        private List<int> _clientId;
        private List<int> _cameraId;
        private List<int> _payment;
        private List<DateTime> _dates;

        public ViewManager(MainForm mainForm)
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
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadData();
        }
        private void LoadData()
        {        
            _id = new List<int>();
            _numarCamera = new List<int>();
            _pret_per_noapte = new List<int>();
            _etaj = new List<int>();
            _tip_camera = new List<string>();
            _tip_balcon = new List<string>();
            _numar_persoane = new List<int>();

            _reservationId = new List<int>();
            _clientId = new List<int>();
            _cameraId = new List<int>();
            _payment = new List<int>();
            _dates = new List<DateTime>();

            using(SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"SELECT * FROM Camera;";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _id.Add(reader.GetInt32(reader.GetOrdinal("id_camera")));
                            _numarCamera.Add(reader.GetInt32(reader.GetOrdinal("numar_camera")));
                            _pret_per_noapte.Add(reader.GetInt32(reader.GetOrdinal("pret_per_noapte")));
                            _etaj.Add(reader.GetInt32(reader.GetOrdinal("etaj")));
                            _tip_camera.Add(reader.GetString(reader.GetOrdinal("tip_camera")));
                            _tip_balcon.Add(reader.GetString(reader.GetOrdinal("tip_balcon")));
                            _numar_persoane.Add(reader.GetInt32(reader.GetOrdinal("capacitate")));
                        }   
                    }
                }
            }

            for(int i=0; i<_id.Count; i++)
            {
                string formatted = $"ID: {_id[i], -5}; Numar: {_numarCamera[i], -5}; Pret/Noapte: {_pret_per_noapte[i], -5}; Etaj: {_etaj[i], -5}; Tip: {_tip_camera[i], -10}; " +
                    $"Balcon: {_tip_balcon[i], -10}; Nr. Persoane: {_numar_persoane[i], -10}";
                listBoxDetaliiCamere.Items.Add(formatted);
            }

            using(SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                using(SqliteCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"SELECT * FROM Rezervare;";

                    using(SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _reservationId.Add(reader.GetInt32(reader.GetOrdinal("id_rezervare")));
                            _clientId.Add(reader.GetInt32(reader.GetOrdinal("id_client")));
                            _cameraId.Add(reader.GetInt32(reader.GetOrdinal("id_camera")));
                            _payment.Add(reader.GetInt32(reader.GetOrdinal("total_plata")));
                            _dates.Add(DateTime.ParseExact(reader.GetString(reader.GetOrdinal("check_in")), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture));
                            _dates.Add(DateTime.ParseExact(reader.GetString(reader.GetOrdinal("check_out")), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture));
                        }
                    }
                }
            }
            int j = 0;
            for(int i = 0; i < _reservationId.Count; i++)
            {
                string formatted = $"ID: {_reservationId[i], -5} | Client (ID): {_clientId[i], -5} | Camera (ID): {_cameraId[i], -5} | " +
                    $"Plata: {_payment[i], -5} | Check in: {_dates[j], -10:yyyy-MM-dd} | Check out: {_dates[j], -10:yyyy-MM-dd}";
                j += 2;
                listBoxDetaliiRezervari.Items.Add(formatted);
            }

        }

        private void buttonViewAdaugaCamera_Click(object sender, EventArgs e)
        {
            _mainForm.SetState(new AddRoomState(_mainForm));
        }

        private void buttonViewManagerRefresh_Click(object sender, EventArgs e)
        {
            listBoxDetaliiCamere.Items.Clear();
            listBoxDetaliiRezervari.Items.Clear();
            LoadData();
        }

        private void buttonViewStergeCamera_Click(object sender, EventArgs e)
        {
            if(listBoxDetaliiCamere.SelectedItems.Count != 1)
            {
                MessageBox.Show("Alegeti din lista din dreapta o singura camera pe care sa o stergeti mai intai", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = listBoxDetaliiCamere.SelectedIndex;
            using(SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                string deletion = @"DELETE FROM Camera WHERE id_camera = @id;";

                using (SqliteCommand command = new SqliteCommand(deletion, connection))
                {
                    command.Parameters.AddWithValue("@id", _id[id]);
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if(rowsAffected > 0)
                        {
                            Console.WriteLine("Stergere cu succes");
                        }
                        else
                        {
                            Console.WriteLine("Nu s-a sters nimic");
                        }
                    }catch(Exception ex)
                    {
                        throw new Exception("Probleme la baza de date\n", ex);
                    }
                }
                
            }

            MessageBox.Show("Stergere realizata cu succes", "Succes");
        }

        private void buttonViewStergereRezervare_Click(object sender, EventArgs e)
        {
            if(listBoxDetaliiRezervari.SelectedItems.Count != 1)
            {
                MessageBox.Show("Mai intai selectati o singura rezervare din lista din stanga", "Eroare", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            int id = listBoxDetaliiRezervari.SelectedIndex + 1;
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                string deletion = @"DELETE FROM Rezervare WHERE id_rezervare = @id;";

                using (SqliteCommand command = new SqliteCommand(deletion, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Stergere cu succes");
                        }
                        else
                        {
                            Console.WriteLine("Nu s-a sters nimic");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Probleme la baza de date\n", ex);
                    }
                }

            }

            MessageBox.Show("Stergere realizata cu succes", "Succes");

        }
    }
}
