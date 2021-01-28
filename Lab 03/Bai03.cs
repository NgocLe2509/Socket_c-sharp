using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_03
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }
        
        private void btClose_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void btOpenTCPServer_Click(object sender, EventArgs e)
        {
            Bai03_tcpServer tcpServer = new Bai03_tcpServer();
            tcpServer.Show();
            btOpenTCPClient.Enabled = true;
        }

        private void btOpenTCPClient_Click(object sender, EventArgs e)
        {
            Bai03_tcpClient tcpClient = new Bai03_tcpClient();
            tcpClient.Show();
        }
    }
}
