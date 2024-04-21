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
        private bool adaugare = false;
        private Task[] tasks;
        private Task currentTask = null;
        public TaskManagement(Form frmParinte, localhost.WebService1 webService, int idUser)
        {
            InitializeComponent();
            this.frmParinte = frmParinte; 
            this.webService = webService;
            this.idUser = idUser;

            #region predifined tasks
            comboBox1.Items.Add("Complete Project Proposal");
            comboBox1.Items.Add("Create Project Plan");
            comboBox1.Items.Add("Create Project Schedule");
            comboBox1.Items.Add("Create Project Budget");
            comboBox1.Items.Add("Prepare Presentation Slides");
            comboBox1.Items.Add("Conduct Research");
            comboBox1.Items.Add("Schedule Meetings");
            comboBox1.Items.Add("Send Status Update Email");
            comboBox1.Items.Add("Review Documents");
            comboBox1.Items.Add("Test Application");
            comboBox1.Items.Add("Update Project Plan");
            comboBox1.Items.Add("Review Code Changes");
            comboBox1.Items.Add("Debug Software Issues");
            #endregion

            this.WindowState = FormWindowState.Maximized;
        }
        private void TaskManagement_Load(object sender, EventArgs e)
        {
            try
            {
                this.tasks = webService.GetTasksByUser(idUser);
                dataGridView1.DataSource = tasks;
                SetStareForm(false);
                VerificareGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred. Please try again.{ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Task currentTask = (Task)dataGridView1.CurrentRow.DataBoundItem;
            if (currentTask != null && buttonAdauga.Enabled)
            {
                comboBox1.SelectedItem = currentTask.taskName;
                dateTimePicker1.Value = currentTask.dueDate;
                richTextBox1.Text = currentTask.description;
                this.currentTask = currentTask;
            }
        }

        #region values changed
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.ContainsFocus && !adaugare)
            {
                SetStareForm(true);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.ContainsFocus && !adaugare)
            {
                SetStareForm(true);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.ContainsFocus && !adaugare)
            {
                SetStareForm(true);
            }
        }
        #endregion

        #region button states
        private void SetStareForm(bool stare)
        {
            dataGridView1.Enabled = !stare;
            buttonAdauga.Enabled = !stare;
            buttonSterge.Enabled = !stare;
            panel2.Enabled = stare;
            buttonAdauga.Focus();
        }

        private void VerificareGridView()
        {
            if(this.tasks.Length == 0)
            {
                buttonSterge.Enabled = false;
            }
            else
            {
                buttonSterge.Enabled = true;
            }
        }
        #endregion

        #region insert, update, delete, cancel
        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = null;
            dateTimePicker1.Value = DateTime.Now;
            richTextBox1.Text = "";
            adaugare = true;
            SetStareForm(true);
        }
        private void buttonRenunta_Click(object sender, EventArgs e)
        {
            SetStareForm(false);
            //refresh data
            dataGridView1_SelectionChanged(null, null);
            adaugare = false;
            VerificareGridView();
        }
        private void buttonSalveaza_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a task.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
                comboBox1.DroppedDown = true;
                return;
            }
            if (dateTimePicker1.Value < DateTime.Now.Date && adaugare)
            {
                MessageBox.Show("Please select a valid due date.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker1.Focus();
                return;
            }
            if (!adaugare)
            {
                if (currentTask != null)
                {
                    try
                    {
                        webService.UpdateTask(currentTask.id, comboBox1.SelectedItem.ToString(), richTextBox1.Text, dateTimePicker1.Value);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred. Please try again.{ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                try
                {
                    webService.AddTask(comboBox1.SelectedItem.ToString(), richTextBox1.Text, dateTimePicker1.Value, idUser);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred. Please try again.{ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            int index = dataGridView1.SelectedRows[0].Index;
            this.tasks = webService.GetTasksByUser(idUser);

            // refresh datasource
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tasks;

            // ensure DataGridView has finished updating
            dataGridView1.Refresh();
            Application.DoEvents();

            
            if (adaugare)
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
                }
            }
            else
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[index].Selected = true;
                }
            }
            

            adaugare = false;
            SetStareForm(false);
            VerificareGridView();
            MessageBox.Show("Task saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonSterge_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this task?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.Yes)
            {
                if(currentTask == null)
                {
                    MessageBox.Show("Please select a task to delete.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    webService.DeleteTask(currentTask.id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred. Please try again.{ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.tasks = webService.GetTasksByUser(idUser);

                // refresh datasource
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tasks;

                // ensure DataGridView has finished updating
                dataGridView1.Refresh();
                Application.DoEvents();

                VerificareGridView();
                MessageBox.Show("Task deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion


        private void TaskManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmParinte.Close();
        }
    }
}
