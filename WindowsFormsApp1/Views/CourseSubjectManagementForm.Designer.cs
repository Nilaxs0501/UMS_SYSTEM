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
            this.grpCourse = new System.Windows.Forms.GroupBox();
            this.dataGridViewCourse = new System.Windows.Forms.DataGridView();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSubject = new System.Windows.Forms.TabPage();
            this.grpSubject = new System.Windows.Forms.GroupBox();
            this.dataGridViewSubject = new System.Windows.Forms.DataGridView();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            this.btnUpdateSubject = new System.Windows.Forms.Button();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Subject.SuspendLayout();
            this.tabCourse.SuspendLayout();
            this.grpCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).BeginInit();
            this.tabSubject.SuspendLayout();
            this.grpSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // Subject
            // 
            this.Subject.Controls.Add(this.tabCourse);
            this.Subject.Controls.Add(this.tabSubject);
            this.Subject.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject.Location = new System.Drawing.Point(1, 2);
            this.Subject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Subject.Name = "Subject";
            this.Subject.SelectedIndex = 0;
            this.Subject.Size = new System.Drawing.Size(1149, 583);
            this.Subject.TabIndex = 0;
            // 
            // tabCourse
            // 
            this.tabCourse.Controls.Add(this.grpCourse);
            this.tabCourse.Location = new System.Drawing.Point(4, 33);
            this.tabCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCourse.Name = "tabCourse";
            this.tabCourse.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCourse.Size = new System.Drawing.Size(1141, 546);
            this.tabCourse.TabIndex = 0;
            this.tabCourse.Text = "Course";
            this.tabCourse.UseVisualStyleBackColor = true;
            this.tabCourse.Click += new System.EventHandler(this.tabCourse_Click);
            // 
            // grpCourse
            // 
            this.grpCourse.Controls.Add(this.dataGridViewCourse);
            this.grpCourse.Controls.Add(this.btnDeleteCourse);
            this.grpCourse.Controls.Add(this.btnUpdateCourse);
            this.grpCourse.Controls.Add(this.btnAddCourse);
            this.grpCourse.Controls.Add(this.txtCourseName);
            this.grpCourse.Controls.Add(this.label1);
            this.grpCourse.Location = new System.Drawing.Point(7, 6);
            this.grpCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCourse.Name = "grpCourse";
            this.grpCourse.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCourse.Size = new System.Drawing.Size(1132, 533);
            this.grpCourse.TabIndex = 0;
            this.grpCourse.TabStop = false;
            this.grpCourse.Text = "Manage Course";
            this.grpCourse.Enter += new System.EventHandler(this.grpCourse_Enter);
            // 
            // dataGridViewCourse
            // 
            this.dataGridViewCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourse.Location = new System.Drawing.Point(77, 309);
            this.dataGridViewCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewCourse.Name = "dataGridViewCourse";
            this.dataGridViewCourse.RowHeadersWidth = 51;
            this.dataGridViewCourse.Size = new System.Drawing.Size(457, 185);
            this.dataGridViewCourse.TabIndex = 5;
            this.dataGridViewCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCourse_CellContentClick);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Location = new System.Drawing.Point(362, 255);
            this.btnDeleteCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(115, 44);
            this.btnDeleteCourse.TabIndex = 4;
            this.btnDeleteCourse.Text = "Delete";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.Location = new System.Drawing.Point(213, 255);
            this.btnUpdateCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(115, 46);
            this.btnUpdateCourse.TabIndex = 3;
            this.btnUpdateCourse.Text = "Update";
            this.btnUpdateCourse.UseVisualStyleBackColor = true;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(77, 255);
            this.btnAddCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(115, 46);
            this.btnAddCourse.TabIndex = 2;
            this.btnAddCourse.Text = "Add";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(431, 103);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(220, 38);
            this.txtCourseName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = " Enter the Course Name :";
            // 
            // tabSubject
            // 
            this.tabSubject.Controls.Add(this.grpSubject);
            this.tabSubject.Location = new System.Drawing.Point(4, 33);
            this.tabSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSubject.Name = "tabSubject";
            this.tabSubject.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSubject.Size = new System.Drawing.Size(1141, 546);
            this.tabSubject.TabIndex = 1;
            this.tabSubject.Text = "Subject";
            this.tabSubject.UseVisualStyleBackColor = true;
            // 
            // grpSubject
            // 
            this.grpSubject.Controls.Add(this.dataGridViewSubject);
            this.grpSubject.Controls.Add(this.btnDeleteSubject);
            this.grpSubject.Controls.Add(this.btnUpdateSubject);
            this.grpSubject.Controls.Add(this.btnAddSubject);
            this.grpSubject.Controls.Add(this.cmbCourse);
            this.grpSubject.Controls.Add(this.label3);
            this.grpSubject.Controls.Add(this.txtSubjectName);
            this.grpSubject.Controls.Add(this.label2);
            this.grpSubject.Location = new System.Drawing.Point(9, 6);
            this.grpSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSubject.Name = "grpSubject";
            this.grpSubject.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSubject.Size = new System.Drawing.Size(1129, 534);
            this.grpSubject.TabIndex = 0;
            this.grpSubject.TabStop = false;
            this.grpSubject.Text = "Manage Subject";
            // 
            // dataGridViewSubject
            // 
            this.dataGridViewSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubject.Location = new System.Drawing.Point(99, 299);
            this.dataGridViewSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewSubject.Name = "dataGridViewSubject";
            this.dataGridViewSubject.RowHeadersWidth = 51;
            this.dataGridViewSubject.Size = new System.Drawing.Size(524, 185);
            this.dataGridViewSubject.TabIndex = 7;
            this.dataGridViewSubject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSubject_CellContentClick);
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.Location = new System.Drawing.Point(488, 252);
            this.btnDeleteSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(117, 39);
            this.btnDeleteSubject.TabIndex = 6;
            this.btnDeleteSubject.Text = "Delete";
            this.btnDeleteSubject.UseVisualStyleBackColor = true;
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // btnUpdateSubject
            // 
            this.btnUpdateSubject.Location = new System.Drawing.Point(336, 252);
            this.btnUpdateSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateSubject.Name = "btnUpdateSubject";
            this.btnUpdateSubject.Size = new System.Drawing.Size(117, 39);
            this.btnUpdateSubject.TabIndex = 5;
            this.btnUpdateSubject.Text = "Update";
            this.btnUpdateSubject.UseVisualStyleBackColor = true;
            this.btnUpdateSubject.Click += new System.EventHandler(this.btnUpdateSubject_Click);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(179, 253);
            this.btnAddSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(117, 38);
            this.btnAddSubject.TabIndex = 4;
            this.btnAddSubject.Text = "Add";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(350, 71);
            this.cmbCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(192, 32);
            this.cmbCourse.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select the Course :";
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectName.Location = new System.Drawing.Point(413, 140);
            this.txtSubjectName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(192, 38);
            this.txtSubjectName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter the Subject Name :";
            // 
            // CourseSubjectManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1152, 590);
            this.Controls.Add(this.Subject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CourseSubjectManagementForm";
            this.Text = "CourseSubjectManagementForm";
            this.Subject.ResumeLayout(false);
            this.tabCourse.ResumeLayout(false);
            this.grpCourse.ResumeLayout(false);
            this.grpCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).EndInit();
            this.tabSubject.ResumeLayout(false);
            this.grpSubject.ResumeLayout(false);
            this.grpSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Subject;
        private System.Windows.Forms.TabPage tabCourse;
        private System.Windows.Forms.TabPage tabSubject;
        private System.Windows.Forms.GroupBox grpCourse;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Button btnUpdateCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.GroupBox grpSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Button btnDeleteSubject;
        private System.Windows.Forms.Button btnUpdateSubject;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.DataGridView dataGridViewSubject;
    }
}