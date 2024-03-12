using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Text = "SI";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label1.Text = "SAU";
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            label1.Text = "XOR";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(label1.Text)
            {
                case "+":
                    textBox3.Text = (Convert.ToInt32(textBox1.Text) & Convert.ToInt32(textBox2.Text)).ToString();
                    break;
                case "-":
                    textBox3.Text = (Convert.ToInt32(textBox1.Text) | Convert.ToInt32(textBox2.Text)).ToString();
                    break;
                case "*":
                    textBox3.Text = (Convert.ToInt32(textBox1.Text) ^ Convert.ToInt32(textBox2.Text)).ToString();
                    break;
                default:
                    textBox3.Text = "Error";
                    break;
            }
        }
    }
}
