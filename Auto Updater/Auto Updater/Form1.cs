using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Reflection;
using System.Globalization;
using System.Diagnostics;

namespace Auto_Updater
{
    public partial class Form1 : Form
    {
        string filename = System.Reflection.Assembly.GetExecutingAssembly().Location; // zjištění  umístění souboru
        public Form1()
        {
            InitializeComponent();
        }
        private void CheckForUpdated()
        {
            double aktualnaVerzia = double.Parse(Assembly.GetExecutingAssembly().GetName().Version.ToString(2), CultureInfo.InvariantCulture); // zjistí aktuální verzi programu

            WebRequest request = WebRequest.Create("http://dcser.eu/apk.txt");
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            double novaVerzia = double.Parse(reader.ReadLine(), CultureInfo.InvariantCulture);
            //Prvý riadok zo stránky

            if (novaVerzia > aktualnaVerzia)
            {
                    if (MessageBox.Show("Je dostupná nová verzia pogramu! \nPrajete si stiahnúť novú verziu?", "Nová verzia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == string Adresa = reader.ReadLine();//Druhý riadok je link
                if (NewestVersion > CurrentVersion)
                {
                    if (MessageBox.Show("Je dostupná nová verzia pogramu! \nPrajete si stiahnúť novú verziu?", "Nová verzia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {

                        Process.Start(@"Vaša cesta k Updateru", filename + "+" + Adresa);

                        Application.Exit();
                    }
                }
            }
        }
    }
}
