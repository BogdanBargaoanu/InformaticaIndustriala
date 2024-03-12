using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private string usernamesLocation = "user.txt";
        private string passwordsLocation = "pass.txt";

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Enter a username!", "Attention!");
                textBox1.Focus();
                return;
            }
            if(textBox2.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Enter a password!", "Attention!");
                textBox2.Focus();
                return;
            }

            if(System.IO.File.Exists(usernamesLocation) && System.IO.File.Exists(passwordsLocation))
            {
                string[] usernames = System.IO.File.ReadAllLines(usernamesLocation);
                string[] passwords = System.IO.File.ReadAllLines(passwordsLocation);

                for(int i = 0; i < usernames.Length; i++)
                {
                    if (usernames[i] == textBox1.Text)
                    {
                        if (passwords[i] == textBox2.Text)
                        {
                            this.Hide();
                            MainForm mainForm = new MainForm();
                            mainForm.username = usernames[i];
                            mainForm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect password!", "Error!");
                            textBox2.Focus();
                            return;
                        }
                    }
                }
                MessageBox.Show("Username not found!", "Error!");
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("No users found!", "Error!");
            }
        }
    }
}
