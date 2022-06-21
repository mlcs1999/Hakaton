using Klijent.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
        }

        private void BtnKreiranjeTakmicara_Click(object sender, EventArgs e)
        {
            FrmKreiranjeTakmicara frm = new FrmKreiranjeTakmicara(false);
            frm.ShowDialog();
        }

        private void BtnPregledTakmicara_Click(object sender, EventArgs e)
        {
            FrmPregledTakmicara frm = new FrmPregledTakmicara();
            frm.ShowDialog();
        }

        private void BtnKreiranjeTima_Click(object sender, EventArgs e)
        {

        }

        private void BtnPregledTimova_Click(object sender, EventArgs e)
        {

        }

        private void BtnKreiranjeTakmicenja_Click(object sender, EventArgs e)
        {

        }

        private void BtnUnosRezultata_Click(object sender, EventArgs e)
        {

        }
    }
}
