using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
   
    public partial class StudentForm : Form
    {
        private int selectedStudentId = -1;
        public StudentForm()
        {
            InitializeComponent();
            LoadCourseComboBox();
            LoadStudentList();
        }
        private void LoadCourseComboBox()
        {
            cmbCourse.DataSource = CourseController.GetAllCourses();
            cmbCourse.DisplayMember = "CourseName";
            cmbCourse.ValueMember = "CourseID";
            cmbCourse.SelectedIndex = -1;
        }

        private void LoadStudentList()
        {
            dgvStudents.DataSource = StudentController.GetAllStudents();
            dgvStudents.ClearSelection();
            selectedStudentId = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = GetStudentFromForm();
            if (StudentController.AddStudent(student))
            {
                MessageBox.Show("Student added successfully");
                LoadStudentList();
                ClearForm();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            Student student = GetStudentFromForm();
            student.StudentID = selectedStudentId;

            if (StudentController.UpdateStudent(student))
            {
                MessageBox.Show("Student updated successfully");
                LoadStudentList();
                ClearForm();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                if (StudentController.DeleteStudent(selectedStudentId))
                {
                    MessageBox.Show("Student deleted successfully");
                    LoadStudentList();
                    ClearForm();
                }
            }
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                var row = dgvStudents.SelectedRows[0];

                selectedStudentId = Convert.ToInt32(row.Cells["StudentID"].Value);
                txtName.Text = row.Cells["StudentName"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPhone.Text = row.Cells["PhoneNumber"].Value.ToString();
                numAge.Value = Convert.ToInt32(row.Cells["Age"].Value);
                cmbCourse.SelectedValue = Convert.ToInt32(row.Cells["CourseID"].Value);

                string gender = row.Cells["Gender"].Value.ToString();
                rdoMale.Checked = gender == "Male";
                rdoFemale.Checked = gender == "Female";

                string group = row.Cells["GroupName"].Value.ToString();
                rdoGroupA.Checked = group == "A";
                rdoGroupB.Checked = group == "B";
            }
        }
        private Student GetStudentFromForm()
        {
            string gender = rdoMale.Checked ? "Male" : rdoFemale.Checked ? "Female" : "";
            string group = rdoGroupA.Checked ? "A" : rdoGroupB.Checked ? "B" : "";

            return new Student
            {
                StudentName = txtName.Text,
                Address = txtAddress.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhone.Text,
                Age = (int)numAge.Value,
                Gender = gender,
                GroupName = group,
                CourseID = Convert.ToInt32(cmbCourse.SelectedValue)
            };
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            numAge.Value = 18;
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            rdoGroupA.Checked = false;
            rdoGroupB.Checked = false;
            cmbCourse.SelectedIndex = -1;
            selectedStudentId = -1;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}

