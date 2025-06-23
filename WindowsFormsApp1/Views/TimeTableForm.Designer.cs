namespace WindowsFormsApp1.Views
{
    partial class TimeTableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpManageTimetable = new System.Windows.Forms.GroupBox();
            this.lblTimeslot = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.txtTimeslot = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvTimetable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLecturer = new System.Windows.Forms.ComboBox();
            this.cmbGroupName = new System.Windows.Forms.ComboBox();
            this.grpManageTimetable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // grpManageTimetable
            // 
            this.grpManageTimetable.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpManageTimetable.Controls.Add(this.cmbGroupName);
            this.grpManageTimetable.Controls.Add(this.cmbLecturer);
            this.grpManageTimetable.Controls.Add(this.label2);
            this.grpManageTimetable.Controls.Add(this.label1);
            this.grpManageTimetable.Controls.Add(this.dgvTimetable);
            this.grpManageTimetable.Controls.Add(this.btnDelete);
            this.grpManageTimetable.Controls.Add(this.btnAdd);
            this.grpManageTimetable.Controls.Add(this.cmbRoom);
            this.grpManageTimetable.Controls.Add(this.lblRoom);
            this.grpManageTimetable.Controls.Add(this.lblSubject);
            this.grpManageTimetable.Controls.Add(this.btnUpdate);
            this.grpManageTimetable.Controls.Add(this.txtTimeslot);
            this.grpManageTimetable.Controls.Add(this.cmbSubject);
            this.grpManageTimetable.Controls.Add(this.lblTimeslot);
            this.grpManageTimetable.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpManageTimetable.Location = new System.Drawing.Point(12, 12);
            this.grpManageTimetable.Name = "grpManageTimetable";
            this.grpManageTimetable.Size = new System.Drawing.Size(832, 455);
            this.grpManageTimetable.TabIndex = 0;
            this.grpManageTimetable.TabStop = false;
            this.grpManageTimetable.Text = "Manage Timetable";
            this.grpManageTimetable.Enter += new System.EventHandler(this.grpManageTimetable_Enter);
            // 
            // lblTimeslot
            // 
            this.lblTimeslot.AutoSize = true;
            this.lblTimeslot.Location = new System.Drawing.Point(33, 54);
            this.lblTimeslot.Name = "lblTimeslot";
            this.lblTimeslot.Size = new System.Drawing.Size(175, 23);
            this.lblTimeslot.TabIndex = 0;
            this.lblTimeslot.Text = "Enter the Timeslot :";
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(214, 110);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(146, 31);
            this.cmbSubject.TabIndex = 1;
            // 
            // txtTimeslot
            // 
            this.txtTimeslot.Location = new System.Drawing.Point(214, 54);
            this.txtTimeslot.Name = "txtTimeslot";
            this.txtTimeslot.Size = new System.Drawing.Size(134, 30);
            this.txtTimeslot.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(37, 319);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 39);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(33, 118);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(171, 23);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = " Select the Subject :";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(421, 54);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(157, 23);
            this.lblRoom.TabIndex = 5;
            this.lblRoom.Text = "Select the Room :";
            // 
            // cmbRoom
            // 
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(584, 51);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(146, 31);
            this.cmbRoom.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(37, 254);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 34);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(35, 382);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 35);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvTimetable
            // 
            this.dgvTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimetable.Location = new System.Drawing.Point(159, 242);
            this.dgvTimetable.Name = "dgvTimetable";
            this.dgvTimetable.Size = new System.Drawing.Size(649, 207);
            this.dgvTimetable.TabIndex = 9;
            this.dgvTimetable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimetable_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select the Lecturer :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select the Group Name :";
            // 
            // cmbLecturer
            // 
            this.cmbLecturer.FormattingEnabled = true;
            this.cmbLecturer.Location = new System.Drawing.Point(619, 175);
            this.cmbLecturer.Name = "cmbLecturer";
            this.cmbLecturer.Size = new System.Drawing.Size(146, 31);
            this.cmbLecturer.TabIndex = 12;
            // 
            // cmbGroupName
            // 
            this.cmbGroupName.FormattingEnabled = true;
            this.cmbGroupName.Location = new System.Drawing.Point(640, 107);
            this.cmbGroupName.Name = "cmbGroupName";
            this.cmbGroupName.Size = new System.Drawing.Size(146, 31);
            this.cmbGroupName.TabIndex = 13;
            // 
            // TimeTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(856, 479);
            this.Controls.Add(this.grpManageTimetable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TimeTableForm";
            this.Text = "TimeTable";
            this.grpManageTimetable.ResumeLayout(false);
            this.grpManageTimetable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpManageTimetable;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtTimeslot;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label lblTimeslot;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvTimetable;
        private System.Windows.Forms.ComboBox cmbGroupName;
        private System.Windows.Forms.ComboBox cmbLecturer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}