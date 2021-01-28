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
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void btUDP_Client_Click(object sender, EventArgs e)
        {
            Bai01_udpClient udp_client = new Bai01_udpClient();
            udp_client.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btUDP_Client.Enabled = true;
            Bai01_udpServer udp_server = new Bai01_udpServer();
            udp_server.Show();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
