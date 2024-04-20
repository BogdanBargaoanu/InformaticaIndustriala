using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;
using System.Windows.Forms;

namespace Client
{
    public partial class CreateUser : Form
    {
        private Form frmParinte;
        private localhost.WebService1 webService;
        public CreateUser(Form frmParinte, localhost.WebService1 webService)
        {
            InitializeComponent();
            this.frmParinte = frmParinte;
            this.webService = webService;
        }

        private void CreateUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.frmParinte.Show();
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text.Length >= 50)
            {
                MessageBox.Show("Username too long.","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUsername.Focus();
                return;
            }
            if(textBoxPw.Text.Length >= 50)
            {
                MessageBox.Show("Password too long.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPw.Focus();
                return;
            }
            if(textBoxPw.Text != textBoxRPw.Text)
            {
                MessageBox.Show("Passwords do not match.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPw.Focus();
                return;
            }
            webService.AddUser(textBoxUsername.Text, textBoxPw.Text);
            MessageBox.Show("User created successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
