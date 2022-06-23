using Klijent.Kontroleri;
using System;
using System.Windows.Forms;

namespace Klijent.Forme
{
    public partial class FrmKreiranjeTakmicenja : Form
    {
        public FrmKreiranjeTakmicenja()
        {
            InitializeComponent();
        }

        private void FrmKreiranjeTakmicenja_Load(object sender, EventArgs e)
        {
            cmbTimovi.DataSource = KreiranjaTakmicenjaController.Instance.VratiSveTimove();
            cmbMesta.DataSource = KreiranjaTakmicenjaController.Instance.VratiSvaMesta();
            dgvTimovi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnKreirajTakmicenje_Click(object sender, EventArgs e)
        {
            if (KreiranjaTakmicenjaController.Instance.ZapamtiTakmicenje(txtNazivTakm.Text, cmbMesta.SelectedItem))
            {
                MessageBox.Show("Sistem je zapamtio takmicenje!");
                ResetujFormu();
            }
            else
            {
                MessageBox.Show("Sistem ne moze da zapamti takmicenje!");
            }
        }

        private void ResetujFormu()
        {
            txtNazivTakm.Text = string.Empty;
            KreiranjaTakmicenjaController.Instance.Reset();
        }

        private void BtnDodajTim_Click(object sender, EventArgs e)
        {
            if (cmbTimovi.SelectedIndex > -1)
            {
                dgvTimovi.DataSource = KreiranjaTakmicenjaController.Instance.DodajTim(cmbTimovi.SelectedItem);
            }
        }

        private void BtnObrisiTim_Click(object sender, EventArgs e)
        {
            try
            {
                var red = dgvTimovi.SelectedRows[0];
                if (red != null)
                {
                    KreiranjaTakmicenjaController.Instance.ObrisiTim(red.DataBoundItem);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Niste izabrali nijedan tim!");
            }
        }
    }
}
