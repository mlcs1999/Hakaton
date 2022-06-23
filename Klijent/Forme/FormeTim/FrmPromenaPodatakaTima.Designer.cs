namespace Klijent.Forme
{
    partial class FrmPromenaPodatakaTima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPromenaPodatakaTima));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimId = new System.Windows.Forms.TextBox();
            this.txtNazivTima = new System.Windows.Forms.TextBox();
            this.dgvPlasmani = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIzmeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlasmani)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "TimId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv";
            // 
            // txtTimId
            // 
            this.txtTimId.Enabled = false;
            this.txtTimId.Location = new System.Drawing.Point(137, 32);
            this.txtTimId.Name = "txtTimId";
            this.txtTimId.Size = new System.Drawing.Size(168, 22);
            this.txtTimId.TabIndex = 2;
            // 
            // txtNazivTima
            // 
            this.txtNazivTima.Location = new System.Drawing.Point(137, 101);
            this.txtNazivTima.Name = "txtNazivTima";
            this.txtNazivTima.Size = new System.Drawing.Size(168, 22);
            this.txtNazivTima.TabIndex = 3;
            // 
            // dgvPlasmani
            // 
            this.dgvPlasmani.AllowUserToAddRows = false;
            this.dgvPlasmani.AllowUserToDeleteRows = false;
            this.dgvPlasmani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlasmani.Enabled = false;
            this.dgvPlasmani.Location = new System.Drawing.Point(58, 211);
            this.dgvPlasmani.Name = "dgvPlasmani";
            this.dgvPlasmani.RowHeadersWidth = 51;
            this.dgvPlasmani.RowTemplate.Height = 24;
            this.dgvPlasmani.Size = new System.Drawing.Size(650, 210);
            this.dgvPlasmani.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Plasmani";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(327, 97);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(118, 28);
            this.btnIzmeni.TabIndex = 6;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.BtnIzmeni_Click);
            // 
            // FrmPromenaPodatakaTima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Klijent.Properties.Resources.FrmGlavna;
            this.ClientSize = new System.Drawing.Size(768, 445);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPlasmani);
            this.Controls.Add(this.txtNazivTima);
            this.Controls.Add(this.txtTimId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPromenaPodatakaTima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promena podataka tima";
            this.Load += new System.EventHandler(this.FrmPromenaPodatakaTima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlasmani)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimId;
        private System.Windows.Forms.TextBox txtNazivTima;
        private System.Windows.Forms.DataGridView dgvPlasmani;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIzmeni;
    }
}