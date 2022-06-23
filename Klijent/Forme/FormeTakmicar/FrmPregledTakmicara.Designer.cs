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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPregledTakmicara));
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTakmicari.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTakmicari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTakmicari.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(613, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kriterijum pretrage";
            // 
            // txtPretragaTakmicara
            // 
            this.txtPretragaTakmicara.Location = new System.Drawing.Point(615, 87);
            this.txtPretragaTakmicara.Name = "txtPretragaTakmicara";
            this.txtPretragaTakmicara.Size = new System.Drawing.Size(144, 22);
            this.txtPretragaTakmicara.TabIndex = 2;
            // 
            // btnPretraziTakmicara
            // 
            this.btnPretraziTakmicara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraziTakmicara.Location = new System.Drawing.Point(616, 126);
            this.btnPretraziTakmicara.Name = "btnPretraziTakmicara";
            this.btnPretraziTakmicara.Size = new System.Drawing.Size(144, 42);
            this.btnPretraziTakmicara.TabIndex = 3;
            this.btnPretraziTakmicara.Text = "Pretrazi";
            this.btnPretraziTakmicara.UseVisualStyleBackColor = true;
            this.btnPretraziTakmicara.Click += new System.EventHandler(this.BtnPretraziTakmicara_Click);
            // 
            // btnObrisiTakmicara
            // 
            this.btnObrisiTakmicara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiTakmicara.Location = new System.Drawing.Point(616, 293);
            this.btnObrisiTakmicara.Name = "btnObrisiTakmicara";
            this.btnObrisiTakmicara.Size = new System.Drawing.Size(144, 41);
            this.btnObrisiTakmicara.TabIndex = 4;
            this.btnObrisiTakmicara.Text = "Obrisi";
            this.btnObrisiTakmicara.UseVisualStyleBackColor = true;
            this.btnObrisiTakmicara.Click += new System.EventHandler(this.BtnObrisiTakmicara_Click);
            // 
            // btnIzmeniTakmicara
            // 
            this.btnIzmeniTakmicara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniTakmicara.Location = new System.Drawing.Point(615, 234);
            this.btnIzmeniTakmicara.Name = "btnIzmeniTakmicara";
            this.btnIzmeniTakmicara.Size = new System.Drawing.Size(144, 42);
            this.btnIzmeniTakmicara.TabIndex = 5;
            this.btnIzmeniTakmicara.Text = "Izmeni";
            this.btnIzmeniTakmicara.UseVisualStyleBackColor = true;
            this.btnIzmeniTakmicara.Click += new System.EventHandler(this.BtnIzmeniTakmicara_Click);
            // 
            // FrmPregledTakmicara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Klijent.Properties.Resources.FrmGlavna;
            this.ClientSize = new System.Drawing.Size(786, 367);
            this.Controls.Add(this.btnIzmeniTakmicara);
            this.Controls.Add(this.btnObrisiTakmicara);
            this.Controls.Add(this.btnPretraziTakmicara);
            this.Controls.Add(this.txtPretragaTakmicara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTakmicari);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPregledTakmicara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled takmicara";
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