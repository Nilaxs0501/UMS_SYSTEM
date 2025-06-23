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
    public partial class CourseSubjectManagementForm : Form
    {
        private int selectedCourseId = -1;
        private int selectedSubjectId = -1;
        private string userRole;

        public CourseSubjectManagementForm( string role)
        {
            InitializeComponent();
            userRole = role;

            LoadCourses();
            LoadSubjects();
            LoadCourseDropdown();
            SetRolePermissions();
            dataGridViewCourse.CellClick += dataGridViewCourse_CellContentClick;
            dataGridViewSubject.CellClick += dataGridViewSubject_CellContentClick;

        }
        private void SetRolePermissions()
        {
            bool isAdmin = userRole == "Admin";

            // Course buttons
            btnAddCourse.Enabled = isAdmin;
            btnUpdateCourse.Enabled = isAdmin;
            btnDeleteCourse.Enabled = isAdmin;

            // Subject buttons
            btnAddSubject.Enabled = isAdmin;
            btnUpdateSubject.Enabled = isAdmin;
            btnDeleteSubject.Enabled = isAdmin;
        }
        private void LoadCourses()
        {
            dataGridViewCourse.DataSource = null;
            dataGridViewCourse.DataSource = CourseController.GetAllCourses();
        }
        private void tabCourse_Click(object sender, EventArgs e)
        {

        }

        private void grpCourse_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                MessageBox.Show("Please enter a course name.");
                return;
            }

            var course = new Course { CourseName = txtCourseName.Text.Trim() };
            if (CourseController.AddCourse(course))
            {
                MessageBox.Show("Course added.");
                txtCourseName.Clear();
                LoadCourses();
                LoadCourseDropdown();
            }
            else
            {
                MessageBox.Show("Failed to add course.");
            }
            if (CourseController.CourseExists(txtCourseName.Text.Trim()))
            {
                MessageBox.Show("Course name already exists.");
                return;
            }
        }

        private void dataGridViewCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedCourseId = Convert.ToInt32(dataGridViewCourse.Rows[e.RowIndex].Cells["CourseID"].Value);
                txtCourseName.Text = dataGridViewCourse.Rows[e.RowIndex].Cells["CourseName"].Value.ToString();
            }
        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            if (selectedCourseId == -1)
            {
                MessageBox.Show("Please select a course to update.");
                return;
            }

            var course = new Course
            {
                CourseID = selectedCourseId,
                CourseName = txtCourseName.Text.Trim()
            };

            if (CourseController.UpdateCourse(course))
            {
                MessageBox.Show("Course updated.");
                txtCourseName.Clear();
                LoadCourses();
                LoadCourseDropdown();
                selectedCourseId = -1;
                dataGridViewCourse.ClearSelection();
            }
            else
            {
                MessageBox.Show("Failed to update.");
            }
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (selectedCourseId == -1)
            {
                MessageBox.Show("Please select a course to delete.");
                return;
            }

            if (CourseController.DeleteCourse(selectedCourseId))
            {
                MessageBox.Show("Course deleted.");
                txtCourseName.Clear();
                LoadCourses();
                LoadCourseDropdown();
                selectedCourseId = -1;
                dataGridViewCourse.ClearSelection();
            }
            else
            {
                MessageBox.Show("Delete failed. Check dependencies.");
            }
        }
        private void LoadSubjects()
        {
            dataGridViewSubject.DataSource = null;
            dataGridViewSubject.DataSource = SubjectController.GetAllSubjects();
        }

        private void LoadCourseDropdown()
        {
            var courseList = CourseController.GetAllCourses();
            cmbCourse.DataSource = courseList;
            cmbCourse.DisplayMember = "CourseName";
            cmbCourse.ValueMember = "CourseID";
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubjectName.Text) || cmbCourse.SelectedIndex == -1)
            {
                MessageBox.Show("Enter subject name and select course.");
                return;
            }

            var subject = new Subject
            {
                SubjectName = txtSubjectName.Text.Trim(),
                CourseID = Convert.ToInt32(cmbCourse.SelectedValue)
            };

            if (SubjectController.AddSubject(subject))
            {
                MessageBox.Show("Subject added.");
                txtSubjectName.Clear();
                LoadSubjects();
            }
            else
            {
                MessageBox.Show("Failed to add subject.");
            }

           
            if (SubjectController.SubjectExists(txtSubjectName.Text.Trim(), Convert.ToInt32(cmbCourse.SelectedValue)))
            {
                MessageBox.Show("This subject already exists for the selected course.");
                return;
            }

        }



        private void dataGridViewSubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedSubjectId = Convert.ToInt32(dataGridViewSubject.Rows[e.RowIndex].Cells["SubjectID"].Value);
                txtSubjectName.Text = dataGridViewSubject.Rows[e.RowIndex].Cells["SubjectName"].Value.ToString();
                cmbCourse.SelectedValue = Convert.ToInt32(dataGridViewSubject.Rows[e.RowIndex].Cells["CourseID"].Value);
            }
        }

        private void btnUpdateSubject_Click(object sender, EventArgs e)
        {
            if (selectedSubjectId == -1)
            {
                MessageBox.Show("Please select a subject to update.");
                return;
            }

            var subject = new Subject
            {
                SubjectID = selectedSubjectId,
                SubjectName = txtSubjectName.Text.Trim(),
                CourseID = Convert.ToInt32(cmbCourse.SelectedValue)
            };

            if (SubjectController.UpdateSubject(subject))
            {
                MessageBox.Show("Subject updated.");
                txtSubjectName.Clear();
                LoadSubjects();
                selectedSubjectId = -1;
                dataGridViewSubject.ClearSelection();
            }
            else
            {
                MessageBox.Show("Failed to update subject.");
            }
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            if (selectedSubjectId == -1)
            {
                MessageBox.Show("Please select a subject to delete.");
                return;
            }

            if (SubjectController.DeleteSubject(selectedSubjectId))
            {
                MessageBox.Show("Subject deleted.");
                txtSubjectName.Clear();
                LoadSubjects();
                selectedSubjectId = -1;
                dataGridViewSubject.ClearSelection();
            }
            else
            {
                MessageBox.Show("Failed to delete subject.");
            }
        }
    }
}
