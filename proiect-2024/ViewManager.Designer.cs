namespace proiect_2024
{
    partial class ViewManager
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
            this.listBoxDetaliiRezervari = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonViewStergereRezervare = new System.Windows.Forms.Button();
            this.listBoxDetaliiCamere = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonViewStergeCamera = new System.Windows.Forms.Button();
            this.buttonViewAdaugaCamera = new System.Windows.Forms.Button();
            this.buttonViewManagerRefresh = new System.Windows.Forms.Button();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(1141, 18);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(77, 31);
            this.buttonLogOut.TabIndex = 60;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1389, 25);
            this.toolStrip1.TabIndex = 59;
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
            this.menuPrincipal.Size = new System.Drawing.Size(1389, 24);
            this.menuPrincipal.TabIndex = 58;
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
            // listBoxDetaliiRezervari
            // 
            this.listBoxDetaliiRezervari.FormattingEnabled = true;
            this.listBoxDetaliiRezervari.Location = new System.Drawing.Point(0, 98);
            this.listBoxDetaliiRezervari.Name = "listBoxDetaliiRezervari";
            this.listBoxDetaliiRezervari.Size = new System.Drawing.Size(544, 420);
            this.listBoxDetaliiRezervari.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Detalii Rezervari";
            // 
            // buttonViewStergereRezervare
            // 
            this.buttonViewStergereRezervare.Location = new System.Drawing.Point(571, 382);
            this.buttonViewStergereRezervare.Margin = new System.Windows.Forms.Padding(2);
            this.buttonViewStergereRezervare.Name = "buttonViewStergereRezervare";
            this.buttonViewStergereRezervare.Size = new System.Drawing.Size(104, 28);
            this.buttonViewStergereRezervare.TabIndex = 64;
            this.buttonViewStergereRezervare.Text = "Sterge Rezervare";
            this.buttonViewStergereRezervare.UseVisualStyleBackColor = true;
            this.buttonViewStergereRezervare.Click += new System.EventHandler(this.buttonViewStergereRezervare_Click);
            // 
            // listBoxDetaliiCamere
            // 
            this.listBoxDetaliiCamere.FormattingEnabled = true;
            this.listBoxDetaliiCamere.Location = new System.Drawing.Point(817, 98);
            this.listBoxDetaliiCamere.Name = "listBoxDetaliiCamere";
            this.listBoxDetaliiCamere.Size = new System.Drawing.Size(560, 420);
            this.listBoxDetaliiCamere.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(814, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Detalii Camere";
            // 
            // buttonViewStergeCamera
            // 
            this.buttonViewStergeCamera.Location = new System.Drawing.Point(684, 180);
            this.buttonViewStergeCamera.Margin = new System.Windows.Forms.Padding(2);
            this.buttonViewStergeCamera.Name = "buttonViewStergeCamera";
            this.buttonViewStergeCamera.Size = new System.Drawing.Size(104, 28);
            this.buttonViewStergeCamera.TabIndex = 67;
            this.buttonViewStergeCamera.Text = "Sterge Camera";
            this.buttonViewStergeCamera.UseVisualStyleBackColor = true;
            this.buttonViewStergeCamera.Click += new System.EventHandler(this.buttonViewStergeCamera_Click);
            // 
            // buttonViewAdaugaCamera
            // 
            this.buttonViewAdaugaCamera.Location = new System.Drawing.Point(684, 111);
            this.buttonViewAdaugaCamera.Margin = new System.Windows.Forms.Padding(2);
            this.buttonViewAdaugaCamera.Name = "buttonViewAdaugaCamera";
            this.buttonViewAdaugaCamera.Size = new System.Drawing.Size(104, 28);
            this.buttonViewAdaugaCamera.TabIndex = 68;
            this.buttonViewAdaugaCamera.Text = "Adauga Camera";
            this.buttonViewAdaugaCamera.UseVisualStyleBackColor = true;
            this.buttonViewAdaugaCamera.Click += new System.EventHandler(this.buttonViewAdaugaCamera_Click);
            // 
            // buttonViewManagerRefresh
            // 
            this.buttonViewManagerRefresh.Location = new System.Drawing.Point(684, 251);
            this.buttonViewManagerRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonViewManagerRefresh.Name = "buttonViewManagerRefresh";
            this.buttonViewManagerRefresh.Size = new System.Drawing.Size(104, 28);
            this.buttonViewManagerRefresh.TabIndex = 69;
            this.buttonViewManagerRefresh.Text = "Reimprospatare";
            this.buttonViewManagerRefresh.UseVisualStyleBackColor = true;
            this.buttonViewManagerRefresh.Click += new System.EventHandler(this.buttonViewManagerRefresh_Click);
            // 
            // ViewManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 531);
            this.Controls.Add(this.buttonViewManagerRefresh);
            this.Controls.Add(this.buttonViewAdaugaCamera);
            this.Controls.Add(this.buttonViewStergeCamera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxDetaliiCamere);
            this.Controls.Add(this.buttonViewStergereRezervare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDetaliiRezervari);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuPrincipal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewManager";
            this.Text = "Manager";
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
        private System.Windows.Forms.ListBox listBoxDetaliiRezervari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonViewStergereRezervare;
        private System.Windows.Forms.ListBox listBoxDetaliiCamere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonViewStergeCamera;
        private System.Windows.Forms.Button buttonViewAdaugaCamera;
        private System.Windows.Forms.Button buttonViewManagerRefresh;
    }
}