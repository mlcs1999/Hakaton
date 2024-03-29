﻿using System;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        private Server server;

        public FrmServer()
        {
            server = new Server();

            InitializeComponent();

            btnStop.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread nit = new Thread(server.Start);
            nit.IsBackground = true;
            nit.Start();
            txtServer.Text = "Server je pokrenut!";

            btnStop.Enabled = true;
            btnStart.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            server.Stop();
            txtServer.Text = "Server je prekinut!";
            btnStop.Enabled = false;
            btnStart.Enabled = true;
        }
    }
}
