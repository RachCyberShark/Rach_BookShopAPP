using System;

namespace APP_RachST20.componnet
{
    partial class Userdashboard
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
            this.subform = new System.Windows.Forms.Panel();
            this.btn_Account = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_task = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // subform
            // 
            this.subform.BackColor = System.Drawing.Color.White;
            this.subform.Location = new System.Drawing.Point(209, 24);
            this.subform.Name = "subform";
            this.subform.Size = new System.Drawing.Size(1044, 552);
            this.subform.TabIndex = 17;
            // 
            // btn_Account
            // 
            this.btn_Account.Location = new System.Drawing.Point(24, 303);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(146, 55);
            this.btn_Account.TabIndex = 18;
            this.btn_Account.Text = "Account";
            this.btn_Account.UseVisualStyleBackColor = true;
            this.btn_Account.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(24, 190);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(146, 55);
            this.btn_home.TabIndex = 19;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_task
            // 
            this.btn_task.Location = new System.Drawing.Point(24, 416);
            this.btn_task.Name = "btn_task";
            this.btn_task.Size = new System.Drawing.Size(146, 55);
            this.btn_task.TabIndex = 20;
            this.btn_task.Text = "Cetecory";
            this.btn_task.UseVisualStyleBackColor = true;
            this.btn_task.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 55);
            this.button1.TabIndex = 21;
            this.button1.Text = "Book ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::APP_RachST20.Properties.Resources.c039b824474525_56334ce736de9;
            this.pictureBox1.Location = new System.Drawing.Point(24, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Userdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1265, 605);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_task);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_Account);
            this.Controls.Add(this.subform);
            this.Name = "Userdashboard";
            this.Text = "Userpf";
            this.Load += new System.EventHandler(this.Userdashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel subform;
        private System.Windows.Forms.Button btn_Account;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_task;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;

        public EventHandler Userpf_Load { get; set; }
    }
}