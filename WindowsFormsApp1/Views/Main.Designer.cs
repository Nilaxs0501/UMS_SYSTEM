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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.btn_changePassword = new System.Windows.Forms.Button();
            this.btn_student = new System.Windows.Forms.Button();
            this.btn_lecturer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNextpage = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_DashBoard
            // 
            this.panel_DashBoard.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_DashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_DashBoard.Location = new System.Drawing.Point(150, 100);
            this.panel_DashBoard.Name = "panel_DashBoard";
            this.panel_DashBoard.Size = new System.Drawing.Size(650, 350);
            this.panel_DashBoard.TabIndex = 2;
            this.panel_DashBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_DashBoard_Paint);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(-2, 380);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 31);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Log out";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btn_user
            // 
            this.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_user.Location = new System.Drawing.Point(-2, 104);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(150, 29);
            this.btn_user.TabIndex = 1;
            this.btn_user.Text = "Add New User";
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // btn_changePassword
            // 
            this.btn_changePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changePassword.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changePassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_changePassword.Location = new System.Drawing.Point(-2, 158);
            this.btn_changePassword.Name = "btn_changePassword";
            this.btn_changePassword.Size = new System.Drawing.Size(150, 29);
            this.btn_changePassword.TabIndex = 2;
            this.btn_changePassword.Text = "Change password";
            this.btn_changePassword.UseVisualStyleBackColor = true;
            this.btn_changePassword.Click += new System.EventHandler(this.btn_changePassword_Click);
            // 
            // btn_student
            // 
            this.btn_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_student.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_student.Location = new System.Drawing.Point(-2, 210);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(150, 28);
            this.btn_student.TabIndex = 3;
            this.btn_student.Text = "Student";
            this.btn_student.UseVisualStyleBackColor = true;
            // 
            // btn_lecturer
            // 
            this.btn_lecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lecturer.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lecturer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_lecturer.Location = new System.Drawing.Point(-2, 264);
            this.btn_lecturer.Name = "btn_lecturer";
            this.btn_lecturer.Size = new System.Drawing.Size(150, 29);
            this.btn_lecturer.TabIndex = 4;
            this.btn_lecturer.Text = "Lecturer";
            this.btn_lecturer.UseVisualStyleBackColor = true;
            this.btn_lecturer.Click += new System.EventHandler(this.btn_lecturer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnNextpage);
            this.panel1.Controls.Add(this.btn_lecturer);
            this.panel1.Controls.Add(this.btn_student);
            this.panel1.Controls.Add(this.btn_changePassword);
            this.panel1.Controls.Add(this.btn_user);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnNextpage
            // 
            this.btnNextpage.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNextpage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextpage.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextpage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNextpage.Location = new System.Drawing.Point(-2, 332);
            this.btnNextpage.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextpage.Name = "btnNextpage";
            this.btnNextpage.Size = new System.Drawing.Size(150, 28);
            this.btnNextpage.TabIndex = 5;
            this.btnNextpage.Text = "Next Page";
            this.btnNextpage.UseVisualStyleBackColor = true;
            this.btnNextpage.Click += new System.EventHandler(this.btnNextpage_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_DashBoard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
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
    }
}