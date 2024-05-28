namespace proiect_2024
{
    partial class ViewAdmin
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
            this.buttonViewAdaugaManager = new System.Windows.Forms.Button();
            this.buttonViewStergeUtilizator = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxDetaliiUtilizatori = new System.Windows.Forms.ListBox();
            this.buttonRefreshAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxDetaliiRezervari = new System.Windows.Forms.ListBox();
            this.buttonStergereRezervare = new System.Windows.Forms.Button();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(1362, 18);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(77, 31);
            this.buttonLogOut.TabIndex = 71;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1439, 25);
            this.toolStrip1.TabIndex = 70;
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
            this.menuPrincipal.Size = new System.Drawing.Size(1439, 24);
            this.menuPrincipal.TabIndex = 69;
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
            // buttonViewAdaugaManager
            // 
            this.buttonViewAdaugaManager.Location = new System.Drawing.Point(703, 236);
            this.buttonViewAdaugaManager.Margin = new System.Windows.Forms.Padding(2);
            this.buttonViewAdaugaManager.Name = "buttonViewAdaugaManager";
            this.buttonViewAdaugaManager.Size = new System.Drawing.Size(104, 28);
            this.buttonViewAdaugaManager.TabIndex = 78;
            this.buttonViewAdaugaManager.Text = "Adauga Manager";
            this.buttonViewAdaugaManager.UseVisualStyleBackColor = true;
            this.buttonViewAdaugaManager.Click += new System.EventHandler(this.buttonViewAdaugaManager_Click);
            // 
            // buttonViewStergeUtilizator
            // 
            this.buttonViewStergeUtilizator.Location = new System.Drawing.Point(703, 288);
            this.buttonViewStergeUtilizator.Margin = new System.Windows.Forms.Padding(2);
            this.buttonViewStergeUtilizator.Name = "buttonViewStergeUtilizator";
            this.buttonViewStergeUtilizator.Size = new System.Drawing.Size(104, 28);
            this.buttonViewStergeUtilizator.TabIndex = 77;
            this.buttonViewStergeUtilizator.Text = "Sterge Utilizator";
            this.buttonViewStergeUtilizator.UseVisualStyleBackColor = true;
            this.buttonViewStergeUtilizator.Click += new System.EventHandler(this.buttonViewStergeUtilizator_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(819, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Detalii Utilizatori";
            // 
            // listBoxDetaliiUtilizatori
            // 
            this.listBoxDetaliiUtilizatori.FormattingEnabled = true;
            this.listBoxDetaliiUtilizatori.Location = new System.Drawing.Point(822, 99);
            this.listBoxDetaliiUtilizatori.Name = "listBoxDetaliiUtilizatori";
            this.listBoxDetaliiUtilizatori.Size = new System.Drawing.Size(605, 420);
            this.listBoxDetaliiUtilizatori.TabIndex = 75;
            // 
            // buttonRefreshAll
            // 
            this.buttonRefreshAll.Location = new System.Drawing.Point(652, 99);
            this.buttonRefreshAll.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefreshAll.Name = "buttonRefreshAll";
            this.buttonRefreshAll.Size = new System.Drawing.Size(104, 28);
            this.buttonRefreshAll.TabIndex = 74;
            this.buttonRefreshAll.Text = "Reimprospatare";
            this.buttonRefreshAll.UseVisualStyleBackColor = true;
            this.buttonRefreshAll.Click += new System.EventHandler(this.buttonRefreshAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Detalii Rezervari";
            // 
            // listBoxDetaliiRezervari
            // 
            this.listBoxDetaliiRezervari.FormattingEnabled = true;
            this.listBoxDetaliiRezervari.Location = new System.Drawing.Point(12, 99);
            this.listBoxDetaliiRezervari.Name = "listBoxDetaliiRezervari";
            this.listBoxDetaliiRezervari.Size = new System.Drawing.Size(558, 420);
            this.listBoxDetaliiRezervari.TabIndex = 72;
            // 
            // buttonStergereRezervare
            // 
            this.buttonStergereRezervare.Location = new System.Drawing.Point(575, 265);
            this.buttonStergereRezervare.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStergereRezervare.Name = "buttonStergereRezervare";
            this.buttonStergereRezervare.Size = new System.Drawing.Size(104, 28);
            this.buttonStergereRezervare.TabIndex = 79;
            this.buttonStergereRezervare.Text = "Sterge Rezervare";
            this.buttonStergereRezervare.UseVisualStyleBackColor = true;
            this.buttonStergereRezervare.Click += new System.EventHandler(this.buttonStergereRezervare_Click);
            // 
            // ViewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 531);
            this.Controls.Add(this.buttonStergereRezervare);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.buttonViewAdaugaManager);
            this.Controls.Add(this.buttonViewStergeUtilizator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxDetaliiUtilizatori);
            this.Controls.Add(this.buttonRefreshAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDetaliiRezervari);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewAdmin";
            this.Text = "Admin";
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
        private System.Windows.Forms.Button buttonViewAdaugaManager;
        private System.Windows.Forms.Button buttonViewStergeUtilizator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxDetaliiUtilizatori;
        private System.Windows.Forms.Button buttonRefreshAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxDetaliiRezervari;
        private System.Windows.Forms.Button buttonStergereRezervare;
    }
}