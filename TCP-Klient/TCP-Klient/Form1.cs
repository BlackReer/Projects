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

namespace TCP_Klient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                s.Connect(IPAddress.Parse("127.0.0.1"), 6547);
                string q = textBox1.Text;
                byte[] data = Encoding.Default.GetBytes(q);
                s.Send(data);
            }
            catch
            {
                MessageBox.Show("Nepripojené");
            }
        }
    }
}
