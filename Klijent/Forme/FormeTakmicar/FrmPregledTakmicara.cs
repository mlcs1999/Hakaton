using Klijent.Kontroleri;
using System;
using System.Windows.Forms;

namespace Klijent.Forme
{
    public partial class FrmPregledTakmicara : Form
    {
        bool izmena = false;

        public FrmPregledTakmicara()
        {
            InitializeComponent();
        }

        private void FrmPregledTakmicara_Load(object sender, EventArgs e)
        {
            dgvTakmicari.DataSource = PrikazTakmicaraController.Instance.VratiSveTakmicare();
            dgvTakmicari.Refresh();
            dgvTakmicari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void BtnPretraziTakmicara_Click(object sender, EventArgs e)
        {
            if(PrikazTakmicaraController.Instance.PretraziTakmicare(txtPretragaTakmicara.Text))
            {
                if(!izmena)
                {
                    MessageBox.Show("Sistem je nasao takmicare po zadatoj vrednosti!");
                }
            }
            else
            {
                if(!izmena)
                {
                    MessageBox.Show("Sistem ne moze da nadje takmicare po zadatoj vrednosti!");
                }
            }
            izmena = false;
        }

        private void BtnObrisiTakmicara_Click(object sender, EventArgs e)
        {
            try
            {
                var red = dgvTakmicari.SelectedRows[0];
                if (red != null)
                {
                    if(PrikazTakmicaraController.Instance.ObrisiTakmicara(red.DataBoundItem))
                    {
                        MessageBox.Show("Sistem je obrisao takmicara!");
                        BtnPretraziTakmicara_Click(sender,e);
                    }
                    else
                    {
                        MessageBox.Show("Sistem ne moze da obrise takmicara!");
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Niste izabrali nijednog takmicara!");
            }
        }

        private void BtnIzmeniTakmicara_Click(object sender, EventArgs e)
        {
            try
            {
                var red = dgvTakmicari.SelectedRows[0];
                if (red != null)
                {
                    if(PrikazTakmicaraController.Instance.AzurirajTakmicara(red.DataBoundItem) != null)
                    {
                        izmena = true;
                        BtnPretraziTakmicara_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Sistem ne moze da pronadje podatke o izabranom takmicaru!");
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Niste izabrali nijednog takmicara!");
            }
        }
    }
}
