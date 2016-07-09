using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trezor_1._0
{
    public partial class Form1 : Form
    {
        string password = "3";
        public Form1()
        {
            InitializeComponent();
        }
        private void btnVstup_Click(object sender, EventArgs e)
        {
            string vstup = txtVstup.Text;
            if (vstup == password)
                {
                Form2 formDva = new Form2();
                this.Hide();
                formDva.Show();
                }
                else
                {
                MessageBox.Show("Zlé heslo !");
                return;
                }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
