using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Enabled = false;
            listBox2.Enabled = false;
            listBox3.Enabled = false;
            string[] lines = System.IO.File.ReadAllLines("reminders.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string[] info = lines[i].Split(' ');
                    listBox1.Items.Add(info[0]);
                    listBox2.Items.Add(info[1]);
                    listBox3.Items.Add(info[2]);
            }

            SetStare(false);
        }

        private void SetStare(bool stare)
        {
            button1.Enabled = stare;
            button2.Enabled = stare;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SetStare(false);
            textBox1.Text = "";
            richTextBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            radioButton1.Checked = radioButton2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length <= 0)
            {
                MessageBox.Show("Introdu denumirea!", "Atentie!");
                textBox1.Focus();
                return;
            }
            if(dateTimePicker1.Value == null)
            {
                MessageBox.Show("Introdu data!", "Atentie!");
                dateTimePicker1.Focus();
                return;
            }
            if(richTextBox1.Text.Length <= 0)
            {
                MessageBox.Show("Introdu descrierea!", "Atentie!");
                richTextBox1.Focus();
                return;
            }
            if(!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Alege tipul!", "Atentie!");
                groupBox1.Focus();
                return;
            }
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            listBox3.Items.Add(richTextBox1.Text);
            var writer = System.IO.File.AppendText("reminders.txt");
            writer.WriteLine(textBox1.Text + " " + dateTimePicker1.Value.ToString("dd/MM/yyyy") + " " + richTextBox1.Text);
            writer.Close();
            textBox1.Text = "";
            richTextBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            radioButton1.Checked = radioButton2.Checked = false;
            SetStare(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.ContainsFocus)
            {
                SetStare(true);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker1.ContainsFocus)
            {
                SetStare(true);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(richTextBox1.ContainsFocus)
            {
                SetStare(true);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(groupBox1.ContainsFocus)
            {
                SetStare(true);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (groupBox1.ContainsFocus)
            {
                SetStare(true);
            }
        }
    }
}
