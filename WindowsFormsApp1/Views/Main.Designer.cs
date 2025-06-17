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
            this.panel_DashBoard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.btn_changePassword = new System.Windows.Forms.Button();
            this.btn_student = new System.Windows.Forms.Button();
            this.btn_lecturer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNextpage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStaff = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_DashBoard
            // 
            this.panel_DashBoard.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_DashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_DashBoard.Location = new System.Drawing.Point(200, 123);
            this.panel_DashBoard.Margin = new System.Windows.Forms.Padding(4);
            this.panel_DashBoard.Name = "panel_DashBoard";
            this.panel_DashBoard.Size = new System.Drawing.Size(867, 431);
            this.panel_DashBoard.TabIndex = 2;
            this.panel_DashBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_DashBoard_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 123);
            this.panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("InaiKathir", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(16, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 38);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btn_user
            // 
            this.btn_user.Location = new System.Drawing.Point(31, 87);
            this.btn_user.Margin = new System.Windows.Forms.Padding(4);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(133, 36);
            this.btn_user.TabIndex = 1;
            this.btn_user.Text = "Add New User";
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // btn_changePassword
            // 
            this.btn_changePassword.Location = new System.Drawing.Point(31, 158);
            this.btn_changePassword.Margin = new System.Windows.Forms.Padding(4);
            this.btn_changePassword.Name = "btn_changePassword";
            this.btn_changePassword.Size = new System.Drawing.Size(133, 36);
            this.btn_changePassword.TabIndex = 2;
            this.btn_changePassword.Text = "Change password";
            this.btn_changePassword.UseVisualStyleBackColor = true;
            this.btn_changePassword.Click += new System.EventHandler(this.btn_changePassword_Click);
            // 
            // btn_student
            // 
            this.btn_student.Location = new System.Drawing.Point(31, 231);
            this.btn_student.Margin = new System.Windows.Forms.Padding(4);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(133, 34);
            this.btn_student.TabIndex = 3;
            this.btn_student.Text = "Student";
            this.btn_student.UseVisualStyleBackColor = true;
            // 
            // btn_lecturer
            // 
            this.btn_lecturer.Location = new System.Drawing.Point(31, 299);
            this.btn_lecturer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lecturer.Name = "btn_lecturer";
            this.btn_lecturer.Size = new System.Drawing.Size(133, 36);
            this.btn_lecturer.TabIndex = 4;
            this.btn_lecturer.Text = "Lecturer";
            this.btn_lecturer.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btnStaff);
            this.panel1.Controls.Add(this.btnNextpage);
            this.panel1.Controls.Add(this.btn_lecturer);
            this.panel1.Controls.Add(this.btn_student);
            this.panel1.Controls.Add(this.btn_changePassword);
            this.panel1.Controls.Add(this.btn_user);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 554);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnNextpage
            // 
            this.btnNextpage.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextpage.Location = new System.Drawing.Point(31, 477);
            this.btnNextpage.Name = "btnNextpage";
            this.btnNextpage.Size = new System.Drawing.Size(133, 34);
            this.btnNextpage.TabIndex = 5;
            this.btnNextpage.Text = "Next Page";
            this.btnNextpage.UseVisualStyleBackColor = true;
            this.btnNextpage.Click += new System.EventHandler(this.btnNextpage_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.long_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(867, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(31, 367);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(133, 36);
            this.btnStaff.TabIndex = 6;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel_DashBoard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_DashBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btn_changePassword;
        private System.Windows.Forms.Button btn_student;
        private System.Windows.Forms.Button btn_lecturer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNextpage;
        private System.Windows.Forms.Button btnStaff;
    }
}