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

namespace FileDowndloader
{
    public partial class Form1 : Form
    {
        WebClient wc = new WebClient();

        string ciel = "D:\\";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChange;
                wc.DownloadFileAsync(new Uri("http://localhost/All-in-One.exe"), ciel+"All-in-One.exe");
            }
        }

        private void wc_DownloadProgressChange(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
    }
}
