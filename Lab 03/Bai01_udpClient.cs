using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Lab_03
{
    public partial class Bai01_udpClient : Form
    {
        public Bai01_udpClient()
        {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(IPAddress.Parse(tbIPhost.Text), int.Parse(tbPort.Text));
            Byte[] sendBytes = Encoding.ASCII.GetBytes(tbMessage.Text);
            udpClient.Send(sendBytes, sendBytes.Length);
        }
    }
}
