namespace Klijent.Forme.FormeTakmicenje
{
    partial class FrmUnosRezultata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnosRezultata));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrojPoena = new System.Windows.Forms.TextBox();
            this.txtRang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTimovi = new System.Windows.Forms.ComboBox();
            this.dgvRezultati = new System.Windows.Forms.DataGridView();
            this.btnUnosRezultat = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtNazivTakmicenja = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezultati)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(608, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj poena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(598, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rang";
            // 
            // txtBrojPoena
            // 
            this.txtBrojPoena.Location = new System.Drawing.Point(601, 149);
            this.txtBrojPoena.Name = "txtBrojPoena";
            this.txtBrojPoena.Size = new System.Drawing.Size(187, 22);
            this.txtBrojPoena.TabIndex = 2;
            // 
            // txtRang
            // 
            this.txtRang.Location = new System.Drawing.Point(598, 266);
            this.txtRang.Name = "txtRang";
            this.txtRang.Size = new System.Drawing.Size(190, 22);
            this.txtRang.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tim";
            // 
            // cmbTimovi
            // 
            this.cmbTimovi.FormattingEnabled = true;
            this.cmbTimovi.Location = new System.Drawing.Point(104, 56);
            this.cmbTimovi.Name = "cmbTimovi";
            this.cmbTimovi.Size = new System.Drawing.Size(121, 24);
            this.cmbTimovi.TabIndex = 5;
            // 
            // dgvRezultati
            // 
            this.dgvRezultati.AllowUserToAddRows = false;
            this.dgvRezultati.AllowUserToDeleteRows = false;
            this.dgvRezultati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezultati.Location = new System.Drawing.Point(35, 108);
            this.dgvRezultati.Name = "dgvRezultati";
            this.dgvRezultati.RowHeadersWidth = 51;
            this.dgvRezultati.RowTemplate.Height = 24;
            this.dgvRezultati.Size = new System.Drawing.Size(557, 239);
            this.dgvRezultati.TabIndex = 6;
            // 
            // btnUnosRezultat
            // 
            this.btnUnosRezultat.Location = new System.Drawing.Point(598, 313);
            this.btnUnosRezultat.Name = "btnUnosRezultat";
            this.btnUnosRezultat.Size = new System.Drawing.Size(197, 34);
            this.btnUnosRezultat.TabIndex = 7;
            this.btnUnosRezultat.Text = "Unesi rezultat za tim";
            this.btnUnosRezultat.UseVisualStyleBackColor = true;
            this.btnUnosRezultat.Click += new System.EventHandler(this.BtnUnosRezultata_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(395, 373);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(197, 34);
            this.btnSacuvaj.TabIndex = 8;
            this.btnSacuvaj.Text = "Sacuvaj rezultat";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // txtNazivTakmicenja
            // 
            this.txtNazivTakmicenja.Enabled = false;
            this.txtNazivTakmicenja.Location = new System.Drawing.Point(565, 12);
            this.txtNazivTakmicenja.Name = "txtNazivTakmicenja";
            this.txtNazivTakmicenja.Size = new System.Drawing.Size(223, 22);
            this.txtNazivTakmicenja.TabIndex = 9;
            // 
            // FrmUnosRezultata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Klijent.Properties.Resources.FrmGlavna;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNazivTakmicenja);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnUnosRezultat);
            this.Controls.Add(this.dgvRezultati);
            this.Controls.Add(this.cmbTimovi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRang);
            this.Controls.Add(this.txtBrojPoena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUnosRezultata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos rezultata";
            this.Load += new System.EventHandler(this.FrmUnosRezultata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezultati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrojPoena;
        private System.Windows.Forms.TextBox txtRang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTimovi;
        private System.Windows.Forms.DataGridView dgvRezultati;
        private System.Windows.Forms.Button btnUnosRezultat;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtNazivTakmicenja;
    }
}