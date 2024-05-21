using Microsoft.Data.Sqlite;
using proiect_2024.states;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace proiect_2024
{
    public partial class SignUp : Form
    {
        //state manager
        private MainForm _mainForm;

        //conexiune cu baza de date
        private string ConnectionString = "Data source=" + Directory.GetCurrentDirectory() + "\\hotel_db.db";//"Data Source=E:\\Facultate\\IP\\Proiect IP 2024\\proiect-2024\\hotel_db.db";


        //campuri private pentru salvarea temporara a datelor de inregistrare
        private string _username;
        private string _password;
        private string _first_name;
        private string _last_name;
        private string _phone;
        private string _email;
        private DateTime _birthDate;

        public SignUp(MainForm mainForm)
        {
            _mainForm = mainForm;

            InitializeComponent();
        }
        /// <summary>
        /// Functia apelata la click trimite utilizatorul catre starea de login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            _mainForm.SetState(new LogInState(_mainForm));
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if(e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Sigur vrei sa inchizi?", "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private bool validPhoneNumber(string phone)
        {
            for (int i = 0; i < _phone.Length; i++)
            {
                if (_phone[i] < '0' || _phone[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }

        private bool validEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);

                return true;
            }
            catch(FormatException)
            {
                return false;
            }
        }
        private bool checkAge(DateTime date)
        {
            DateTime now = DateTime.Now;
            if(now.Year - date.Year < 18)
            {
                return false;
            }
            return true;

        }
        private string GetSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if(textBoxUsernameSignUp.Text == null)
            {
                MessageBox.Show("Eroare", "Introduceti un nume de utilizator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else
            {
                _username = textBoxUsernameSignUp.Text;
                using (SqliteConnection connection = new SqliteConnection(ConnectionString))
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = @"SELECT username FROM Utilizatori;";
                        using (var reader = command.ExecuteReader())
                        {
                            string dbUsername = reader.GetString(reader.GetOrdinal("username"));
                            if (dbUsername == _username)
                            {
                                MessageBox.Show("Altceva", "Numele de utilizator exista deja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                connection.Close();
                                return;
                            }
                        }
                    }
                }
            }

            if(textBoxPasswordSignUp.Text == null)
            {
                MessageBox.Show("Parola lipsa", "Introduceti o parola, nu lasati campuri necompletate");
                return;
            }
            _password = GetSHA256Hash(textBoxPasswordSignUp.Text);
            
            if(textBoxNumeSignUp.Text == null)
            {
                MessageBox.Show("Nume lipsa", "Introduceti numele dumneavoastra, nu lasati campuri necompletate");
                return;

            }

            _first_name = textBoxNumeSignUp.Text;

            if(textBoxPrenumeSignUp.Text == null)
            {
                MessageBox.Show("Prenume lipsa", "Introduceti prenumele dumneavoastra, nu lasati campuri necompletate");
                return;

            }

            _last_name = textBoxPrenumeSignUp.Text;

            if(textBoxTelefonSignUp.Text == null)
            {
                MessageBox.Show("Numar de telefon lipsa", "Introduceti numarul de telefon pentru a putea fi contactat");
                return;
            }
            else
            {
                _phone = textBoxTelefonSignUp.Text;
                if(!validPhoneNumber(_phone))
                {
                    MessageBox.Show("Doar cifre", "Nu introduceti altceva decat cifre la numarul de telefon");
                    return;
                }
               
            }

            if(textBoxEmailSignUp.Text == null)
            {
                MessageBox.Show("Email lipsa", "Introduceti si adresa de email");
                return;
            }
            else
            {
                _email = textBoxEmailSignUp.Text;
                if (!validEmail(_email))
                {
                    MessageBox.Show("Email invalid", "Introduceti o adresa de email valida");
                    return;
                }
                
            }
            
            _birthDate = DateTime.Now;
            if (!checkAge(_birthDate))
            {
                MessageBox.Show("Eroare", "Nu puteti crea cont daca suntetu minor");
                return;
            }





            /*using (SqliteConnection connection = new SqliteConnection(ConnectionString))
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
                            string dbPassword = reader.GetString(reader.GetOrdinal("parola"));
                            _ownership = reader.GetString(reader.GetOrdinal("rol"));
                            if (username == dbUsername && password == dbPassword)
                            {
                                return true;
                            }
                        }
                    }
                }
            }*/
        }
    }
}
