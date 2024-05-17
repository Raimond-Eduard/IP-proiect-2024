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
            this.buttonClientModificareRezervare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxDetaliiRezervari = new System.Windows.Forms.ListBox();
            this.buttonViewAdaugaRezervare = new System.Windows.Forms.Button();
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1182, 25);
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
            this.menuPrincipal.Size = new System.Drawing.Size(1182, 28);
            this.menuPrincipal.TabIndex = 69;
            this.menuPrincipal.Text = "menuPrincipal";
            // 
            // aboutToolStripMenu
            // 
            this.aboutToolStripMenu.Name = "aboutToolStripMenu";
            this.aboutToolStripMenu.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenu.Text = "About";
            // 
            // exitToolStripMenu
            // 
            this.exitToolStripMenu.Name = "exitToolStripMenu";
            this.exitToolStripMenu.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenu.Text = "Exit";
            // 
            // buttonClientModificareRezervare
            // 
            this.buttonClientModificareRezervare.Location = new System.Drawing.Point(954, 405);
            this.buttonClientModificareRezervare.Name = "buttonClientModificareRezervare";
            this.buttonClientModificareRezervare.Size = new System.Drawing.Size(150, 34);
            this.buttonClientModificareRezervare.TabIndex = 74;
            this.buttonClientModificareRezervare.Text = "Modificare Rezervare";
            this.buttonClientModificareRezervare.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 73;
            this.label1.Text = "Detalii Rezervari";
            // 
            // listBoxDetaliiRezervari
            // 
            this.listBoxDetaliiRezervari.FormattingEnabled = true;
            this.listBoxDetaliiRezervari.ItemHeight = 16;
            this.listBoxDetaliiRezervari.Location = new System.Drawing.Point(0, 123);
            this.listBoxDetaliiRezervari.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDetaliiRezervari.Name = "listBoxDetaliiRezervari";
            this.listBoxDetaliiRezervari.Size = new System.Drawing.Size(870, 532);
            this.listBoxDetaliiRezervari.TabIndex = 72;
            // 
            // buttonViewAdaugaRezervare
            // 
            this.buttonViewAdaugaRezervare.Location = new System.Drawing.Point(954, 335);
            this.buttonViewAdaugaRezervare.Name = "buttonViewAdaugaRezervare";
            this.buttonViewAdaugaRezervare.Size = new System.Drawing.Size(150, 34);
            this.buttonViewAdaugaRezervare.TabIndex = 75;
            this.buttonViewAdaugaRezervare.Text = "Adauga Rezervare";
            this.buttonViewAdaugaRezervare.UseVisualStyleBackColor = true;
            // 
            // ViewRezervariClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.buttonViewAdaugaRezervare);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.buttonClientModificareRezervare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDetaliiRezervari);
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
        private System.Windows.Forms.Button buttonClientModificareRezervare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxDetaliiRezervari;
        private System.Windows.Forms.Button buttonViewAdaugaRezervare;
    }
}