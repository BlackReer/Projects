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

namespace TCP_Server
{
    public partial class Form1 : Form
    {
        static byte[] data;
        static Socket socket;
        public Form1()
        {
            InitializeComponent();
            //
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 6547));

            socket.Listen(1);
            Socket acceptddata = socket.Accept();
            data = new byte[acceptddata.SendBufferSize];
            int j = acceptddata.Receive(data);
            byte[] adata = new byte[j];
            for (int i = 0; i < j; i++)
                adata[i] = data[i];
            string dat = Encoding.Default.GetString(adata);
            //
            textBox1.Text = dat;
        }
    }
}
