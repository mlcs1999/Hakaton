using Klijent.Kontroleri;
using System;
using System.Windows.Forms;

namespace Klijent.Forme
{
    public partial class FrmKreiranjeTima : Form
    {
        public FrmKreiranjeTima()
        {
            InitializeComponent();
        }

        private void FrmKreiranjeTima_Load(object sender, EventArgs e)
        {
            cmbTakmicari.DataSource = KreiranjeTimaController.Instance.VratiSveTakmicare();
            dgvUnetiTakmicari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnDodajTakmicara_Click(object sender, EventArgs e)
        {
            if(cmbTakmicari.SelectedIndex > -1)
            {
                dgvUnetiTakmicari.DataSource = KreiranjeTimaController.Instance.DodajTakmicara(cmbTakmicari.SelectedItem);
            }
            
        }

        private void BtnIzbaciTakmicara_Click(object sender, EventArgs e)
        {
            try
            {
                var red = dgvUnetiTakmicari.SelectedRows[0];
                if (red != null)
                {
                    KreiranjeTimaController.Instance.ObrisiTakmicara(red.DataBoundItem);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Niste izabrali nijednog takmicara!");
            }
        }

        private void BtnSacuvajTim_Click(object sender, EventArgs e)
        {
            if(KreiranjeTimaController.Instance.ZapamtiTim(txtNazivTima.Text))
            {
                MessageBox.Show("Sistem je zapamtio tim!");
                ResetujFormu();
            }
            else
            {
                MessageBox.Show("Sistem ne moze da zapamti tim!");
            }
            
        }

        private void ResetujFormu()
        {
            txtNazivTima.Text = string.Empty;
            KreiranjeTimaController.Instance.Reset();
        }
    }
}
