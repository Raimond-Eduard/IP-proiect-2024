/**************************************************************************
 *                                                                        *
 *  File:        LogIn.cs                                                 *
 *  Copyright:   (c) 2024, Butnaru Raimond-Eduard,			              *
 *			   Maieczki Petronela-Sînziana,			                      *
 *			   Lupu Andreea-Sabina,				                          *
 *			   Guriuc Vlad-Ionuț                                          *
 *  E-mail:                                                               *
 *       raimond-eduard.butnaru@Student.tuiasi.ro 	                      *
 *		 petronela-sinziana.maieczki@student.tuiasi.ro		              *
 *		 andreea-sabina.lupu@student.tuiasi.ro 			                  *
 *		 vlad-ionut.guriuc@student.tuiasi.ro                              *
 *  Description:  Clasă care reprezintă formularul de autentificare în    *
 *       aplicație. Este responsabilă pentru verificarea și gestionarea   *
 *       credențialelor de autentificare ale utilizatorilor în baza de    *
 *       date, asigurând securitatea și integritatea datelor.             *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

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
using System.IO;
//using proiect_2024.hash;
using proiect_2024.helpers;

namespace proiect_2024
{
    /// <summary>
    /// Formularul pentru autentificare.
    /// </summary>
    public partial class LogIn : Form
    {
        private string ConnectionString = "Data source=" + Directory.GetCurrentDirectory() + "\\hotel_db.db";
        private string _ownership;
        private int _idUser;

        private MainForm _mainForm;

        /// <summary>
        /// Constructorul clasei LogIn.
        /// </summary>
        /// <param name="mainForm">Formularul principal al aplicatiei.</param>
        public LogIn(MainForm mainForm)
        {
            _mainForm = mainForm;

            InitializeComponent();
        }

        /// <summary>
        /// Metoda apelata la apasarea butonului "Sign Up", care initiaza procesul de inregistrare.
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            _mainForm.SetState(new SignUpState(_mainForm));
        }

        /// <summary>
        /// Metoda apelata la inchiderea formularului, pentru confirmarea inchiderii.
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
        /// Verifica credentialele de autentificare in baza de date.
        /// </summary>
        /// <param name="username">Numele de utilizator introdus.</param>
        /// <param name="password">Parola introdusa.</param>
        /// <returns>True daca credentialele sunt corecte, altfel False.</returns>
        /// <remarks>
        /// Aceasta metoda verifica daca perechea de nume de utilizator si parola introduse
        /// corespund cu inregistrarile din baza de date a aplicatiei. Returneaza true daca
        /// autentificarea este reusita si false in caz contrar.
        /// </remarks>
        private bool CheckForLogInCredentials(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Va rog sa introduceti un nume de utilizator si parola");
            }
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"SELECT * FROM Utilizatori;";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _idUser = reader.GetInt32(reader.GetOrdinal("id_utilizator"));
                            string dbUsername = reader.GetString(reader.GetOrdinal("username"));
                            string dbPassword = reader.GetString(reader.GetOrdinal("parola"));
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

        /// <summary>
        /// Obtine hash-ul SHA256 al unui text.
        /// </summary>
        /// <param name="input">Textul de care se doreste obtinerea hash-ului.</param>
        /// <returns>Hash-ul SHA256 al textului.</returns>
        /// <remarks>
        /// Aceasta metoda utilizeaza algoritmul SHA256 pentru a calcula hash-ul unui text dat.
        /// </remarks>
        private string GetSHA256Hash(string input)
        {
            return Helpers.HashHelper.GetSHA256hash(input);
        }

        /// <summary>
        /// Metoda apelata la apasarea butonului "Log In".
        /// </summary>
        /// <param name="sender">Obiectul care a generat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string username = textBoxUsernameLogIn.Text;
            string password = GetSHA256Hash(textBoxPasswordLogIn.Text);
            if(CheckForLogInCredentials(username, password))
            {
                UserSession.UserId = _idUser;
                //throw new Exception("Method needs to be implemented");
                //logica de logare + state pentru utilizator
                switch (_ownership){
                    case null:
                        MessageBox.Show("Utilizatorul nu are un rol sau nu a fost gasit vreun rol", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "user":
                        _mainForm.SetState(new ClientViewState(_mainForm));
                        break;
                    case "manager":
                        _mainForm.SetState(new ManagerViewState(_mainForm));
                        break;
                    case "admin":
                        _mainForm.SetState(new AdminViewState(_mainForm));
                        break;
                    default:
                        MessageBox.Show("Atat s-a putut");
                        break;
                }

            }
            else
            {
                MessageBox.Show("Daca nu ai cont dai pe Sign Up", "Nume sau parola gresite", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
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
