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
using System.Threading;

namespace Lab_03
{
    public partial class Bai01_udpServer : Form
    {
        public Bai01_udpServer()
        {
            InitializeComponent();
        }
        public void serverThread()
        {
            UdpClient udpClient = new UdpClient(int.Parse(tbPort.Text));
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);
                string mess = RemoteIpEndPoint.Address.ToString() + ":" + returnData.ToString();
                ListViewItem lvi = new ListViewItem(mess);
                lwReceived.Items.Add(lvi);
            }
        }
        private void btListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
            lwReceived.Items.Add("Server: OK");
            btListen.Enabled = false;
        }
    }
}
