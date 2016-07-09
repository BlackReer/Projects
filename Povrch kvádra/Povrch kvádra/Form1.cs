using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Povrch_kvádra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Deklarovanie premenných
            string stranaA = txtA.Text;
            string stranaB = txtB.Text;
            string stranaC = txtC.Text;
            // Premenenie premenných na float
            float stranaA_F = float.Parse(stranaA);
            float stranaB_f = float.Parse(stranaB);
            float stranaC_f = float.Parse(stranaC);
            // Výpočet povrchu a vloženie do txt. pola
            float vysledokp_F = 2 * (stranaA_F * stranaB_f + stranaB_f * stranaC_f + stranaC_f * stranaA_F);
            string vysledokp = vysledokp_F.ToString();
            txtVysledokP.Text = vysledokp;
            // Výpočet objemu a vloženie do txt. pola
            float vysledokO_F = stranaA_F * stranaB_f * stranaC_f;
            string vysledokO = vysledokO_F.ToString();
            txtvysledokO.Text = vysledokO;
        }
    }
}
