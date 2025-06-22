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
            cmbSubject.DataSource = SubjectController.GetAllSubjects();
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";
        }

        private void LoadExams()
        {
            dataGridViewExam.DataSource = ExamController.GetAllExams();
        }
        private void LoadStudents()
        {
            cmbStudent.DataSource = StudentController.GetAllStudents();
            cmbStudent.DisplayMember = "StudentName";
            cmbStudent.ValueMember = "StudentID";
        }
        private void LoadExam()
        {
            dataGridViewExam.DataSource = ExamController.GetAllExams();
            selectedExamId = -1;
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
                SubjectID = (int)cmbSubject.SelectedValue,
                ExamName = txtExamName.Text,
                ExamDate = dtpExamDate.Value.ToString("yyyy-MM-dd"),
                ExamStartTime = dtpSTime.Value.ToString("HH:mm"),
                ExamEndTime = dtpeETime.Value.ToString("HH:mm")

            };

            if (ExamController.UpdateExam(exam))
            {
                MessageBox.Show("Exam updated successfully.");
                LoadExams();
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
                LoadExams();
            }
            else
            {
                MessageBox.Show("Failed to delete exam.");
            }
        }

        private void dataGridViewExam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridViewExam.SelectedRows.Count > 0)
            {
                var row = dataGridViewExam.SelectedRows[0];
                selectedExamId = Convert.ToInt32(row.Cells["ExamID"].Value);
                txtExamName.Text = row.Cells["ExamName"].Value.ToString();
                cmbSubject.SelectedValue = row.Cells["SubjectID"].Value;
                dtpExamDate.Value = DateTime.Parse(row.Cells["ExamDate"].Value.ToString());
                dtpSTime.Value = DateTime.ParseExact(row.Cells["ExamStartTime"].Value.ToString(), "HH:mm", null);
                dtpeETime.Value = DateTime.ParseExact(row.Cells["ExamEndTime"].Value.ToString(), "HH:mm", null);
            }
        }

        private void btnAddMarks_Click(object sender, EventArgs e)
        {
            Mark mark = new Mark
            {
                StudentID = (int)cmbStudent.SelectedValue,
                ExamID = (int)cmbExam.SelectedValue,
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
                StudentID = (int)cmbStudent.SelectedValue,
                ExamID = (int)cmbExam.SelectedValue,
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
            if (dataGridViewMarks.SelectedRows.Count > 0)
            {
                var row = dataGridViewMarks.SelectedRows[0];
                selectedMarkId = Convert.ToInt32(row.Cells["MarkID"].Value);
                cmbStudent.SelectedValue = row.Cells["StudentID"].Value;
                cmbExam.SelectedValue = row.Cells["ExamID"].Value;
                numScore.Value = Convert.ToInt32(row.Cells["Score"].Value);
            }
        }
    }
    
    
}
