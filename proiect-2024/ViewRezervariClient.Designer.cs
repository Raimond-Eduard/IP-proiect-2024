namespace proiect_2024
{
    partial class ViewRezervariClient
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
            this.buttonClientRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxDetaliiRezervari = new System.Windows.Forms.ListBox();
            this.buttonViewAdaugaRezervare = new System.Windows.Forms.Button();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(1107, 11);
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
            this.toolStrip1.Size = new System.Drawing.Size(1184, 25);
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
            this.menuPrincipal.Size = new System.Drawing.Size(1184, 24);
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
            // buttonClientRefresh
            // 
            this.buttonClientRefresh.Location = new System.Drawing.Point(1027, 319);
            this.buttonClientRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClientRefresh.Name = "buttonClientRefresh";
            this.buttonClientRefresh.Size = new System.Drawing.Size(112, 28);
            this.buttonClientRefresh.TabIndex = 74;
            this.buttonClientRefresh.Text = "Reimprospatare";
            this.buttonClientRefresh.UseVisualStyleBackColor = true;
            this.buttonClientRefresh.Click += new System.EventHandler(this.buttonClientRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Detalii Rezervari";
            // 
            // listBoxDetaliiRezervari
            // 
            this.listBoxDetaliiRezervari.FormattingEnabled = true;
            this.listBoxDetaliiRezervari.Location = new System.Drawing.Point(0, 100);
            this.listBoxDetaliiRezervari.Name = "listBoxDetaliiRezervari";
            this.listBoxDetaliiRezervari.Size = new System.Drawing.Size(948, 433);
            this.listBoxDetaliiRezervari.TabIndex = 72;
            // 
            // buttonViewAdaugaRezervare
            // 
            this.buttonViewAdaugaRezervare.Location = new System.Drawing.Point(1027, 262);
            this.buttonViewAdaugaRezervare.Margin = new System.Windows.Forms.Padding(2);
            this.buttonViewAdaugaRezervare.Name = "buttonViewAdaugaRezervare";
            this.buttonViewAdaugaRezervare.Size = new System.Drawing.Size(112, 28);
            this.buttonViewAdaugaRezervare.TabIndex = 75;
            this.buttonViewAdaugaRezervare.Text = "Adauga Rezervare";
            this.buttonViewAdaugaRezervare.UseVisualStyleBackColor = true;
            this.buttonViewAdaugaRezervare.Click += new System.EventHandler(this.buttonViewAdaugaRezervare_Click);
            // 
            // ViewRezervariClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.buttonViewAdaugaRezervare);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.buttonClientRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDetaliiRezervari);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewRezervariClient";
            this.Text = "Rezervari";
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
        private System.Windows.Forms.Button buttonClientRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxDetaliiRezervari;
        private System.Windows.Forms.Button buttonViewAdaugaRezervare;
    }
}