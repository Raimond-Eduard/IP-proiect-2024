﻿using Microsoft.Data.Sqlite;
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

        //campuri ce vor fi utilizate in afisarea si eventual stergerea datelor
        private List<int> _id = new List<int>();
        private List<int> _numarCamera = new List<int>();
        private List<int> _pret_per_noapte = new List<int>();
        private List<int> _etaj = new List<int>();
        private List<string> _tip_camera = new List<string>();
        private List<string> _tip_balcon = new List<string>();
        private List<int> _numar_persoane = new List<int>();

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
                string formatted = $"ID: {_id[i], -10}; Numar: {_numarCamera[i], -10}; Pret/Noapte: {_pret_per_noapte[i], -10}; Etaj: {_etaj[i], -10}; Tip: {_tip_camera[i], -10}; " +
                    $"Balcon: {_tip_balcon[i], -10}; Nr. Persoane: {_numar_persoane[i], -10}";
                listBoxDetaliiCamere.Items.Add(formatted);
            }

        }
    }
}
