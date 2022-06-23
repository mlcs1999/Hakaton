namespace Klijent.Forme
{
    partial class FrmPretragaTima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPretragaTima));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazivTima = new System.Windows.Forms.TextBox();
            this.dgvTimovi = new System.Windows.Forms.DataGridView();
            this.btnPretraziTimove = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(658, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // txtNazivTima
            // 
            this.txtNazivTima.Location = new System.Drawing.Point(661, 83);
            this.txtNazivTima.Name = "txtNazivTima";
            this.txtNazivTima.Size = new System.Drawing.Size(169, 22);
            this.txtNazivTima.TabIndex = 1;
            // 
            // dgvTimovi
            // 
            this.dgvTimovi.AllowUserToAddRows = false;
            this.dgvTimovi.AllowUserToDeleteRows = false;
            this.dgvTimovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimovi.Location = new System.Drawing.Point(37, 38);
            this.dgvTimovi.Name = "dgvTimovi";
            this.dgvTimovi.RowHeadersWidth = 51;
            this.dgvTimovi.RowTemplate.Height = 24;
            this.dgvTimovi.Size = new System.Drawing.Size(595, 287);
            this.dgvTimovi.TabIndex = 2;
            // 
            // btnPretraziTimove
            // 
            this.btnPretraziTimove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraziTimove.Location = new System.Drawing.Point(661, 131);
            this.btnPretraziTimove.Name = "btnPretraziTimove";
            this.btnPretraziTimove.Size = new System.Drawing.Size(169, 43);
            this.btnPretraziTimove.TabIndex = 3;
            this.btnPretraziTimove.Text = "Pretrazi";
            this.btnPretraziTimove.UseVisualStyleBackColor = true;
            this.btnPretraziTimove.Click += new System.EventHandler(this.BtnPretraziTimove_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(661, 282);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(169, 43);
            this.btnIzmeni.TabIndex = 4;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.BtnIzmeni_Click);
            // 
            // FrmPretragaTima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Klijent.Properties.Resources.FrmGlavna;
            this.ClientSize = new System.Drawing.Size(861, 349);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnPretraziTimove);
            this.Controls.Add(this.dgvTimovi);
            this.Controls.Add(this.txtNazivTima);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPretragaTima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga tima";
            this.Load += new System.EventHandler(this.FrmPretragaTima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazivTima;
        private System.Windows.Forms.DataGridView dgvTimovi;
        private System.Windows.Forms.Button btnPretraziTimove;
        private System.Windows.Forms.Button btnIzmeni;
    }
}