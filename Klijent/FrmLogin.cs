using Klijent.Kontroleri;
using System;
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
            MessageBox.Show(loginController.Login(txtUsername.Text, txtPassword.Text));
        }
    }
}
