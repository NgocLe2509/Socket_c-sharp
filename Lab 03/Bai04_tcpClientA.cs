using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab_03
{
    public partial class Bai04_tcpClientA : Form
    {
        Thread listen;
        bool connect = false;
        Socket client;
        string name = "";
        public Bai04_tcpClientA()
        {
            InitializeComponent();
        }

        // Mở kết nối
        public void connect_Client()
        {
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            try
            {
                client.Connect(ipep);
                string _content = "--------------- " + name + " has join us---------------";
                client.Send(serialize(_content));
                lvMess.Items.Add("Connect Successfully");
                // listen
                listen = new Thread(new ThreadStart(Received));
                listen.Start();
            }
            catch
            {
                MessageBox.Show("Không kết nối được đến server");
                btSend.Enabled = false;
                btConnect.Text = "Connect";
                tbName.Enabled = true;
                connect = false;
            }
            
        }

        // gửi
        public byte[] serialize(string mess)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(memoryStream, mess);
            return memoryStream.ToArray();
        }

        // Nhận
        public string deserialize(byte[] data)
        {
            MemoryStream memoryStream = new MemoryStream(data);
            BinaryFormatter bf = new BinaryFormatter();
            return (string)bf.Deserialize(memoryStream);
        }
        public void Received()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 10000];
                    client.Receive(data);
                    string mess = deserialize(data);
                    lvMess.Items.Add(new ListViewItem(mess));
                }
            }
            catch
            {
                string info = name + " nhận không thành công";
                MessageBox.Show(info);
            }
        }

        // đóng kết nối
        public void disconnect_Client()
        {
            string conntent = name + ": has left";
            client.Send(serialize(conntent));
            client.Close();
            this.Close();
        }
        
        //
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //
        private void btSend_Click(object sender, EventArgs e)
        {
            if (tbMess.Text != string.Empty)
            {
                string mess = name + ": " + tbMess.Text;
                client.Send(serialize(mess));
                tbMess.Clear();
            }
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            name = tbName.Text;
            if (connect == false)
            {
                if (name != "")
                {
                    connect = true;
                    btSend.Enabled = true;
                    btConnect.Text = "Disconnect";
                    tbName.Enabled = false;
                    connect_Client();
                    
                }
                else
                {
                    MessageBox.Show("Chưa nhập tên!!!");
                }
                
            }
            else
            {
                disconnect_Client();
                btSend.Enabled = false;
                btConnect.Text = "Connect";
                tbName.Enabled = true;
                connect = false;
            }
        }
    }
}
