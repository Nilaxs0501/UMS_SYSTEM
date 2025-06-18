using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public partial class Main : Form
    {
        public Main(Users user)
        {
            InitializeComponent();
           
        }

        public void LoadForm(object formObj)
        {
            if (this.panel_DashBoard.Controls.Count > 0)
            {
                this.panel_DashBoard.Controls.RemoveAt(0);
            }

            Form form = formObj as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panel_DashBoard.Controls.Add(form);
            this.panel_DashBoard.Tag = form;
            form.Show();
        }








        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_user_Click(object sender, EventArgs e)
        {
             LoadForm(new UsersForm());
        }

        private void Main_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void panel_DashBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void btnNextpage_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var Main2 = new SubMain();
            Main2.ShowDialog();
            this.Close();
        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            LoadForm(new ChangePasswordForm());
        }

        private void btn_lecturer_Click(object sender, EventArgs e)
        {

        }
    }
}
