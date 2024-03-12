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
        private long id = -1;
        private bool adaugare = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            if (!System.IO.File.Exists("reminders.txt"))
            {
                System.IO.File.Create("reminders.txt").Close();
            }
            string[] lines = System.IO.File.ReadAllLines("reminders.txt");
            if(lines.Length == 0)
            {
                textBox1.Enabled = false;
                richTextBox1.Enabled = false;
                dateTimePicker1.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
            }
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
            panel1.Hide();
            button3.Show();
            listBox1.Enabled = true;
            listBox2.Enabled = true;
            listBox3.Enabled = true;
            adaugare = false;
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

            if(adaugare == true)
            {
                listBox1.Items.Add(textBox1.Text);
                listBox2.Items.Add(dateTimePicker1.Value.ToString("dd/MM/yyyy"));
                listBox3.Items.Add(richTextBox1.Text);
                var writer = System.IO.File.AppendText("reminders.txt");
                writer.WriteLine($"{textBox1.Text} {dateTimePicker1.Value.ToString("dd/MM/yyyy")} {richTextBox1.Text} {radioButton1.Checked} {radioButton2.Checked} {System.DateTime.Now.ToString("yyyyMMddHHmmss")}");
                writer.Close();
                textBox1.Text = "";
                richTextBox1.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                radioButton1.Checked = radioButton2.Checked = false;
            }
            else
            {
                lines = System.IO.File.ReadAllLines("reminders.txt");
                lines[listBox1.SelectedIndex] = $"{textBox1.Text} {dateTimePicker1.Value.ToString("dd/MM/yyyy")} {richTextBox1.Text} {radioButton1.Checked} {radioButton2.Checked} {System.DateTime.Now.ToString("yyyyMMddHHmmss")}";
                System.IO.File.WriteAllLines("reminders.txt", lines);
                listBox1.Items[listBox1.SelectedIndex] = textBox1.Text;
                listBox2.Items[listBox2.SelectedIndex] = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                listBox3.Items[listBox3.SelectedIndex] = richTextBox1.Text;
            }
            SetStare(false);
            panel1.Hide();
            button3.Show();
            listBox1.Enabled = true;
            listBox2.Enabled = true;
            listBox3.Enabled = true;
            adaugare = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.ContainsFocus)
            {
                SetStare(true);
                button3.Hide();
                panel1.Show();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker1.ContainsFocus)
            {
                SetStare(true);
                button3.Hide();
                panel1.Show();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(richTextBox1.ContainsFocus)
            {
                SetStare(true);
                button3.Hide();
                panel1.Show();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(groupBox1.ContainsFocus)
            {
                SetStare(true);
                button3.Hide();
                panel1.Show();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (groupBox1.ContainsFocus)
            {
                SetStare(true);
                button3.Hide();
                panel1.Show();
            }
        }
        string[] lines;
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox2.ContainsFocus && listBox2.SelectedIndex >= 0)
            {
                listBox1.SelectedIndex = listBox2.SelectedIndex;
                listBox3.SelectedIndex = listBox2.SelectedIndex;
                lines = System.IO.File.ReadAllLines("reminders.txt");
                textBox1.Text = listBox1.SelectedItem.ToString();
                richTextBox1.Text = listBox3.SelectedItem.ToString();
                dateTimePicker1.Value = DateTime.Parse(listBox2.SelectedItem.ToString());
                radioButton1.Checked = lines[listBox2.SelectedIndex].Split(' ')[3] == "True" ? true : false;
                radioButton2.Checked = lines[listBox2.SelectedIndex].Split(' ')[4] == "True" ? true : false;
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.ContainsFocus && listBox1.SelectedIndex >= 0)
            {
                listBox2.SelectedIndex = listBox1.SelectedIndex;
                listBox3.SelectedIndex = listBox1.SelectedIndex;
                lines = System.IO.File.ReadAllLines("reminders.txt");
                textBox1.Text = listBox1.SelectedItem.ToString();
                richTextBox1.Text = listBox3.SelectedItem.ToString();
                dateTimePicker1.Value = DateTime.Parse(listBox2.SelectedItem.ToString());
                radioButton1.Checked = lines[listBox2.SelectedIndex].Split(' ')[3] == "True" ? true : false;
                radioButton2.Checked = lines[listBox2.SelectedIndex].Split(' ')[4] == "True" ? true : false;
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox3.ContainsFocus && listBox3.SelectedIndex >= 0)
            {
                listBox1.SelectedIndex = listBox3.SelectedIndex;
                listBox2.SelectedIndex = listBox3.SelectedIndex;
                lines = System.IO.File.ReadAllLines("reminders.txt");
                textBox1.Text = listBox1.SelectedItem.ToString();
                richTextBox1.Text = listBox3.SelectedItem.ToString();
                dateTimePicker1.Value = DateTime.Parse(listBox2.SelectedItem.ToString());
                radioButton1.Checked = lines[listBox2.SelectedIndex].Split(' ')[3] == "True" ? true : false;
                radioButton2.Checked = lines[listBox2.SelectedIndex].Split(' ')[4] == "True" ? true : false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Hide();
            panel1.Show();
            adaugare = true;
            listBox1.SelectedIndex = listBox2.SelectedIndex = listBox3.SelectedIndex = -1;
            listBox1.Enabled = false;
            listBox2.Enabled = false;
            listBox3.Enabled = false;
            textBox1.Text = "";
            richTextBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            radioButton1.Checked = radioButton2.Checked = false;
            if(textBox1.Enabled == false)
            {
                textBox1.Enabled = true;
                richTextBox1.Enabled = true;
                dateTimePicker1.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
            }
        }
    }
}
