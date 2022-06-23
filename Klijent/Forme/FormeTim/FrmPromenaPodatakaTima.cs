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
    public partial class FrmPromenaPodatakaTima : Form
    {
        public FrmPromenaPodatakaTima(int? id, string naziv, object plasmani)
        {
            InitializeComponent();
            txtTimId.Text = id.ToString();
            txtNazivTima.Text = naziv;
            dgvPlasmani.DataSource = plasmani;
            dgvPlasmani.Columns[1].Visible = false;
        }

        private void FrmPromenaPodatakaTima_Load(object sender, EventArgs e)
        {
            dgvPlasmani.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnIzmeni_Click(object sender, EventArgs e)
        {
            if(PromenaPodataTimaController.Instance.AzurirajTim(txtTimId.Text, txtNazivTima.Text))
            {
                MessageBox.Show("Sistem je zapamtio tim!");
            }
            else
            {
                MessageBox.Show("Sistem ne moze da zapamti tim!");
            }
        }
    }
}
