/**************************************************************************
 *                                                                        *
 *  File:        ViewAdmin.cs                                             *
 *  Copyright:   (c) 2024, Butnaru Raimond-Eduard,			              *
 *			   Maieczki Petronela-Sînziana,			                      *
 *			   Lupu Andreea-Sabina,				                          *
 *			   Guriuc Vlad-Ionuț                                          *
 *  E-mail:                                                               *
 *       raimond-eduard.butnaru@Student.tuiasi.ro 	                      *
 *		 petronela-sinziana.maieczki@student.tuiasi.ro		              *
 *		 andreea-sabina.lupu@student.tuiasi.ro 			                  *
 *		 vlad-ionut.guriuc@student.tuiasi.ro                              *
 *  Description:  Clasă care reprezintă formularul pentru vizualizarea    *
 *       utilizatorilor și rezervărilor din perspectiva adminului.        *
 *       Este responsabilă pentru afișarea informațiilor despre           *
 *       utilizatori și rezervări în interfața utilizatorului,            *
 *       extragerea acestor informații din baza de date și                *
 *       actualizarea interfeței în funcție de acestea. De                *
 *       asemenea, permite adminului să se deconecteze și să              *
 *       adauge un nou manager.                                           * 
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/


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
    /// <summary>
    /// Formularul pentru vizualizarea utilizatorilor si rezervarilor din perspectiva adminului.
    /// </summary>
    public partial class ViewAdmin : Form
    {
        //state manager
        private MainForm _mainForm;

        //conexiune cu baza de date
        private string ConnectionString = "Data source=" + Directory.GetCurrentDirectory() + "\\hotel_db.db";//"Data Source=E:\\Facultate\\IP\\Proiect IP 2024\\proiect-2024\\hotel_db.db";


        //campuri private afisare utilizatori
        private List<int> _usersID;
        private List<string> _usernames;
        private List<string> _roles;

        //campuri private afisare rezervari
        private List<int> _reservationID;
        private List<int> _clientID;
        private List<int> _cameraID;
        private List<int> _payment;
        private List<DateTime> _dates;

        /// <summary>
        /// Constructor pentru clasa ViewAdmin.
        /// </summary>
        /// <param name="mainForm">Referinta catre instanta MainForm.</param>
        public ViewAdmin(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            
        }

        /// <summary>
        /// Handler pentru butonul de deconectare.
        /// </summary>
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            _mainForm.SetState(new LogInState(_mainForm));
        }

        /// <summary>
        /// Inchide formularul si, daca inchiderea este cauzata de utilizator, solicita confirmare.
        /// </summary>
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

        /// <summary>
        /// Incarca interfata utilizatorului.
        /// </summary>
        private void LoadInterface()
        {
            _usersID = new List<int>();
            _usernames = new List<string>();
            _roles = new List<string>();

            _reservationID = new List<int>();
            _clientID = new List<int>();
            _cameraID = new List<int>();
            _payment = new List<int>();
            _dates = new List<DateTime>();

            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM Utilizatori WHERE id_utilizator != @id;";

                using(SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", UserSession.UserId);

                    using(SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _usersID.Add(reader.GetInt32(reader.GetOrdinal("id_utilizator")));
                            _usernames.Add(reader.GetString(reader.GetOrdinal("username")));
                            _roles.Add(reader.GetString(reader.GetOrdinal("rol")));
                        }
                    }
                }
                query = @"SELECT * FROM Rezervare;";

                using(SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.CommandText = query;

                    using(SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _reservationID.Add(reader.GetInt32(reader.GetOrdinal("id_rezervare")));
                            _clientID.Add(reader.GetInt32(reader.GetOrdinal("id_client")));
                            _cameraID.Add(reader.GetInt32(reader.GetOrdinal("id_camera")));
                            _payment.Add(reader.GetInt32(reader.GetOrdinal("total_plata")));
                            _dates.Add(DateTime.ParseExact(reader.GetString(reader.GetOrdinal("check_in")), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture));
                            _dates.Add(DateTime.ParseExact(reader.GetString(reader.GetOrdinal("check_out")), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture));
                        }
                    }
                }

            }
            for(int i = 0; i < _usersID.Count; i++) 
            {
                string formatted = $"ID: {_usersID[i],-5} | Username: {_usernames[i],-10} | Rol: {_roles[i],-10}";
                listBoxDetaliiUtilizatori.Items.Add(formatted);
            }

            int j = 0;
            for(int i = 0; i < _reservationID.Count; i++)
            {
                string formatted = $"ID: {_reservationID[i], -5} | Client(ID): {_clientID[i], -5} | " +
                    $"Camera(ID): {_cameraID[i], -5} | Total plata (Lei): {_payment[i], -5} | Check in: {_dates[j],-15:yyyy-MM-dd} | " +
                    $"Check Out: {_dates[j+1], -15:yyyy-MM-dd}";
                j += 2;
                listBoxDetaliiRezervari.Items.Add(formatted);
            }
        }

        /// <summary>
        /// Handler pentru evenimentul de incarcare a formularului.
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadInterface();
        }

        /// <summary>
        /// Handler pentru butonul de adaugare manager.
        /// </summary>
        private void buttonViewAdaugaManager_Click(object sender, EventArgs e)
        {
            _mainForm.SetState(new AddManagerState(_mainForm));
        }

        /// <summary>
        /// Handler pentru butonul de actualizare.
        /// </summary>
        private void buttonRefreshAll_Click(object sender, EventArgs e)
        {
            listBoxDetaliiRezervari.Items.Clear();
            listBoxDetaliiUtilizatori.Items.Clear();
            LoadInterface();
        }

        /// <summary>
        /// Handler pentru butonul de stergere utilizator.
        /// </summary>
        private void buttonViewStergeUtilizator_Click(object sender, EventArgs e)
        {
            if(listBoxDetaliiUtilizatori.SelectedItems.Count != 1)
            {
                MessageBox.Show("Selectati din lista din dreapta UN utilizator mai intai", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = listBoxDetaliiUtilizatori.SelectedIndex;
            bool hasReservations;

            using(SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT id_rezervare FROM Rezervare WHERE id_client = @id;";

                using(SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", _usersID[id]);

                    using(SqliteDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read() && !reader.IsDBNull(reader.GetOrdinal("id_rezervare")))
                        {
                            hasReservations = true;
                        }
                        else
                        {
                            hasReservations = false;
                        }
                    }
                }
                if (hasReservations)
                {
                    query = @"DELETE FROM Rezervare WHERE id_client = @id;";

                    using(SqliteCommand command = new SqliteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", _usersID[id]);
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
                        catch(Exception ex)
                        {
                            throw new Exception("Exceptie la stergerea rezervarilor utilizatorilor care urmeaza sa fie stersi dar inca au rezervari in baza de date\n" + ex);
                        }
                    }
                }

            }
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                string deletion = @"DELETE FROM Utilizatori WHERE id_utilizator = @id;";

                using (SqliteCommand command = new SqliteCommand(deletion, connection))
                {
                    command.Parameters.AddWithValue("@id", _usersID[id]);
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
                        throw new Exception("Problema la stergerea utilizatorului\n" + ex);
                    }
                }

            }

            MessageBox.Show("Stergere realizata cu succes", "Succes");

        }

        /// <summary>
        /// Handler pentru butonul de stergere rezervare.
        /// </summary>
        private void buttonStergereRezervare_Click(object sender, EventArgs e)
        {
            if (listBoxDetaliiRezervari.SelectedItems.Count != 1)
            {
                MessageBox.Show("Selectati din lista din stanga o singura rezervare mai intai", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = listBoxDetaliiRezervari.SelectedIndex;
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                string deletion = @"DELETE FROM Rezervare WHERE id_rezervare = @id;";

                using (SqliteCommand command = new SqliteCommand(deletion, connection))
                {
                    command.Parameters.AddWithValue("@id", _reservationID[id]);
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
                        throw new Exception("Probleme la stergerea de rezervazi din admin view\n" + ex);
                    }
                }

            }

            MessageBox.Show("Stergere realizata cu succes", "Succes");

        }

        private void exitToolStripMenu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sigur vrei sa inchizi?", "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void aboutToolStripMenu_Click(object sender, EventArgs e)
        {
            string helpLocation = System.Environment.CurrentDirectory + "\\help_hotel.chm";
            Help.ShowHelp(this, helpLocation);
        }
    }
}
