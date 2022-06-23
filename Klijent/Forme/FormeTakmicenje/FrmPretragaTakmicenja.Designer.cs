namespace Klijent.Forme.FormeTakmicenje
{
    partial class FrmPretragaTakmicenja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPretragaTakmicenja));
            this.dgvTakmicenja = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnUnosRezultata = new System.Windows.Forms.Button();
            this.txtNazivTakm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakmicenja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTakmicenja
            // 
            this.dgvTakmicenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTakmicenja.Location = new System.Drawing.Point(12, 47);
            this.dgvTakmicenja.Name = "dgvTakmicenja";
            this.dgvTakmicenja.RowHeadersWidth = 51;
            this.dgvTakmicenja.RowTemplate.Height = 24;
            this.dgvTakmicenja.Size = new System.Drawing.Size(554, 340);
            this.dgvTakmicenja.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(605, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.Location = new System.Drawing.Point(608, 147);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(155, 42);
            this.btnPretrazi.TabIndex = 2;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.BtnPretrazi_Click);
            // 
            // btnUnosRezultata
            // 
            this.btnUnosRezultata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnosRezultata.Location = new System.Drawing.Point(608, 344);
            this.btnUnosRezultata.Name = "btnUnosRezultata";
            this.btnUnosRezultata.Size = new System.Drawing.Size(155, 43);
            this.btnUnosRezultata.TabIndex = 3;
            this.btnUnosRezultata.Text = "UnosRezultata";
            this.btnUnosRezultata.UseVisualStyleBackColor = true;
            this.btnUnosRezultata.Click += new System.EventHandler(this.BtnUnosRezultata_Click);
            // 
            // txtNazivTakm
            // 
            this.txtNazivTakm.Location = new System.Drawing.Point(608, 99);
            this.txtNazivTakm.Name = "txtNazivTakm";
            this.txtNazivTakm.Size = new System.Drawing.Size(155, 22);
            this.txtNazivTakm.TabIndex = 4;
            // 
            // FrmPretragaTakmicenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Klijent.Properties.Resources.FrmGlavna;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNazivTakm);
            this.Controls.Add(this.btnUnosRezultata);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTakmicenja);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPretragaTakmicenja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga takmicenja";
            this.Load += new System.EventHandler(this.FrmPretragaTakmicenja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakmicenja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTakmicenja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnUnosRezultata;
        private System.Windows.Forms.TextBox txtNazivTakm;
    }
}