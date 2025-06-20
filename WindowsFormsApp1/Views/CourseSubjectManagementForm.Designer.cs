namespace WindowsFormsApp1.Views
{
    partial class CourseSubjectManagementForm
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
            this.Subject = new System.Windows.Forms.TabControl();
            this.tabCourse = new System.Windows.Forms.TabPage();
            this.tabSubject = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Subject.SuspendLayout();
            this.tabCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // Subject
            // 
            this.Subject.Controls.Add(this.tabCourse);
            this.Subject.Controls.Add(this.tabSubject);
            this.Subject.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject.Location = new System.Drawing.Point(1, 2);
            this.Subject.Name = "Subject";
            this.Subject.SelectedIndex = 0;
            this.Subject.Size = new System.Drawing.Size(1149, 584);
            this.Subject.TabIndex = 0;
            // 
            // tabCourse
            // 
            this.tabCourse.Controls.Add(this.groupBox1);
            this.tabCourse.Location = new System.Drawing.Point(4, 33);
            this.tabCourse.Name = "tabCourse";
            this.tabCourse.Padding = new System.Windows.Forms.Padding(3);
            this.tabCourse.Size = new System.Drawing.Size(1141, 547);
            this.tabCourse.TabIndex = 0;
            this.tabCourse.Text = "Course";
            this.tabCourse.UseVisualStyleBackColor = true;
            this.tabCourse.Click += new System.EventHandler(this.tabCourse_Click);
            // 
            // tabSubject
            // 
            this.tabSubject.Location = new System.Drawing.Point(4, 33);
            this.tabSubject.Name = "tabSubject";
            this.tabSubject.Padding = new System.Windows.Forms.Padding(3);
            this.tabSubject.Size = new System.Drawing.Size(1141, 547);
            this.tabSubject.TabIndex = 1;
            this.tabSubject.Text = "Subject";
            this.tabSubject.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 507);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // CourseSubjectManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1152, 589);
            this.Controls.Add(this.Subject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseSubjectManagementForm";
            this.Text = "CourseSubjectManagementForm";
            this.Subject.ResumeLayout(false);
            this.tabCourse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Subject;
        private System.Windows.Forms.TabPage tabCourse;
        private System.Windows.Forms.TabPage tabSubject;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}