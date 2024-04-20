using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Client.localhost;

namespace Client
{
    public partial class TaskManagement : Form
    {
        private Form frmParinte;
        private localhost.WebService1 webService;
        private int idUser;
        private Task[] tasks;
        public TaskManagement(Form frmParinte, localhost.WebService1 webService, int idUser)
        {
            InitializeComponent();
            this.frmParinte = frmParinte; 
            this.webService = webService;
            this.idUser = idUser;
        }
        private void TaskManagement_Load(object sender, EventArgs e)
        {
            try
            {
                this.tasks = webService.GetTasks();
                dataGridView1.DataSource = tasks;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred. Please try again.{ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void TaskManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmParinte.Close();
        }

        
    }
}
