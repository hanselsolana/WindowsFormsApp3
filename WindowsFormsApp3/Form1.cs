using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
                    }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = txtname.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] huruf = new string[26];

            huruf[0] = "a";
            huruf[1] = "b";
            huruf[2] = "c";
            huruf[3] = "d";
            huruf[4] = "e";
            huruf[5] = "f";
            huruf[6] = "g";
            huruf[7] = "h";
            huruf[8] = "i";
            huruf[9] = "j";
            huruf[10] = "k";
            huruf[11] = "l";
            huruf[12] = "m";
            huruf[13] = "n";
            huruf[14] = "o";
            huruf[15] = "p";
            huruf[16] = "q";
            huruf[17] = "r";
            huruf[18] = "s";
            huruf[19] = "t";
            huruf[20] = "u";
            huruf[21] = "v";
            huruf[22] = "w";
            huruf[23] = "x";
            huruf[24] = "y";
            huruf[25] = "z";

            if (txtboxmenjadi.Text.ToUpper() == "a")
                txtboxhuruf.Text = huruf[0];
            else if (txtboxmenjadi.Text.ToUpper() == "b")
                txtboxhuruf.Text = huruf[1];
            else if (txtboxmenjadi.Text.ToUpper() == "c")
                txtboxhuruf.Text = huruf[2];
            else if (txtboxmenjadi.Text.ToUpper() == "d")
                txtboxhuruf.Text = huruf[3];
            else if (txtboxmenjadi.Text.ToUpper() == "e")
                txtboxhuruf.Text = huruf[4];
            else if (txtboxmenjadi.Text.ToUpper() == "f")
                txtboxhuruf.Text = huruf[5];
            else if (txtboxmenjadi.Text.ToUpper() == "g")
                txtboxhuruf.Text = huruf[6];
            else if (txtboxmenjadi.Text.ToUpper() == "h")
                txtboxhuruf.Text = huruf[7];
            else if (txtboxmenjadi.Text.ToUpper() == "i")
                txtboxhuruf.Text = huruf[8];
            else if (txtboxmenjadi.Text.ToUpper() == "j")
                txtboxhuruf.Text = huruf[9];
            else if (txtboxmenjadi.Text.ToUpper() == "k")
                txtboxhuruf.Text = huruf[10];
            else if (txtboxmenjadi.Text.ToUpper() == "l")
                txtboxhuruf.Text = huruf[11];
            else if (txtboxmenjadi.Text.ToUpper() == "m")
                txtboxhuruf.Text = huruf[12];
            else if (txtboxmenjadi.Text.ToUpper() == "n")
                txtboxhuruf.Text = huruf[13];
            else if (txtboxmenjadi.Text.ToUpper() == "o")
                txtboxhuruf.Text = huruf[14];
            else if (txtboxmenjadi.Text.ToUpper() == "p")
                txtboxhuruf.Text = huruf[15];
            else if (txtboxmenjadi.Text.ToUpper() == "q")
                txtboxhuruf.Text = huruf[16];
            else if (txtboxmenjadi.Text.ToUpper() == "r")
                txtboxhuruf.Text = huruf[17];
            else if (txtboxmenjadi.Text.ToUpper() == "s")
                txtboxhuruf.Text = huruf[18];
            else if (txtboxmenjadi.Text.ToUpper() == "t")
                txtboxhuruf.Text = huruf[19];
            else if (txtboxmenjadi.Text.ToUpper() == "u")
                txtboxhuruf.Text = huruf[20];
            else if (txtboxmenjadi.Text.ToUpper() == "v")
                txtboxhuruf.Text = huruf[21];
            else if (txtboxmenjadi.Text.ToUpper() == "w")
                txtboxhuruf.Text = huruf[22];
            else if (txtboxmenjadi.Text.ToUpper() == "x")
                txtboxhuruf.Text = huruf[23];
            else if (txtboxmenjadi.Text.ToUpper() == "y")
                txtboxhuruf.Text = huruf[24];
            else if (txtboxmenjadi.Text.ToUpper() == "z")
                txtboxhuruf.Text = huruf[25];

            for (int i=0; i < 26; i++)
            lblhasil.Text = txtboxhuruf.Text;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}


