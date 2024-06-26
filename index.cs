﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using APP_RachST20.componnet;
using System.Web;

namespace APP_RachST20.componnet
{
    public partial class index : Form
    {
        private int CategoryId;

        public index()
        {
            InitializeComponent();
        }

        // Event handler for the exit button click
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Event handler for the login button click
        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve email and password from the textboxes
            string email = txtemail.Text;
            string password = txtpassword.Text;
            
            
            // Check if login is valid using UserController's checkLogin method
            bool checkLogin = componnet.UserController.checkLogin(email, password);
            if (checkLogin)
            {
                
                // If login is valid, retrieve authenticated user details
                User auth = UserController.getAuthicatedUser(email, password);
                
                this.Hide(); // Hide the current form
                new Userdashboard(auth , CategoryId).Show(); // Show the UserProfile form with authenticated user details
            }
            else
            {
                // If login is invalid, show a message box with "Invalid" message
                MessageBox.Show("Invalid");
            }
        }

        // Event handler for text changed in the password textbox
        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            // This method can be used for any actions when text changes in the password textbox
        }

        // Event handler for text changed in the email textbox
        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            // This method can be used for any actions when text changes in the email textbox
        }

        // Event handler for clicking on the label
        private void label1_Click(object sender, EventArgs e)
        {
            // This method can be used for any actions when the label is clicked
        }

        // Event handler for text changed in the username textbox
        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            // This method can be used for any actions when text changes in the username textbox
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = txtpassword.Enabled = true;
        }

        private void index_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
