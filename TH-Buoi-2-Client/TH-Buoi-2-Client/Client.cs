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
namespace TH_Buoi_2_Client
{
    public partial class Client : Form
    {
        Socket TH_Buoi_2;
        Socket TH_Buoi_2_Client;
        IPEndPoint ipserver;
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            TH_Buoi_2  = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ipserver = new IPEndPoint(IPAddress.Any, 1234);
            TH_Buoi_2.Bind(ipserver);
            TH_Buoi_2.Listen(5);
            TH_Buoi_2_Client = TH_Buoi_2.Accept();
            byte[] data = new byte[1024];
            TH_Buoi_2_Client.Receive(data);
            Listbox.Items.Add("Server: " + Encoding.ASCII.GetString(data));
        }

        private void BtnConn_Click(object sender, EventArgs e)
        {
            ipserver = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            TH_Buoi_2_Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            TH_Buoi_2_Client.Connect(ipserver);
        }

        private void BtnSendClient_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1024];
            data = Encoding.ASCII.GetBytes(txtboxMessageClient.Text);
            Listbox.Items.Add("Server: " + txtboxMessageClient.Text);
            txtboxMessageClient.Text = "";
        }
    }
}
