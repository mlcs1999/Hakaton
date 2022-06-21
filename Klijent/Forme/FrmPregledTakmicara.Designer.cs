namespace Klijent.Forme
{
    partial class FrmPregledTakmicara
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
            this.dgvTakmicari = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretragaTakmicara = new System.Windows.Forms.TextBox();
            this.btnPretraziTakmicara = new System.Windows.Forms.Button();
            this.btnObrisiTakmicara = new System.Windows.Forms.Button();
            this.btnIzmeniTakmicara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakmicari)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTakmicari
            // 
            this.dgvTakmicari.AllowUserToAddRows = false;
            this.dgvTakmicari.AllowUserToDeleteRows = false;
            this.dgvTakmicari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTakmicari.Location = new System.Drawing.Point(23, 46);
            this.dgvTakmicari.Name = "dgvTakmicari";
            this.dgvTakmicari.RowHeadersWidth = 51;
            this.dgvTakmicari.RowTemplate.Height = 24;
            this.dgvTakmicari.Size = new System.Drawing.Size(575, 288);
            this.dgvTakmicari.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(612, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kriterijum pretrage";
            // 
            // txtPretragaTakmicara
            // 
            this.txtPretragaTakmicara.Location = new System.Drawing.Point(615, 87);
            this.txtPretragaTakmicara.Name = "txtPretragaTakmicara";
            this.txtPretragaTakmicara.Size = new System.Drawing.Size(134, 22);
            this.txtPretragaTakmicara.TabIndex = 2;
            // 
            // btnPretraziTakmicara
            // 
            this.btnPretraziTakmicara.Location = new System.Drawing.Point(615, 138);
            this.btnPretraziTakmicara.Name = "btnPretraziTakmicara";
            this.btnPretraziTakmicara.Size = new System.Drawing.Size(134, 38);
            this.btnPretraziTakmicara.TabIndex = 3;
            this.btnPretraziTakmicara.Text = "Pretrazi";
            this.btnPretraziTakmicara.UseVisualStyleBackColor = true;
            this.btnPretraziTakmicara.Click += new System.EventHandler(this.BtnPretraziTakmicara_Click);
            // 
            // btnObrisiTakmicara
            // 
            this.btnObrisiTakmicara.Location = new System.Drawing.Point(615, 297);
            this.btnObrisiTakmicara.Name = "btnObrisiTakmicara";
            this.btnObrisiTakmicara.Size = new System.Drawing.Size(134, 37);
            this.btnObrisiTakmicara.TabIndex = 4;
            this.btnObrisiTakmicara.Text = "Obrisi";
            this.btnObrisiTakmicara.UseVisualStyleBackColor = true;
            this.btnObrisiTakmicara.Click += new System.EventHandler(this.BtnObrisiTakmicara_Click);
            // 
            // btnIzmeniTakmicara
            // 
            this.btnIzmeniTakmicara.Location = new System.Drawing.Point(615, 237);
            this.btnIzmeniTakmicara.Name = "btnIzmeniTakmicara";
            this.btnIzmeniTakmicara.Size = new System.Drawing.Size(134, 42);
            this.btnIzmeniTakmicara.TabIndex = 5;
            this.btnIzmeniTakmicara.Text = "Izmeni";
            this.btnIzmeniTakmicara.UseVisualStyleBackColor = true;
            this.btnIzmeniTakmicara.Click += new System.EventHandler(this.BtnIzmeniTakmicara_Click);
            // 
            // FrmPregledTakmicara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 367);
            this.Controls.Add(this.btnIzmeniTakmicara);
            this.Controls.Add(this.btnObrisiTakmicara);
            this.Controls.Add(this.btnPretraziTakmicara);
            this.Controls.Add(this.txtPretragaTakmicara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTakmicari);
            this.Name = "FrmPregledTakmicara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPregledTakmicara";
            this.Load += new System.EventHandler(this.FrmPregledTakmicara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakmicari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTakmicari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretragaTakmicara;
        private System.Windows.Forms.Button btnPretraziTakmicara;
        private System.Windows.Forms.Button btnObrisiTakmicara;
        private System.Windows.Forms.Button btnIzmeniTakmicara;
    }
}