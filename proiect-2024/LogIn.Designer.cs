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
            this.menuLogIn = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuLogIn = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuLogIn = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelSignIn = new System.Windows.Forms.LinkLabel();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.menuLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuLogIn
            // 
            this.menuLogIn.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuLogIn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuLogIn,
            this.exitToolStripMenuLogIn});
            this.menuLogIn.Location = new System.Drawing.Point(0, 0);
            this.menuLogIn.Name = "menuLogIn";
            this.menuLogIn.Size = new System.Drawing.Size(936, 28);
            this.menuLogIn.TabIndex = 9;
            this.menuLogIn.Text = "menuLogIn";
            // 
            // aboutToolStripMenuLogIn
            // 
            this.aboutToolStripMenuLogIn.Name = "aboutToolStripMenuLogIn";
            this.aboutToolStripMenuLogIn.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuLogIn.Text = "About";
            // 
            // exitToolStripMenuLogIn
            // 
            this.exitToolStripMenuLogIn.Name = "exitToolStripMenuLogIn";
            this.exitToolStripMenuLogIn.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuLogIn.Text = "Exit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ai deja cont?";
            // 
            // linkLabelSignIn
            // 
            this.linkLabelSignIn.AutoSize = true;
            this.linkLabelSignIn.Location = new System.Drawing.Point(515, 255);
            this.linkLabelSignIn.Name = "linkLabelSignIn";
            this.linkLabelSignIn.Size = new System.Drawing.Size(47, 16);
            this.linkLabelSignIn.TabIndex = 19;
            this.linkLabelSignIn.TabStop = true;
            this.linkLabelSignIn.Text = "Sign In";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(334, 179);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(67, 16);
            this.labelPassword.TabIndex = 18;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(334, 96);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(70, 16);
            this.labelUsername.TabIndex = 17;
            this.labelUsername.Text = "Username";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(337, 217);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(224, 22);
            this.textBoxPassword.TabIndex = 16;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(337, 132);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(224, 22);
            this.textBoxUsername.TabIndex = 15;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(399, 297);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(114, 40);
            this.buttonLogIn.TabIndex = 14;
            this.buttonLogIn.Text = "Log In";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(936, 431);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelSignIn);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.menuLogIn);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "LogIn";
            this.Text = "Log In";
            this.menuLogIn.ResumeLayout(false);
            this.menuLogIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuLogIn;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuLogIn;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuLogIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelSignIn;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonLogIn;
    }
}