namespace WindowsFormsApp1.Views
{
    partial class SubMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExam = new System.Windows.Forms.Button();
            this.btnMarks = new System.Windows.Forms.Button();
            this.btnTimetable = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAttendence = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnAttendence);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnCourse);
            this.panel1.Controls.Add(this.btnTimetable);
            this.panel1.Controls.Add(this.btnMarks);
            this.panel1.Controls.Add(this.btnExam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 589);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 116);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(878, 473);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.long_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(878, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnExam
            // 
            this.btnExam.Location = new System.Drawing.Point(36, 172);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(116, 35);
            this.btnExam.TabIndex = 1;
            this.btnExam.Text = "Exam";
            this.btnExam.UseVisualStyleBackColor = true;
            // 
            // btnMarks
            // 
            this.btnMarks.Location = new System.Drawing.Point(36, 260);
            this.btnMarks.Name = "btnMarks";
            this.btnMarks.Size = new System.Drawing.Size(116, 35);
            this.btnMarks.TabIndex = 2;
            this.btnMarks.Text = "Marks";
            this.btnMarks.UseVisualStyleBackColor = true;
            // 
            // btnTimetable
            // 
            this.btnTimetable.Location = new System.Drawing.Point(36, 344);
            this.btnTimetable.Name = "btnTimetable";
            this.btnTimetable.Size = new System.Drawing.Size(116, 33);
            this.btnTimetable.TabIndex = 3;
            this.btnTimetable.Text = "Timetable";
            this.btnTimetable.UseVisualStyleBackColor = true;
            // 
            // btnCourse
            // 
            this.btnCourse.Location = new System.Drawing.Point(36, 92);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(116, 36);
            this.btnCourse.TabIndex = 4;
            this.btnCourse.Text = "Course";
            this.btnCourse.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(36, 511);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 34);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAttendence
            // 
            this.btnAttendence.Location = new System.Drawing.Point(36, 419);
            this.btnAttendence.Name = "btnAttendence";
            this.btnAttendence.Size = new System.Drawing.Size(116, 34);
            this.btnAttendence.TabIndex = 6;
            this.btnAttendence.Text = "Attendence";
            this.btnAttendence.UseVisualStyleBackColor = true;
            // 
            // SubMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 589);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubMain";
            this.Text = "SubMain";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMarks;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTimetable;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAttendence;
    }
}