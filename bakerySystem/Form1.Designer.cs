namespace bakerySystem
{
    partial class mainmenu
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.toAdminBtn = new System.Windows.Forms.Button();
            this.toOrderBtn = new System.Windows.Forms.Button();
            this.toBakerBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose The Display Screen";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.toAdminBtn);
            this.flowLayoutPanel1.Controls.Add(this.toOrderBtn);
            this.flowLayoutPanel1.Controls.Add(this.toBakerBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 159);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 291);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // toAdminBtn
            // 
            this.toAdminBtn.Location = new System.Drawing.Point(3, 3);
            this.toAdminBtn.Name = "toAdminBtn";
            this.toAdminBtn.Size = new System.Drawing.Size(267, 131);
            this.toAdminBtn.TabIndex = 0;
            this.toAdminBtn.Text = "Admin Screen";
            this.toAdminBtn.UseVisualStyleBackColor = true;
            this.toAdminBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // toOrderBtn
            // 
            this.toOrderBtn.Location = new System.Drawing.Point(276, 3);
            this.toOrderBtn.Name = "toOrderBtn";
            this.toOrderBtn.Size = new System.Drawing.Size(260, 131);
            this.toOrderBtn.TabIndex = 1;
            this.toOrderBtn.Text = "Ordering Screen";
            this.toOrderBtn.UseVisualStyleBackColor = true;
            // 
            // toBakerBtn
            // 
            this.toBakerBtn.Location = new System.Drawing.Point(542, 3);
            this.toBakerBtn.Name = "toBakerBtn";
            this.toBakerBtn.Size = new System.Drawing.Size(255, 131);
            this.toBakerBtn.TabIndex = 2;
            this.toBakerBtn.Text = "Baker Screen";
            this.toBakerBtn.UseVisualStyleBackColor = true;
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "mainmenu";
            this.Text = "Bakery System - Main Menu";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button toAdminBtn;
        private System.Windows.Forms.Button toOrderBtn;
        private System.Windows.Forms.Button toBakerBtn;
    }
}

