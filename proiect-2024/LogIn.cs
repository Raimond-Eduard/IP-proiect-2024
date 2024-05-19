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
using System.Security.Cryptography;
using Microsoft.Data.Sqlite;

namespace proiect_2024
{
    public partial class LogIn : Form
    {
        private const string ConnectionString = "Data Source=hotel_db.db";
        private string _ownership;

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
        private bool CheckForLogInCredentials(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Va rog sa introduceti un nume de utilizator si parola");
            }
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"SELECT * FROM Utilizatori;";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = reader.GetInt32(reader.GetOrdinal("id_utilizator"));
                            string dbUsername = reader.GetString(reader.GetOrdinal("username"));
                            string dbPassword = reader.GetString(reader.GetOrdinal("password"));
                            _ownership = reader.GetString(reader.GetOrdinal("rol"));
                            if(username == dbUsername && password == dbPassword)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        private string GetSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder builder = new StringBuilder();
                for(int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string username = textBoxUsernameLogIn.Text;
            string password = GetSHA256Hash(textBoxPasswordLogIn.Text);
            if(CheckForLogInCredentials(username, password))
            {
                throw new Exception("Method needs to be implemented");
            }
        }
    }
}
