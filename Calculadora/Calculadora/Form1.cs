using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double n1, n2, re;
        string ope;

        public Form1()
        {
            InitializeComponent();
        }
        private void Button14_Click(object sender, EventArgs e)
        {
            ope = "*";
            n1 = double.Parse(barra.Text);
            barra.Clear();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            barra.Text = barra.Text + "7";
        }
        private void Button16_Click(object sender, EventArgs e)
        {
            ope = "%";
            n1 = double.Parse(barra.Text);
            barra.Clear();
        }
        private void B8_Click(object sender, EventArgs e)
        {
            barra.Text = barra.Text + "8";
        }
        private void B9_Click(object sender, EventArgs e)
        {
            barra.Text = barra.Text + "9";
        }
        private void B4_Click(object sender, EventArgs e)
        {
            barra.Text = barra.Text + "4";
        }
        private void B5_Click(object sender, EventArgs e)
        {
            barra.Text = barra.Text + "5";
        }
        private void B6_Click(object sender, EventArgs e)
        {
            barra.Text = barra.Text + "6";
        }
        private void B1_Click(object sender, EventArgs e)
        {
            barra.Text = barra.Text + "1";
        }
        private void B2_Click(object sender, EventArgs e)
        {
            barra.Text = barra.Text + "2";
        }
        private void B3_Click(object sender, EventArgs e)
        {
            barra.Text = barra.Text + "3";
        }
        private void Bp_Click(object sender, EventArgs e)
        {
            barra.Text = barra.Text + ".";
        }
        private void Bs_Click(object sender, EventArgs e)
        {
            ope = "+";
            n1 = double.Parse(barra.Text);
            barra.Clear();
        }
        private void Br_Click(object sender, EventArgs e)
        {
            ope = "-";
            n1 = double.Parse(barra.Text);
            barra.Clear();
        }

        private void Bd_Click(object sender, EventArgs e)
        {
            ope = "/";
            n1 = double.Parse(barra.Text);
            barra.Clear();
        }

        private void Bi_Click(object sender, EventArgs e)
        {
            n2 = double.Parse(barra.Text);
            if (ope=="+")
            {
                re = n1 + n2;
                barra.Text = re.ToString();
            }
            else if (ope=="-")
            {
                re = n1 - n2;
                barra.Text = re.ToString();
            }
            else if (ope == "*")
            {
                re = n1 * n2;
                barra.Text = re.ToString();
            }
            else if (ope == "/")
            {
                re = n1 / n2;
                barra.Text = re.ToString();
            }
            else if (ope == "%")
            {
                re = n1 /100 * n2;
                barra.Text = re.ToString();
            }
        }
        private void Bce_Click(object sender, EventArgs e)
        {
            if (barra.Text.Length == 1)
            {
                barra.Text = "";
            }
            else
            {
                barra.Text = barra.Text.Substring(0, barra.Text.Length - 1);
            }
        }
        private void B0_Click(object sender, EventArgs e)
        {
            barra.Text = barra.Text + "0";
        }

        private void Bc_Click(object sender, EventArgs e)
        {
            barra.Clear();
        }
    }
}
