using Microsoft.Data.Sqlite;
using proiect_2024.hash;
using proiect_2024.helpers;
using proiect_2024.interfaces;
using proiect_2024.states;
using proiect_2024.strategies;
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

        //strategy
        private IStrategy _mailStrategy;
        private IStrategy _phoneStrategy;
        private IStrategy _ageStrategy;

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
        private int _id;
        private int _age;

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

        private bool validPhoneNumber(string phone)
        {
            _phoneStrategy = new ValidatePhoneStrategy();
            return _phoneStrategy.Check(phone);
        }

        private bool validEmail(string email)
        {
            _mailStrategy = new ValidateEmailStrategy();
            return _mailStrategy.Check(email);
        }
        private bool checkAge(DateTime date)
        {
            _ageStrategy = new ValidateAgeStrategy();
            return _ageStrategy.Check(date.ToString());

        }
        private string GetSHA256Hash(string input)
        {
            return HashHelper.GetSHA256hash(input);
        }
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            //variabile temporare pentru verificare unicitate email si numar de telefon
            


            if (textBoxPasswordSignUp.Text == null)
            {
                MessageBox.Show("Parola lipsa", "Introduceti o parola, nu lasati campuri necompletate");
                return;
            }
            _password = GetSHA256Hash(textBoxPasswordSignUp.Text);

            if (textBoxNumeSignUp.Text == null)
            {
                MessageBox.Show("Nume lipsa", "Introduceti numele dumneavoastra, nu lasati campuri necompletate");
                return;

            }

            _first_name = textBoxNumeSignUp.Text;

            if (textBoxPrenumeSignUp.Text == null)
            {
                MessageBox.Show("Prenume lipsa", "Introduceti prenumele dumneavoastra, nu lasati campuri necompletate");
                return;

            }

            _last_name = textBoxPrenumeSignUp.Text;

            if (textBoxTelefonSignUp.Text == null)
            {
                MessageBox.Show("Numar de telefon lipsa", "Introduceti numarul de telefon pentru a putea fi contactat");
                return;
            }
            else
            {
                _phone = textBoxTelefonSignUp.Text;
                if (!validPhoneNumber(_phone))
                {
                    MessageBox.Show("Doar cifre", "Nu introduceti altceva decat cifre la numarul de telefon");
                    return;
                }

            }

            if (textBoxEmailSignUp.Text == null)
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

            _birthDate = dataNastereSignUp.Value;
            if (!checkAge(_birthDate))
            {
                MessageBox.Show("Eroare", "Nu puteti crea cont daca sunteti minor");
                return;
            }

            _age = AgeCalculatorHelper.calculateAge(_birthDate);

            if (textBoxUsernameSignUp.Text == null)
            {
                MessageBox.Show("Eroare", "Introduceti un nume de utilizator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                _username = textBoxUsernameSignUp.Text;
                using (SqliteConnection connection = new SqliteConnection(ConnectionString))
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = @"SELECT username, email, telefon FROM Utilizatori;";
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string dbUsername = reader.IsDBNull(reader.GetOrdinal("username")) ? "" : reader.GetString(reader.GetOrdinal("username"));
                                string emailChecker = reader.IsDBNull(reader.GetOrdinal("email")) ? "Unknown" : reader.GetString(reader.GetOrdinal("email"));
                                string phoneChecker = reader.IsDBNull(reader.GetOrdinal("telefon")) ? "Unknown" : reader.GetString(reader.GetOrdinal("telefon"));
                                if (dbUsername == _username)
                                {
                                    MessageBox.Show("Altceva", "Numele de utilizator exista deja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    connection.Close();
                                    return;
                                }
                                if (emailChecker == _email)
                                {
                                    MessageBox.Show("Email existent", "Va rog utilizati o alte adresa de email valida");
                                    return;
                                }
                                if(phoneChecker == _phone)
                                {
                                    MessageBox.Show("Numar de telefon existent", "Va rog utilizati un alt numar de telefon");
                                    return;
                                }
                            }
                        }
                        
                        
                    }
                    string count = @"SELECT COUNT(*) FROM Utilizatori;";
                    using (var command = new SqliteCommand(count, connection))
                    {
                        _id = Convert.ToInt32(command.ExecuteScalar()) + 1;
                    }
                       
                }
            }

            

           

            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                string insert = "INSERT INTO Utilizatori VALUES(@id, @first_name, @last_name," +
                    "@username, @age, @role, @email, @phone, @password);";
                try
                {
                    using (SqliteCommand command = new SqliteCommand(insert, connection))
                    {
                        command.Parameters.AddWithValue("@id", _id);
                        command.Parameters.AddWithValue("@first_name", _first_name);
                        command.Parameters.AddWithValue("@last_name", _last_name);
                        command.Parameters.AddWithValue("@username", _username);
                        command.Parameters.AddWithValue("@age", _age);
                        command.Parameters.AddWithValue("@role", "user");
                        command.Parameters.AddWithValue("@email", _email);
                        command.Parameters.AddWithValue("@phone", _phone);
                        command.Parameters.AddWithValue("@password", _password);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ceva cu baza de date\n", ex);
                }
                finally
                {
                    connection.Close();
                }

            }

            MessageBox.Show("Succes", "V-ati inregistrat cu succes, veti fi redirectionat la pagina de Log In", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _mainForm.SetState(new LogInState(_mainForm));
        }
    }
}
