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
namespace TH_Buoi_2
{
    public partial class Server : Form
    {
        Socket TH_Buoi_2;
        Socket TH_Buoi_2_Client;
        IPEndPoint ipserver;
        public Server()
        {
            InitializeComponent();
        }

        private void txtboxMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            string text = txtboxMessage.Text;
            Listbox.Items.Add(txtboxMessage.Text);
            txtboxMessage.Clear();
            byte[] data = new byte[1024];
            data = Encoding.ASCII.GetBytes(text);
            TH_Buoi_2_Client.Send(data);
            data = new byte[1024];
            TH_Buoi_2_Client.Receive(data);
            Listbox.Items.Add("Client: " + Encoding.ASCII.GetString(data));
        }

        private void Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TH_Buoi_2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ipserver = new IPEndPoint(IPAddress.Any, 1234);
            TH_Buoi_2.Bind(ipserver);
            TH_Buoi_2.Listen(5);
            TH_Buoi_2_Client = TH_Buoi_2.Accept();
            txtboxMessage.Text = (TH_Buoi_2_Client.RemoteEndPoint).ToString();
            byte[] data = new byte[1024];
            TH_Buoi_2_Client.Receive(data);
            Listbox.Items.Add("Client: " + Encoding.ASCII.GetString(data));
        }

    }
}
