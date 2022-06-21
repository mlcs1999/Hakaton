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
    public partial class FrmKreiranjeTakmicenja : Form
    {

        bool izmena;
        public FrmKreiranjeTakmicenja(bool izmena)
        {
            InitializeComponent();
            this.izmena = izmena;
        }

        private void FrmKreiranjeTakmicenja_Load(object sender, EventArgs e)
        {

        }
    }
}
