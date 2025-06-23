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
            this.tabExamMarkManageMent.Location = new System.Drawing.Point(4, 15);
            this.tabExamMarkManageMent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabExamMarkManageMent.Name = "tabExamMarkManageMent";
            this.tabExamMarkManageMent.SelectedIndex = 0;
            this.tabExamMarkManageMent.Size = new System.Drawing.Size(1143, 569);
            this.tabExamMarkManageMent.TabIndex = 0;
            // 
            // tabExam
            // 
            this.tabExam.Controls.Add(this.grpExams);
            this.tabExam.Location = new System.Drawing.Point(4, 39);
            this.tabExam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabExam.Name = "tabExam";
            this.tabExam.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabExam.Size = new System.Drawing.Size(1135, 526);
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
            this.grpExams.Location = new System.Drawing.Point(8, 7);
            this.grpExams.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpExams.Name = "grpExams";
            this.grpExams.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpExams.Size = new System.Drawing.Size(1120, 522);
            this.grpExams.TabIndex = 0;
            this.grpExams.TabStop = false;
            this.grpExams.Text = "Manage Exam";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(553, 223);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 38);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(756, 223);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 38);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddExam
            // 
            this.btnAddExam.Location = new System.Drawing.Point(359, 223);
            this.btnAddExam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddExam.Name = "btnAddExam";
            this.btnAddExam.Size = new System.Drawing.Size(113, 43);
            this.btnAddExam.TabIndex = 11;
            this.btnAddExam.Text = "Add";
            this.btnAddExam.UseVisualStyleBackColor = true;
            this.btnAddExam.Click += new System.EventHandler(this.btnAddExam_Click);
            // 
            // dtpeETime
            // 
            this.dtpeETime.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpeETime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpeETime.Location = new System.Drawing.Point(300, 148);
            this.dtpeETime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpeETime.Name = "dtpeETime";
            this.dtpeETime.ShowUpDown = true;
            this.dtpeETime.Size = new System.Drawing.Size(136, 27);
            this.dtpeETime.TabIndex = 10;
            // 
            // lblExamEtime
            // 
            this.lblExamEtime.AutoSize = true;
            this.lblExamEtime.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamEtime.Location = new System.Drawing.Point(31, 153);
            this.lblExamEtime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExamEtime.Name = "lblExamEtime";
            this.lblExamEtime.Size = new System.Drawing.Size(250, 24);
            this.lblExamEtime.TabIndex = 9;
            this.lblExamEtime.Text = "Select the Exam End Time :";
            // 
            // dataGridViewExam
            // 
            this.dataGridViewExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExam.Location = new System.Drawing.Point(277, 274);
            this.dataGridViewExam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewExam.Name = "dataGridViewExam";
            this.dataGridViewExam.RowHeadersWidth = 51;
            this.dataGridViewExam.Size = new System.Drawing.Size(793, 238);
            this.dataGridViewExam.TabIndex = 8;
            this.dataGridViewExam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExam_CellContentClick);
            // 
            // lblExamName
            // 
            this.lblExamName.AutoSize = true;
            this.lblExamName.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamName.Location = new System.Drawing.Point(489, 53);
            this.lblExamName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExamName.Name = "lblExamName";
            this.lblExamName.Size = new System.Drawing.Size(212, 24);
            this.lblExamName.TabIndex = 7;
            this.lblExamName.Text = "Enter the Exam Name :";
            // 
            // dtpExamDate
            // 
            this.dtpExamDate.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExamDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExamDate.Location = new System.Drawing.Point(300, 53);
            this.dtpExamDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpExamDate.MaxDate = new System.DateTime(2025, 6, 23, 0, 0, 0, 0);
            this.dtpExamDate.Name = "dtpExamDate";
            this.dtpExamDate.ShowUpDown = true;
            this.dtpExamDate.Size = new System.Drawing.Size(136, 27);
            this.dtpExamDate.TabIndex = 6;
            this.dtpExamDate.Value = new System.DateTime(2025, 6, 23, 0, 0, 0, 0);
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDate.Location = new System.Drawing.Point(31, 53);
            this.lblSelectDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(203, 24);
            this.lblSelectDate.TabIndex = 5;
            this.lblSelectDate.Text = "Select the Exam Date :";
            // 
            // dtpSTime
            // 
            this.dtpSTime.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSTime.Location = new System.Drawing.Point(300, 100);
            this.dtpSTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpSTime.Name = "dtpSTime";
            this.dtpSTime.ShowUpDown = true;
            this.dtpSTime.Size = new System.Drawing.Size(136, 27);
            this.dtpSTime.TabIndex = 4;
            // 
            // lblExamStime
            // 
            this.lblExamStime.AutoSize = true;
            this.lblExamStime.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamStime.Location = new System.Drawing.Point(31, 100);
            this.lblExamStime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExamStime.Name = "lblExamStime";
            this.lblExamStime.Size = new System.Drawing.Size(255, 24);
            this.lblExamStime.TabIndex = 3;
            this.lblExamStime.Text = "Select the Exam Start Time :";
            // 
            // txtExamName
            // 
            this.txtExamName.Location = new System.Drawing.Point(728, 36);
            this.txtExamName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtExamName.Name = "txtExamName";
            this.txtExamName.Size = new System.Drawing.Size(160, 35);
            this.txtExamName.TabIndex = 2;
            // 
            // lblSelectSubject
            // 
            this.lblSelectSubject.AutoSize = true;
            this.lblSelectSubject.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSubject.Location = new System.Drawing.Point(532, 113);
            this.lblSelectSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectSubject.Name = "lblSelectSubject";
            this.lblSelectSubject.Size = new System.Drawing.Size(169, 24);
            this.lblSelectSubject.TabIndex = 1;
            this.lblSelectSubject.Text = "Select the Subject :";
            // 
            // cmbSubject
            // 
            this.cmbSubject.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(728, 113);
            this.cmbSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(160, 32);
            this.cmbSubject.TabIndex = 0;
            // 
            // tabMark
            // 
            this.tabMark.Controls.Add(this.grpMarks);
            this.tabMark.Location = new System.Drawing.Point(4, 39);
            this.tabMark.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabMark.Name = "tabMark";
            this.tabMark.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabMark.Size = new System.Drawing.Size(1135, 526);
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
            this.grpMarks.Location = new System.Drawing.Point(9, 9);
            this.grpMarks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpMarks.Name = "grpMarks";
            this.grpMarks.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpMarks.Size = new System.Drawing.Size(1115, 521);
            this.grpMarks.TabIndex = 0;
            this.grpMarks.TabStop = false;
            this.grpMarks.Text = "Manage Marks";
            // 
            // btnDeleteMarks
            // 
            this.btnDeleteMarks.Location = new System.Drawing.Point(436, 247);
            this.btnDeleteMarks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteMarks.Name = "btnDeleteMarks";
            this.btnDeleteMarks.Size = new System.Drawing.Size(123, 39);
            this.btnDeleteMarks.TabIndex = 9;
            this.btnDeleteMarks.Text = "Delete";
            this.btnDeleteMarks.UseVisualStyleBackColor = true;
            this.btnDeleteMarks.Click += new System.EventHandler(this.btnDeleteMarks_Click);
            // 
            // btnUpdateMarks
            // 
            this.btnUpdateMarks.Location = new System.Drawing.Point(272, 247);
            this.btnUpdateMarks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateMarks.Name = "btnUpdateMarks";
            this.btnUpdateMarks.Size = new System.Drawing.Size(116, 39);
            this.btnUpdateMarks.TabIndex = 8;
            this.btnUpdateMarks.Text = "Update";
            this.btnUpdateMarks.UseVisualStyleBackColor = true;
            this.btnUpdateMarks.Click += new System.EventHandler(this.btnUpdateMarks_Click);
            // 
            // btnAddMarks
            // 
            this.btnAddMarks.Location = new System.Drawing.Point(93, 247);
            this.btnAddMarks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddMarks.Name = "btnAddMarks";
            this.btnAddMarks.Size = new System.Drawing.Size(133, 39);
            this.btnAddMarks.TabIndex = 7;
            this.btnAddMarks.Text = "Add";
            this.btnAddMarks.UseVisualStyleBackColor = true;
            this.btnAddMarks.Click += new System.EventHandler(this.btnAddMarks_Click);
            // 
            // dataGridViewMarks
            // 
            this.dataGridViewMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarks.Location = new System.Drawing.Point(93, 292);
            this.dataGridViewMarks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMarks.Name = "dataGridViewMarks";
            this.dataGridViewMarks.RowHeadersWidth = 51;
            this.dataGridViewMarks.RowTemplate.Height = 24;
            this.dataGridViewMarks.Size = new System.Drawing.Size(475, 202);
            this.dataGridViewMarks.TabIndex = 6;
            this.dataGridViewMarks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMarks_CellContentClick);
            // 
            // numScore
            // 
            this.numScore.Location = new System.Drawing.Point(224, 158);
            this.numScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numScore.Name = "numScore";
            this.numScore.Size = new System.Drawing.Size(120, 38);
            this.numScore.TabIndex = 5;
            // 
            // lblEnterScore
            // 
            this.lblEnterScore.AutoSize = true;
            this.lblEnterScore.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterScore.Location = new System.Drawing.Point(44, 164);
            this.lblEnterScore.Name = "lblEnterScore";
            this.lblEnterScore.Size = new System.Drawing.Size(152, 24);
            this.lblEnterScore.TabIndex = 4;
            this.lblEnterScore.Text = "Enter the Score :";
            // 
            // cmbExam
            // 
            this.cmbExam.FormattingEnabled = true;
            this.cmbExam.Location = new System.Drawing.Point(596, 54);
            this.cmbExam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbExam.Name = "cmbExam";
            this.cmbExam.Size = new System.Drawing.Size(131, 38);
            this.cmbExam.TabIndex = 3;
            // 
            // lblSelectExam
            // 
            this.lblSelectExam.AutoSize = true;
            this.lblSelectExam.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectExam.Location = new System.Drawing.Point(421, 62);
            this.lblSelectExam.Name = "lblSelectExam";
            this.lblSelectExam.Size = new System.Drawing.Size(157, 24);
            this.lblSelectExam.TabIndex = 2;
            this.lblSelectExam.Text = "Select the Exam :";
            // 
            // lblSelectStudent
            // 
            this.lblSelectStudent.AutoSize = true;
            this.lblSelectStudent.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectStudent.Location = new System.Drawing.Point(35, 68);
            this.lblSelectStudent.Name = "lblSelectStudent";
            this.lblSelectStudent.Size = new System.Drawing.Size(172, 24);
            this.lblSelectStudent.TabIndex = 1;
            this.lblSelectStudent.Text = "Select the Student :";
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(223, 60);
            this.cmbStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(137, 38);
            this.cmbStudent.TabIndex = 0;
            // 
            // ExamMarkManageMentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1152, 590);
            this.Controls.Add(this.tabExamMarkManageMent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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