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
    public partial class FrmKreiranjeTakmicara : Form
    {
        bool izmena;
        private object tim;
        public FrmKreiranjeTakmicara(bool izmena)
        {
            InitializeComponent();
            this.izmena = izmena;
        }

        public FrmKreiranjeTakmicara(bool izmena, int takmicarId, string JMBG, string ime, string prezime, string pol, object tim)
        {
            InitializeComponent();
            this.izmena = izmena;
            if(izmena)
            {
                txtTakmicarId.Text = takmicarId.ToString();
                txtJMBG.Text = JMBG;
                txtImeTakmicara.Text = ime;
                txtPrezime.Text = prezime;
                txtPol.Text = pol;
                this.tim = tim;
            }
        }

        private void FrmKreiranjeTakmicara_Load(object sender, EventArgs e)
        {
            if(izmena)
            {
                btnKreirajTakmicara.Text = "Izmeni";
                txtTakmicarId.Enabled = false;
                var timovi = ObradaTakmicaraController.Instance.VratiSveTimove();
                cmbTim.DataSource = timovi;
                cmbTim.SelectedIndex = ObradaTakmicaraController.Instance.PostaviTim(tim, timovi);
            }
            else
            {
                label1.Visible = false;
                txtTakmicarId.Visible = false;
                label6.Visible = false;
                cmbTim.Visible = false;
            }
        }
        private void BtnKreirajTakmicara_Click(object sender, EventArgs e)
        {
            if(izmena)
            {
                if(ObradaTakmicaraController.Instance.IzmeniPodatkeTakmicara(txtTakmicarId.Text, txtJMBG.Text, txtImeTakmicara.Text, txtPrezime.Text, txtPol.Text, cmbTim.SelectedItem))
                {
                    MessageBox.Show("Sistem je zapamtio takmicara");
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da zapamti takmicara");

                }
            }
            else
            {
                if(ObradaTakmicaraController.Instance.KreirajTakmicara(txtJMBG.Text, txtImeTakmicara.Text, txtPrezime.Text, txtPol.Text))
                {
                    MessageBox.Show("Sistem je zapamtio takmicara");
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da zapamti takmicara");
                }
            }
        }


    }
}
