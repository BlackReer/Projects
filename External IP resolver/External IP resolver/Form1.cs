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

namespace External_IP_resolver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  GetIP GetIP = new GetIP;
            //  string s;
            // string ip = s.ToString(GetIP.IP);
            string IP = new WebClient().DownloadString("http://icanhazip.com");
            textBox1.Text = IP;
        }
    }
}
