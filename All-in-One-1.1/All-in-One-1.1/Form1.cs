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

namespace All_in_One_1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2_ObvodStvorca fr = new Form2_ObvodStvorca();
            fr.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3_ObsahStvorca fr = new Form3_ObsahStvorca();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4_ObvodObdlznika fr = new Form4_ObvodObdlznika();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5_ObsahObdlznika fr = new Form5_ObsahObdlznika();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6_ObvodTrojuholnika fr = new Form6_ObvodTrojuholnika();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7_ObsahTrojuholnika fr = new Form7_ObsahTrojuholnika();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8_ObsahKocky fr = new Form8_ObsahKocky();
            fr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9_ObjemKocky fr = new Form9_ObjemKocky();
            fr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10_ObsahKvadra fr = new Form10_ObsahKvadra();
            fr.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11_ObjemKvadra fr = new Form11_ObjemKvadra();
            fr.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12_ObsahKruhu fr = new Form12_ObsahKruhu();
            fr.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13_ObsahKruhu fr = new Form13_ObsahKruhu();
            fr.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14_PolomerKruhuZObsahu fr = new Form14_PolomerKruhuZObsahu();
            fr.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5_PolomerKruhuZObvodu fr = new Form5_PolomerKruhuZObvodu();
            fr.Show();
        }

        private readonly string Version = "1.1.0.0";
        public string getVersion()
        {
            return Version;
        }
        private void btnCheckUpdate_Click(object sender, EventArgs e)
        {
            string aktualneUmiestnenie = System.Reflection.Assembly.GetExecutingAssembly().Location;
            WebClient wc = new WebClient();
            ///
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
            if (getVersion() != serverVersion)
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChange;
                wc.DownloadFileCompleted += wc_DownloadFileComplete;
                wc.DownloadFileAsync(new Uri("http://dcser.eu/allinone/All-in-One.exe"), @aktualneUmiestnenie + "All-in-One.exe");
            }
            else
            {
                MessageBox.Show("Máte aktuálnu verziu");
            }
            ///
        }
        private void wc_DownloadProgressChange(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBarDownload.Value = e.ProgressPercentage;
        }

        private void wc_DownloadFileComplete(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Stiahnuté !");
        }
    }
}
