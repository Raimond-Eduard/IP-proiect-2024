/**************************************************************************
 *                                                                        *
 *  File:        AdaugareCamera.cs                                        *
 *  Copyright:   (c) 2024, Butnaru Raimond-Eduard,			              *
 *			   Maieczki Petronela-Sînziana,			                      *
 *			   Lupu Andreea-Sabina,				                          *
 *			   Guriuc Vlad-Ionuț                                          *
 *  E-mail:                                                               *
 *       raimond-eduard.butnaru@Student.tuiasi.ro 	                      *
 *		 petronela-sinziana.maieczki@student.tuiasi.ro		              *
 *		 andreea-sabina.lupu@student.tuiasi.ro 			                  *
 *		 vlad-ionut.guriuc@student.tuiasi.ro                              *
 *  Description:  Clasă care gestionează logica pentru adăugarea unei     *
 *       camere noi în baza de date. Este responsabilă pentru             *
 *       validarea datelor introduse și inserarea unei noi camere         *
 *       în baza de date în cazul în care datele sunt corecte.            *
 *       De asemenea, oferă utilizatorului posibilitatea de a se          *
 *       deconecta și de a reveni la starea anterioară.                   *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

﻿using Microsoft.Data.Sqlite;
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
    /// <summary>
    /// Clasa AdaugareCamera gestioneaza logica pentru adaugarea unei camere noi in baza de date.
    /// </summary>
    public partial class AdaugareCamera : Form
    {
        //State
        private MainForm _mainForm;

        //Campuri private pentru validare de date si eventual inserare
        private int _numarCamera;
        private int _pret_per_noapte;
        private int _etaj;
        private string _tipCamera;
        private int _capacitate;
        private string _tipBalcon;

        //conexiune cu baza de date
        private string ConnectionString = "Data source=" + Directory.GetCurrentDirectory() + "\\hotel_db.db";//"Data Source=E:\\Facultate\\IP\\Proiect IP 2024\\proiect-2024\\hotel_db.db";

        /// <summary>
        /// Constructor pentru clasa AdaugareCamera.
        /// </summary>
        /// <param name="mainForm">Referinta catre instanta MainForm.</param>

        public AdaugareCamera(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }

        /// <summary>
        /// Metoda apelata la click pe butonul de adaugare a camerei.
        /// </summary>
        /// <param name="sender">Obiectul care a declansat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        /// <returns>Nu returneaza nimic.</returns>
        /// <remarks>
        /// Aceasta metoda valideaza datele introduse si insereaza o noua camera in baza de date daca datele sunt corecte.
        /// </remarks>
        private void buttonAdaugaCamera_Click(object sender, EventArgs e)
        {
            int maxID;
            if (textBoxNumarCamera.Text == null || textBoxNumarCamera.Text == "" || textBoxNumarEtaj.Text == "" || textBoxPretNoapte.Text == "")
            {
                MessageBox.Show("Nu lasati campuri necompletate", "Campuri necompletate");
                return;
            }
            _numarCamera = Convert.ToInt32(textBoxNumarCamera.Text);
            bool cameraExistenta = false;
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                string query = @"SELECT * FROM Camera WHERE numar_camera = @camera;";

                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@camera", _numarCamera);

                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())

                        {
                            cameraExistenta = true;
                        }
                    }
                }

                query = @"SELECT MAX(id_camera) FROM Camera;";
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    maxID = Convert.ToInt32(command.ExecuteScalar());
                }

            }
            if (cameraExistenta)
            {
                MessageBox.Show("Aceasta camera exista deja va rog sa reganditi datele", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _pret_per_noapte = Convert.ToInt32(textBoxPretNoapte.Text);
            _etaj = Convert.ToInt32(textBoxNumarEtaj.Text);
            _tipCamera = comboBoxTipulCamerei.SelectedItem.ToString();
            _tipBalcon = comboBoxTipBalcon.SelectedItem.ToString();
            _capacitate = Convert.ToInt32(comboBoxCapacitate.SelectedItem.ToString());

            try
            {
                using (SqliteConnection connection = new SqliteConnection(ConnectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO Camera VALUES(@id, @numar, @pret, @etaj, @tip_camera, @tip_balcon, @cap);";

                    using (SqliteCommand command = new SqliteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", maxID + 1);
                        command.Parameters.AddWithValue("@numar", _numarCamera);
                        command.Parameters.AddWithValue("@pret", _pret_per_noapte);
                        command.Parameters.AddWithValue("@etaj", _etaj);
                        command.Parameters.AddWithValue("@tip_camera", _tipCamera);
                        command.Parameters.AddWithValue("@tip_balcon", _tipBalcon);
                        command.Parameters.AddWithValue("@cap", _capacitate);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)

            {
                throw new Exception("Ceva nu a mers bine cu baza de date\n", ex);
            }

            MessageBox.Show("Adaugarea a avut succes", "Succes");

        }



        /// <summary>
        /// Metoda care este apelata la inchiderea formularului.
        /// </summary>
        /// <param name="e">Argumentele evenimentului de inchidere a formularului.</param>
        /// <returns>Nu returneaza nimic.</returns>
        /// <remarks>
        /// Aceasta metoda cere confirmarea utilizatorului inainte de a inchide aplicatia.
        /// </remarks>
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
        /// Metoda apelata la click pe butonul de revenire.
        /// </summary>
        /// <param name="sender">Obiectul care a declansat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        /// <returns>Nu returneaza nimic.</returns>
        /// <remarks>
        /// Aceasta metoda schimba starea aplicatiei la ManagerViewState.
        /// </remarks>

        private void buttonBack_Click(object sender, EventArgs e)
        {
            _mainForm.SetState(new ManagerViewState(_mainForm));
        }

        /// <summary>
        /// Metoda apelata la click pe butonul de deconectare.
        /// </summary>
        /// <param name="sender">Obiectul care a declansat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        /// <returns>Nu returneaza nimic.</returns>
        /// <remarks>
        /// Aceasta metoda schimba starea aplicatiei la LogInState.
        /// </remarks>

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            _mainForm.SetState(new LogInState(_mainForm));
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
