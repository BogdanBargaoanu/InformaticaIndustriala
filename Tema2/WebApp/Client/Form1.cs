using Client.localhost;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        localhost.WebService1 webService = new localhost.WebService1();
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabelCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateUser createUser = new CreateUser(this, webService);
            this.Hide();
            createUser.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User[] users = webService.GetUsers();
                foreach(User user in users)
                {
                    if(user.username == textBoxUsername.Text && user.password == textBoxPw.Text)
                    {
                        MessageBox.Show("Login successful.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                MessageBox.Show("Login failed. Please try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred. Please try again. {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
