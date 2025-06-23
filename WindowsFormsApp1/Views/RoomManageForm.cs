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
    public partial class RoomManageForm : Form
    {
        private int selectedRoomId = -1;
        public RoomManageForm()
        {
            InitializeComponent();
            cmbRoomType.Items.AddRange(new[] { " select the Room","Lab", "Hall" });
            cmbRoomType.SelectedIndex = 0;
            dataGridViewRoom.SelectionChanged += dataGridViewRoom_SelectionChanged;
            LoadRooms();
        }
        private void LoadRooms()
        {
            dataGridViewRoom.DataSource = RoomController.GetAllRooms();
            dataGridViewRoom.ClearSelection();
            selectedRoomId = -1;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomName.Text) || cmbRoomType.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter Room Name and select Room Type.");
                return;
            }

            Room room = new Room
            {
                RoomName = txtRoomName.Text.Trim(),
                RoomType = cmbRoomType.SelectedItem.ToString()
            };

            if (RoomController.AddRoom(room))
            {
                MessageBox.Show("Room added successfully.");
                LoadRooms();
                ClearFields();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == -1)
            {
                MessageBox.Show("Please select a room to update.");
                return;
            }

            Room room = new Room
            {
                RoomID = selectedRoomId,
                RoomName = txtRoomName.Text.Trim(),
                RoomType = cmbRoomType.SelectedItem.ToString()
            };

            if (RoomController.UpdateRoom(room))
            {
                MessageBox.Show("Room updated successfully.");
                LoadRooms();
                ClearFields();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == -1)
            {
                MessageBox.Show("Please select a room to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                if (RoomController.DeleteRoom(selectedRoomId))
                {
                    MessageBox.Show("Room deleted successfully.");
                    LoadRooms();
                    ClearFields();
                }
            }
        }

        private void dataGridViewRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        //    if (dataGridViewRoom.SelectedRows.Count > 0)
        //    {
        //        var row = dataGridViewRoom.SelectedRows[0];
        //        selectedRoomId = Convert.ToInt32(row.Cells["RoomID"].Value);
        //        txtRoomName.Text = row.Cells["RoomName"].Value.ToString();
        //        cmbRoomType.SelectedItem = row.Cells["RoomType"].Value.ToString();
        //    }
        }
        private void dataGridViewRoom_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRoom.SelectedRows.Count > 0)
            {
                var row = dataGridViewRoom.SelectedRows[0];
                selectedRoomId = Convert.ToInt32(row.Cells["RoomID"].Value);
                txtRoomName.Text = row.Cells["RoomName"].Value.ToString();
                cmbRoomType.SelectedItem = row.Cells["RoomType"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtRoomName.Clear();
            cmbRoomType.SelectedIndex = 0;
            selectedRoomId = -1;
        }
    }
}
