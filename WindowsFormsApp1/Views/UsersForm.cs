using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public partial class UsersForm : Form
    {

        private int selectedUserId = -1; 
      
        public UsersForm()
        {
            InitializeComponent();
            LoadUsers();
        }
         
        private void LoadUsers()
        {
            dataGridView1.DataSource = UsersController.GetAllUsers();
            dataGridView1.Columns["password"].Visible = false;
          
            selectedUserId = -1;
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

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

            LoadUsers();  // Load after wiring the event
            ClearFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
     
        
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    MessageBox.Show("Please enter both Name and Address.");
                    return;
                }
                Users user = new Users
                {
                    UserName = txtUsername.Text,
                    Password = "user123",
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
                if (selectedUserId == -1)
                {
                    MessageBox.Show("Please select a user to update.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    MessageBox.Show("Please enter both Name and Address.");
                    return;
                }
                Users user = new Users
                {
                    UserID = selectedUserId,
                    UserName = txtUsername.Text,
               
                    Role = cmbRole.SelectedItem.ToString(),
                    Name = txtName.Text,
                    Address = txtAddress.Text
                };

                if (UsersController.UpdateUser(user))
                {
                    MessageBox.Show("User updated successfully");
                    LoadUsers();
                   
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
                if (selectedUserId == -1)
                {
                    MessageBox.Show("Please select a user to delete.");
                    return;
                }
                var confirmResult = MessageBox.Show("Are you sure to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                   
                {
                    UsersController.DeleteUser(selectedUserId);
                    MessageBox.Show("User deleted successfully");
                    LoadUsers();
                    
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

            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    var selectedRow = dataGridView1.SelectedRows[0];

            //    selectedUserId = Convert.ToInt32(selectedRow.Cells["UserID"].Value);
            //    txtUsername.Text = selectedRow.Cells["UserName"].Value.ToString();
            //    cmbRole.SelectedItem = selectedRow.Cells["Role"].Value.ToString();
            //    txtName.Text = selectedRow.Cells["Name"].Value.ToString();
            //    txtAddress.Text = selectedRow.Cells["Address"].Value.ToString();
            //}


        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridView1.SelectedRows[0];
                    if (selectedRow.Cells["UserID"].Value != null)
                    {
                        selectedUserId = Convert.ToInt32(selectedRow.Cells["UserID"].Value);
                        txtUsername.Text = selectedRow.Cells["UserName"].Value.ToString();
                        cmbRole.SelectedItem = selectedRow.Cells["Role"].Value.ToString();
                        txtName.Text = selectedRow.Cells["Name"].Value.ToString();
                        txtAddress.Text = selectedRow.Cells["Address"].Value.ToString();
                    }
                }
            
        }

        private void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtName.Text = "";
            txtAddress.Text = "";
            cmbRole.SelectedIndex = 0;
            selectedUserId = -1;
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

