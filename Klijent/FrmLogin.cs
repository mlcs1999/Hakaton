using Klijent.Kontroleri;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace Klijent
{
    public partial class FrmLogin : Form
    {
        LoginController loginController = new LoginController();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var message = loginController.Login(txtUsername.Text, txtPassword.Text);
            MessageBox.Show(message);

            if(message != ConfigurationManager.AppSettings["neuspesnaPrijava"] &&
               message != ConfigurationManager.AppSettings["neuspesnoPovezivanje"])
            {
                loginController.PokreniGlavnuFormu();
            }
        }
    }
}
