﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        bool insert = false;
        bool insertUniv = false;
        public Form1()
        {
            InitializeComponent();
        }
        public SqlConnection myCon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\dbObject.mdf;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbObjectDataSet.Universitati1' table. You can move, or remove it, as needed.
            this.universitati1TableAdapter.Fill(this.dbObjectDataSet.Universitati1);
            // TODO: This line of code loads data into the 'dbObjectDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.dbObjectDataSet.Table);
            // TODO: This line of code loads data into the 'dbObjectDataSet.Universitati' table. You can move, or remove it, as needed.
            this.universitatiTableAdapter.Fill(this.dbObjectDataSet.Universitati);
            this.facultatiTableAdapter.FillByCode(this.dbObjectDataSet.Facultati, (int)listBoxUniversitati.SelectedValue);
            //this.facultatiTableAdapter.Insert(5,"Facultatea de Informatica");
            listBoxFacultati_SelectedIndexChanged(null, null); //refresh info la first load
            listBoxUniversitati_SelectedIndexChanged(null, null);
            PopulateComboBox();
            PopulateDataGridView();
        }

        private void listBoxUniversitati_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxUniversitati.SelectedIndex >= 0)
            {
                this.facultatiTableAdapter.FillByCode(this.dbObjectDataSet.Facultati, (int)listBoxUniversitati.SelectedValue);
            }
            if (listBoxFacultati.SelectedIndex > 0)
            {
                listBoxFacultati.SelectedIndex = 0;
            }
            listBoxFacultati_SelectedIndexChanged(null, null);
            DataRowView rowView = listBoxUniversitati.SelectedItem as DataRowView;
            if (rowView != null)
            {
                textBox1.Text = rowView["Id"].ToString();
                textBox2.Text = rowView["NameUniv"].ToString();
                textBox3.Text = rowView["City"].ToString();
                textBox4.Text = rowView["Code"].ToString();
            }
        }

        private void listBoxFacultati_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = listBoxFacultati.SelectedItem as DataRowView;
            if (row != null)
            {
                textBoxFacultati.Text = row["NumeFac"].ToString();
                textBoxCode.Text = row["Code"].ToString();
                textBoxId.Text = row["Id"].ToString();
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            insert = true;
            //dbObjectDataSet.FacultatiRow newRow = dbObjectDataSet.Facultati.NewFacultatiRow();
            textBoxFacultati.Text = "";
            textBoxId.Text = "";
            //textBoxCode.Text = listBoxUniversitati.SelectedValue.ToString();
        }

        private void UpdateRowFacultati(long id)
        {
            SqlCommand sqlCommand = new SqlCommand("UPDATE Facultati SET NumeFac = @NumeFac WHERE Id = @Id", facultatiTableAdapter.Connection);
            sqlCommand.Parameters.AddWithValue("@NumeFac", textBoxFacultati.Text);
            sqlCommand.Parameters.AddWithValue("@Id", id);
            if (sqlCommand.Connection.State != ConnectionState.Open)
            {
                sqlCommand.Connection.Open();
            }
            sqlCommand.ExecuteNonQuery();
        }

        private void UpdateRowUniversitati(long code)
        {
            SqlCommand sqlCommand = new SqlCommand("UPDATE Universitati SET Id = @Id, NameUniv = @NameUniv, City = @City WHERE Code = @Code", universitatiTableAdapter.Connection);
            sqlCommand.Parameters.AddWithValue("@Id", textBox1.Text);
            sqlCommand.Parameters.AddWithValue("@NameUniv", textBox2.Text);
            sqlCommand.Parameters.AddWithValue("@City", textBox3.Text);
            sqlCommand.Parameters.AddWithValue("@Code", code);
            if (sqlCommand.Connection.State != ConnectionState.Open)
            {
                sqlCommand.Connection.Open();
            }
            sqlCommand.ExecuteNonQuery();
        }

        private void DeleteUniversitate(long code)
        {
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM Universitati WHERE Code = @Code", universitatiTableAdapter.Connection);
            sqlCommand.Parameters.AddWithValue("@Code", code);
            if (sqlCommand.Connection.State != ConnectionState.Open)
            {
                sqlCommand.Connection.Open();
            }
            sqlCommand.ExecuteNonQuery();
        }

        private void DeleteFacultate(long id)
        {
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM Facultati WHERE Id = @ID", facultatiTableAdapter.Connection);
            sqlCommand.Parameters.AddWithValue("@ID", id);
            if (sqlCommand.Connection.State != ConnectionState.Open)
            {
                sqlCommand.Connection.Open();
            }
            sqlCommand.ExecuteNonQuery();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (insert)
            {
                this.facultatiTableAdapter.Insert((int)listBoxUniversitati.SelectedValue, textBoxFacultati.Text);
            }
            else
            {
                DataRowView rowView = listBoxFacultati.SelectedItem as DataRowView;
                if (rowView != null)
                {
                    int id = (int)rowView["Id"];
                    if (id > 0)
                    {
                        UpdateRowFacultati(id);
                    }
                }
            }
            this.facultatiTableAdapter.FillByCode(this.dbObjectDataSet.Facultati, (int)listBoxUniversitati.SelectedValue);
            insert = false;
        }

        private void buttonNewRowUniv_Click(object sender, EventArgs e)
        {
            insertUniv = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void buttonUpdateUniv_Click(object sender, EventArgs e)
        {
            if (insertUniv)
            {
                this.universitatiTableAdapter.Insert(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text);
            }
            else
            {
                DataRowView rowView = listBoxUniversitati.SelectedItem as DataRowView;
                if (rowView != null)
                {
                    int code = (int)rowView["Code"];
                    if (code > 0)
                    {
                        UpdateRowUniversitati(code);
                    }
                }
            }
            this.universitatiTableAdapter.Fill(this.dbObjectDataSet.Universitati);
            insertUniv = false;
        }

        private void buttonDeleteUniv_Click(object sender, EventArgs e)
        {
            if (listBoxFacultati.Items.Count > 0)
            {
                MessageBox.Show("Universitatea are facultati si nu se poate sterge!", "Atentie!");
                return;
            }
            if (listBoxUniversitati.SelectedIndex > 0)
            {
                int code = (int)listBoxUniversitati.SelectedValue;
                DeleteUniversitate(code);
                this.universitatiTableAdapter.Fill(this.dbObjectDataSet.Universitati);
                listBoxUniversitati_SelectedIndexChanged(null, null);
            }
        }

        private void buttonDeleteFacult_Click(object sender, EventArgs e)
        {
            if (listBoxFacultati.SelectedIndex > 0)
            {
                int id = (int)listBoxFacultati.SelectedValue;
                DeleteFacultate(id);
                this.facultatiTableAdapter.FillByCode(this.dbObjectDataSet.Facultati, (int)listBoxUniversitati.SelectedValue);
                listBoxFacultati_SelectedIndexChanged(null, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = facultatiTableAdapter.Connection)
            {
                using (SqlCommand cmd = new SqlCommand("dbo.InsertIntoFacultati", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@NumeFac", SqlDbType.NVarChar).Value = "Faculty Name";
                    cmd.Parameters.Add("@Code", SqlDbType.Int).Value = 1;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["Column1"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Doriti sa stergeti linia?", "Stergere", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    myCon.Open();
                    SqlCommand sqlcom = new SqlCommand("DeleteFac", myCon);
                    sqlcom.CommandType = CommandType.StoredProcedure;
                    sqlcom.Parameters.AddWithValue("@Id", Convert.ToInt32(dataGridView1.CurrentRow.Cells["Column1"].Value));
                    sqlcom.ExecuteNonQuery();
                    myCon.Close();
                }
                else e.Cancel = true;
            }
            else e.Cancel = true;
        }
        private void PopulateComboBox()
        {
            SqlDataAdapter daUniv1 = new SqlDataAdapter("SELECT * FROM Universitati", myCon);
            DataTable dtUniv = new DataTable();
            daUniv1.Fill(dtUniv);
            Column3.ValueMember = "Code";
            Column3.DisplayMember = "NameUniv";
            DataRow topItem = dtUniv.NewRow();
            topItem[0] = 0;
            topItem[1] = "-SELECT-";
            dtUniv.Rows.InsertAt(topItem, 0);
            Column3.DataSource = dtUniv;

        }
        private void PopulateDataGridView()
        {
            SqlDataAdapter daFac1 = new SqlDataAdapter("SELECT * FROM Facultati", myCon);
            DataTable dtFac = new DataTable();
            daFac1.Fill(dtFac);
            dataGridView1.DataSource = dtFac;


        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (dataGridView1.CurrentRow != null)
                {
                    myCon.Open();
                    DataGridViewRow row = dataGridView1.CurrentRow;
                    if
                    (row.Cells["Column1"].Value == DBNull.Value) //insert
                    {
                        SqlCommand sqlcom1 = new SqlCommand("InsertIntoFacultati", myCon);
                        sqlcom1.CommandType = CommandType.StoredProcedure;
                        sqlcom1.Parameters.AddWithValue("@Code", Convert.ToInt32(row.Cells["Column3"].Value == DBNull.Value ?
                "1" : row.Cells["Column3"].Value.ToString()));
                        sqlcom1.Parameters.AddWithValue("@NumeFac", row.Cells["Column2"].Value == DBNull.Value ?
                            "" : row.Cells["Column3"].Value.ToString());
                        sqlcom1.ExecuteNonQuery();
                        PopulateDataGridView();
                    }
                    myCon.Close();
                }
            }
        }

    }
}
    

