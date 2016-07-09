using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyklusi
{
    public partial class Form1 : Form
    {
        List<string> listhraci = new List<string>();
        public Form1()
        {
            InitializeComponent();

           /* int i = 0;
            while(i<300)
            {
                listhraci.Add(" David");
                i = i + 1;
            }*/

            for(int y=0; y<300; y++)
            {
                listhraci.Add("David");
            }

            for(int x=0;x<listhraci.Count;x++)
            {
                txtHraci.Text = txtHraci.Text + listhraci[x] + Environment.NewLine;
            }


            /*int x = 0;
            while(x < listhraci.Count)
            {
                txtHraci.Text = txtHraci.Text + listhraci[x] + Environment.NewLine;
                x += 1;
                //i = i + 1;
                //i++;
            }*/
        }
    }
}
