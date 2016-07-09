using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obsah_trojuhloníku_90stupnov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float stranaaF = float.Parse(txtStranaa.Text);
            float stranabF = float.Parse(txtStranab.Text);
            //
            float vysledok = (stranaaF * stranabF) / 2;
            txtVysledok.Text = vysledok.ToString();
        }
    }
}
