namespace Klijent.Forme
{
    partial class FrmKreiranjeTima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKreiranjeTima));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazivTima = new System.Windows.Forms.TextBox();
            this.cmbTakmicari = new System.Windows.Forms.ComboBox();
            this.dgvUnetiTakmicari = new System.Windows.Forms.DataGridView();
            this.btnIzbaciTakmicara = new System.Windows.Forms.Button();
            this.btnDodajTakmicara = new System.Windows.Forms.Button();
            this.btnSacuvajTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnetiTakmicari)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Takmicari";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv";
            // 
            // txtNazivTima
            // 
            this.txtNazivTima.Location = new System.Drawing.Point(166, 37);
            this.txtNazivTima.Name = "txtNazivTima";
            this.txtNazivTima.Size = new System.Drawing.Size(205, 22);
            this.txtNazivTima.TabIndex = 2;
            // 
            // cmbTakmicari
            // 
            this.cmbTakmicari.FormattingEnabled = true;
            this.cmbTakmicari.Location = new System.Drawing.Point(166, 113);
            this.cmbTakmicari.Name = "cmbTakmicari";
            this.cmbTakmicari.Size = new System.Drawing.Size(205, 24);
            this.cmbTakmicari.TabIndex = 4;
            // 
            // dgvUnetiTakmicari
            // 
            this.dgvUnetiTakmicari.AllowUserToAddRows = false;
            this.dgvUnetiTakmicari.AllowUserToDeleteRows = false;
            this.dgvUnetiTakmicari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnetiTakmicari.Location = new System.Drawing.Point(38, 181);
            this.dgvUnetiTakmicari.Name = "dgvUnetiTakmicari";
            this.dgvUnetiTakmicari.RowHeadersWidth = 51;
            this.dgvUnetiTakmicari.RowTemplate.Height = 24;
            this.dgvUnetiTakmicari.Size = new System.Drawing.Size(589, 158);
            this.dgvUnetiTakmicari.TabIndex = 5;
            // 
            // btnIzbaciTakmicara
            // 
            this.btnIzbaciTakmicara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbaciTakmicara.ForeColor = System.Drawing.Color.Black;
            this.btnIzbaciTakmicara.Location = new System.Drawing.Point(633, 229);
            this.btnIzbaciTakmicara.Name = "btnIzbaciTakmicara";
            this.btnIzbaciTakmicara.Size = new System.Drawing.Size(171, 43);
            this.btnIzbaciTakmicara.TabIndex = 6;
            this.btnIzbaciTakmicara.Text = "Izbaci takmicara";
            this.btnIzbaciTakmicara.UseVisualStyleBackColor = true;
            this.btnIzbaciTakmicara.Click += new System.EventHandler(this.BtnIzbaciTakmicara_Click);
            // 
            // btnDodajTakmicara
            // 
            this.btnDodajTakmicara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajTakmicara.Location = new System.Drawing.Point(390, 107);
            this.btnDodajTakmicara.Name = "btnDodajTakmicara";
            this.btnDodajTakmicara.Size = new System.Drawing.Size(173, 37);
            this.btnDodajTakmicara.TabIndex = 7;
            this.btnDodajTakmicara.Text = "Dodaj takmicara";
            this.btnDodajTakmicara.UseVisualStyleBackColor = true;
            this.btnDodajTakmicara.Click += new System.EventHandler(this.BtnDodajTakmicara_Click);
            // 
            // btnSacuvajTim
            // 
            this.btnSacuvajTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajTim.Location = new System.Drawing.Point(633, 296);
            this.btnSacuvajTim.Name = "btnSacuvajTim";
            this.btnSacuvajTim.Size = new System.Drawing.Size(171, 43);
            this.btnSacuvajTim.TabIndex = 8;
            this.btnSacuvajTim.Text = "Sacuvaj tim";
            this.btnSacuvajTim.UseVisualStyleBackColor = true;
            this.btnSacuvajTim.Click += new System.EventHandler(this.BtnSacuvajTim_Click);
            // 
            // FrmKreiranjeTima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Klijent.Properties.Resources.FrmGlavna;
            this.ClientSize = new System.Drawing.Size(827, 384);
            this.Controls.Add(this.btnSacuvajTim);
            this.Controls.Add(this.btnDodajTakmicara);
            this.Controls.Add(this.btnIzbaciTakmicara);
            this.Controls.Add(this.dgvUnetiTakmicari);
            this.Controls.Add(this.cmbTakmicari);
            this.Controls.Add(this.txtNazivTima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmKreiranjeTima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreiranje tima";
            this.Load += new System.EventHandler(this.FrmKreiranjeTima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnetiTakmicari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazivTima;
        private System.Windows.Forms.ComboBox cmbTakmicari;
        private System.Windows.Forms.DataGridView dgvUnetiTakmicari;
        private System.Windows.Forms.Button btnIzbaciTakmicara;
        private System.Windows.Forms.Button btnDodajTakmicara;
        private System.Windows.Forms.Button btnSacuvajTim;
    }
}