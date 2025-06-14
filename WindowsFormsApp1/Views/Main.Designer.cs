namespace WindowsFormsApp1.Views
{
    partial class Main
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
            this.btn_changePassword = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.panel_DashBoard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_student = new System.Windows.Forms.Button();
            this.btn_lecturer = new System.Windows.Forms.Button();
            this.btn_course = new System.Windows.Forms.Button();
            this.btn_Exam = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Exam);
            this.panel1.Controls.Add(this.btn_course);
            this.panel1.Controls.Add(this.btn_lecturer);
            this.panel1.Controls.Add(this.btn_student);
            this.panel1.Controls.Add(this.btn_changePassword);
            this.panel1.Controls.Add(this.btn_user);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 450);
            this.panel1.TabIndex = 0;
            // 
            // btn_changePassword
            // 
            this.btn_changePassword.Location = new System.Drawing.Point(24, 66);
            this.btn_changePassword.Name = "btn_changePassword";
            this.btn_changePassword.Size = new System.Drawing.Size(103, 23);
            this.btn_changePassword.TabIndex = 2;
            this.btn_changePassword.Text = "Change password";
            this.btn_changePassword.UseVisualStyleBackColor = true;
            // 
            // btn_user
            // 
            this.btn_user.Location = new System.Drawing.Point(24, 23);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(100, 23);
            this.btn_user.TabIndex = 1;
            this.btn_user.Text = "Add New User";
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // panel_DashBoard
            // 
            this.panel_DashBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_DashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_DashBoard.Location = new System.Drawing.Point(150, 100);
            this.panel_DashBoard.Name = "panel_DashBoard";
            this.panel_DashBoard.Size = new System.Drawing.Size(650, 350);
            this.panel_DashBoard.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(150, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 100);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.long_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_student
            // 
            this.btn_student.Location = new System.Drawing.Point(24, 112);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(100, 23);
            this.btn_student.TabIndex = 3;
            this.btn_student.Text = "Student";
            this.btn_student.UseVisualStyleBackColor = true;
            // 
            // btn_lecturer
            // 
            this.btn_lecturer.Location = new System.Drawing.Point(24, 158);
            this.btn_lecturer.Name = "btn_lecturer";
            this.btn_lecturer.Size = new System.Drawing.Size(100, 23);
            this.btn_lecturer.TabIndex = 4;
            this.btn_lecturer.Text = "Lecturer";
            this.btn_lecturer.UseVisualStyleBackColor = true;
            // 
            // btn_course
            // 
            this.btn_course.Location = new System.Drawing.Point(24, 207);
            this.btn_course.Name = "btn_course";
            this.btn_course.Size = new System.Drawing.Size(100, 23);
            this.btn_course.TabIndex = 5;
            this.btn_course.Text = "Course";
            this.btn_course.UseVisualStyleBackColor = true;
            // 
            // btn_Exam
            // 
            this.btn_Exam.Location = new System.Drawing.Point(24, 254);
            this.btn_Exam.Name = "btn_Exam";
            this.btn_Exam.Size = new System.Drawing.Size(100, 23);
            this.btn_Exam.TabIndex = 6;
            this.btn_Exam.Text = "Exam";
            this.btn_Exam.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_DashBoard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_DashBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_changePassword;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btn_lecturer;
        private System.Windows.Forms.Button btn_student;
        private System.Windows.Forms.Button btn_Exam;
        private System.Windows.Forms.Button btn_course;
    }
}