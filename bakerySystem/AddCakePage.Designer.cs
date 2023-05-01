namespace bakerySystem
{
    partial class AddCakePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.IDTxtField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTxtField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.typeCmbBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priceTxtField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chooseImg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addcakeBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addOptionBtn = new System.Windows.Forms.Button();
            this.cfmBtn = new System.Windows.Forms.Button();
            this.cnclBtn = new System.Windows.Forms.Button();
            this.typeTxtField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add A New Cake";
            // 
            // pictureDialog
            // 
            this.pictureDialog.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "*Cake ID :";
            // 
            // IDTxtField
            // 
            this.IDTxtField.Location = new System.Drawing.Point(140, 78);
            this.IDTxtField.Name = "IDTxtField";
            this.IDTxtField.Size = new System.Drawing.Size(139, 22);
            this.IDTxtField.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "*Cake Name :";
            // 
            // nameTxtField
            // 
            this.nameTxtField.Location = new System.Drawing.Point(140, 129);
            this.nameTxtField.Name = "nameTxtField";
            this.nameTxtField.Size = new System.Drawing.Size(367, 22);
            this.nameTxtField.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "*Cake Type :";
            // 
            // typeCmbBox
            // 
            this.typeCmbBox.FormattingEnabled = true;
            this.typeCmbBox.Location = new System.Drawing.Point(140, 179);
            this.typeCmbBox.Name = "typeCmbBox";
            this.typeCmbBox.Size = new System.Drawing.Size(220, 24);
            this.typeCmbBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "*Price Per Slice :";
            // 
            // priceTxtField
            // 
            this.priceTxtField.Location = new System.Drawing.Point(171, 229);
            this.priceTxtField.Name = "priceTxtField";
            this.priceTxtField.Size = new System.Drawing.Size(72, 22);
            this.priceTxtField.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "RM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "*Cake Image :";
            // 
            // chooseImg
            // 
            this.chooseImg.Location = new System.Drawing.Point(140, 282);
            this.chooseImg.Name = "chooseImg";
            this.chooseImg.Size = new System.Drawing.Size(148, 28);
            this.chooseImg.TabIndex = 11;
            this.chooseImg.Text = "Choose An Image";
            this.chooseImg.UseVisualStyleBackColor = true;
            this.chooseImg.Click += new System.EventHandler(this.chooseImg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(294, 282);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // addcakeBtn
            // 
            this.addcakeBtn.Location = new System.Drawing.Point(325, 431);
            this.addcakeBtn.Name = "addcakeBtn";
            this.addcakeBtn.Size = new System.Drawing.Size(114, 35);
            this.addcakeBtn.TabIndex = 13;
            this.addcakeBtn.Text = "Add To Menu";
            this.addcakeBtn.UseVisualStyleBackColor = true;
            this.addcakeBtn.Click += new System.EventHandler(this.addcakeBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(445, 431);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(95, 35);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addOptionBtn
            // 
            this.addOptionBtn.Location = new System.Drawing.Point(366, 178);
            this.addOptionBtn.Name = "addOptionBtn";
            this.addOptionBtn.Size = new System.Drawing.Size(50, 31);
            this.addOptionBtn.TabIndex = 15;
            this.addOptionBtn.Text = "➕";
            this.addOptionBtn.UseVisualStyleBackColor = true;
            this.addOptionBtn.Click += new System.EventHandler(this.addOptionBtn_Click_1);
            // 
            // cfmBtn
            // 
            this.cfmBtn.Location = new System.Drawing.Point(366, 178);
            this.cfmBtn.Name = "cfmBtn";
            this.cfmBtn.Size = new System.Drawing.Size(88, 30);
            this.cfmBtn.TabIndex = 16;
            this.cfmBtn.Text = "Add Type";
            this.cfmBtn.UseVisualStyleBackColor = true;
            this.cfmBtn.Click += new System.EventHandler(this.cfmBtn_Click);
            // 
            // cnclBtn
            // 
            this.cnclBtn.Location = new System.Drawing.Point(460, 179);
            this.cnclBtn.Name = "cnclBtn";
            this.cnclBtn.Size = new System.Drawing.Size(80, 30);
            this.cnclBtn.TabIndex = 17;
            this.cnclBtn.Text = "Cancel";
            this.cnclBtn.UseVisualStyleBackColor = true;
            this.cnclBtn.Click += new System.EventHandler(this.cnclBtn_Click_1);
            // 
            // typeTxtField
            // 
            this.typeTxtField.Location = new System.Drawing.Point(140, 179);
            this.typeTxtField.Name = "typeTxtField";
            this.typeTxtField.Size = new System.Drawing.Size(220, 22);
            this.typeTxtField.TabIndex = 18;
            // 
            // AddCakePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 478);
            this.Controls.Add(this.cnclBtn);
            this.Controls.Add(this.addOptionBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addcakeBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chooseImg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.priceTxtField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTxtField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDTxtField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cfmBtn);
            this.Controls.Add(this.typeCmbBox);
            this.Controls.Add(this.typeTxtField);
            this.Name = "AddCakePage";
            this.Text = "Bakery System - Add Cake (Admin)";
            this.Load += new System.EventHandler(this.AddCakePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog pictureDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDTxtField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTxtField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox typeCmbBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox priceTxtField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button chooseImg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addcakeBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addOptionBtn;
        private System.Windows.Forms.Button cfmBtn;
        private System.Windows.Forms.Button cnclBtn;
        private System.Windows.Forms.TextBox typeTxtField;
    }
}