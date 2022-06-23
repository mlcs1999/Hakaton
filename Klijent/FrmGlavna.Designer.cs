namespace Klijent
{
    partial class FrmGlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGlavna));
            this.btnKreiranjeTakmicara = new System.Windows.Forms.Button();
            this.btnPregledTakmicara = new System.Windows.Forms.Button();
            this.btnKreiranjeTima = new System.Windows.Forms.Button();
            this.btnPregledTimova = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKreiranjeTakmicenja = new System.Windows.Forms.Button();
            this.btnUnosRezultata = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKreiranjeTakmicara
            // 
            this.btnKreiranjeTakmicara.BackColor = System.Drawing.Color.Transparent;
            this.btnKreiranjeTakmicara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreiranjeTakmicara.Location = new System.Drawing.Point(259, 34);
            this.btnKreiranjeTakmicara.Name = "btnKreiranjeTakmicara";
            this.btnKreiranjeTakmicara.Size = new System.Drawing.Size(198, 64);
            this.btnKreiranjeTakmicara.TabIndex = 0;
            this.btnKreiranjeTakmicara.Text = "Kreiranje";
            this.btnKreiranjeTakmicara.UseVisualStyleBackColor = false;
            this.btnKreiranjeTakmicara.Click += new System.EventHandler(this.BtnKreiranjeTakmicara_Click);
            // 
            // btnPregledTakmicara
            // 
            this.btnPregledTakmicara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregledTakmicara.Location = new System.Drawing.Point(543, 34);
            this.btnPregledTakmicara.Name = "btnPregledTakmicara";
            this.btnPregledTakmicara.Size = new System.Drawing.Size(191, 64);
            this.btnPregledTakmicara.TabIndex = 1;
            this.btnPregledTakmicara.Text = "Pregled";
            this.btnPregledTakmicara.UseVisualStyleBackColor = true;
            this.btnPregledTakmicara.Click += new System.EventHandler(this.BtnPregledTakmicara_Click);
            // 
            // btnKreiranjeTima
            // 
            this.btnKreiranjeTima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreiranjeTima.Location = new System.Drawing.Point(259, 151);
            this.btnKreiranjeTima.Name = "btnKreiranjeTima";
            this.btnKreiranjeTima.Size = new System.Drawing.Size(198, 64);
            this.btnKreiranjeTima.TabIndex = 2;
            this.btnKreiranjeTima.Text = "Kreiranje";
            this.btnKreiranjeTima.UseVisualStyleBackColor = true;
            this.btnKreiranjeTima.Click += new System.EventHandler(this.BtnKreiranjeTima_Click);
            // 
            // btnPregledTimova
            // 
            this.btnPregledTimova.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregledTimova.Location = new System.Drawing.Point(543, 151);
            this.btnPregledTimova.Name = "btnPregledTimova";
            this.btnPregledTimova.Size = new System.Drawing.Size(191, 64);
            this.btnPregledTimova.TabIndex = 3;
            this.btnPregledTimova.Text = "Pregled";
            this.btnPregledTimova.UseVisualStyleBackColor = true;
            this.btnPregledTimova.Click += new System.EventHandler(this.BtnPregledTimova_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Takmicar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tim";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPregledTakmicara);
            this.panel1.Controls.Add(this.btnKreiranjeTakmicara);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 111);
            this.panel1.TabIndex = 9;
            // 
            // btnKreiranjeTakmicenja
            // 
            this.btnKreiranjeTakmicenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreiranjeTakmicenja.Location = new System.Drawing.Point(259, 21);
            this.btnKreiranjeTakmicenja.Name = "btnKreiranjeTakmicenja";
            this.btnKreiranjeTakmicenja.Size = new System.Drawing.Size(198, 64);
            this.btnKreiranjeTakmicenja.TabIndex = 4;
            this.btnKreiranjeTakmicenja.Text = "Kreiranje";
            this.btnKreiranjeTakmicenja.UseVisualStyleBackColor = true;
            this.btnKreiranjeTakmicenja.Click += new System.EventHandler(this.BtnKreiranjeTakmicenja_Click);
            // 
            // btnUnosRezultata
            // 
            this.btnUnosRezultata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnosRezultata.Location = new System.Drawing.Point(543, 21);
            this.btnUnosRezultata.Name = "btnUnosRezultata";
            this.btnUnosRezultata.Size = new System.Drawing.Size(191, 64);
            this.btnUnosRezultata.TabIndex = 5;
            this.btnUnosRezultata.Text = "Unos rezultata";
            this.btnUnosRezultata.UseVisualStyleBackColor = true;
            this.btnUnosRezultata.Click += new System.EventHandler(this.BtnUnosRezultata_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Takmicenje";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnUnosRezultata);
            this.panel2.Controls.Add(this.btnKreiranjeTakmicenja);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 113);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Klijent.Properties.Resources.FrmGlavna;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnKreiranjeTima);
            this.panel3.Controls.Add(this.btnPregledTimova);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(777, 353);
            this.panel3.TabIndex = 11;
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Klijent.Properties.Resources.FrmGlavna;
            this.ClientSize = new System.Drawing.Size(777, 353);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hakaton";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKreiranjeTakmicara;
        private System.Windows.Forms.Button btnPregledTakmicara;
        private System.Windows.Forms.Button btnKreiranjeTima;
        private System.Windows.Forms.Button btnPregledTimova;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKreiranjeTakmicenja;
        private System.Windows.Forms.Button btnUnosRezultata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}