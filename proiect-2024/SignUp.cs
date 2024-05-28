/**************************************************************************
 *                                                                        *
 *  File:        SignUp.cs                                                *
 *  Copyright:   (c) 2024, Butnaru Raimond-Eduard,			              *
 *			   Maieczki Petronela-Sînziana,			                      *
 *			   Lupu Andreea-Sabina,				                          *
 *			   Guriuc Vlad-Ionuț                                          *
 *  E-mail:                                                               *
 *       raimond-eduard.butnaru@Student.tuiasi.ro 	                      *
 *		 petronela-sinziana.maieczki@student.tuiasi.ro		              *
 *		 andreea-sabina.lupu@student.tuiasi.ro 			                  *
 *		 vlad-ionut.guriuc@student.tuiasi.ro                              *
 *  Description:  Clasă care reprezintă formularul pentru înregistrarea   *
 *       unui nou utilizator în aplicație. Clasa este responsabilă        *
 *       pentru validarea datelor introduse de utilizator și stocarea     *
 *       acestora în baza de date, asigurând în același timp securitatea  *
 *       și integritatea informațiilor.                                   *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using Microsoft.Data.Sqlite;
//using proiect_2024.hash;
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
    /// <summary>
    /// Formularul pentru inregistrarea unui nou utilizator.
    /// </summary>
    /// <param name="_mainForm">Referinta catre formularul principal.</param>
    /// <remarks>
    /// Clasa defineste formularul pentru inregistrarea unui nou utilizator in aplicatie.
    /// </remarks>
    public partial class SignUp : Form
    {
        //state manager
        private MainForm _mainForm;

        //strategy
        private IStrategy _mailStrategy;
        private IStrategy _phoneStrategy;
        private IStrategy _ageStrategy;
        private IStrategy _usernameStrategy;

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

        /// <summary>
        /// Constructor pentru clasa SignUp.
        /// </summary>
        /// <param name="mainForm">Formularul principal al aplicatiei.</param>
        public SignUp(MainForm mainForm)
        {
            _mainForm = mainForm;

            InitializeComponent();
        }

        /// <summary>
        /// Functie pentru gestionarea evenimentului de apasare a butonului de logare.
        /// </summary>
        /// <param name="sender">Obiectul care a declansat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            _mainForm.SetState(new LogInState(_mainForm));
        }

        /// <summary>
        /// Functie pentru gestionarea evenimentului de inchidere a formularului.
        /// </summary>
        /// <param name="e">Argumentele evenimentului.</param>
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
        /// Functie pentru validarea unui nume de utilizator.
        /// </summary>
        /// <param name="username">Numele de utilizator de validat.</param>
        /// <returns>True daca numele de utilizator este valid, altfel false.</returns>
        private bool validateUsername(string username)
        {
            _usernameStrategy = new ValidateUsernameStrategy();
            return _usernameStrategy.Check(username);
        }

        /// <summary>
        /// Functie pentru validarea unui numar de telefon.
        /// </summary>
        /// <param name="phone">Numarul de telefon de validat.</param>
        /// <returns>True daca numarul de telefon este valid, altfel false.</returns>
        private bool validPhoneNumber(string phone)
        {
            _phoneStrategy = new ValidatePhoneStrategy();
            return _phoneStrategy.Check(phone);
        }

        /// <summary>
        /// Functie pentru validarea unei adrese de email.
        /// </summary>
        /// <param name="email">Adresa de email de validat.</param>
        /// <returns>True daca adresa de email este valida, altfel false.</returns>
        private bool validEmail(string email)
        {
            _mailStrategy = new ValidateEmailStrategy();
            return _mailStrategy.Check(email);
        }

        /// <summary>
        /// Functie pentru verificarea varstei utilizatorului.
        /// </summary>
        /// <param name="date">Data de nastere a utilizatorului.</param>
        /// <returns>True daca utilizatorul este major, altfel false.</returns>
        private bool checkAge(DateTime date)
        {
            _ageStrategy = new ValidateAgeStrategy();
            return _ageStrategy.Check(date.ToString());

        }

        /// <summary>
        /// Functie pentru generarea hash-ului SHA256 pentru un text dat.
        /// </summary>
        /// <param name="input">Textul pentru care se genereaza hash-ul.</param>
        /// <returns>Hash-ul SHA256 al textului dat.</returns>
        private string GetSHA256Hash(string input)
        {
            return Helpers.HashHelper.GetSHA256hash(input);
        }

        /// <summary>
        /// Functie pentru gestionarea evenimentului de apasare a butonului de inregistrare.
        /// </summary>
        /// <param name="sender">Obiectul care a declansat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            //variabile temporare pentru verificare unicitate email si numar de telefon
            


            if (textBoxPasswordSignUp.Text == null || textBoxPasswordSignUp.Text == "")
            {
                MessageBox.Show("Parola lipsa", "Introduceti o parola, nu lasati campuri necompletate");
                return;
            }
            _password = GetSHA256Hash(textBoxPasswordSignUp.Text);

            if (textBoxNumeSignUp.Text == null || textBoxNumeSignUp.Text == "")
            {
                MessageBox.Show("Nume lipsa", "Introduceti numele dumneavoastra, nu lasati campuri necompletate");
                return;

            }

            _first_name = textBoxNumeSignUp.Text;

            if (textBoxPrenumeSignUp.Text == null || textBoxPrenumeSignUp.Text == "")
            {
                MessageBox.Show("Prenume lipsa", "Introduceti prenumele dumneavoastra, nu lasati campuri necompletate");
                return;

            }

            _last_name = textBoxPrenumeSignUp.Text;

            if (textBoxTelefonSignUp.Text == null || textBoxTelefonSignUp.Text == "")
            {
                MessageBox.Show("Numar de telefon lipsa", "Introduceti numarul de telefon pentru a putea fi contactat");
                return;
            }
            else
            {
                _phone = textBoxTelefonSignUp.Text;
                if (!validPhoneNumber(_phone))
                {
                    MessageBox.Show("Nu introduceti altceva decat cifre la numarul de telefon", "Doar cifre");
                    return;
                }

            }

            if (textBoxEmailSignUp.Text == null || textBoxEmailSignUp.Text == "")
            {
                MessageBox.Show("Introduceti si adresa de email", "Email lipsa");
                return;
            }
            else
            {
                _email = textBoxEmailSignUp.Text;
                if (!validEmail(_email))
                {
                    MessageBox.Show("Introduceti o adresa de email valida", "Email invalid");
                    return;
                }
            }

            _birthDate = dataNastereSignUp.Value;
            if (!checkAge(_birthDate))
            {
                MessageBox.Show("Nu puteti crea cont daca sunteti minor", "Eroare");
                return;
            }

            _age = Helpers.AgeCalculatorHelper.calculateAge(_birthDate);

            if(_age < 18)
            {
                MessageBox.Show("Nu aveti voie sa creati cont daca sunteti minor", "Verificare varsta");
                return;
            }

            if (textBoxUsernameSignUp.Text == null || textBoxUsernameSignUp.Text == "")
            {
                MessageBox.Show("Eroare", "Introduceti un nume de utilizator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (!validateUsername(textBoxUsernameSignUp.Text))
                {
                    MessageBox.Show("Username-ul nu poate contine spatii", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
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

        private void exitToolStripMenuSignUp_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sigur vrei sa inchizi?", "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void aboutToolStripMenuSignUp_Click(object sender, EventArgs e)
        {
            string helpLocation = System.Environment.CurrentDirectory + "\\help_hotel.chm";
            Help.ShowHelp(this, helpLocation);
        }
    }
}
