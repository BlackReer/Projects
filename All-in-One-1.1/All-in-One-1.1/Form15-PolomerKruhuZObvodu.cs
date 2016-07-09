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
    public partial class Form5_PolomerKruhuZObvodu : Form
    {
        public Form5_PolomerKruhuZObvodu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A_d = double.Parse(textBox1.Text);
            double priemer_d = A_d / Math.PI;
            double vysledok_d = priemer_d / 2;
            textBox2.Text = vysledok_d.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
        }
    }
}
