using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    public partial class Form1 : Form
    {
        Socket server;
        EndPoint remote;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3456);
            remote = (EndPoint)ipe;
        }

        private void btnKeo_Click(object sender, EventArgs e)
        {
            txtSelection.Text = "Keo";
            byte[] sendData = Encoding.ASCII.GetBytes("1");

            server.SendTo(sendData, remote);
            byte[] receiveData = new byte[20];

            server.ReceiveFrom(receiveData, ref remote);
            txtResult.Text = Encoding.ASCII.GetString(receiveData);
        }

        private void btnBao_Click(object sender, EventArgs e)
        {
            txtSelection.Text = "Bao";
            byte[] sendData = Encoding.ASCII.GetBytes("2");

            server.SendTo(sendData, remote);
            byte[] receiveData = new byte[20];

            server.ReceiveFrom(receiveData, ref remote);
            txtResult.Text = Encoding.ASCII.GetString(receiveData);
        }

        private void btnBua_Click(object sender, EventArgs e)
        {
            txtSelection.Text = "Bua";
            byte[] sendData = Encoding.ASCII.GetBytes("0");

            server.SendTo(sendData, remote);
            byte[] receiveData = new byte[20];

            server.ReceiveFrom(receiveData, ref remote);
            txtResult.Text = Encoding.ASCII.GetString(receiveData);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.Close();
        }
    }
}
