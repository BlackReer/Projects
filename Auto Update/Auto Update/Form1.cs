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
using System.IO;

namespace Auto_Update
{
    public partial class Form1 : Form
    {
        private readonly string Version = "1.0.0.0";

        public string getVersion()
        {
            return Version;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog1.FileName);
            }
        }

        public void ChechForUpdate()
        {
            //--Základné info
            string URL = "http://localhost/";
            string appName = "All-in-One.exe";
            string serverVersion;
            string serverVersionName = "Version.txt";
            //

            //--Zistenie verzie na servery
            WebRequest req = WebRequest.Create(URL + serverVersionName);
            WebResponse res = req.GetResponse();
            Stream str = res.GetResponseStream();
            StreamReader tr = new StreamReader(str);
            serverVersion = tr.ReadLine();
            //

            if(getVersion() != serverVersion)
            {
                //All-in-One
                WebClient client = new WebClient();
                byte[] appdata = client.DownloadData(URL + appName);

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = File.Create(saveFileDialog1.FileName))
                    {
                        fs.Write(appdata, 0, appdata.Length);
                        MessageBox.Show("Súbor:\n" + saveFileDialog1.FileName + "\bol uložený");
                    }
                }

            }
            else
            {
                MessageBox.Show("Máte najnovšiu verziu!");
            }
        }

    }
}
