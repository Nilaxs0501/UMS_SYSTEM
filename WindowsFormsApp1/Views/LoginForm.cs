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
    public partial class LoginForm : Form
    {
       

        public LoginForm()
        {
            InitializeComponent();
           
       
        }

        private void Login_Load(object sender, EventArgs e)
        {

            cmbRole.Items.Add("Select your Role");
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Staff");
            cmbRole.Items.Add("Lecturer");
            cmbRole.Items.Add("Student");
            cmbRole.SelectedIndex = 0;
        


        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
           
        
            string username = txt_username.Text.Trim();
            string password = txt_password.Text;
            string role = cmbRole.SelectedItem.ToString();

            Users user = LoginController.GetUser(username, password, role);

            if (user != null)
            {
                MessageBox.Show($"Welcome {user.UserName} ({user.Role})", "Login Success");

                this.Hide();
                var Main = new MainForm(user); 
                Main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username, Password, or Role!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked)
            {
                // Show password
                txt_password.PasswordChar = '\0';  // Removes masking
            }
            else
            {
                // Hide password
               txt_password.PasswordChar = '*';  // Masks with '*'
            }
        }
    }
}

