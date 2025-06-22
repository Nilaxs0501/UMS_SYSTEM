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
    public partial class MainForm : Form
    {
        private Users currentUser;
        public string role_01;
        public MainForm(Users user)
        {
            InitializeComponent();
            currentUser = user;
            lblWelcome.Text = $"Welcome {user.UserName} ({user.Role})";
            ConfigureRoleAccess(user.Role);

        }
        private void ConfigureRoleAccess(string role)
        {
            btnStudents.Visible = role == "Admin" || role == "Staff" || role == "Student";
            btnLecturer.Visible = role == "Admin" || role == "Staff" || role == "Lecturer";
            btnExam.Visible = role == "Student" || role == "Admin" ||  role == "Lecturer";
            btnViewMarks.Visible = role == "Lecturer" || role == "Admin" || role == "Staff";
            btnAttendence.Visible = role == "Admin" || role == "Staff";
            btnTimetable.Visible = true;
            btnChangePassword.Visible = true; 
            btnAddUser.Visible = true;
            role_01=role;
            
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
            var login = new LoginForm();
            login.ShowDialog();
            this.Close();
        }

        private void panel_DashBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            LoadForm(new ChangePasswordForm());
        }

        private void btn_lecturer_Click(object sender, EventArgs e)
        {
            LoadForm(new LecturerForm());
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {

            //CourseSubjectManagementForm form = new CourseSubjectManagementForm(role_);
            //LoadForm(form);
            //form.Show();
            LoadForm(new CourseSubjectManagementForm( role_01));
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            LoadForm(new ExamMarkManageMentForm());
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            LoadForm(new StudentForm());    
        }
    }
    
}
