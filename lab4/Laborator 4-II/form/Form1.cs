using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class Form1 : Form
    {
        private localhost.WebService1 webService1 = new localhost.WebService1();
        string[] list = new string[5];
        
        public Form1()
        {
            InitializeComponent();
            list[0] = "adsd";
            list[1] = "asdasdasd";
            list[2] = "adasdasdasasds";
            list[3] = "test";
            list[4] = "testare";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lista = webService1.AfisareLista(list);
            string[] strings = lista.Split(' ');
            foreach(string s in strings)
            {
                listBox1.Items.Add(s);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string data = webService1.DataSiOra();
            labelData.Text = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(webService1.FtoC(Convert.ToDouble(textBox1.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(webService1.CtoF(Convert.ToDouble(textBox2.Text)));
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = Convert.ToString(webService1.EuroToLei(Convert.ToDouble(textBox4.Text)));
        }
    }
}
