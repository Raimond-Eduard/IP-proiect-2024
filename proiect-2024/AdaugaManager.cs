using Microsoft.Data.Sqlite;
using proiect_2024.hash;
using proiect_2024.states;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace proiect_2024
{
    public partial class AdaugaManager : Form
    {
        //state
        private MainForm _mainForm;

        //Campuri private pentru datele managerului
        private string _first_name;
        private string _last_name;
        private string _username;
        private string _password;
        private int _id;

        //Referinta catre baza de date
        private string ConnectionString = "Data source=" + Directory.GetCurrentDirectory() + "\\hotel_db.db";//"Data Source=E:\\Facultate\\IP\\Proiect IP 2024\\proiect-2024\\hotel_db.db";

        public AdaugaManager(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            _mainForm.SetState(new AdminViewState(_mainForm));
        }

        private string hashPassword(string password)
        {
            return HashHelper.GetSHA256hash(password);
        }

        private void buttonManagerSignUp_Click(object sender, EventArgs e)
        {
            if(textBoxNumeManagerSignUp.Text == null || textBoxPasswordManagerSignUp.Text == null || textBoxNumeManagerSignUp.Text == null || textBoxPrenumeManagerSignUp.Text == null)
            {
                MessageBox.Show("Nu pot exista campuri necompletate", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _username = textBoxUsernameManagerSignUp.Text;
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"SELECT username FROM Utilizatori;";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string dbUsername = reader.GetString(reader.GetOrdinal("username"));
                            if(_username == dbUsername)
                            {
                                MessageBox.Show("Alegeti alt nume de utilizator", "Nume utilizator existent", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                connection.Close();
                                return;
                            }
                        }
                    }
                }
                string db_id = @"SELECT MAX(id_utilizator) FROM Utilizatori;";
                using (var command = new SqliteCommand(db_id, connection))
                {
                    _id = Convert.ToInt32(command.ExecuteScalar()) + 1;
                }
            }

            _first_name = textBoxNumeManagerSignUp.Text;
            _last_name = textBoxPrenumeManagerSignUp.Text;
            _username = textBoxUsernameManagerSignUp.Text;
            _password = hashPassword(textBoxPasswordManagerSignUp.Text);

            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                string insertion = @"INSERT INTO Utilizatori(id_utilizator, nume, prenume," +
                    "username, rol, parola) VALUES(@id, @first_name, @last_name," +
                    "@username, @role, @password);";
                try
                {
                    using (SqliteCommand command = new SqliteCommand(insertion, connection))
                    {
                        command.Parameters.AddWithValue("@id", _id);
                        command.Parameters.AddWithValue("@first_name", _first_name);
                        command.Parameters.AddWithValue("@last_name", _last_name);
                        command.Parameters.AddWithValue("@username", _username);
                        command.Parameters.AddWithValue("@role", "manager");
                        command.Parameters.AddWithValue("@password", _password);

                        command.ExecuteNonQuery();
                    }
                }
                catch(Exception ex)
                {
                    throw new Exception("Probleme la scrierea in baza de date\n", ex);
                }
                finally
                {
                    connection.Close();
                }
            }
            MessageBox.Show("Ati adaugat un nou manager cu success", "Operatie incheiata cu success");
            _mainForm.SetState(new AdminViewState(_mainForm));

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
    }
}
