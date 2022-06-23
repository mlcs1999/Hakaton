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
    public partial class FrmPretragaTakmicenja : Form
    {
        public FrmPretragaTakmicenja()
        {
            InitializeComponent();
        }

        private void FrmPretragaTakmicenja_Load(object sender, EventArgs e)
        {
            dgvTakmicenja.DataSource = PretragaTakmicenjaController.Instance.UcitajTakmicenja();
            dgvTakmicenja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnPretrazi_Click(object sender, EventArgs e)
        {
            if (PretragaTakmicenjaController.Instance.TraziTakmicenja(txtNazivTakm.Text))
            {
                    MessageBox.Show("Sistem je nasao takmicenja po zadatoj vrednosti!");
            }
            else
            {
                    MessageBox.Show("Sistem ne moze da nadje takmicenja po zadatoj vrednosti!");

            }
        }

        private void BtnUnosRezultata_Click(object sender, EventArgs e)
        {
            try
            {
                var takmicenje = dgvTakmicenja.SelectedRows[0];
                if (takmicenje != null)
                {
                    PretragaTakmicenjaController.Instance.OtvoriFormuZaUnos(takmicenje.DataBoundItem);
                }
                else
                {
                    MessageBox.Show("Niste izabrali nijedno takmicenje!");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Niste izabrali nijedno takmicenje!");
            }
            
        }
    }
}
