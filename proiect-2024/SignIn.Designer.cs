namespace proiect_2024
{
    partial class SignIn
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
            this.menuSignIn = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuSignIn = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuSignIn = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelLogIn = new System.Windows.Forms.LinkLabel();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.menuSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuSignIn
            // 
            this.menuSignIn.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuSignIn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuSignIn,
            this.exitToolStripMenuSignIn});
            this.menuSignIn.Location = new System.Drawing.Point(0, 0);
            this.menuSignIn.Name = "menuSignIn";
            this.menuSignIn.Size = new System.Drawing.Size(1149, 30);
            this.menuSignIn.TabIndex = 10;
            this.menuSignIn.Text = "menuSignIn";
            // 
            // aboutToolStripMenuSignIn
            // 
            this.aboutToolStripMenuSignIn.Name = "aboutToolStripMenuSignIn";
            this.aboutToolStripMenuSignIn.Size = new System.Drawing.Size(64, 26);
            this.aboutToolStripMenuSignIn.Text = "About";
            // 
            // exitToolStripMenuSignIn
            // 
            this.exitToolStripMenuSignIn.Name = "exitToolStripMenuSignIn";
            this.exitToolStripMenuSignIn.Size = new System.Drawing.Size(47, 26);
            this.exitToolStripMenuSignIn.Text = "Exit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nu ai cont?";
            // 
            // linkLabelLogIn
            // 
            this.linkLabelLogIn.AutoSize = true;
            this.linkLabelLogIn.Location = new System.Drawing.Point(628, 272);
            this.linkLabelLogIn.Name = "linkLabelLogIn";
            this.linkLabelLogIn.Size = new System.Drawing.Size(43, 16);
            this.linkLabelLogIn.TabIndex = 26;
            this.linkLabelLogIn.TabStop = true;
            this.linkLabelLogIn.Text = "Log In";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(447, 196);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(67, 16);
            this.labelPassword.TabIndex = 25;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(447, 113);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(70, 16);
            this.labelUsername.TabIndex = 24;
            this.labelUsername.Text = "Username";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(450, 234);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(224, 22);
            this.textBoxPassword.TabIndex = 23;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(450, 149);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(224, 22);
            this.textBoxUsername.TabIndex = 22;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Location = new System.Drawing.Point(512, 314);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(114, 40);
            this.buttonSignIn.TabIndex = 21;
            this.buttonSignIn.Text = "Sign In";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelLogIn);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.menuSignIn);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.menuSignIn.ResumeLayout(false);
            this.menuSignIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuSignIn;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuSignIn;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuSignIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelLogIn;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonSignIn;
    }
}