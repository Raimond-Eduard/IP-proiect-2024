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
            this.buttonGenerareRaport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxDetaliiRezervari = new System.Windows.Forms.ListBox();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(1081, 28);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(103, 38);
            this.buttonLogOut.TabIndex = 71;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1182, 31);
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
            this.menuPrincipal.Size = new System.Drawing.Size(1182, 30);
            this.menuPrincipal.TabIndex = 69;
            this.menuPrincipal.Text = "menuPrincipal";
            // 
            // aboutToolStripMenu
            // 
            this.aboutToolStripMenu.Name = "aboutToolStripMenu";
            this.aboutToolStripMenu.Size = new System.Drawing.Size(64, 26);
            this.aboutToolStripMenu.Text = "About";
            // 
            // exitToolStripMenu
            // 
            this.exitToolStripMenu.Name = "exitToolStripMenu";
            this.exitToolStripMenu.Size = new System.Drawing.Size(47, 26);
            this.exitToolStripMenu.Text = "Exit";
            // 
            // buttonViewAdaugaManager
            // 
            this.buttonViewAdaugaManager.Location = new System.Drawing.Point(624, 316);
            this.buttonViewAdaugaManager.Name = "buttonViewAdaugaManager";
            this.buttonViewAdaugaManager.Size = new System.Drawing.Size(138, 34);
            this.buttonViewAdaugaManager.TabIndex = 78;
            this.buttonViewAdaugaManager.Text = "Adauga Manager";
            this.buttonViewAdaugaManager.UseVisualStyleBackColor = true;
            // 
            // buttonViewStergeUtilizator
            // 
            this.buttonViewStergeUtilizator.Location = new System.Drawing.Point(624, 381);
            this.buttonViewStergeUtilizator.Name = "buttonViewStergeUtilizator";
            this.buttonViewStergeUtilizator.Size = new System.Drawing.Size(138, 34);
            this.buttonViewStergeUtilizator.TabIndex = 77;
            this.buttonViewStergeUtilizator.Text = "Sterge Utilizator";
            this.buttonViewStergeUtilizator.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(791, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 76;
            this.label2.Text = "Detalii Utilizatori";
            // 
            // listBoxDetaliiUtilizatori
            // 
            this.listBoxDetaliiUtilizatori.FormattingEnabled = true;
            this.listBoxDetaliiUtilizatori.ItemHeight = 16;
            this.listBoxDetaliiUtilizatori.Location = new System.Drawing.Point(794, 137);
            this.listBoxDetaliiUtilizatori.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDetaliiUtilizatori.Name = "listBoxDetaliiUtilizatori";
            this.listBoxDetaliiUtilizatori.Size = new System.Drawing.Size(390, 516);
            this.listBoxDetaliiUtilizatori.TabIndex = 75;
            // 
            // buttonGenerareRaport
            // 
            this.buttonGenerareRaport.Location = new System.Drawing.Point(422, 381);
            this.buttonGenerareRaport.Name = "buttonGenerareRaport";
            this.buttonGenerareRaport.Size = new System.Drawing.Size(138, 34);
            this.buttonGenerareRaport.TabIndex = 74;
            this.buttonGenerareRaport.Text = "Generare Raport";
            this.buttonGenerareRaport.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 73;
            this.label1.Text = "Detalii Rezervari";
            // 
            // listBoxDetaliiRezervari
            // 
            this.listBoxDetaliiRezervari.FormattingEnabled = true;
            this.listBoxDetaliiRezervari.ItemHeight = 16;
            this.listBoxDetaliiRezervari.Location = new System.Drawing.Point(2, 137);
            this.listBoxDetaliiRezervari.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDetaliiRezervari.Name = "listBoxDetaliiRezervari";
            this.listBoxDetaliiRezervari.Size = new System.Drawing.Size(392, 516);
            this.listBoxDetaliiRezervari.TabIndex = 72;
            // 
            // ViewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.buttonViewAdaugaManager);
            this.Controls.Add(this.buttonViewStergeUtilizator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxDetaliiUtilizatori);
            this.Controls.Add(this.buttonGenerareRaport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDetaliiRezervari);
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
        private System.Windows.Forms.Button buttonGenerareRaport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxDetaliiRezervari;
    }
}