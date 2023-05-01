namespace bakerySystem
{
    partial class EditCakePage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.typeTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chooseImg = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.priceTxtField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cnclBtn = new System.Windows.Forms.Button();
            this.addOptionBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cfmBtn = new System.Windows.Forms.Button();
            this.typeCmbBox = new System.Windows.Forms.ComboBox();
            this.nameTxtField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cakeIDTxtField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.totalItemsLbl = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(29, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.Size = new System.Drawing.Size(745, 215);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cake ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cake Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cake Type";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price Per Slice (RM)";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cake Image";
            this.Column5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 192;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(29, 35);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(443, 22);
            this.searchBox.TabIndex = 2;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(576, 284);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(96, 30);
            this.editBtn.TabIndex = 3;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(678, 284);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(96, 30);
            this.removeBtn.TabIndex = 4;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.typeTxtBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.confirmBtn);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.chooseImg);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.priceTxtField);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cnclBtn);
            this.groupBox1.Controls.Add(this.addOptionBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cfmBtn);
            this.groupBox1.Controls.Add(this.typeCmbBox);
            this.groupBox1.Controls.Add(this.nameTxtField);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cakeIDTxtField);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 181);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // typeTxtBox
            // 
            this.typeTxtBox.Location = new System.Drawing.Point(259, 57);
            this.typeTxtBox.Name = "typeTxtBox";
            this.typeTxtBox.Size = new System.Drawing.Size(234, 22);
            this.typeTxtBox.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(628, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 33);
            this.button1.TabIndex = 30;
            this.button1.Text = "Cancel Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(511, 140);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(111, 33);
            this.confirmBtn.TabIndex = 29;
            this.confirmBtn.Text = "Confirm Edit";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // chooseImg
            // 
            this.chooseImg.Location = new System.Drawing.Point(6, 142);
            this.chooseImg.Name = "chooseImg";
            this.chooseImg.Size = new System.Drawing.Size(148, 28);
            this.chooseImg.TabIndex = 27;
            this.chooseImg.Text = "Choose An Image";
            this.chooseImg.UseVisualStyleBackColor = true;
            this.chooseImg.Click += new System.EventHandler(this.chooseImg_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "*Cake Image :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "RM";
            // 
            // priceTxtField
            // 
            this.priceTxtField.Location = new System.Drawing.Point(321, 98);
            this.priceTxtField.Name = "priceTxtField";
            this.priceTxtField.Size = new System.Drawing.Size(72, 22);
            this.priceTxtField.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "*Price Per Slice :";
            // 
            // cnclBtn
            // 
            this.cnclBtn.Location = new System.Drawing.Point(596, 54);
            this.cnclBtn.Name = "cnclBtn";
            this.cnclBtn.Size = new System.Drawing.Size(80, 30);
            this.cnclBtn.TabIndex = 22;
            this.cnclBtn.Text = "Cancel";
            this.cnclBtn.UseVisualStyleBackColor = true;
            this.cnclBtn.Click += new System.EventHandler(this.cnclBtn_Click);
            // 
            // addOptionBtn
            // 
            this.addOptionBtn.Location = new System.Drawing.Point(502, 53);
            this.addOptionBtn.Name = "addOptionBtn";
            this.addOptionBtn.Size = new System.Drawing.Size(50, 31);
            this.addOptionBtn.TabIndex = 20;
            this.addOptionBtn.Text = "➕";
            this.addOptionBtn.UseVisualStyleBackColor = true;
            this.addOptionBtn.Click += new System.EventHandler(this.addOptionBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "*Cake Type :";
            // 
            // cfmBtn
            // 
            this.cfmBtn.Location = new System.Drawing.Point(502, 53);
            this.cfmBtn.Name = "cfmBtn";
            this.cfmBtn.Size = new System.Drawing.Size(88, 30);
            this.cfmBtn.TabIndex = 21;
            this.cfmBtn.Text = "Add Type";
            this.cfmBtn.UseVisualStyleBackColor = true;
            this.cfmBtn.Click += new System.EventHandler(this.cfmBtn_Click);
            // 
            // typeCmbBox
            // 
            this.typeCmbBox.FormattingEnabled = true;
            this.typeCmbBox.Location = new System.Drawing.Point(259, 56);
            this.typeCmbBox.Name = "typeCmbBox";
            this.typeCmbBox.Size = new System.Drawing.Size(235, 24);
            this.typeCmbBox.TabIndex = 19;
            // 
            // nameTxtField
            // 
            this.nameTxtField.Location = new System.Drawing.Point(479, 23);
            this.nameTxtField.Name = "nameTxtField";
            this.nameTxtField.Size = new System.Drawing.Size(240, 22);
            this.nameTxtField.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "*Cake Name :";
            // 
            // cakeIDTxtField
            // 
            this.cakeIDTxtField.Location = new System.Drawing.Point(240, 23);
            this.cakeIDTxtField.Name = "cakeIDTxtField";
            this.cakeIDTxtField.ReadOnly = true;
            this.cakeIDTxtField.Size = new System.Drawing.Size(127, 22);
            this.cakeIDTxtField.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Cake ID :";
            // 
            // pictureDialog
            // 
            this.pictureDialog.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalItemsLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 459);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // totalItemsLbl
            // 
            this.totalItemsLbl.Name = "totalItemsLbl";
            this.totalItemsLbl.Size = new System.Drawing.Size(151, 20);
            this.totalItemsLbl.Text = "toolStripStatusLabel1";
            // 
            // EditCakePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditCakePage";
            this.Text = "Bakery System - Edit Menu (Admin)";
            this.Load += new System.EventHandler(this.EditCakePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cakeIDTxtField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTxtField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cnclBtn;
        private System.Windows.Forms.Button addOptionBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cfmBtn;
        private System.Windows.Forms.ComboBox typeCmbBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox priceTxtField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button chooseImg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox typeTxtBox;
        private System.Windows.Forms.OpenFileDialog pictureDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel totalItemsLbl;
    }
}