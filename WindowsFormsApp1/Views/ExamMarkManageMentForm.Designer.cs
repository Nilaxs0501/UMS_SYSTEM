namespace WindowsFormsApp1.Views
{
    partial class ExamMarkManageMentForm
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
            this.tabExamMarkManageMent = new System.Windows.Forms.TabControl();
            this.tabExam = new System.Windows.Forms.TabPage();
            this.grpExams = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddExam = new System.Windows.Forms.Button();
            this.dtpeETime = new System.Windows.Forms.DateTimePicker();
            this.lblExamEtime = new System.Windows.Forms.Label();
            this.dataGridViewExam = new System.Windows.Forms.DataGridView();
            this.lblExamName = new System.Windows.Forms.Label();
            this.dtpExamDate = new System.Windows.Forms.DateTimePicker();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.dtpSTime = new System.Windows.Forms.DateTimePicker();
            this.lblExamStime = new System.Windows.Forms.Label();
            this.txtExamName = new System.Windows.Forms.TextBox();
            this.lblSelectSubject = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.tabMark = new System.Windows.Forms.TabPage();
            this.grpMarks = new System.Windows.Forms.GroupBox();
            this.btnDeleteMarks = new System.Windows.Forms.Button();
            this.btnUpdateMarks = new System.Windows.Forms.Button();
            this.btnAddMarks = new System.Windows.Forms.Button();
            this.dataGridViewMarks = new System.Windows.Forms.DataGridView();
            this.numScore = new System.Windows.Forms.NumericUpDown();
            this.lblEnterScore = new System.Windows.Forms.Label();
            this.cmbExam = new System.Windows.Forms.ComboBox();
            this.lblSelectExam = new System.Windows.Forms.Label();
            this.lblSelectStudent = new System.Windows.Forms.Label();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.tabExamMarkManageMent.SuspendLayout();
            this.tabExam.SuspendLayout();
            this.grpExams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExam)).BeginInit();
            this.tabMark.SuspendLayout();
            this.grpMarks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).BeginInit();
            this.SuspendLayout();
            // 
            // tabExamMarkManageMent
            // 
            this.tabExamMarkManageMent.Controls.Add(this.tabExam);
            this.tabExamMarkManageMent.Controls.Add(this.tabMark);
            this.tabExamMarkManageMent.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabExamMarkManageMent.Location = new System.Drawing.Point(3, 12);
            this.tabExamMarkManageMent.Name = "tabExamMarkManageMent";
            this.tabExamMarkManageMent.SelectedIndex = 0;
            this.tabExamMarkManageMent.Size = new System.Drawing.Size(857, 462);
            this.tabExamMarkManageMent.TabIndex = 0;
            // 
            // tabExam
            // 
            this.tabExam.Controls.Add(this.grpExams);
            this.tabExam.Location = new System.Drawing.Point(4, 34);
            this.tabExam.Name = "tabExam";
            this.tabExam.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabExam.Size = new System.Drawing.Size(849, 424);
            this.tabExam.TabIndex = 0;
            this.tabExam.Text = "Exam";
            this.tabExam.UseVisualStyleBackColor = true;
            this.tabExam.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // grpExams
            // 
            this.grpExams.Controls.Add(this.btnUpdate);
            this.grpExams.Controls.Add(this.btnDelete);
            this.grpExams.Controls.Add(this.btnAddExam);
            this.grpExams.Controls.Add(this.dtpeETime);
            this.grpExams.Controls.Add(this.lblExamEtime);
            this.grpExams.Controls.Add(this.dataGridViewExam);
            this.grpExams.Controls.Add(this.lblExamName);
            this.grpExams.Controls.Add(this.dtpExamDate);
            this.grpExams.Controls.Add(this.lblSelectDate);
            this.grpExams.Controls.Add(this.dtpSTime);
            this.grpExams.Controls.Add(this.lblExamStime);
            this.grpExams.Controls.Add(this.txtExamName);
            this.grpExams.Controls.Add(this.lblSelectSubject);
            this.grpExams.Controls.Add(this.cmbSubject);
            this.grpExams.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpExams.Location = new System.Drawing.Point(6, 6);
            this.grpExams.Name = "grpExams";
            this.grpExams.Size = new System.Drawing.Size(840, 424);
            this.grpExams.TabIndex = 0;
            this.grpExams.TabStop = false;
            this.grpExams.Text = "Manage Exam";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(415, 181);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 31);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(567, 181);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 31);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddExam
            // 
            this.btnAddExam.Location = new System.Drawing.Point(269, 181);
            this.btnAddExam.Name = "btnAddExam";
            this.btnAddExam.Size = new System.Drawing.Size(85, 35);
            this.btnAddExam.TabIndex = 11;
            this.btnAddExam.Text = "Add";
            this.btnAddExam.UseVisualStyleBackColor = true;
            this.btnAddExam.Click += new System.EventHandler(this.btnAddExam_Click);
            // 
            // dtpeETime
            // 
            this.dtpeETime.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpeETime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpeETime.Location = new System.Drawing.Point(225, 120);
            this.dtpeETime.Name = "dtpeETime";
            this.dtpeETime.ShowUpDown = true;
            this.dtpeETime.Size = new System.Drawing.Size(103, 23);
            this.dtpeETime.TabIndex = 10;
            // 
            // lblExamEtime
            // 
            this.lblExamEtime.AutoSize = true;
            this.lblExamEtime.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamEtime.Location = new System.Drawing.Point(23, 124);
            this.lblExamEtime.Name = "lblExamEtime";
            this.lblExamEtime.Size = new System.Drawing.Size(200, 19);
            this.lblExamEtime.TabIndex = 9;
            this.lblExamEtime.Text = "Select the Exam End Time :";
            // 
            // dataGridViewExam
            // 
            this.dataGridViewExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExam.Location = new System.Drawing.Point(208, 223);
            this.dataGridViewExam.Name = "dataGridViewExam";
            this.dataGridViewExam.RowHeadersWidth = 51;
            this.dataGridViewExam.Size = new System.Drawing.Size(595, 193);
            this.dataGridViewExam.TabIndex = 8;
            this.dataGridViewExam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExam_CellContentClick);
            // 
            // lblExamName
            // 
            this.lblExamName.AutoSize = true;
            this.lblExamName.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamName.Location = new System.Drawing.Point(367, 43);
            this.lblExamName.Name = "lblExamName";
            this.lblExamName.Size = new System.Drawing.Size(169, 19);
            this.lblExamName.TabIndex = 7;
            this.lblExamName.Text = "Enter the Exam Name :";
            // 
            // dtpExamDate
            // 
            this.dtpExamDate.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExamDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExamDate.Location = new System.Drawing.Point(225, 43);
            this.dtpExamDate.Name = "dtpExamDate";
            this.dtpExamDate.ShowUpDown = true;
            this.dtpExamDate.Size = new System.Drawing.Size(103, 23);
            this.dtpExamDate.TabIndex = 6;
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDate.Location = new System.Drawing.Point(23, 43);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(163, 19);
            this.lblSelectDate.TabIndex = 5;
            this.lblSelectDate.Text = "Select the Exam Date :";
            // 
            // dtpSTime
            // 
            this.dtpSTime.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSTime.Location = new System.Drawing.Point(225, 81);
            this.dtpSTime.Name = "dtpSTime";
            this.dtpSTime.ShowUpDown = true;
            this.dtpSTime.Size = new System.Drawing.Size(103, 23);
            this.dtpSTime.TabIndex = 4;
            // 
            // lblExamStime
            // 
            this.lblExamStime.AutoSize = true;
            this.lblExamStime.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamStime.Location = new System.Drawing.Point(23, 81);
            this.lblExamStime.Name = "lblExamStime";
            this.lblExamStime.Size = new System.Drawing.Size(204, 19);
            this.lblExamStime.TabIndex = 3;
            this.lblExamStime.Text = "Select the Exam Start Time :";
            // 
            // txtExamName
            // 
            this.txtExamName.Location = new System.Drawing.Point(546, 29);
            this.txtExamName.Name = "txtExamName";
            this.txtExamName.Size = new System.Drawing.Size(121, 30);
            this.txtExamName.TabIndex = 2;
            // 
            // lblSelectSubject
            // 
            this.lblSelectSubject.AutoSize = true;
            this.lblSelectSubject.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSubject.Location = new System.Drawing.Point(399, 92);
            this.lblSelectSubject.Name = "lblSelectSubject";
            this.lblSelectSubject.Size = new System.Drawing.Size(137, 19);
            this.lblSelectSubject.TabIndex = 1;
            this.lblSelectSubject.Text = "Select the Subject :";
            // 
            // cmbSubject
            // 
            this.cmbSubject.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(546, 92);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(121, 27);
            this.cmbSubject.TabIndex = 0;
            // 
            // tabMark
            // 
            this.tabMark.Controls.Add(this.grpMarks);
            this.tabMark.Location = new System.Drawing.Point(4, 34);
            this.tabMark.Name = "tabMark";
            this.tabMark.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabMark.Size = new System.Drawing.Size(849, 424);
            this.tabMark.TabIndex = 1;
            this.tabMark.Text = "Mark";
            this.tabMark.UseVisualStyleBackColor = true;
            // 
            // grpMarks
            // 
            this.grpMarks.Controls.Add(this.btnDeleteMarks);
            this.grpMarks.Controls.Add(this.btnUpdateMarks);
            this.grpMarks.Controls.Add(this.btnAddMarks);
            this.grpMarks.Controls.Add(this.dataGridViewMarks);
            this.grpMarks.Controls.Add(this.numScore);
            this.grpMarks.Controls.Add(this.lblEnterScore);
            this.grpMarks.Controls.Add(this.cmbExam);
            this.grpMarks.Controls.Add(this.lblSelectExam);
            this.grpMarks.Controls.Add(this.lblSelectStudent);
            this.grpMarks.Controls.Add(this.cmbStudent);
            this.grpMarks.Location = new System.Drawing.Point(7, 7);
            this.grpMarks.Name = "grpMarks";
            this.grpMarks.Size = new System.Drawing.Size(836, 423);
            this.grpMarks.TabIndex = 0;
            this.grpMarks.TabStop = false;
            this.grpMarks.Text = "Manage Marks";
            // 
            // btnDeleteMarks
            // 
            this.btnDeleteMarks.Location = new System.Drawing.Point(327, 201);
            this.btnDeleteMarks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteMarks.Name = "btnDeleteMarks";
            this.btnDeleteMarks.Size = new System.Drawing.Size(92, 32);
            this.btnDeleteMarks.TabIndex = 9;
            this.btnDeleteMarks.Text = "Delete";
            this.btnDeleteMarks.UseVisualStyleBackColor = true;
            this.btnDeleteMarks.Click += new System.EventHandler(this.btnDeleteMarks_Click);
            // 
            // btnUpdateMarks
            // 
            this.btnUpdateMarks.Location = new System.Drawing.Point(204, 201);
            this.btnUpdateMarks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateMarks.Name = "btnUpdateMarks";
            this.btnUpdateMarks.Size = new System.Drawing.Size(87, 32);
            this.btnUpdateMarks.TabIndex = 8;
            this.btnUpdateMarks.Text = "Update";
            this.btnUpdateMarks.UseVisualStyleBackColor = true;
            this.btnUpdateMarks.Click += new System.EventHandler(this.btnUpdateMarks_Click);
            // 
            // btnAddMarks
            // 
            this.btnAddMarks.Location = new System.Drawing.Point(70, 201);
            this.btnAddMarks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddMarks.Name = "btnAddMarks";
            this.btnAddMarks.Size = new System.Drawing.Size(100, 32);
            this.btnAddMarks.TabIndex = 7;
            this.btnAddMarks.Text = "Add";
            this.btnAddMarks.UseVisualStyleBackColor = true;
            this.btnAddMarks.Click += new System.EventHandler(this.btnAddMarks_Click);
            // 
            // dataGridViewMarks
            // 
            this.dataGridViewMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarks.Location = new System.Drawing.Point(70, 237);
            this.dataGridViewMarks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewMarks.Name = "dataGridViewMarks";
            this.dataGridViewMarks.RowHeadersWidth = 51;
            this.dataGridViewMarks.RowTemplate.Height = 24;
            this.dataGridViewMarks.Size = new System.Drawing.Size(356, 164);
            this.dataGridViewMarks.TabIndex = 6;
            this.dataGridViewMarks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMarks_CellContentClick);
            // 
            // numScore
            // 
            this.numScore.Location = new System.Drawing.Point(168, 128);
            this.numScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numScore.Name = "numScore";
            this.numScore.Size = new System.Drawing.Size(90, 32);
            this.numScore.TabIndex = 5;
            // 
            // lblEnterScore
            // 
            this.lblEnterScore.AutoSize = true;
            this.lblEnterScore.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterScore.Location = new System.Drawing.Point(33, 133);
            this.lblEnterScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnterScore.Name = "lblEnterScore";
            this.lblEnterScore.Size = new System.Drawing.Size(122, 19);
            this.lblEnterScore.TabIndex = 4;
            this.lblEnterScore.Text = "Enter the Score :";
            // 
            // cmbExam
            // 
            this.cmbExam.FormattingEnabled = true;
            this.cmbExam.Location = new System.Drawing.Point(447, 44);
            this.cmbExam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbExam.Name = "cmbExam";
            this.cmbExam.Size = new System.Drawing.Size(99, 33);
            this.cmbExam.TabIndex = 3;
            // 
            // lblSelectExam
            // 
            this.lblSelectExam.AutoSize = true;
            this.lblSelectExam.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectExam.Location = new System.Drawing.Point(316, 50);
            this.lblSelectExam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectExam.Name = "lblSelectExam";
            this.lblSelectExam.Size = new System.Drawing.Size(126, 19);
            this.lblSelectExam.TabIndex = 2;
            this.lblSelectExam.Text = "Select the Exam :";
            // 
            // lblSelectStudent
            // 
            this.lblSelectStudent.AutoSize = true;
            this.lblSelectStudent.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectStudent.Location = new System.Drawing.Point(26, 55);
            this.lblSelectStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectStudent.Name = "lblSelectStudent";
            this.lblSelectStudent.Size = new System.Drawing.Size(140, 19);
            this.lblSelectStudent.TabIndex = 1;
            this.lblSelectStudent.Text = "Select the Student :";
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(167, 49);
            this.cmbStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(104, 33);
            this.cmbStudent.TabIndex = 0;
            // 
            // ExamMarkManageMentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(864, 479);
            this.Controls.Add(this.tabExamMarkManageMent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExamMarkManageMentForm";
            this.Text = "ExamMarkManageMent";
            this.Load += new System.EventHandler(this.ExamMarkManageMentForm_Load);
            this.tabExamMarkManageMent.ResumeLayout(false);
            this.tabExam.ResumeLayout(false);
            this.grpExams.ResumeLayout(false);
            this.grpExams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExam)).EndInit();
            this.tabMark.ResumeLayout(false);
            this.grpMarks.ResumeLayout(false);
            this.grpMarks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabExamMarkManageMent;
        private System.Windows.Forms.TabPage tabExam;
        private System.Windows.Forms.TabPage tabMark;
        private System.Windows.Forms.GroupBox grpExams;
        private System.Windows.Forms.GroupBox grpMarks;
        private System.Windows.Forms.Label lblSelectSubject;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.TextBox txtExamName;
        private System.Windows.Forms.Label lblExamStime;
        private System.Windows.Forms.DateTimePicker dtpSTime;
        private System.Windows.Forms.DateTimePicker dtpExamDate;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.Label lblExamName;
        private System.Windows.Forms.DataGridView dataGridViewExam;
        private System.Windows.Forms.Label lblExamEtime;
        private System.Windows.Forms.DateTimePicker dtpeETime;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddExam;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Label lblSelectStudent;
        private System.Windows.Forms.Label lblEnterScore;
        private System.Windows.Forms.ComboBox cmbExam;
        private System.Windows.Forms.Label lblSelectExam;
        private System.Windows.Forms.DataGridView dataGridViewMarks;
        private System.Windows.Forms.NumericUpDown numScore;
        private System.Windows.Forms.Button btnDeleteMarks;
        private System.Windows.Forms.Button btnUpdateMarks;
        private System.Windows.Forms.Button btnAddMarks;
        private System.Windows.Forms.Button btnUpdate;
    }
}