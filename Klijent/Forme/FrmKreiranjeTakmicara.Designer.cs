namespace Klijent.Forme
{
    partial class FrmKreiranjeTakmicara
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
            this.txtTakmicarId = new System.Windows.Forms.TextBox();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtImeTakmicara = new System.Windows.Forms.TextBox();
            this.txtPol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTim = new System.Windows.Forms.ComboBox();
            this.btnKreirajTakmicara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTakmicarId
            // 
            this.txtTakmicarId.Location = new System.Drawing.Point(192, 33);
            this.txtTakmicarId.Name = "txtTakmicarId";
            this.txtTakmicarId.Size = new System.Drawing.Size(100, 22);
            this.txtTakmicarId.TabIndex = 0;
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(192, 111);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(100, 22);
            this.txtJMBG.TabIndex = 1;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(192, 265);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 22);
            this.txtPrezime.TabIndex = 2;
            // 
            // txtImeTakmicara
            // 
            this.txtImeTakmicara.Location = new System.Drawing.Point(192, 190);
            this.txtImeTakmicara.Name = "txtImeTakmicara";
            this.txtImeTakmicara.Size = new System.Drawing.Size(100, 22);
            this.txtImeTakmicara.TabIndex = 3;
            // 
            // txtPol
            // 
            this.txtPol.Location = new System.Drawing.Point(192, 351);
            this.txtPol.Name = "txtPol";
            this.txtPol.Size = new System.Drawing.Size(100, 22);
            this.txtPol.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "TakmicarId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "JMBG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prezime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pol";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tim";
            // 
            // cmbTim
            // 
            this.cmbTim.FormattingEnabled = true;
            this.cmbTim.Location = new System.Drawing.Point(183, 410);
            this.cmbTim.Name = "cmbTim";
            this.cmbTim.Size = new System.Drawing.Size(121, 24);
            this.cmbTim.TabIndex = 11;
            // 
            // btnKreirajTakmicara
            // 
            this.btnKreirajTakmicara.Location = new System.Drawing.Point(48, 488);
            this.btnKreirajTakmicara.Name = "btnKreirajTakmicara";
            this.btnKreirajTakmicara.Size = new System.Drawing.Size(256, 31);
            this.btnKreirajTakmicara.TabIndex = 12;
            this.btnKreirajTakmicara.Text = "Kreiraj";
            this.btnKreirajTakmicara.UseVisualStyleBackColor = true;
            this.btnKreirajTakmicara.Click += new System.EventHandler(this.BtnKreirajTakmicara_Click);
            // 
            // FrmKreiranjeTakmicara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 590);
            this.Controls.Add(this.btnKreirajTakmicara);
            this.Controls.Add(this.cmbTim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPol);
            this.Controls.Add(this.txtImeTakmicara);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.txtTakmicarId);
            this.Name = "FrmKreiranjeTakmicara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKreiranjeTakmicara";
            this.Load += new System.EventHandler(this.FrmKreiranjeTakmicara_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTakmicarId;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtImeTakmicara;
        private System.Windows.Forms.TextBox txtPol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTim;
        private System.Windows.Forms.Button btnKreirajTakmicara;
    }
}