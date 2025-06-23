using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public partial class TimeTableForm : Form
    {
        private int selectedTimetableId = -1;

        public TimeTableForm()
        {
            InitializeComponent();
            LoadSubjects();
            LoadRooms();
            LoadLecturers();
            LoadTimetables();
            dgvTimetable.CellClick += dgvTimetable_CellContentClick;

            LoadGroupNames();
        }
        private void LoadGroupNames()
        {
            cmbGroupName.Items.Clear();
            cmbGroupName.Items.Add("A");
            cmbGroupName.Items.Add("B");
            cmbGroupName.SelectedIndex = -1; // Nothing selected by default
        }
        private void LoadSubjects()
        {
            cmbSubject.DataSource = SubjectController.GetAllSubjects();
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";
            cmbSubject.SelectedIndex = -1;
        }

        private void LoadRooms()
        {
            cmbRoom.DataSource = RoomController.GetAllRooms();
            cmbRoom.DisplayMember = "RoomName";
            cmbRoom.ValueMember = "RoomID";
            cmbRoom.SelectedIndex = -1;
        }

        private void LoadLecturers()
        {
            cmbLecturer.DataSource = LecturerController.GetAllLecturers();
            cmbLecturer.DisplayMember = "LecturerName";
            cmbLecturer.ValueMember = "LecturerID";
            cmbLecturer.SelectedIndex = -1;
        }

        private void LoadTimetables()
        {
            dgvTimetable.DataSource = TimeTableController.GetAllTimetables();
            dgvTimetable.ClearSelection();
            selectedTimetableId = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Timetable t = GetTimetableFromForm();
            if (TimeTableController.AddTimetable(t))
            {
                MessageBox.Show("Timetable added successfully");
                LoadTimetables();
                ClearForm();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedTimetableId == -1)
            {
                MessageBox.Show("Please select a timetable entry to update.");
                return;
            }

            Timetable t = GetTimetableFromForm();
            t.TimetableID = selectedTimetableId;
            if (TimeTableController.UpdateTimetable(t))
            {
                MessageBox.Show("Timetable updated successfully.");
                LoadTimetables();
                ClearForm();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedTimetableId == -1)
            {
                MessageBox.Show("Please select a timetable entry to delete.");
                return;
            }

            if (TimeTableController.DeleteTimetable(selectedTimetableId))
            {
                MessageBox.Show("Timetable deleted successfully.");
                LoadTimetables();
                ClearForm();
            }
        }
        
        private Timetable GetTimetableFromForm()
        {
            return new Timetable
            {
                SubjectID = (int)cmbSubject.SelectedValue,
                RoomID = (int)cmbRoom.SelectedValue,
                LecturerID = (int)cmbLecturer.SelectedValue,
                GroupName = cmbGroupName.Text,
                TimeSlot = txtTimeslot.Text.Trim()
            };
        }

        private void ClearForm()
        {
            txtTimeslot.Clear();
            cmbSubject.SelectedIndex = -1;
            cmbRoom.SelectedIndex = -1;
            cmbLecturer.SelectedIndex = -1;
            cmbGroupName.SelectedIndex = -1;
            selectedTimetableId = -1;
        }

        private void grpManageTimetable_Enter(object sender, EventArgs e)
        {

        }

        private void dgvTimetable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTimetable.Rows[e.RowIndex];

                selectedTimetableId = Convert.ToInt32(row.Cells["TimetableID"].Value);
                cmbSubject.Text = row.Cells["SubjectName"].Value.ToString();
                txtTimeslot.Text = row.Cells["TimeSlot"].Value.ToString();
                cmbRoom.Text = row.Cells["RoomName"].Value.ToString();
                cmbLecturer.Text = row.Cells["LecturerName"].Value.ToString();
                cmbGroupName.Text = row.Cells["GroupName"].Value.ToString();
            }
        }
    }

}
