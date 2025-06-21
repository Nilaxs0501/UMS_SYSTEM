namespace WindowsFormsApp1.Views
{
    partial class ExamMarkManageMent
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
            this.tabMark = new System.Windows.Forms.TabPage();
            this.grpExams = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSelectSubject = new System.Windows.Forms.Label();
            this.txtExamName = new System.Windows.Forms.TextBox();
            this.lblExamStime = new System.Windows.Forms.Label();
            this.dtpSTime = new System.Windows.Forms.DateTimePicker();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.dtpExamDate = new System.Windows.Forms.DateTimePicker();
            this.lblExamName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblExamEtime = new System.Windows.Forms.Label();
            this.dtpeETime = new System.Windows.Forms.DateTimePicker();
            this.btnAddExam = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabExamMarkManageMent.SuspendLayout();
            this.tabExam.SuspendLayout();
            this.tabMark.SuspendLayout();
            this.grpExams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tabExam.Padding = new System.Windows.Forms.Padding(3);
            this.tabExam.Size = new System.Drawing.Size(849, 424);
            this.tabExam.TabIndex = 0;
            this.tabExam.Text = "Exam";
            this.tabExam.UseVisualStyleBackColor = true;
            this.tabExam.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabMark
            // 
            this.tabMark.Controls.Add(this.groupBox2);
            this.tabMark.Location = new System.Drawing.Point(4, 34);
            this.tabMark.Name = "tabMark";
            this.tabMark.Padding = new System.Windows.Forms.Padding(3);
            this.tabMark.Size = new System.Drawing.Size(849, 424);
            this.tabMark.TabIndex = 1;
            this.tabMark.Text = "Mark";
            this.tabMark.UseVisualStyleBackColor = true;
            // 
            // grpExams
            // 
            this.grpExams.Controls.Add(this.button3);
            this.grpExams.Controls.Add(this.button2);
            this.grpExams.Controls.Add(this.btnAddExam);
            this.grpExams.Controls.Add(this.dtpeETime);
            this.grpExams.Controls.Add(this.lblExamEtime);
            this.grpExams.Controls.Add(this.dataGridView1);
            this.grpExams.Controls.Add(this.lblExamName);
            this.grpExams.Controls.Add(this.dtpExamDate);
            this.grpExams.Controls.Add(this.lblSelectDate);
            this.grpExams.Controls.Add(this.dtpSTime);
            this.grpExams.Controls.Add(this.lblExamStime);
            this.grpExams.Controls.Add(this.txtExamName);
            this.grpExams.Controls.Add(this.lblSelectSubject);
            this.grpExams.Controls.Add(this.comboBox1);
            this.grpExams.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpExams.Location = new System.Drawing.Point(6, 6);
            this.grpExams.Name = "grpExams";
            this.grpExams.Size = new System.Drawing.Size(840, 424);
            this.grpExams.TabIndex = 0;
            this.grpExams.TabStop = false;
            this.grpExams.Text = "Manage Exam";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(7, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(836, 423);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(200, 167);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 0;
            // 
            // lblSelectSubject
            // 
            this.lblSelectSubject.AutoSize = true;
            this.lblSelectSubject.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSubject.Location = new System.Drawing.Point(49, 167);
            this.lblSelectSubject.Name = "lblSelectSubject";
            this.lblSelectSubject.Size = new System.Drawing.Size(129, 19);
            this.lblSelectSubject.TabIndex = 1;
            this.lblSelectSubject.Text = "Select the Subject";
            // 
            // txtExamName
            // 
            this.txtExamName.Location = new System.Drawing.Point(550, 43);
            this.txtExamName.Name = "txtExamName";
            this.txtExamName.Size = new System.Drawing.Size(121, 30);
            this.txtExamName.TabIndex = 2;
            // 
            // lblExamStime
            // 
            this.lblExamStime.AutoSize = true;
            this.lblExamStime.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamStime.Location = new System.Drawing.Point(23, 81);
            this.lblExamStime.Name = "lblExamStime";
            this.lblExamStime.Size = new System.Drawing.Size(196, 19);
            this.lblExamStime.TabIndex = 3;
            this.lblExamStime.Text = "Select the Exam Start Time";
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
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDate.Location = new System.Drawing.Point(23, 43);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(155, 19);
            this.lblSelectDate.TabIndex = 5;
            this.lblSelectDate.Text = "Select the Exam Date";
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
            // lblExamName
            // 
            this.lblExamName.AutoSize = true;
            this.lblExamName.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamName.Location = new System.Drawing.Point(371, 50);
            this.lblExamName.Name = "lblExamName";
            this.lblExamName.Size = new System.Drawing.Size(161, 19);
            this.lblExamName.TabIndex = 7;
            this.lblExamName.Text = "Enter the Exam Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(491, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // lblExamEtime
            // 
            this.lblExamEtime.AutoSize = true;
            this.lblExamEtime.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamEtime.Location = new System.Drawing.Point(23, 124);
            this.lblExamEtime.Name = "lblExamEtime";
            this.lblExamEtime.Size = new System.Drawing.Size(192, 19);
            this.lblExamEtime.TabIndex = 9;
            this.lblExamEtime.Text = "Select the Exam End Time";
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
            // btnAddExam
            // 
            this.btnAddExam.Location = new System.Drawing.Point(447, 110);
            this.btnAddExam.Name = "btnAddExam";
            this.btnAddExam.Size = new System.Drawing.Size(85, 35);
            this.btnAddExam.TabIndex = 11;
            this.btnAddExam.Text = "Add";
            this.btnAddExam.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(447, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(447, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 31);
            this.button3.TabIndex = 13;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ExamMarkManageMent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(864, 479);
            this.Controls.Add(this.tabExamMarkManageMent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExamMarkManageMent";
            this.Text = "ExamMarkManageMent";
            this.tabExamMarkManageMent.ResumeLayout(false);
            this.tabExam.ResumeLayout(false);
            this.tabMark.ResumeLayout(false);
            this.grpExams.ResumeLayout(false);
            this.grpExams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabExamMarkManageMent;
        private System.Windows.Forms.TabPage tabExam;
        private System.Windows.Forms.TabPage tabMark;
        private System.Windows.Forms.GroupBox grpExams;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSelectSubject;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtExamName;
        private System.Windows.Forms.Label lblExamStime;
        private System.Windows.Forms.DateTimePicker dtpSTime;
        private System.Windows.Forms.DateTimePicker dtpExamDate;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.Label lblExamName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblExamEtime;
        private System.Windows.Forms.DateTimePicker dtpeETime;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddExam;
    }
}