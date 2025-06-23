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
    public partial class ExamMarkManageMentForm : Form
    {
        private int selectedExamId = -1;
        private int selectedMarkId = -1;
       
        public ExamMarkManageMentForm()
        {

            InitializeComponent();
            LoadSubjects();
            LoadStudents();
            LoadExam();
            LoadMarks();
            

        }
        private void LoadSubjects()
        {
            var subjects = SubjectController.GetAllSubjects();
            cmbSubject.DataSource = subjects;
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";
            cmbSubject.SelectedIndex = subjects.Count > 0 ? 0 : -1;
        }

        private void LoadExam()
        {
            var exams = ExamController.GetAllExams();

            // For DataGridView
            dataGridViewExam.DataSource = exams;

            // For ComboBox
            cmbExam.DataSource = exams;
            cmbExam.DisplayMember = "ExamName";
            cmbExam.ValueMember = "ExamID";
            cmbExam.SelectedIndex = exams.Count > 0 ? 0 : -1;

            selectedExamId = -1;
        }
        private void LoadStudents()
        {

            var students = StudentController.GetAllStudents();
            cmbStudent.DataSource = students;
            cmbStudent.DisplayMember = "StudentName";
            cmbStudent.ValueMember = "StudentID";
            cmbStudent.SelectedIndex = students.Count > 0 ? 0 : -1;
        }
        

        private void LoadMarks()
        {
            dataGridViewMarks.DataSource = MarkController.GetAllMarks();
            selectedMarkId = -1;
        }
        
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            Exam exam = new Exam
            {
                ExamName = txtExamName.Text,
                SubjectID = Convert.ToInt32(cmbSubject.SelectedValue),
                ExamDate = dtpExamDate.Value.ToString("yyyy-MM-dd"),
                ExamStartTime = dtpSTime.Value.ToString("HH:mm"),
                ExamEndTime = dtpeETime.Value.ToString("HH:mm")
            };

            if (ExamController.AddExam(exam))
            {
                MessageBox.Show("Exam added successfully.");
                LoadExam();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to update.");
                return;
            }

            Exam exam = new Exam
            {
                ExamID = selectedExamId,
                SubjectID = Convert.ToInt32(cmbSubject.SelectedValue),
                ExamName = txtExamName.Text,
                ExamDate = dtpExamDate.Value.ToString("yyyy-MM-dd"),
                ExamStartTime = dtpSTime.Value.ToString("HH:mm"),
                ExamEndTime = dtpeETime.Value.ToString("HH:mm")
            };

            if (ExamController.UpdateExam(exam))
            {
                MessageBox.Show("Exam updated successfully.");
                LoadExam();
            }
            else
            {
                MessageBox.Show("Failed to update exam.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to delete.");
                return;
            }

            if (ExamController.DeleteExam(selectedExamId))
            {
                MessageBox.Show("Exam deleted successfully.");
                LoadExam();
            }
            else
            {
                MessageBox.Show("Failed to delete exam.");
            }
        }

        private void dataGridViewExam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //if (dataGridViewExam.SelectedRows.Count > 0)
            //{
            //    var row = dataGridViewExam.SelectedRows[0];
            //    selectedExamId = Convert.ToInt32(row.Cells["ExamID"].Value);
            //    txtExamName.Text = row.Cells["ExamName"].Value.ToString();
            //    cmbSubject.SelectedValue = row.Cells["SubjectID"].Value;
            //    dtpExamDate.Value = DateTime.Parse(row.Cells["ExamDate"].Value.ToString());
            //    dtpSTime.Value = DateTime.ParseExact(row.Cells["ExamStartTime"].Value.ToString(), "HH:mm", null);
            //    dtpeETime.Value = DateTime.ParseExact(row.Cells["ExamEndTime"].Value.ToString(), "HH:mm", null);
            //}
        }
        private void dataGridViewExam_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewExam.SelectedRows.Count > 0)
            {
                var row = dataGridViewExam.SelectedRows[0];
                selectedExamId = Convert.ToInt32(row.Cells["ExamID"].Value);
                txtExamName.Text = row.Cells["ExamName"].ToString();
                cmbSubject.SelectedValue = Convert.ToInt32(row.Cells["SubjectID"].Value);
                if (DateTime.TryParse(row.Cells["ExamDate"].Value?.ToString(), out DateTime examDate))
                    dtpExamDate.Value = examDate;

                if (DateTime.TryParseExact(row.Cells["ExamStartTime"].Value?.ToString(), "HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime startTime))
                    dtpSTime.Value = startTime;

                if (DateTime.TryParseExact(row.Cells["ExamEndTime"].Value?.ToString(), "HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime endTime))
                    dtpeETime.Value = endTime;
            }
        }
        private void btnAddMarks_Click(object sender, EventArgs e)
        {
            if (cmbStudent.SelectedValue == null || cmbExam.SelectedValue == null)
            {
                MessageBox.Show("Please select both a student and an exam.");
                return;
            }

            Mark mark = new Mark
            {
                StudentID = Convert.ToInt32(cmbStudent.SelectedValue),
                ExamID = Convert.ToInt32(cmbExam.SelectedValue),
                Score = (int)numScore.Value
            };

            if (MarkController.AddMark(mark))
            {
                MessageBox.Show("Mark added successfully.");
                LoadMarks();
            }
            else
            {
                MessageBox.Show("Failed to add mark.");
            }
        }

        private void btnUpdateMarks_Click(object sender, EventArgs e)
        {
            if (selectedMarkId == -1)
            {
                MessageBox.Show("Please select a mark to update.");
                return;
            }

            Mark mark = new Mark
            {
                MarkID = selectedMarkId,
                StudentID = Convert.ToInt32(cmbStudent.SelectedValue),
                ExamID = Convert.ToInt32(cmbExam.SelectedValue),
                Score = (int)numScore.Value
            };

            if (MarkController.UpdateMark(mark))
            {
                MessageBox.Show("Mark updated successfully.");
                LoadMarks();
            }
            else
            {
                MessageBox.Show("Failed to update mark.");
            }
        }

        private void btnDeleteMarks_Click(object sender, EventArgs e)
        {
            if (selectedMarkId == -1)
            {
                MessageBox.Show("Please select a mark to delete.");
                return;
            }

            if (MarkController.DeleteMark(selectedMarkId))
            {
                MessageBox.Show("Mark deleted successfully.");
                LoadMarks();
            }
            else
            {
                MessageBox.Show("Failed to delete mark.");
            }
        }

        private void dataGridViewMarks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridViewMarks.SelectedRows.Count > 0)
            //{
            //    var row = dataGridViewMarks.SelectedRows[0];
            //    selectedMarkId = Convert.ToInt32(row.Cells["MarkID"].Value);
            //    cmbStudent.SelectedValue = row.Cells["StudentID"].Value;
            //    cmbExam.SelectedValue = row.Cells["ExamID"].Value;
            //    numScore.Value = Convert.ToInt32(row.Cells["Score"].Value);
            //}
        }

        private void dataGridViewMarks_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMarks.SelectedRows.Count > 0)
            {
                var row = dataGridViewMarks.SelectedRows[0];
                selectedMarkId = Convert.ToInt32(row.Cells["MarkID"].Value);
                cmbStudent.SelectedValue = Convert.ToInt32(row.Cells["StudentID"].Value);
                cmbExam.SelectedValue = Convert.ToInt32(row.Cells["ExamID"].Value);
                numScore.Value = Convert.ToInt32(row.Cells["Score"].Value);
            }
        }

        private void ExamMarkManageMentForm_Load(object sender, EventArgs e)
        {
            dataGridViewExam.SelectionChanged += dataGridViewExam_SelectionChanged;
            dataGridViewMarks.SelectionChanged += dataGridViewMarks_SelectionChanged;
        }
    }
}
