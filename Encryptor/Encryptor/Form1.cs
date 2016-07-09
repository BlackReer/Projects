using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryptor
{
    public partial class Form1 : Form
    {
        string[] polePismenka = new string[29];
        string[] polePismenkaR = new string[29];
        public Form1()
        {
            InitializeComponent();
            polePismenka[0] = "a";
            polePismenka[1] = "b";
            polePismenka[2] = "c";
            polePismenka[3] = "d";
            polePismenka[4] = "e";
            polePismenka[5] = "f";
            polePismenka[6] = "g";
            polePismenka[7] = "h";
            polePismenka[8] = "i";
            polePismenka[9] = "j";
            polePismenka[10] = "k";
            polePismenka[11] = "l";
            polePismenka[12] = "m";
            polePismenka[13] = "n";
            polePismenka[14] = "o";
            polePismenka[15] = "p";
            polePismenka[16] = "q";
            polePismenka[17] = "r";
            polePismenka[18] = "s";
            polePismenka[19] = "t";
            polePismenka[20] = "u";
            polePismenka[21] = "v";
            polePismenka[22] = "w";
            polePismenka[23] = "x";
            polePismenka[24] = "y";
            polePismenka[25] = "z";
            polePismenka[26] = " ";
            polePismenka[27] = ".";
            polePismenka[28] = ",";
            //
            polePismenkaR[0] = "g";
            polePismenkaR[1] = "c";
            polePismenkaR[2] = "y";
            polePismenkaR[3] = "f";
            polePismenkaR[4] = "n";
            polePismenkaR[5] = "s";
            polePismenkaR[6] = "v";
            polePismenkaR[7] = "d";
            polePismenkaR[8] = "z";
            polePismenkaR[9] = "j";
            polePismenkaR[10] = "e";
            polePismenkaR[11] = "b";
            polePismenkaR[12] = "t";
            polePismenkaR[13] = "l";
            polePismenkaR[14] = "x";
            polePismenkaR[15] = "i";
            polePismenkaR[16] = "q";
            polePismenkaR[17] = "m";
            polePismenkaR[18] = "u";
            polePismenkaR[19] = "w";
            polePismenkaR[20] = "a";
            polePismenkaR[21] = "p";
            polePismenkaR[22] = "h";
            polePismenkaR[23] = "o";
            polePismenkaR[24] = "k";
            polePismenkaR[25] = "r";
            polePismenkaR[26] = "2";
            polePismenkaR[27] = "1";
            polePismenkaR[28] = "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string veta = txtVeta.Text;
            veta = veta.ToLower();
            foreach(char c in veta)
            {
                string d = c.ToString();
                if (d == polePismenka[0])
                {
                    d = d.Replace(polePismenkaR[0]);
                }
                else
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
