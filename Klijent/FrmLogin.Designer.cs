namespace Klijent
{
    partial class FrmLogin
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(25, 45);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 17);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(29, 137);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(28, 83);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(160, 22);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(28, 171);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(160, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Silver;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogin.Location = new System.Drawing.Point(28, 247);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(160, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(435, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 341);
            this.panel1.TabIndex = 5;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Klijent.Properties.Resources.FrmLogin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 341);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel1;
    }
}

