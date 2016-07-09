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

namespace Trezor_1._0
{
    public partial class Form2 : Form
    {
        WebClient wc = new WebClient();
        string aktualneUmiestnenie = System.Reflection.Assembly.GetExecutingAssembly().Location;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wc.DownloadProgressChanged += wc_DownloadProgressChange;
            wc.DownloadFileCompleted += wc_DownloadFileComplete;
            wc.DownloadFileAsync(new Uri("http://vignette3.wikia.nocookie.net/gtawiki/images/4/46/Artwork-FranklinandChop-GTAV.jpg"), aktualneUmiestnenie + "Artwork - FranklinandChop - GTAV.jpg");
        }
        private void wc_DownloadProgressChange(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }
        private void wc_DownloadFileComplete(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Stiahnuté !");
        }
    }
}
