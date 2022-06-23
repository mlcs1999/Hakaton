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
    public partial class FrmPretragaTima : Form
    {
        bool izmena = false;
        public FrmPretragaTima()
        {
            InitializeComponent();
        }

        private void FrmPretragaTima_Load(object sender, EventArgs e)
        {
            dgvTimovi.DataSource = PretragaTimovaController.Instance.UcitajTimove();
            dgvTimovi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnPretraziTimove_Click(object sender, EventArgs e)
        {
            if(PretragaTimovaController.Instance.TraziTimove(txtNazivTima.Text))
            {
                if (!izmena)
                {
                    MessageBox.Show("Sistem je nasao timove po zadatoj vrednosti!");
                }
                
            }
            else
            {
                if(!izmena)
                {
                    MessageBox.Show("Sistem ne moze da nadje timove po zadatoj vrednosti!");
                }
                
            }
            izmena = false;
        }

        private void BtnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                var red = dgvTimovi.SelectedRows[0];
                if (red != null)
                {
                    if(PretragaTimovaController.Instance.OtvoreniFormuZaIzmenu(red.DataBoundItem) != null)
                    {
                        izmena = true;
                        BtnPretraziTimove_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Sistem ne moze da pronadje podatke o izabranom timu!");
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Niste izabrali nijedan tim!");
            }
        }
    }
}
