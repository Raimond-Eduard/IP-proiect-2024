namespace proiect_2024
{
    partial class AdaugareCamera
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
            this.components = new System.ComponentModel.Container();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumarEtaj = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPretNoapte = new System.Windows.Forms.TextBox();
            this.textBoxNumarCamera = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBoxTipulCamerei = new System.Windows.Forms.ComboBox();
            this.comboBoxCapacitate = new System.Windows.Forms.ComboBox();
            this.comboBoxTipBalcon = new System.Windows.Forms.ComboBox();
            this.buttonAdaugaCamera = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
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
            this.menuPrincipal.Size = new System.Drawing.Size(886, 24);
            this.menuPrincipal.TabIndex = 10;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Tipul Camerei";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Etaj (numar)";
            // 
            // textBoxNumarEtaj
            // 
            this.textBoxNumarEtaj.Location = new System.Drawing.Point(433, 171);
            this.textBoxNumarEtaj.Margin = new System.Windows.Forms.Padding(2);

            this.textBoxNumarEtaj.Name = "textBoxNumarEtaj";
            this.textBoxNumarEtaj.Size = new System.Drawing.Size(169, 20);
            this.textBoxNumarEtaj.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Pret pe noapte (numar)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Numar Camera";
            // 
            // textBoxPretNoapte
            // 
            this.textBoxPretNoapte.Location = new System.Drawing.Point(433, 125);
            this.textBoxPretNoapte.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPretNoapte.Name = "textBoxPretNoapte";
            this.textBoxPretNoapte.Size = new System.Drawing.Size(169, 20);
            this.textBoxPretNoapte.TabIndex = 37;
            // 
            // textBoxNumarCamera
            // 
            this.textBoxNumarCamera.Location = new System.Drawing.Point(433, 76);
            this.textBoxNumarCamera.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumarCamera.Name = "textBoxNumarCamera";
            this.textBoxNumarCamera.Size = new System.Drawing.Size(169, 20);
            this.textBoxNumarCamera.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Capacitate (persoane)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 310);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Tip Balcon";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(886, 25);
            this.toolStrip1.TabIndex = 51;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBoxTipulCamerei
            // 
            this.comboBoxTipulCamerei.FormattingEnabled = true;
            this.comboBoxTipulCamerei.Items.AddRange(new object[] {
            "Standard",
            "Deluxe",
            "Apartament"});
            this.comboBoxTipulCamerei.Location = new System.Drawing.Point(433, 214);
            this.comboBoxTipulCamerei.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTipulCamerei.Name = "comboBoxTipulCamerei";
            this.comboBoxTipulCamerei.Size = new System.Drawing.Size(169, 21);
            this.comboBoxTipulCamerei.TabIndex = 52;
            this.comboBoxTipulCamerei.Text = "Standard";
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
            this.comboBoxCapacitate.Location = new System.Drawing.Point(433, 259);
            this.comboBoxCapacitate.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCapacitate.Name = "comboBoxCapacitate";
            this.comboBoxCapacitate.Size = new System.Drawing.Size(169, 21);
            this.comboBoxCapacitate.TabIndex = 53;
            this.comboBoxCapacitate.Text = "1";
            // 
            // comboBoxTipBalcon
            // 
            this.comboBoxTipBalcon.FormattingEnabled = true;
            this.comboBoxTipBalcon.Items.AddRange(new object[] {
            "Fara",
            "Propriu",
            "Comun"});
            this.comboBoxTipBalcon.Location = new System.Drawing.Point(433, 303);
            this.comboBoxTipBalcon.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTipBalcon.Name = "comboBoxTipBalcon";
            this.comboBoxTipBalcon.Size = new System.Drawing.Size(169, 21);
            this.comboBoxTipBalcon.TabIndex = 54;
            this.comboBoxTipBalcon.Text = "Fara";
            // 
            // buttonAdaugaCamera
            // 
            this.buttonAdaugaCamera.Location = new System.Drawing.Point(354, 378);
            this.buttonAdaugaCamera.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdaugaCamera.Name = "buttonAdaugaCamera";
            this.buttonAdaugaCamera.Size = new System.Drawing.Size(168, 46);
            this.buttonAdaugaCamera.TabIndex = 55;
            this.buttonAdaugaCamera.Text = "Adauga Camera";
            this.buttonAdaugaCamera.UseVisualStyleBackColor = true;
            this.buttonAdaugaCamera.Click += new System.EventHandler(this.buttonAdaugaCamera_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(809, 23);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(77, 31);
            this.buttonLogOut.TabIndex = 56;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(0, 23);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(77, 31);
            this.buttonBack.TabIndex = 57;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // AdaugareCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 531);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonAdaugaCamera);
            this.Controls.Add(this.comboBoxTipBalcon);
            this.Controls.Add(this.comboBoxCapacitate);
            this.Controls.Add(this.comboBoxTipulCamerei);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNumarEtaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPretNoapte);
            this.Controls.Add(this.textBoxNumarCamera);
            this.Controls.Add(this.menuPrincipal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdaugareCamera";
            this.Text = "AdaugareCamera";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumarEtaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPretNoapte;
        private System.Windows.Forms.TextBox textBoxNumarCamera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBoxTipulCamerei;
        private System.Windows.Forms.ComboBox comboBoxCapacitate;
        private System.Windows.Forms.ComboBox comboBoxTipBalcon;
        private System.Windows.Forms.Button buttonAdaugaCamera;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonBack;
    }
}