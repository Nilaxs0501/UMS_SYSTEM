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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            LoadUsers();
        }
        int selectedUserId = 0;
        private void LoadUsers()
        {
            dataGridView1.DataSource = UsersController.GetAllUsers();
            dataGridView1.Columns["password"].Visible = false;
        }


        private void UsersForm_Load(object sender, EventArgs e)
        {
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Select your Role");
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Staff");
            cmbRole.Items.Add("Lecturer");
            cmbRole.Items.Add("Student");

            cmbRole.SelectedIndex = 0; 

            LoadUsers(); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
     
        
            try
            {
                Users user = new Users
                {
                    UserName = txtUsername.Text,
                    Password = txtPassword.Text,
                    Role = cmbRole.SelectedItem.ToString(),
                    Name = txtName.Text,
                    Address = txtAddress.Text
                };

                if (UsersController.AddUser(user))
                {
                    MessageBox.Show("User added successfully");
                    LoadUsers();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to add user");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          
        
            try
            {
                if (selectedUserId == 0)
                {
                    MessageBox.Show("Please select a user to update.");
                    return;
                }

                Users user = new Users
                {
                    UserID = selectedUserId,
                    UserName = txtUsername.Text,
                    Password = txtPassword.Text,
                    Role = cmbRole.SelectedItem.ToString(),
                    Name = txtName.Text,
                    Address = txtAddress.Text
                };

                if (UsersController.UpdateUser(user))
                {
                    MessageBox.Show("User updated successfully");
                    LoadUsers();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to update user");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
          
        
            try
            {
                if (selectedUserId == 0)
                {
                    MessageBox.Show("Please select a user to delete.");
                    return;
                }

                if (UsersController.DeleteUser(selectedUserId))
                {
                    MessageBox.Show("User deleted successfully");
                    LoadUsers();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to delete user");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
  
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedUserId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["UserID"].Value);
                txtUsername.Text = dataGridView1.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
                txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                cmbRole.Text = dataGridView1.Rows[e.RowIndex].Cells["Role"].Value.ToString();
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            }
        }
        private void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtName.Clear();
            txtAddress.Clear();
            cmbRole.SelectedIndex = 0;
            selectedUserId = 0;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lbladdress_Click(object sender, EventArgs e)
        {

        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

