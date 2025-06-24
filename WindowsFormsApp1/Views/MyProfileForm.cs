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

namespace WindowsFormsApp1.Views
{
    public partial class MyProfileForm : Form
    {
        public MyProfileForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string input = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter a User ID or Username.");
                return;
            }

            var user = UsersController.GetUserByIdOrUsername(input);

            if (user != null)
            {
                lblName.Text = user.Name;
                lblUsername.Text = user.UserName;
                lblRole.Text = user.Role;
                lblAddress.Text = user.Address;
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }
    }
}
