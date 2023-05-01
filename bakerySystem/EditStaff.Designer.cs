namespace bakerySystem
{
    partial class EditStaff
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIcNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffPhoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bakerysystemDataSet = new bakerySystem.bakerysystemDataSet();
            this.staffTableAdapter = new bakerySystem.bakerysystemDataSetTableAdapters.StaffTableAdapter();
            this.editBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cpTxtField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hpTxtField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pwdTxtField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTxtField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.icTxtField = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTxtField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.totalItemsLbl = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakerysystemDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 32);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(394, 22);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.staffIcNoDataGridViewTextBoxColumn,
            this.staffNameDataGridViewTextBoxColumn,
            this.staffPhoneNoDataGridViewTextBoxColumn,
            this.staffPasswordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.staffBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 204);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Staff ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffIcNoDataGridViewTextBoxColumn
            // 
            this.staffIcNoDataGridViewTextBoxColumn.DataPropertyName = "staffIcNo";
            this.staffIcNoDataGridViewTextBoxColumn.HeaderText = "Staff IC Number";
            this.staffIcNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffIcNoDataGridViewTextBoxColumn.Name = "staffIcNoDataGridViewTextBoxColumn";
            this.staffIcNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.staffIcNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffNameDataGridViewTextBoxColumn
            // 
            this.staffNameDataGridViewTextBoxColumn.DataPropertyName = "staffName";
            this.staffNameDataGridViewTextBoxColumn.HeaderText = "Staff Name";
            this.staffNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffNameDataGridViewTextBoxColumn.Name = "staffNameDataGridViewTextBoxColumn";
            this.staffNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.staffNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffPhoneNoDataGridViewTextBoxColumn
            // 
            this.staffPhoneNoDataGridViewTextBoxColumn.DataPropertyName = "staffPhoneNo";
            this.staffPhoneNoDataGridViewTextBoxColumn.HeaderText = "Staff Phone No";
            this.staffPhoneNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffPhoneNoDataGridViewTextBoxColumn.Name = "staffPhoneNoDataGridViewTextBoxColumn";
            this.staffPhoneNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.staffPhoneNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffPasswordDataGridViewTextBoxColumn
            // 
            this.staffPasswordDataGridViewTextBoxColumn.DataPropertyName = "staffPassword";
            this.staffPasswordDataGridViewTextBoxColumn.HeaderText = "Staff Password";
            this.staffPasswordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffPasswordDataGridViewTextBoxColumn.Name = "staffPasswordDataGridViewTextBoxColumn";
            this.staffPasswordDataGridViewTextBoxColumn.ReadOnly = true;
            this.staffPasswordDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.bakerysystemDataSet;
            // 
            // bakerysystemDataSet
            // 
            this.bakerysystemDataSet.DataSetName = "bakerysystemDataSet";
            this.bakerysystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(632, 271);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 33);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(713, 271);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 33);
            this.removeBtn.TabIndex = 3;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cpTxtField);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.hpTxtField);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pwdTxtField);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nameTxtField);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.icTxtField);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.usernameTxtField);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 167);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(672, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 37);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Confirm Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cpTxtField
            // 
            this.cpTxtField.Location = new System.Drawing.Point(460, 114);
            this.cpTxtField.Name = "cpTxtField";
            this.cpTxtField.Size = new System.Drawing.Size(192, 22);
            this.cpTxtField.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "*Confirm Password :";
            // 
            // hpTxtField
            // 
            this.hpTxtField.Location = new System.Drawing.Point(460, 73);
            this.hpTxtField.Name = "hpTxtField";
            this.hpTxtField.Size = new System.Drawing.Size(190, 22);
            this.hpTxtField.TabIndex = 9;
            this.hpTxtField.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "*Staff Phone No :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pwdTxtField
            // 
            this.pwdTxtField.Location = new System.Drawing.Point(119, 114);
            this.pwdTxtField.Name = "pwdTxtField";
            this.pwdTxtField.Size = new System.Drawing.Size(192, 22);
            this.pwdTxtField.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "*Staff Password :";
            // 
            // nameTxtField
            // 
            this.nameTxtField.Location = new System.Drawing.Point(119, 26);
            this.nameTxtField.Name = "nameTxtField";
            this.nameTxtField.Size = new System.Drawing.Size(231, 22);
            this.nameTxtField.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "*Staff Name :";
            // 
            // icTxtField
            // 
            this.icTxtField.Location = new System.Drawing.Point(119, 70);
            this.icTxtField.Mask = "000000-00-0000";
            this.icTxtField.Name = "icTxtField";
            this.icTxtField.Size = new System.Drawing.Size(106, 22);
            this.icTxtField.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "*Staff IC No :";
            // 
            // usernameTxtField
            // 
            this.usernameTxtField.Location = new System.Drawing.Point(458, 29);
            this.usernameTxtField.Name = "usernameTxtField";
            this.usernameTxtField.Size = new System.Drawing.Size(192, 22);
            this.usernameTxtField.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Staff ID :";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalItemsLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // totalItemsLbl
            // 
            this.totalItemsLbl.Name = "totalItemsLbl";
            this.totalItemsLbl.Size = new System.Drawing.Size(151, 20);
            this.totalItemsLbl.Text = "toolStripStatusLabel1";
            // 
            // EditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditStaff";
            this.Text = "Bakery System - Edit Staff Details (Admin)";
            this.Load += new System.EventHandler(this.EditStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakerysystemDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bakerysystemDataSet bakerysystemDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private bakerysystemDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIcNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffPhoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox hpTxtField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pwdTxtField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTxtField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox icTxtField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTxtField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cpTxtField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel totalItemsLbl;
    }
}