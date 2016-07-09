using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;

namespace Updater
{
    public partial class Updater : Form
    {
        string cestaKsouboru;
        string LinkDownload;
        string cesta;
       public Updater(String[] args)
       {
          InitializeComponent();
          cesta = args[0].ToString(); //načetení parametru z upadatovaná apliakce
          string[] nameParts = cesta.Split('+'); //rozdělení parametru na cestu a link


         cestaKsouboru = nameParts[0];
         LinkDownload = nameParts[1];

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            label3.Text = cestaKsouboru;
           

          
            WebClient client = new WebClient();
            client.DownloadFileAsync(new Uri(LinkDownload), cestaKsouboru); //adresa souboru pro stažení, umístění upd. apliakce      



            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);

        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            int bity = int.Parse(e.BytesReceived.ToString());
            int celkovebity = int.Parse(e.TotalBytesToReceive.ToString());
            int kb1 = bity / 1024;
            int kb2 = celkovebity / 1024;

            label1.Text = kb1.ToString() + " Kb z " + kb2.ToString() + " Kb (" + e.ProgressPercentage.ToString() + "%)";
            progressBar2.Value = e.ProgressPercentage;



            if (kb1 == kb2)
            {
                DialogResult dr = MessageBox.Show("Aplikace byla úspěšně aktualizována.\r Chcete aplikaci znovu spustit ?", "Aktualizace proběhla úspěšně !", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                  Process.Start(label3.Text);
                Application.Exit();
            }

        }



    }
}

