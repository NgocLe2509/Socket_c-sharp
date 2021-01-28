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
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btClientA.Enabled = true;
            btServer.Enabled = false;
            Bai04_tcpServer server = new Bai04_tcpServer();
            server.Show();
        }
        int count = 0;
        private void btClientA_Click(object sender, EventArgs e)
        { 
            if(count <= 10)
            {
                Bai04_tcpClientA clientA = new Bai04_tcpClientA();
                clientA.Show();
                count++;
            }
            else
            {
                MessageBox.Show("Chỉ mở tối đâ 10 client");
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
