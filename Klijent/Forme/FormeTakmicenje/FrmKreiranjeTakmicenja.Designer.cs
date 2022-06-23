namespace Klijent.Forme
{
    partial class FrmKreiranjeTakmicenja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKreiranjeTakmicenja));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazivTakm = new System.Windows.Forms.TextBox();
            this.cmbMesta = new System.Windows.Forms.ComboBox();
            this.btnKreirajTakmicenje = new System.Windows.Forms.Button();
            this.cmbTimovi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTimovi = new System.Windows.Forms.DataGridView();
            this.btnDodajTim = new System.Windows.Forms.Button();
            this.btnObrisiTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mesto";
            // 
            // txtNazivTakm
            // 
            this.txtNazivTakm.Location = new System.Drawing.Point(122, 36);
            this.txtNazivTakm.Name = "txtNazivTakm";
            this.txtNazivTakm.Size = new System.Drawing.Size(180, 22);
            this.txtNazivTakm.TabIndex = 2;
            // 
            // cmbMesta
            // 
            this.cmbMesta.FormattingEnabled = true;
            this.cmbMesta.Location = new System.Drawing.Point(122, 105);
            this.cmbMesta.Name = "cmbMesta";
            this.cmbMesta.Size = new System.Drawing.Size(180, 24);
            this.cmbMesta.TabIndex = 3;
            // 
            // btnKreirajTakmicenje
            // 
            this.btnKreirajTakmicenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajTakmicenje.Location = new System.Drawing.Point(678, 421);
            this.btnKreirajTakmicenje.Name = "btnKreirajTakmicenje";
            this.btnKreirajTakmicenje.Size = new System.Drawing.Size(180, 48);
            this.btnKreirajTakmicenje.TabIndex = 4;
            this.btnKreirajTakmicenje.Text = "Kreiraj";
            this.btnKreirajTakmicenje.UseVisualStyleBackColor = true;
            this.btnKreirajTakmicenje.Click += new System.EventHandler(this.BtnKreirajTakmicenje_Click);
            // 
            // cmbTimovi
            // 
            this.cmbTimovi.FormattingEnabled = true;
            this.cmbTimovi.Location = new System.Drawing.Point(122, 173);
            this.cmbTimovi.Name = "cmbTimovi";
            this.cmbTimovi.Size = new System.Drawing.Size(180, 24);
            this.cmbTimovi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tim";
            // 
            // dgvTimovi
            // 
            this.dgvTimovi.AllowUserToAddRows = false;
            this.dgvTimovi.AllowUserToDeleteRows = false;
            this.dgvTimovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimovi.Location = new System.Drawing.Point(37, 257);
            this.dgvTimovi.Name = "dgvTimovi";
            this.dgvTimovi.RowHeadersWidth = 51;
            this.dgvTimovi.RowTemplate.Height = 24;
            this.dgvTimovi.Size = new System.Drawing.Size(611, 212);
            this.dgvTimovi.TabIndex = 7;
            // 
            // btnDodajTim
            // 
            this.btnDodajTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajTim.Location = new System.Drawing.Point(324, 166);
            this.btnDodajTim.Name = "btnDodajTim";
            this.btnDodajTim.Size = new System.Drawing.Size(146, 37);
            this.btnDodajTim.TabIndex = 8;
            this.btnDodajTim.Text = "Dodaj tim";
            this.btnDodajTim.UseVisualStyleBackColor = true;
            this.btnDodajTim.Click += new System.EventHandler(this.BtnDodajTim_Click);
            // 
            // btnObrisiTim
            // 
            this.btnObrisiTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiTim.Location = new System.Drawing.Point(678, 337);
            this.btnObrisiTim.Name = "btnObrisiTim";
            this.btnObrisiTim.Size = new System.Drawing.Size(180, 48);
            this.btnObrisiTim.TabIndex = 9;
            this.btnObrisiTim.Text = "Izbaci tim";
            this.btnObrisiTim.UseVisualStyleBackColor = true;
            this.btnObrisiTim.Click += new System.EventHandler(this.BtnObrisiTim_Click);
            // 
            // FrmKreiranjeTakmicenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Klijent.Properties.Resources.FrmGlavna;
            this.ClientSize = new System.Drawing.Size(870, 536);
            this.Controls.Add(this.btnObrisiTim);
            this.Controls.Add(this.btnDodajTim);
            this.Controls.Add(this.dgvTimovi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTimovi);
            this.Controls.Add(this.btnKreirajTakmicenje);
            this.Controls.Add(this.cmbMesta);
            this.Controls.Add(this.txtNazivTakm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmKreiranjeTakmicenja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreiranje hakatona";
            this.Load += new System.EventHandler(this.FrmKreiranjeTakmicenja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazivTakm;
        private System.Windows.Forms.ComboBox cmbMesta;
        private System.Windows.Forms.Button btnKreirajTakmicenje;
        private System.Windows.Forms.ComboBox cmbTimovi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTimovi;
        private System.Windows.Forms.Button btnDodajTim;
        private System.Windows.Forms.Button btnObrisiTim;
    }
}