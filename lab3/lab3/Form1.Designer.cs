namespace lab3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxFacultati = new System.Windows.Forms.ListBox();
            this.facultatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbObjectDataSet = new lab3.dbObjectDataSet();
            this.facultatiTableAdapter = new lab3.dbObjectDataSetTableAdapters.FacultatiTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.universitati1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteUniv = new System.Windows.Forms.Button();
            this.buttonUpdateUniv = new System.Windows.Forms.Button();
            this.buttonNewRowUniv = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteFacult = new System.Windows.Forms.Button();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxFacultati = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.listBoxUniversitati = new System.Windows.Forms.ListBox();
            this.universitatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.universitatiTableAdapter = new lab3.dbObjectDataSetTableAdapters.UniversitatiTableAdapter();
            this.tableTableAdapter = new lab3.dbObjectDataSetTableAdapters.TableTableAdapter();
            this.universitati1TableAdapter = new lab3.dbObjectDataSetTableAdapters.Universitati1TableAdapter();
            this.nameUnivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeFacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.facultatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbObjectDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universitati1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.universitatiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFacultati
            // 
            this.listBoxFacultati.DataSource = this.facultatiBindingSource;
            this.listBoxFacultati.DisplayMember = "NumeFac";
            this.listBoxFacultati.FormattingEnabled = true;
            this.listBoxFacultati.Location = new System.Drawing.Point(264, 56);
            this.listBoxFacultati.Name = "listBoxFacultati";
            this.listBoxFacultati.Size = new System.Drawing.Size(194, 160);
            this.listBoxFacultati.TabIndex = 0;
            this.listBoxFacultati.ValueMember = "Id";
            this.listBoxFacultati.SelectedIndexChanged += new System.EventHandler(this.listBoxFacultati_SelectedIndexChanged);
            // 
            // facultatiBindingSource
            // 
            this.facultatiBindingSource.DataMember = "Facultati";
            this.facultatiBindingSource.DataSource = this.dbObjectDataSet;
            // 
            // dbObjectDataSet
            // 
            this.dbObjectDataSet.DataSetName = "dbObjectDataSet";
            this.dbObjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facultatiTableAdapter
            // 
            this.facultatiTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.listBoxUniversitati);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBoxFacultati);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1074, 542);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameUnivDataGridViewTextBoxColumn,
            this.numeFacDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(631, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(396, 222);
            this.dataGridView1.TabIndex = 21;
            // 
            // universitati1BindingSource
            // 
            this.universitati1BindingSource.DataMember = "Universitati1";
            this.universitati1BindingSource.DataSource = this.dbObjectDataSet;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.dbObjectDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Insert univ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDeleteUniv);
            this.groupBox3.Controls.Add(this.buttonUpdateUniv);
            this.groupBox3.Controls.Add(this.buttonNewRowUniv);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(6, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 215);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sectiune universitati";
            // 
            // buttonDeleteUniv
            // 
            this.buttonDeleteUniv.Location = new System.Drawing.Point(36, 166);
            this.buttonDeleteUniv.Name = "buttonDeleteUniv";
            this.buttonDeleteUniv.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteUniv.TabIndex = 18;
            this.buttonDeleteUniv.Text = "Delete";
            this.buttonDeleteUniv.UseVisualStyleBackColor = true;
            this.buttonDeleteUniv.Click += new System.EventHandler(this.buttonDeleteUniv_Click);
            // 
            // buttonUpdateUniv
            // 
            this.buttonUpdateUniv.Location = new System.Drawing.Point(155, 123);
            this.buttonUpdateUniv.Name = "buttonUpdateUniv";
            this.buttonUpdateUniv.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateUniv.TabIndex = 12;
            this.buttonUpdateUniv.Text = "Update";
            this.buttonUpdateUniv.UseVisualStyleBackColor = true;
            this.buttonUpdateUniv.Click += new System.EventHandler(this.buttonUpdateUniv_Click);
            // 
            // buttonNewRowUniv
            // 
            this.buttonNewRowUniv.Location = new System.Drawing.Point(36, 122);
            this.buttonNewRowUniv.Name = "buttonNewRowUniv";
            this.buttonNewRowUniv.Size = new System.Drawing.Size(75, 23);
            this.buttonNewRowUniv.TabIndex = 17;
            this.buttonNewRowUniv.Text = "New row";
            this.buttonNewRowUniv.UseVisualStyleBackColor = true;
            this.buttonNewRowUniv.Click += new System.EventHandler(this.buttonNewRowUniv_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Code:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "City:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "NameUniv:";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(79, 97);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(151, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(79, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Id:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDeleteFacult);
            this.groupBox2.Controls.Add(this.textBoxCode);
            this.groupBox2.Controls.Add(this.buttonUpdate);
            this.groupBox2.Controls.Add(this.textBoxFacultati);
            this.groupBox2.Controls.Add(this.buttonInsert);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxId);
            this.groupBox2.Location = new System.Drawing.Point(254, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 215);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sectiune facultati";
            // 
            // buttonDeleteFacult
            // 
            this.buttonDeleteFacult.Location = new System.Drawing.Point(30, 166);
            this.buttonDeleteFacult.Name = "buttonDeleteFacult";
            this.buttonDeleteFacult.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteFacult.TabIndex = 19;
            this.buttonDeleteFacult.Text = "Delete";
            this.buttonDeleteFacult.UseVisualStyleBackColor = true;
            this.buttonDeleteFacult.Click += new System.EventHandler(this.buttonDeleteFacult_Click);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(73, 72);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(151, 20);
            this.textBoxCode.TabIndex = 6;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(149, 98);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxFacultati
            // 
            this.textBoxFacultati.Location = new System.Drawing.Point(73, 46);
            this.textBoxFacultati.Name = "textBoxFacultati";
            this.textBoxFacultati.Size = new System.Drawing.Size(151, 20);
            this.textBoxFacultati.TabIndex = 4;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(30, 98);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 10;
            this.buttonInsert.Text = "New row";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "NumeFac:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Code:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(73, 20);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(151, 20);
            this.textBoxId.TabIndex = 8;
            // 
            // listBoxUniversitati
            // 
            this.listBoxUniversitati.DataSource = this.universitatiBindingSource;
            this.listBoxUniversitati.DisplayMember = "NameUniv";
            this.listBoxUniversitati.FormattingEnabled = true;
            this.listBoxUniversitati.Location = new System.Drawing.Point(21, 56);
            this.listBoxUniversitati.Name = "listBoxUniversitati";
            this.listBoxUniversitati.Size = new System.Drawing.Size(209, 160);
            this.listBoxUniversitati.TabIndex = 3;
            this.listBoxUniversitati.ValueMember = "Code";
            this.listBoxUniversitati.SelectedIndexChanged += new System.EventHandler(this.listBoxUniversitati_SelectedIndexChanged);
            // 
            // universitatiBindingSource
            // 
            this.universitatiBindingSource.DataMember = "Universitati";
            this.universitatiBindingSource.DataSource = this.dbObjectDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Facultati";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Universitati";
            // 
            // universitatiTableAdapter
            // 
            this.universitatiTableAdapter.ClearBeforeFill = true;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // universitati1TableAdapter
            // 
            this.universitati1TableAdapter.ClearBeforeFill = true;
            // 
            // nameUnivDataGridViewTextBoxColumn
            // 
            this.nameUnivDataGridViewTextBoxColumn.DataPropertyName = "NameUniv";
            this.nameUnivDataGridViewTextBoxColumn.HeaderText = "NameUniv";
            this.nameUnivDataGridViewTextBoxColumn.Name = "nameUnivDataGridViewTextBoxColumn";
            // 
            // numeFacDataGridViewTextBoxColumn
            // 
            this.numeFacDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.numeFacDataGridViewTextBoxColumn.DataSource = this.universitati1BindingSource;
            this.numeFacDataGridViewTextBoxColumn.DisplayMember = "NameUniv";
            this.numeFacDataGridViewTextBoxColumn.HeaderText = "NumeFac";
            this.numeFacDataGridViewTextBoxColumn.Name = "numeFacDataGridViewTextBoxColumn";
            this.numeFacDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeFacDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.numeFacDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.numeFacDataGridViewTextBoxColumn.ValueMember = "Code";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 542);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facultatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbObjectDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universitati1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.universitatiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFacultati;
        private dbObjectDataSet dbObjectDataSet;
        private System.Windows.Forms.BindingSource facultatiBindingSource;
        private dbObjectDataSetTableAdapters.FacultatiTableAdapter facultatiTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxFacultati;
        private System.Windows.Forms.ListBox listBoxUniversitati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource universitatiBindingSource;
        private dbObjectDataSetTableAdapters.UniversitatiTableAdapter universitatiTableAdapter;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonUpdateUniv;
        private System.Windows.Forms.Button buttonNewRowUniv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonDeleteUniv;
        private System.Windows.Forms.Button buttonDeleteFacult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private dbObjectDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.BindingSource universitati1BindingSource;
        private dbObjectDataSetTableAdapters.Universitati1TableAdapter universitati1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameUnivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn numeFacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}

