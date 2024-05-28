namespace proiect_2024
{
    partial class AdaugareRezervare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAdaugaRezervare = new System.Windows.Forms.Button();
            this.comboBoxTipBalcon = new System.Windows.Forms.ComboBox();
            this.comboBoxCapacitate = new System.Windows.Forms.ComboBox();
            this.comboBoxTipulCamerei = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datePickCheckIn = new System.Windows.Forms.MonthCalendar();
            this.datePickCheckOut = new System.Windows.Forms.MonthCalendar();
            this.buttonRezervari = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRezervareCautareCamera = new System.Windows.Forms.Button();
            this.listBoxAdaugareRezervare = new System.Windows.Forms.ListBox();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(1320, 26);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(77, 31);
            this.buttonLogOut.TabIndex = 64;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1408, 25);
            this.toolStrip1.TabIndex = 63;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenu,
            this.exitToolStripMenu});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuPrincipal.Size = new System.Drawing.Size(1408, 24);
            this.menuPrincipal.TabIndex = 62;
            this.menuPrincipal.Text = "menuPrincipal";
            // 
            // aboutToolStripMenu
            // 
            this.aboutToolStripMenu.Name = "aboutToolStripMenu";
            this.aboutToolStripMenu.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenu.Text = "About";
            this.aboutToolStripMenu.Click += new System.EventHandler(this.aboutToolStripMenu_Click);
            // 
            // exitToolStripMenu
            // 
            this.exitToolStripMenu.Name = "exitToolStripMenu";
            this.exitToolStripMenu.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenu.Text = "Exit";
            this.exitToolStripMenu.Click += new System.EventHandler(this.exitToolStripMenu_Click);
            // 
            // buttonAdaugaRezervare
            // 
            this.buttonAdaugaRezervare.Location = new System.Drawing.Point(363, 431);
            this.buttonAdaugaRezervare.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdaugaRezervare.Name = "buttonAdaugaRezervare";
            this.buttonAdaugaRezervare.Size = new System.Drawing.Size(168, 46);
            this.buttonAdaugaRezervare.TabIndex = 78;
            this.buttonAdaugaRezervare.Text = "Adauga Rezervare";
            this.buttonAdaugaRezervare.UseVisualStyleBackColor = true;
            this.buttonAdaugaRezervare.Click += new System.EventHandler(this.buttonAdaugaRezervare_Click);
            // 
            // comboBoxTipBalcon
            // 
            this.comboBoxTipBalcon.FormattingEnabled = true;
            this.comboBoxTipBalcon.Items.AddRange(new object[] {
            "Fara",
            "Propriu",
            "Comun"});
            this.comboBoxTipBalcon.Location = new System.Drawing.Point(452, 155);
            this.comboBoxTipBalcon.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTipBalcon.Name = "comboBoxTipBalcon";
            this.comboBoxTipBalcon.Size = new System.Drawing.Size(169, 21);
            this.comboBoxTipBalcon.TabIndex = 77;
            this.comboBoxTipBalcon.Text = "Fara";
            // 
            // comboBoxCapacitate
            // 
            this.comboBoxCapacitate.FormattingEnabled = true;
            this.comboBoxCapacitate.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBoxCapacitate.Location = new System.Drawing.Point(452, 96);
            this.comboBoxCapacitate.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCapacitate.Name = "comboBoxCapacitate";
            this.comboBoxCapacitate.Size = new System.Drawing.Size(169, 21);
            this.comboBoxCapacitate.TabIndex = 76;
            this.comboBoxCapacitate.Text = "1";
            // 
            // comboBoxTipulCamerei
            // 
            this.comboBoxTipulCamerei.FormattingEnabled = true;
            this.comboBoxTipulCamerei.Items.AddRange(new object[] {
            "Standard",
            "Deluxe",
            "Apartament"});
            this.comboBoxTipulCamerei.Location = new System.Drawing.Point(452, 41);
            this.comboBoxTipulCamerei.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTipulCamerei.Name = "comboBoxTipulCamerei";
            this.comboBoxTipulCamerei.Size = new System.Drawing.Size(169, 21);
            this.comboBoxTipulCamerei.TabIndex = 75;
            this.comboBoxTipulCamerei.Text = "Standard";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 74;
            this.label7.Text = "Tip Balcon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Capacitate (persoane)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Tipul Camerei";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Check In";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Check Out";
            // 
            // datePickCheckIn
            // 
            this.datePickCheckIn.Location = new System.Drawing.Point(204, 230);
            this.datePickCheckIn.Margin = new System.Windows.Forms.Padding(7);
            this.datePickCheckIn.Name = "datePickCheckIn";
            this.datePickCheckIn.TabIndex = 81;
            // 
            // datePickCheckOut
            // 
            this.datePickCheckOut.Location = new System.Drawing.Point(494, 230);
            this.datePickCheckOut.Margin = new System.Windows.Forms.Padding(7);
            this.datePickCheckOut.Name = "datePickCheckOut";
            this.datePickCheckOut.TabIndex = 82;
            // 
            // buttonRezervari
            // 
            this.buttonRezervari.Location = new System.Drawing.Point(0, 23);
            this.buttonRezervari.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRezervari.Name = "buttonRezervari";
            this.buttonRezervari.Size = new System.Drawing.Size(77, 31);
            this.buttonRezervari.TabIndex = 83;
            this.buttonRezervari.Text = "Rezervari";
            this.buttonRezervari.UseVisualStyleBackColor = true;
            this.buttonRezervari.Click += new System.EventHandler(this.buttonRezervari_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(312, 496);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 13);
            this.label6.TabIndex = 84;
            this.label6.Text = "***Rezervarea nu poate fi stearsa decat de catre MANAGER***";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(851, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 13);
            this.label5.TabIndex = 86;
            this.label5.Text = "Camere care se potrivesc selectiei";
            // 
            // buttonRezervareCautareCamera
            // 
            this.buttonRezervareCautareCamera.Location = new System.Drawing.Point(714, 129);
            this.buttonRezervareCautareCamera.Name = "buttonRezervareCautareCamera";
            this.buttonRezervareCautareCamera.Size = new System.Drawing.Size(106, 23);
            this.buttonRezervareCautareCamera.TabIndex = 87;
            this.buttonRezervareCautareCamera.Text = "Cauta";
            this.buttonRezervareCautareCamera.UseVisualStyleBackColor = true;
            this.buttonRezervareCautareCamera.Click += new System.EventHandler(this.buttonRezervareCautareCamera_Click);
            // 
            // listBoxAdaugareRezervare
            // 
            this.listBoxAdaugareRezervare.FormattingEnabled = true;
            this.listBoxAdaugareRezervare.Location = new System.Drawing.Point(854, 90);
            this.listBoxAdaugareRezervare.Name = "listBoxAdaugareRezervare";
            this.listBoxAdaugareRezervare.Size = new System.Drawing.Size(543, 433);
            this.listBoxAdaugareRezervare.TabIndex = 88;
            // 
            // AdaugareRezervare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 531);
            this.Controls.Add(this.listBoxAdaugareRezervare);
            this.Controls.Add(this.buttonRezervareCautareCamera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonRezervari);
            this.Controls.Add(this.datePickCheckOut);
            this.Controls.Add(this.datePickCheckIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdaugaRezervare);
            this.Controls.Add(this.comboBoxTipBalcon);
            this.Controls.Add(this.comboBoxCapacitate);
            this.Controls.Add(this.comboBoxTipulCamerei);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuPrincipal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdaugareRezervare";
            this.Text = "Adaugare Rezervare";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenu;
        private System.Windows.Forms.Button buttonAdaugaRezervare;
        private System.Windows.Forms.ComboBox comboBoxTipBalcon;
        private System.Windows.Forms.ComboBox comboBoxCapacitate;
        private System.Windows.Forms.ComboBox comboBoxTipulCamerei;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar datePickCheckIn;
        private System.Windows.Forms.MonthCalendar datePickCheckOut;
        private System.Windows.Forms.Button buttonRezervari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRezervareCautareCamera;
        private System.Windows.Forms.ListBox listBoxAdaugareRezervare;
    }
}