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
    public partial class LecturerForm : Form
    {
        private int selectedLecturerId = -1;

        public LecturerForm()
        {
            InitializeComponent();
            LoadSubjects();
            LoadLecturers();
        }

        private void LoadSubjects()
        {
            cmbSubject.DataSource = SubjectController.GetAllSubjects();
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";
            cmbSubject.SelectedIndex = -1;
        }

        private void LoadLecturers()
        {
            dgvLecturers.DataSource = LecturerController.GetAllLecturers();
            dgvLecturers.ClearSelection();
            selectedLecturerId = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Lecturer lecturer = GetLecturerFromForm();
            if (LecturerController.AddLecturer(lecturer))
            {
                MessageBox.Show("Lecturer added successfully");
                LoadLecturers();
                ClearForm();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedLecturerId == -1)
            {
                MessageBox.Show("Please select a lecturer to update.");
                return;
            }

            Lecturer lecturer = GetLecturerFromForm();
            lecturer.LecturerID = selectedLecturerId;

            if (LecturerController.UpdateLecturer(lecturer))
            {
                MessageBox.Show("Lecturer updated successfully");
                LoadLecturers();
                ClearForm();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedLecturerId == -1)
            {
                MessageBox.Show("Please select a lecturer to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure to delete this lecturer?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                if (LecturerController.DeleteLecturer(selectedLecturerId))
                {
                    MessageBox.Show("Lecturer deleted successfully");
                    LoadLecturers();
                    ClearForm();
                }
            }
        }

        private void dgvLecturers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLecturers.SelectedRows.Count > 0)
            {
                var row = dgvLecturers.SelectedRows[0];

                selectedLecturerId = Convert.ToInt32(row.Cells["LecturerID"].Value);
                txtName.Text = row.Cells["LecturerName"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPhone.Text = row.Cells["PhoneNumber"].Value.ToString();
                numAge.Value = Convert.ToInt32(row.Cells["Age"].Value);
                cmbSubject.SelectedValue = Convert.ToInt32(row.Cells["SubjectID"].Value);

                string gender = row.Cells["Gender"].Value.ToString();
                rdoMale.Checked = gender == "Male";
                rdoFemale.Checked = gender == "Female";
            }
        }
            private Lecturer GetLecturerFromForm()
            {
                string gender = rdoMale.Checked ? "Male" : rdoFemale.Checked ? "Female" : "";

                return new Lecturer
                {
                LecturerName = txtName.Text,
                Address = txtAddress.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhone.Text,
                Age = (int)numAge.Value,
                Gender = gender,
                SubjectID = Convert.ToInt32(cmbSubject.SelectedValue)
                };
             }

        private void ClearForm()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            numAge.Value = 30;
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            cmbSubject.SelectedIndex = -1;
            selectedLecturerId = -1;
        }
    }
    
}
