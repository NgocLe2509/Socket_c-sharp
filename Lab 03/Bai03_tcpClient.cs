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
    public partial class Bai03_tcpClient : Form
    {
        public Bai03_tcpClient()
        {
            InitializeComponent();
        }
        
        TcpClient tcpClient;
        NetworkStream ns;
        bool _connect = true;
        public void connect()
        {
            tcpClient = new TcpClient();
            IPAddress ipAddress = IPAddress.Parse(tbIP.Text);
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 8080);
            tcpClient.Connect(ipEndPoint);
            ns = tcpClient.GetStream();
            _connect = false;
        }
        public void sendData()
        {
            // Gửi DL
            Byte[] data = Encoding.ASCII.GetBytes(tbMess.Text);
            ns.Write(data, 0, data.GetLength(0));
            lvMess.Items.Add(new ListViewItem(tbMess.Text));
            data = System.Text.Encoding.ASCII.GetBytes("\n");
            ns.Write(data, 0, data.Length);
        }
        public void DisConnect()
        {
            ns.Close();
            tcpClient.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sendData();
        }

        public void Disconnect()
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes("\n");
            ns.Write(data, 0, data.Length);
            DisConnect();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            if(_connect == true)
            {
                connect();
                btSend.Enabled = true;
                btConnect.Text = "Disconnect";
            }
            else
            {
                Disconnect();
                _connect = true;
                btConnect.Text = "Connect";
                btSend.Enabled = false;
                this.Close();
            }
        }
    }
}
