using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obvod_Obsah_kruhu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPremena_Click(object sender, EventArgs e)
        {
            string polomer = txtPolomer.Text;
            float polomer_f = float.Parse(polomer);
            //
            double obvod = 2 * Math.PI*polomer_f;
            txtObvod.Text = obvod.ToString();
            //
            double obsah = Math.PI * polomer_f * polomer_f;
            txtObsah.Text = obsah.ToString();
        }
    }
}
