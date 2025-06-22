namespace WindowsFormsApp1.Views
{
    partial class ChangePasswordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtCUsername = new System.Windows.Forms.TextBox();
            this.txtCPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkshowCPassword = new System.Windows.Forms.CheckBox();
            this.chkshowNPassword = new System.Windows.Forms.CheckBox();
            this.chkshowCoPassword = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(491, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(535, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "New Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(483, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirm Password :";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(883, 511);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(96, 43);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Save";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtCUsername
            // 
            this.txtCUsername.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCUsername.Location = new System.Drawing.Point(799, 119);
            this.txtCUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCUsername.Name = "txtCUsername";
            this.txtCUsername.Size = new System.Drawing.Size(204, 35);
            this.txtCUsername.TabIndex = 6;
            // 
            // txtCPassword
            // 
            this.txtCPassword.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPassword.Location = new System.Drawing.Point(799, 185);
            this.txtCPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCPassword.Name = "txtCPassword";
            this.txtCPassword.PasswordChar = '*';
            this.txtCPassword.Size = new System.Drawing.Size(204, 35);
            this.txtCPassword.TabIndex = 7;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(799, 260);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(204, 35);
            this.txtNewPassword.TabIndex = 8;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(799, 333);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(204, 35);
            this.txtConfirmPassword.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 636);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Computer_login_amico__1_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 633);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // chkshowCPassword
            // 
            this.chkshowCPassword.AutoSize = true;
            this.chkshowCPassword.Location = new System.Drawing.Point(1031, 193);
            this.chkshowCPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkshowCPassword.Name = "chkshowCPassword";
            this.chkshowCPassword.Size = new System.Drawing.Size(41, 20);
            this.chkshowCPassword.TabIndex = 11;
            this.chkshowCPassword.Text = "👁️";
            this.chkshowCPassword.UseVisualStyleBackColor = true;
            this.chkshowCPassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkshowNPassword
            // 
            this.chkshowNPassword.AutoSize = true;
            this.chkshowNPassword.Location = new System.Drawing.Point(1031, 268);
            this.chkshowNPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkshowNPassword.Name = "chkshowNPassword";
            this.chkshowNPassword.Size = new System.Drawing.Size(41, 20);
            this.chkshowNPassword.TabIndex = 12;
            this.chkshowNPassword.Text = "👁️";
            this.chkshowNPassword.UseVisualStyleBackColor = true;
            this.chkshowNPassword.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkshowCoPassword
            // 
            this.chkshowCoPassword.AutoSize = true;
            this.chkshowCoPassword.Location = new System.Drawing.Point(1031, 341);
            this.chkshowCoPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkshowCoPassword.Name = "chkshowCoPassword";
            this.chkshowCoPassword.Size = new System.Drawing.Size(41, 20);
            this.chkshowCoPassword.TabIndex = 13;
            this.chkshowCoPassword.Text = "👁️";
            this.chkshowCoPassword.UseVisualStyleBackColor = true;
            this.chkshowCoPassword.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1171, 636);
            this.Controls.Add(this.chkshowCoPassword);
            this.Controls.Add(this.chkshowNPassword);
            this.Controls.Add(this.chkshowCPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtCPassword);
            this.Controls.Add(this.txtCUsername);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox txtCUsername;
        private System.Windows.Forms.TextBox txtCPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkshowCPassword;
        private System.Windows.Forms.CheckBox chkshowNPassword;
        private System.Windows.Forms.CheckBox chkshowCoPassword;
    }
}