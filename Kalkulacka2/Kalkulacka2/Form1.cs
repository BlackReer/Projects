using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulacka2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            long cislo1default = 0;
            txtcislo1.Text = cislo1default.ToString();
            long cislo2default = 0;
            txtcislo2.Text = cislo1default.ToString();
            long cislo3default = 0;
            txtcislo3.Text = cislo1default.ToString();
        }

        private void bntp_Click(object sender, EventArgs e)
        {
            // long cislo1default = 0;
            // txtcislo1.Text = cislo1default.ToString();
            long cislo1 = long.Parse(txtcislo1.Text);
            long cislo2 = long.Parse(txtcislo2.Text);
            long cislo3 = long.Parse(txtcislo3.Text);
            long vysledok = cislo1 + cislo2 + cislo3;
            txtvysledok.Text = vysledok.ToString();
        }

        private void btnm_Click(object sender, EventArgs e)
        {
            long cislo1 = long.Parse(txtcislo1.Text);
            long cislo2 = long.Parse(txtcislo2.Text);
            long cislo3 = long.Parse(txtcislo3.Text);
            long vysledok = cislo1 - cislo2 - cislo3;
            txtvysledok.Text = vysledok.ToString();
        }

        private void btnk_Click(object sender, EventArgs e)
        {
            long cislo1 = long.Parse(txtcislo1.Text);
            long cislo2 = long.Parse(txtcislo2.Text);
            long cislo3 = long.Parse(txtcislo3.Text);
            long vysledok = cislo1 * cislo2 * cislo3;
            txtvysledok.Text = vysledok.ToString();
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            long cislo1 = long.Parse(txtcislo1.Text);
            long cislo2 = long.Parse(txtcislo2.Text);
            long vysledok = cislo1 / cislo2;
            txtvysledok.Text = vysledok.ToString();
        }
    }
}
