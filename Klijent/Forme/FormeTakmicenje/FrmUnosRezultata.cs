using Klijent.Kontroleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.Forme.FormeTakmicenje
{
    public partial class FrmUnosRezultata : Form
    {
        private object timId;
        private string naziv;
        private object plasmani;

        public FrmUnosRezultata()
        {
            InitializeComponent();
        }

        public FrmUnosRezultata(string naziv, object plasmani)
        {
            InitializeComponent();
            this.naziv = naziv;
            this.plasmani = plasmani;
        }

        private void FrmUnosRezultata_Load(object sender, EventArgs e)
        {
            cmbTimovi.DataSource = UnosRezultataController.Instance.VratiSveTimove(plasmani);
            dgvRezultati.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtNazivTakmicenja.Text = this.naziv;
        }

        private void BtnUnosRezultata_Click(object sender, EventArgs e)
        {
            if(cmbTimovi.SelectedItem != null && !string.IsNullOrEmpty(txtBrojPoena.Text)  && !string.IsNullOrEmpty(txtRang.Text))
            {
                dgvRezultati.DataSource = UnosRezultataController.Instance.UnesiRezultat(cmbTimovi.SelectedItem, txtBrojPoena.Text, txtRang.Text, plasmani);
            }
            else
            {
                MessageBox.Show("Morate uneti sve podatke!");
            }
        }

        private void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if(UnosRezultataController.Instance.KompletniPodaciZaSveTimove())
            {
                if(UnosRezultataController.Instance.SacuvajRezultat())
                {
                    MessageBox.Show("Sistem je zapamtio rezultat takmicenja!");
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da zapamti rezultat takmicenja!");
                }
            }
            else
            {
                MessageBox.Show("Niste uneli podatke za sve timove!");
            }
            
        }

    }
}
