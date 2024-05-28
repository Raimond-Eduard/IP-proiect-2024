namespace proiect_2024
{
    partial class LogIn
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxPasswordLogIn = new System.Windows.Forms.TextBox();
            this.textBoxUsernameLogIn = new System.Windows.Forms.TextBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.buttonSignUp = new System.Windows.Forms.Button();
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
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuPrincipal.Size = new System.Drawing.Size(1181, 30);
            this.menuPrincipal.TabIndex = 9;
            this.menuPrincipal.Text = "menuPrincipal";
            // 
            // aboutToolStripMenu
            // 
            this.aboutToolStripMenu.Name = "aboutToolStripMenu";
            this.aboutToolStripMenu.Size = new System.Drawing.Size(64, 26);
            this.aboutToolStripMenu.Text = "About";
            this.aboutToolStripMenu.Click += new System.EventHandler(this.aboutToolStripMenu_Click);
            // 
            // exitToolStripMenu
            // 
            this.exitToolStripMenu.Name = "exitToolStripMenu";
            this.exitToolStripMenu.Size = new System.Drawing.Size(47, 26);
            this.exitToolStripMenu.Text = "Exit";
            this.exitToolStripMenu.Click += new System.EventHandler(this.exitToolStripMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nu ai cont?";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(453, 229);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(67, 16);
            this.labelPassword.TabIndex = 18;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(453, 146);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(70, 16);
            this.labelUsername.TabIndex = 17;
            this.labelUsername.Text = "Username";
            // 
            // textBoxPasswordLogIn
            // 
            this.textBoxPasswordLogIn.Location = new System.Drawing.Point(456, 267);
            this.textBoxPasswordLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPasswordLogIn.Name = "textBoxPasswordLogIn";
            this.textBoxPasswordLogIn.PasswordChar = '*';
            this.textBoxPasswordLogIn.Size = new System.Drawing.Size(224, 22);
            this.textBoxPasswordLogIn.TabIndex = 16;
            // 
            // textBoxUsernameLogIn
            // 
            this.textBoxUsernameLogIn.Location = new System.Drawing.Point(456, 182);
            this.textBoxUsernameLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsernameLogIn.Name = "textBoxUsernameLogIn";
            this.textBoxUsernameLogIn.Size = new System.Drawing.Size(224, 22);
            this.textBoxUsernameLogIn.TabIndex = 15;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(508, 433);
            this.buttonLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(115, 39);
            this.buttonLogIn.TabIndex = 14;
            this.buttonLogIn.Text = "Log In";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(565, 303);
            this.buttonSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(115, 39);
            this.buttonSignUp.TabIndex = 39;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1181, 654);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxPasswordLogIn);
            this.Controls.Add(this.textBoxUsernameLogIn);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.menuPrincipal);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LogIn";
            this.Text = "Log In";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxPasswordLogIn;
        private System.Windows.Forms.TextBox textBoxUsernameLogIn;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Button buttonSignUp;
    }
}