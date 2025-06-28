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
    public partial class AttendanceForm : Form
    {
        private int selectedAttendanceId = -1;
        private int selectedStudentId = -1;
        public AttendanceForm()
        {
            InitializeComponent();
            LoadSubjects();
            LoadStatuses();
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.CellClick += dgvAttendance_CellContentClick;

        }
        private void LoadSubjects()
        {
            cmbSubject.DataSource = SubjectController.GetAllSubjects();
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";
            cmbSubject.SelectedIndex = -1;
        }
        private void LoadStatuses()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new string[] { "Present", "Absent", "Late", "Excused" });
            cmbStatus.SelectedIndex = -1;
        }
        private void grpManageAttendance_Enter(object sender, EventArgs e)
        {

        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cmbSubject.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a subject.");
                return;
            }

            int subjectId = Convert.ToInt32(cmbSubject.SelectedValue);
            string date = dtpDate.Value.ToString("yyyy-MM-dd");

            dgvAttendance.DataSource = AttendanceController.GetAttendanceBySubjectAndDate(subjectId, date);
            dgvAttendance.ClearSelection();

            selectedAttendanceId = -1;
            selectedStudentId = -1;
            txtStudentName.Clear();
            cmbStatus.SelectedIndex = -1;
        }

        private void dgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvAttendance.Rows.Count > e.RowIndex)
            {
                var row = dgvAttendance.Rows[e.RowIndex];

                selectedAttendanceId = Convert.ToInt32(row.Cells["AttendanceID"].Value);
                selectedStudentId = Convert.ToInt32(row.Cells["StudentID"].Value);
                txtStudentName.Text = row.Cells["StudentName"].Value.ToString();
                cmbStatus.Text = row.Cells["Status"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbSubject.SelectedIndex == -1 || cmbStatus.SelectedIndex == -1 || selectedStudentId == -1)
            {
                MessageBox.Show("Please load and select a student, subject, and status.");
                return;
            }

            var att = new Attendance
            {
                StudentID = selectedStudentId,
                SubjectID = Convert.ToInt32(cmbSubject.SelectedValue),
                Date = dtpDate.Value.ToString("yyyy-MM-dd"),
                Status = cmbStatus.Text
            };

            if (AttendanceController.AddAttendance(att))
            {
                MessageBox.Show("Attendance added.");
                btnLoad_Click(null, null); // refresh
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedAttendanceId == -1)
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }

            var att = new Attendance
            {
                AttendanceID = selectedAttendanceId,
                Status = cmbStatus.Text
            };

            if (AttendanceController.UpdateAttendance(att))
            {
                MessageBox.Show("Attendance updated.");
                btnLoad_Click(null, null);
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedAttendanceId == -1)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                if (AttendanceController.DeleteAttendance(selectedAttendanceId))
                {
                    MessageBox.Show("Attendance deleted.");
                    btnLoad_Click(null, null);
                }
            }

        }
    }
}
