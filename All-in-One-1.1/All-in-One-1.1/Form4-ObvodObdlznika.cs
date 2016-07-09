using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_in_One_1._1
{
    public partial class Form4_ObvodObdlznika : Form
    {
        public Form4_ObvodObdlznika()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A_d = double.Parse(textBox1.Text);
            double B_d = double.Parse(textBox2.Text);
            double vysledok_d = (2 * A_d) + (2 * B_d);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
        }
    }
}
