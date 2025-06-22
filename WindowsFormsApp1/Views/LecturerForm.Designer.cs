namespace WindowsFormsApp1.Views
{
    partial class LecturerForm
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
            this.grpManageStudent = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgvLecturers = new System.Windows.Forms.DataGridView();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.grpManageStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturers)).BeginInit();
            this.grpGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpManageStudent
            // 
            this.grpManageStudent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpManageStudent.Controls.Add(this.btnDelete);
            this.grpManageStudent.Controls.Add(this.btnUpdate);
            this.grpManageStudent.Controls.Add(this.numAge);
            this.grpManageStudent.Controls.Add(this.lblCourse);
            this.grpManageStudent.Controls.Add(this.lblAge);
            this.grpManageStudent.Controls.Add(this.txtPhone);
            this.grpManageStudent.Controls.Add(this.txtEmail);
            this.grpManageStudent.Controls.Add(this.txtAddress);
            this.grpManageStudent.Controls.Add(this.lblPhoneNumber);
            this.grpManageStudent.Controls.Add(this.lblEmail);
            this.grpManageStudent.Controls.Add(this.lblAddress);
            this.grpManageStudent.Controls.Add(this.cmbSubject);
            this.grpManageStudent.Controls.Add(this.txtName);
            this.grpManageStudent.Controls.Add(this.dgvLecturers);
            this.grpManageStudent.Controls.Add(this.grpGender);
            this.grpManageStudent.Controls.Add(this.btnAdd);
            this.grpManageStudent.Controls.Add(this.lblName);
            this.grpManageStudent.Font = new System.Drawing.Font("Imprint MT Shadow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpManageStudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpManageStudent.Location = new System.Drawing.Point(7, 8);
            this.grpManageStudent.Name = "grpManageStudent";
            this.grpManageStudent.Size = new System.Drawing.Size(1147, 621);
            this.grpManageStudent.TabIndex = 1;
            this.grpManageStudent.TabStop = false;
            this.grpManageStudent.Text = "Manage Student";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(667, 321);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 39);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(478, 321);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 39);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(519, 158);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(120, 39);
            this.numAge.TabIndex = 15;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(713, 155);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(245, 33);
            this.lblCourse.TabIndex = 14;
            this.lblCourse.Text = "Select the Subject :";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(420, 164);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(76, 33);
            this.lblAge.TabIndex = 13;
            this.lblAge.Text = "Age :";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(958, 69);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(172, 39);
            this.txtPhone.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(519, 66);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(174, 39);
            this.txtEmail.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(168, 165);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(214, 39);
            this.txtAddress.TabIndex = 10;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(736, 69);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(216, 33);
            this.lblPhoneNumber.TabIndex = 9;
            this.lblPhoneNumber.Text = "Phone Number :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(376, 66);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(103, 33);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(31, 165);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(125, 33);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address :";
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(975, 158);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(151, 40);
            this.cmbSubject.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(139, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 39);
            this.txtName.TabIndex = 4;
            // 
            // dgvLecturers
            // 
            this.dgvLecturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLecturers.Location = new System.Drawing.Point(37, 364);
            this.dgvLecturers.Name = "dgvLecturers";
            this.dgvLecturers.RowHeadersWidth = 51;
            this.dgvLecturers.RowTemplate.Height = 24;
            this.dgvLecturers.Size = new System.Drawing.Size(1074, 247);
            this.dgvLecturers.TabIndex = 3;
            this.dgvLecturers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLecturers_CellContentClick);
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdoFemale);
            this.grpGender.Controls.Add(this.rdoMale);
            this.grpGender.Location = new System.Drawing.Point(56, 240);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(202, 118);
            this.grpGender.TabIndex = 2;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(7, 81);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(127, 37);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(9, 38);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(96, 37);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(301, 321);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 39);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(31, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 33);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // LecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 636);
            this.Controls.Add(this.grpManageStudent);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LecturerForm";
            this.Text = "LecturerForm";
            this.grpManageStudent.ResumeLayout(false);
            this.grpManageStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturers)).EndInit();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpManageStudent;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgvLecturers;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
    }
}