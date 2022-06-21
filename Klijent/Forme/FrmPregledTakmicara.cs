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

namespace Klijent.Forme
{
    public partial class FrmPregledTakmicara : Form
    {
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
            PrikazTakmicaraController.Instance.PretraziTakmicare(txtPretragaTakmicara.Text);
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
                    PrikazTakmicaraController.Instance.AzurirajTakmicara(red.DataBoundItem);
                    BtnPretraziTakmicara_Click(sender, e);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Niste izabrali nijednog takmicara!");
            }
        }
    }
}
