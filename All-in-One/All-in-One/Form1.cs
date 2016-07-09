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
using System.Reflection;
using System.Globalization;
using System.IO;

namespace All_in_One
{
    public partial class Form1 : Form
    {
        //11111111111111
        //string aktualneUmiestnenie2 = System.Reflection.Assembly.GetExecutingAssembly().Location; // zjištění  umístění souboru
        string aktualneUmiestnenie = System.Reflection.Assembly.GetExecutingAssembly().Location; // zjištění  umístění souboru  
        //string aktualneUmiestnenie = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        WebClient wc = new WebClient();

        private readonly string Version = "1.0.0.0";

        public string getVersion()
        {
            return Version;
        }
        //111111111111111
        public Form1()
        {
            InitializeComponent();
        }
        //222222222222
        private void btnCheckUpdate_Click(object sender, EventArgs e)
        {
            //Úprava cesty
            //string aktualneUmiestnenie2 = aktualneUmiestnenie.Remove(aktualneUmiestnenie.Length - 14);
            //string aktualneUmiestnenie3 = aktualneUmiestnenie2.Replace("/", "\"");
            //string aktualneUmiestnenie4 = aktualneUmiestnenie3 + "A";
            //MessageBox.Show(aktualneUmiestnenie4);
            //Úprava cesty - Koniec

            //Základne Info
            string URL = "http://dcser.eu/allinone/";
            string appName = "All-in-One.exe";
            string serverVersion;
            string serverVersionName = "Version.txt";
            //Základne Info - Koniec

            //Zistenie verzie zo servera
            WebRequest req = WebRequest.Create(URL + serverVersionName);
            WebResponse res = req.GetResponse();
            Stream str = res.GetResponseStream();
            StreamReader tr = new StreamReader(str);
            serverVersion = tr.ReadLine();
            //Zistenie verzie zo servera - Koniec

            //Porovnanie verzii
            if(getVersion() != serverVersion)
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChange;
                wc.DownloadFileCompleted += wc_DownloadFileComplete;
                wc.DownloadFileAsync(new Uri("http://dcser.eu/allinone/All-in-One.exe"), @aktualneUmiestnenie + "All-in-One.exe");
            }
            else
            {
                MessageBox.Show("Máte aktuálnu verziu");
            }
        }

        private void wc_DownloadProgressChange(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBarDownload.Value = e.ProgressPercentage;
        }

        private void wc_DownloadFileComplete(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Stiahnuté !");
        }
        //2222222222222
        private void button1_Click(object sender, EventArgs e)
        {
            double A_d = double.Parse(txtA.Text);
            double B_d = double.Parse(txtB.Text);
            double C_d = double.Parse(txtC.Text);
            double vysledok_d = 4 * A_d;
            txtVysledok.Text = vysledok_d.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double A_d = double.Parse(txtA.Text);
            double B_d = double.Parse(txtB.Text);
            double C_d = double.Parse(txtC.Text);
            double vysledok_d = A_d * A_d;
            txtVysledok.Text = vysledok_d.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double A_d = double.Parse(txtA.Text);
            double B_d = double.Parse(txtB.Text);
            double C_d = double.Parse(txtC.Text);
            double vysledok_d = (2 * A_d) + (2 * B_d);
            txtVysledok.Text = vysledok_d.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double A_d = double.Parse(txtA.Text);
            double B_d = double.Parse(txtB.Text);
            double C_d = double.Parse(txtC.Text);
            double vysledok_d = A_d * B_d;
            txtVysledok.Text = vysledok_d.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double A_d = double.Parse(txtA.Text);
            double B_d = double.Parse(txtB.Text);
            double C_d = double.Parse(txtC.Text);
            double vysledok_d = A_d + B_d + C_d;
            txtVysledok.Text = vysledok_d.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double A_d = double.Parse(txtA.Text);
            double B_d = double.Parse(txtB.Text);
            double C_d = double.Parse(txtC.Text);
            double vysledok_d = (A_d * B_d) / 2;
            txtVysledok.Text = vysledok_d.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double A_d = double.Parse(txtA.Text);
            double B_d = double.Parse(txtB.Text);
            double C_d = double.Parse(txtC.Text);
            double vysledok_d = 6 * A_d * A_d;
            txtVysledok.Text = vysledok_d.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double A_d = double.Parse(txtA.Text);
            double B_d = double.Parse(txtB.Text);
            double C_d = double.Parse(txtC.Text);
            double vysledok_d = A_d * A_d * A_d;
            txtVysledok.Text = vysledok_d.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double A_d = double.Parse(txtA.Text);
            double B_d = double.Parse(txtB.Text);
            double C_d = double.Parse(txtC.Text);
            double vysledok_d = 2 * (A_d * B_d + B_d * C_d + C_d * A_d);
            txtVysledok.Text = vysledok_d.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double A_d = double.Parse(txtA.Text);
            double B_d = double.Parse(txtB.Text);
            double C_d = double.Parse(txtC.Text);
            double vysledok_d = A_d * B_d * C_d;
            txtVysledok.Text = vysledok_d.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double A_d = double.Parse(txtA.Text);
            double B_d = double.Parse(txtB.Text);
            double C_d = double.Parse(txtC.Text);
            double vysledok_d = 2 * Math.PI * A_d;
            txtVysledok.Text = vysledok_d.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double A_d = double.Parse(txtA.Text);
            double B_d = double.Parse(txtB.Text);
            double C_d = double.Parse(txtC.Text);
            double vysledok_d = Math.PI * A_d * A_d;
            txtVysledok.Text = vysledok_d.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double A_d = double.Parse(txtA.Text);
            double odmocnene_d = Math.Sqrt(A_d);
            double vysledok_d = odmocnene_d / Math.PI;
            txtVysledok.Text = vysledok_d.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double A_d = double.Parse(txtA.Text);
            double priemer_d = A_d / Math.PI;
            double vysledok_d = priemer_d / 2;
            txtVysledok.Text = vysledok_d.ToString();
        }
    }
}
