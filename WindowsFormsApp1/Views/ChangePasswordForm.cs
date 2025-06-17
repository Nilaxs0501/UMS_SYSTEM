using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string username = txtCUsername.Text.Trim();
            string currentPassword = txtCPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
           
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(currentPassword) ||
                string.IsNullOrWhiteSpace(newPassword) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New Password and Confirm Password do not match.");
                return;
            }

            if (UsersController.ChangePassword(username, currentPassword, newPassword))
            {
                MessageBox.Show("Password changed successfully.");
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Incorrect current username or password.");
            }
        }
    }
    
}
