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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab_03
{
    public partial class Bai04_tcpServer : Form
    {
        string sendData = "";
        Socket server;
        List<Socket> clientList;
        public Bai04_tcpServer()
        {
            InitializeComponent();
        }

        // Mở kết nối
        public void listenThread()
        {
            while (true)
            {
                server.Listen(10);
                Socket client = server.Accept();
                clientList.Add(client);
                Thread recv = new Thread(Received);
                recv.Start(client);
            }
        }
        public void StartUnsafeThread()
        {
            clientList = new List<Socket>();
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 8080);
            server.Bind(ipep);
            lvMess.Items.Add("Waiting Client Accept..............");
            // listen
            Thread listen = new Thread(listenThread);
            listen.Start();
        }

        // gửi
        public byte[] serialize(string mess)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(memoryStream, mess);
            return memoryStream.ToArray();
        }
        public void send(string data)
        {
            foreach (Socket item in clientList)
            {
                item.Send(serialize(data));
            }
        }

        // Nhận
        public string deserialize(byte[] data)
        {
            MemoryStream memoryStream = new MemoryStream(data);
            BinaryFormatter bf = new BinaryFormatter();
            return (string)bf.Deserialize(memoryStream);
        }
        public void Received(Object obj)
        {
            Socket client = (Socket)obj;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 10000];
                    client.Receive(data);
                    sendData = deserialize(data);
                    lvMess.Items.Add(new ListViewItem(sendData));
                    send(sendData);
                }
            }
            catch
            {
                MessageBox.Show("Nhận không thành công");
            }
        }

        // đóng kết nối
        public void disconnect_Client()
        {
            server.Close();
        }

        //
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //

        private void btListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
            btListen.Enabled = false;
        }
    }
}
