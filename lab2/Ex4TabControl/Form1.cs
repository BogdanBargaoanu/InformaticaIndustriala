using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            string[] lista = { "Audi", "BMW", "Mercedes", "VW" };
            listBox1.Items.AddRange(lista);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBox1.GetItemText(listBox1.SelectedItem);
            string imagePath = $"{selectedItem.ToLower()}.jpg";
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((radioButton1.Checked == false && radioButton2.Checked == false) || (radioButton3.Checked == false && radioButton4.Checked == false))
            {
                MessageBox.Show("Selecteaza un camp din ambele grupari!", "Atentie!");
                return;
            }

            string mesaj = "Ai ales: ";
            if(radioButton1.Checked)
            {
                mesaj += radioButton1.Text;
            }
            if(radioButton2.Checked)
            {
                mesaj += radioButton2.Text;
            }
            if(radioButton3.Checked)
            {
                mesaj += radioButton3.Text;
            }
            if(radioButton4.Checked)
            {
                mesaj += radioButton4.Text;
            }

            MessageBox.Show(mesaj);

        }
    }
}
