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
    public partial class TaskManagement : Form
    {
        private Form frmParinte;
        private localhost.WebService1 webService;
        public TaskManagement(Form frmParinte, localhost.WebService1 webService)
        {
            InitializeComponent();
            this.frmParinte = frmParinte; 
            this.webService = webService;
        }

        private void TaskManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmParinte.Close();
        }
    }
}
